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
    /// EventTimeActivity
    /// </summary>
    [DataContract]
    public partial class EventTimeActivity : Entity,  IEquatable<EventTimeActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventTimeActivity" /> class.
        /// </summary>
        /// <param name="billableOvertime">billableOvertime.</param>
        /// <param name="billableTime">billableTime.</param>
        /// <param name="overtime">overtime.</param>
        /// <param name="timeSpent">timeSpent.</param>
        public EventTimeActivity(StringValue billableOvertime = default(StringValue), StringValue billableTime = default(StringValue), StringValue overtime = default(StringValue), StringValue timeSpent = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BillableOvertime = billableOvertime;
            this.BillableTime = billableTime;
            this.Overtime = overtime;
            this.TimeSpent = timeSpent;
        }
        
        /// <summary>
        /// Gets or Sets BillableOvertime
        /// </summary>
        [DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
        public StringValue BillableOvertime { get; set; }

        /// <summary>
        /// Gets or Sets BillableTime
        /// </summary>
        [DataMember(Name="BillableTime", EmitDefaultValue=false)]
        public StringValue BillableTime { get; set; }

        /// <summary>
        /// Gets or Sets Overtime
        /// </summary>
        [DataMember(Name="Overtime", EmitDefaultValue=false)]
        public StringValue Overtime { get; set; }

        /// <summary>
        /// Gets or Sets TimeSpent
        /// </summary>
        [DataMember(Name="TimeSpent", EmitDefaultValue=false)]
        public StringValue TimeSpent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventTimeActivity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BillableOvertime: ").Append(BillableOvertime).Append("\n");
            sb.Append("  BillableTime: ").Append(BillableTime).Append("\n");
            sb.Append("  Overtime: ").Append(Overtime).Append("\n");
            sb.Append("  TimeSpent: ").Append(TimeSpent).Append("\n");
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
            return this.Equals(input as EventTimeActivity);
        }

        /// <summary>
        /// Returns true if EventTimeActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of EventTimeActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventTimeActivity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BillableOvertime == input.BillableOvertime ||
                    (this.BillableOvertime != null &&
                    this.BillableOvertime.Equals(input.BillableOvertime))
                ) && base.Equals(input) && 
                (
                    this.BillableTime == input.BillableTime ||
                    (this.BillableTime != null &&
                    this.BillableTime.Equals(input.BillableTime))
                ) && base.Equals(input) && 
                (
                    this.Overtime == input.Overtime ||
                    (this.Overtime != null &&
                    this.Overtime.Equals(input.Overtime))
                ) && base.Equals(input) && 
                (
                    this.TimeSpent == input.TimeSpent ||
                    (this.TimeSpent != null &&
                    this.TimeSpent.Equals(input.TimeSpent))
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
                if (this.BillableOvertime != null)
                    hashCode = hashCode * 59 + this.BillableOvertime.GetHashCode();
                if (this.BillableTime != null)
                    hashCode = hashCode * 59 + this.BillableTime.GetHashCode();
                if (this.Overtime != null)
                    hashCode = hashCode * 59 + this.Overtime.GetHashCode();
                if (this.TimeSpent != null)
                    hashCode = hashCode * 59 + this.TimeSpent.GetHashCode();
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
