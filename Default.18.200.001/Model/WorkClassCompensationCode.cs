/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Acumatica.RESTClient.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
    /// <summary>
    /// WorkClassCompensationCode
    /// </summary>
    [DataContract]
    public partial class WorkClassCompensationCode : Entity,  IEquatable<WorkClassCompensationCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkClassCompensationCode" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="costCodeFrom">costCodeFrom.</param>
        /// <param name="costCodeTo">costCodeTo.</param>
        /// <param name="description">description.</param>
        /// <param name="wCCCode">wCCCode.</param>
        public WorkClassCompensationCode(BooleanValue active = default(BooleanValue), StringValue costCodeFrom = default(StringValue), StringValue costCodeTo = default(StringValue), StringValue description = default(StringValue), StringValue wCCCode = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.CostCodeFrom = costCodeFrom;
            this.CostCodeTo = costCodeTo;
            this.Description = description;
            this.WCCCode = wCCCode;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets CostCodeFrom
        /// </summary>
        [DataMember(Name="CostCodeFrom", EmitDefaultValue=false)]
        public StringValue CostCodeFrom { get; set; }

        /// <summary>
        /// Gets or Sets CostCodeTo
        /// </summary>
        [DataMember(Name="CostCodeTo", EmitDefaultValue=false)]
        public StringValue CostCodeTo { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets WCCCode
        /// </summary>
        [DataMember(Name="WCCCode", EmitDefaultValue=false)]
        public StringValue WCCCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkClassCompensationCode {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CostCodeFrom: ").Append(CostCodeFrom).Append("\n");
            sb.Append("  CostCodeTo: ").Append(CostCodeTo).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WCCCode: ").Append(WCCCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkClassCompensationCode);
        }

        /// <summary>
        /// Returns true if WorkClassCompensationCode instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkClassCompensationCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkClassCompensationCode input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) && 
                (
                    this.CostCodeFrom == input.CostCodeFrom ||
                    (this.CostCodeFrom != null &&
                    this.CostCodeFrom.Equals(input.CostCodeFrom))
                ) && base.Equals(input) && 
                (
                    this.CostCodeTo == input.CostCodeTo ||
                    (this.CostCodeTo != null &&
                    this.CostCodeTo.Equals(input.CostCodeTo))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.WCCCode == input.WCCCode ||
                    (this.WCCCode != null &&
                    this.WCCCode.Equals(input.WCCCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CostCodeFrom != null)
                    hashCode = hashCode * 59 + this.CostCodeFrom.GetHashCode();
                if (this.CostCodeTo != null)
                    hashCode = hashCode * 59 + this.CostCodeTo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.WCCCode != null)
                    hashCode = hashCode * 59 + this.WCCCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
