using System;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Get the error code (HTTP status code).
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; }

        /// <summary>
        /// Get the error content (body json object).
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public JToken ErrorContent { get; }

        /// <summary>
        /// Get the server exception (if unexpected exception happend and error cannot be presented as part of object).
        /// </summary>
        public ServerException ServerException { get; }

        /// <summary>
        /// Get the error message if it presented as part of entity.
        /// </summary>
        public string Error { get; }

        public string MessageText { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        public ApiException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message)
        {
            ErrorCode = errorCode;
            MessageText = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        public ApiException(int errorCode, string message, string errorContent = null) : this(errorCode, message)
        {
            if (errorContent != null)
            {
                try
                {
                    ErrorContent = JToken.Parse(errorContent);
                    ServerException = ErrorContent.ToObject<ServerException>();
                    if (ServerException.Message == null)
                    {
                        ServerException = null;
                        Error = ErrorContent["error"]?.ToString();
                    }
                }
                catch
                {
                    ErrorContent = message + "\r\n Error code: " + errorCode.ToString();
                }
            }
        }

        public override string Message => MessageText + (ErrorContent != null ? Environment.NewLine + ErrorContent.ToString() : null);

        private static readonly string[] keyFields =
        {
            "error",
            "value",
            "id",
            "ID",
        };

        // clear from body all fields that doesn't contain "error" field recursively
        public static JToken GetEntityBodyWithOnlyErrors(JToken token)
        {
            switch (token)
            {
                case JProperty jprop:
                    {
                        if (keyFields.Contains(jprop.Name))
                            return jprop;

                        if (jprop.Value is JObject || jprop.Value is JArray)
                        {
                            var val = GetEntityBodyWithOnlyErrors(jprop.Value);
                            if (val != null)
                                return new JProperty(jprop.Name, val);
                        }

                        return null;
                    }

                case JObject jobj:
                    {
                        if (jobj["id"] != null)
                        {
                            // rm not valuable props
                            var props = jobj.Properties().Select(GetEntityBodyWithOnlyErrors).OfType<JProperty>().ToList();
                            if (props.Count > 1) // rm only id
                                return new JObject(props);
                        }
                        if (jobj["error"] != null)
                        {
                            return jobj;
                        }
                        return null;
                    }
                case JArray jarr:
                    {
                        var tokens = jarr.Select(GetEntityBodyWithOnlyErrors).OfType<JObject>().ToList();
                        if (tokens.Any())
                            return new JArray(tokens);
                        return null;
                    }
                default:
                    return null;
            }
        }
    }

    public class ServerException
    {
        [JsonConstructor]
        public ServerException(string message, string exceptionMessage, string exceptionType, string stackTrace, ServerException innerException = null)
        {
            Message = message;
            ExceptionMessage = exceptionMessage;
            ExceptionType = exceptionType;
            StackTrace = stackTrace;
            InnerException = innerException;
        }

        public string Message { get; }
        public string ExceptionMessage { get; }
        public string ExceptionType { get; }
        public string StackTrace { get; }
        public ServerException InnerException { get; }

        public ServerException GetInnermostException() => InnerException?.GetInnermostException() ?? this;

        private string GetIndention(int depth)
        {
            return new string('\t', depth);
        }

        private void BuildString(StringBuilder builder, int depth = 0)
        {
            var indent = GetIndention(depth);
            builder.AppendLine($"{indent}Message: {Message}");
            builder.AppendLine($"{indent}ExceptionMessage: {ExceptionMessage}");
            builder.AppendLine($"{indent}ExceptionType: {ExceptionType}");
            if (InnerException != null)
            {
                builder.AppendLine($"{indent}InnerException:");
                InnerException.BuildString(builder, depth + 1);
            }
            builder.AppendLine($"{indent}StackTrace:");
            var traceIndention = GetIndention(depth + 1);
            builder.AppendLine($"{traceIndention}{StackTrace?.Replace("\n", "\n" + traceIndention)}");
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            BuildString(builder);
            return builder.ToString();
        }
    }
}
