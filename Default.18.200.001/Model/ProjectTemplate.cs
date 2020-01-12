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
    /// ProjectTemplate
    /// </summary>
    [DataContract]
    public partial class ProjectTemplate : Entity,  IEquatable<ProjectTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplate" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="billingAndAllocationSettings">billingAndAllocationSettings.</param>
        /// <param name="description">description.</param>
        /// <param name="employees">employees.</param>
        /// <param name="equipments">equipments.</param>
        /// <param name="gLAccounts">gLAccounts.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="projectProperties">projectProperties.</param>
        /// <param name="projectTemplateID">projectTemplateID.</param>
        /// <param name="status">status.</param>
        /// <param name="visibilitySettings">visibilitySettings.</param>
        public ProjectTemplate(List<AttributeValue> attributes = default(List<AttributeValue>), ProjectBillingAndAllocationSettings billingAndAllocationSettings = default(ProjectBillingAndAllocationSettings), StringValue description = default(StringValue), List<ProjectEmployee> employees = default(List<ProjectEmployee>), List<ProjectEquipment> equipments = default(List<ProjectEquipment>), ProjectGLAccount gLAccounts = default(ProjectGLAccount), DateTimeValue lastModifiedDateTime = default(DateTimeValue), ProjectProperties projectProperties = default(ProjectProperties), StringValue projectTemplateID = default(StringValue), StringValue status = default(StringValue), VisibilitySettings visibilitySettings = default(VisibilitySettings), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Attributes = attributes;
            this.BillingAndAllocationSettings = billingAndAllocationSettings;
            this.Description = description;
            this.Employees = employees;
            this.Equipments = equipments;
            this.GLAccounts = gLAccounts;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.ProjectProperties = projectProperties;
            this.ProjectTemplateID = projectTemplateID;
            this.Status = status;
            this.VisibilitySettings = visibilitySettings;
        }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="Attributes", EmitDefaultValue=false)]
        public List<AttributeValue> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets BillingAndAllocationSettings
        /// </summary>
        [DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
        public ProjectBillingAndAllocationSettings BillingAndAllocationSettings { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Employees
        /// </summary>
        [DataMember(Name="Employees", EmitDefaultValue=false)]
        public List<ProjectEmployee> Employees { get; set; }

        /// <summary>
        /// Gets or Sets Equipments
        /// </summary>
        [DataMember(Name="Equipments", EmitDefaultValue=false)]
        public List<ProjectEquipment> Equipments { get; set; }

        /// <summary>
        /// Gets or Sets GLAccounts
        /// </summary>
        [DataMember(Name="GLAccounts", EmitDefaultValue=false)]
        public ProjectGLAccount GLAccounts { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ProjectProperties
        /// </summary>
        [DataMember(Name="ProjectProperties", EmitDefaultValue=false)]
        public ProjectProperties ProjectProperties { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTemplateID
        /// </summary>
        [DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
        public StringValue ProjectTemplateID { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets VisibilitySettings
        /// </summary>
        [DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
        public VisibilitySettings VisibilitySettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectTemplate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  BillingAndAllocationSettings: ").Append(BillingAndAllocationSettings).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Employees: ").Append(Employees).Append("\n");
            sb.Append("  Equipments: ").Append(Equipments).Append("\n");
            sb.Append("  GLAccounts: ").Append(GLAccounts).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  ProjectProperties: ").Append(ProjectProperties).Append("\n");
            sb.Append("  ProjectTemplateID: ").Append(ProjectTemplateID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VisibilitySettings: ").Append(VisibilitySettings).Append("\n");
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
            return this.Equals(input as ProjectTemplate);
        }

        /// <summary>
        /// Returns true if ProjectTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectTemplate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && base.Equals(input) && 
                (
                    this.BillingAndAllocationSettings == input.BillingAndAllocationSettings ||
                    (this.BillingAndAllocationSettings != null &&
                    this.BillingAndAllocationSettings.Equals(input.BillingAndAllocationSettings))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Employees == input.Employees ||
                    this.Employees != null &&
                    this.Employees.SequenceEqual(input.Employees)
                ) && base.Equals(input) && 
                (
                    this.Equipments == input.Equipments ||
                    this.Equipments != null &&
                    this.Equipments.SequenceEqual(input.Equipments)
                ) && base.Equals(input) && 
                (
                    this.GLAccounts == input.GLAccounts ||
                    (this.GLAccounts != null &&
                    this.GLAccounts.Equals(input.GLAccounts))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.ProjectProperties == input.ProjectProperties ||
                    (this.ProjectProperties != null &&
                    this.ProjectProperties.Equals(input.ProjectProperties))
                ) && base.Equals(input) && 
                (
                    this.ProjectTemplateID == input.ProjectTemplateID ||
                    (this.ProjectTemplateID != null &&
                    this.ProjectTemplateID.Equals(input.ProjectTemplateID))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.VisibilitySettings == input.VisibilitySettings ||
                    (this.VisibilitySettings != null &&
                    this.VisibilitySettings.Equals(input.VisibilitySettings))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.BillingAndAllocationSettings != null)
                    hashCode = hashCode * 59 + this.BillingAndAllocationSettings.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Employees != null)
                    hashCode = hashCode * 59 + this.Employees.GetHashCode();
                if (this.Equipments != null)
                    hashCode = hashCode * 59 + this.Equipments.GetHashCode();
                if (this.GLAccounts != null)
                    hashCode = hashCode * 59 + this.GLAccounts.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.ProjectProperties != null)
                    hashCode = hashCode * 59 + this.ProjectProperties.GetHashCode();
                if (this.ProjectTemplateID != null)
                    hashCode = hashCode * 59 + this.ProjectTemplateID.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VisibilitySettings != null)
                    hashCode = hashCode * 59 + this.VisibilitySettings.GetHashCode();
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
