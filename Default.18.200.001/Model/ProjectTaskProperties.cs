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
    /// ProjectTaskProperties
    /// </summary>
    [DataContract]
    public partial class ProjectTaskProperties : Entity,  IEquatable<ProjectTaskProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskProperties" /> class.
        /// </summary>
        /// <param name="approver">approver.</param>
        /// <param name="completed">completed.</param>
        /// <param name="completionMethod">completionMethod.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="plannedEndDate">plannedEndDate.</param>
        /// <param name="plannedStartDate">plannedStartDate.</param>
        /// <param name="startDate">startDate.</param>
        public ProjectTaskProperties(StringValue approver = default(StringValue), DecimalValue completed = default(DecimalValue), StringValue completionMethod = default(StringValue), DateTimeValue endDate = default(DateTimeValue), DateTimeValue plannedEndDate = default(DateTimeValue), DateTimeValue plannedStartDate = default(DateTimeValue), DateTimeValue startDate = default(DateTimeValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Approver = approver;
            this.Completed = completed;
            this.CompletionMethod = completionMethod;
            this.EndDate = endDate;
            this.PlannedEndDate = plannedEndDate;
            this.PlannedStartDate = plannedStartDate;
            this.StartDate = startDate;
        }
        
        /// <summary>
        /// Gets or Sets Approver
        /// </summary>
        [DataMember(Name="Approver", EmitDefaultValue=false)]
        public StringValue Approver { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="Completed", EmitDefaultValue=false)]
        public DecimalValue Completed { get; set; }

        /// <summary>
        /// Gets or Sets CompletionMethod
        /// </summary>
        [DataMember(Name="CompletionMethod", EmitDefaultValue=false)]
        public StringValue CompletionMethod { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTimeValue EndDate { get; set; }

        /// <summary>
        /// Gets or Sets PlannedEndDate
        /// </summary>
        [DataMember(Name="PlannedEndDate", EmitDefaultValue=false)]
        public DateTimeValue PlannedEndDate { get; set; }

        /// <summary>
        /// Gets or Sets PlannedStartDate
        /// </summary>
        [DataMember(Name="PlannedStartDate", EmitDefaultValue=false)]
        public DateTimeValue PlannedStartDate { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTimeValue StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectTaskProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Approver: ").Append(Approver).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  CompletionMethod: ").Append(CompletionMethod).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PlannedEndDate: ").Append(PlannedEndDate).Append("\n");
            sb.Append("  PlannedStartDate: ").Append(PlannedStartDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as ProjectTaskProperties);
        }

        /// <summary>
        /// Returns true if ProjectTaskProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectTaskProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectTaskProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Approver == input.Approver ||
                    (this.Approver != null &&
                    this.Approver.Equals(input.Approver))
                ) && base.Equals(input) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && base.Equals(input) && 
                (
                    this.CompletionMethod == input.CompletionMethod ||
                    (this.CompletionMethod != null &&
                    this.CompletionMethod.Equals(input.CompletionMethod))
                ) && base.Equals(input) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && base.Equals(input) && 
                (
                    this.PlannedEndDate == input.PlannedEndDate ||
                    (this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(input.PlannedEndDate))
                ) && base.Equals(input) && 
                (
                    this.PlannedStartDate == input.PlannedStartDate ||
                    (this.PlannedStartDate != null &&
                    this.PlannedStartDate.Equals(input.PlannedStartDate))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.Approver != null)
                    hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.CompletionMethod != null)
                    hashCode = hashCode * 59 + this.CompletionMethod.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.PlannedEndDate != null)
                    hashCode = hashCode * 59 + this.PlannedEndDate.GetHashCode();
                if (this.PlannedStartDate != null)
                    hashCode = hashCode * 59 + this.PlannedStartDate.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
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
