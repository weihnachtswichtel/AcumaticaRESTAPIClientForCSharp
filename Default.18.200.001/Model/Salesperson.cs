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
    /// Salesperson
    /// </summary>
    [DataContract]
    public partial class Salesperson : Entity,  IEquatable<Salesperson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Salesperson" /> class.
        /// </summary>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="defaultCommission">defaultCommission.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="name">name.</param>
        /// <param name="salespersonID">salespersonID.</param>
        /// <param name="salesSubaccount">salesSubaccount.</param>
        public Salesperson(DateTimeValue createdDateTime = default(DateTimeValue), DecimalValue defaultCommission = default(DecimalValue), BooleanValue isActive = default(BooleanValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue name = default(StringValue), StringValue salespersonID = default(StringValue), StringValue salesSubaccount = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CreatedDateTime = createdDateTime;
            this.DefaultCommission = defaultCommission;
            this.IsActive = isActive;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.Name = name;
            this.SalespersonID = salespersonID;
            this.SalesSubaccount = salesSubaccount;
        }
        
        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCommission
        /// </summary>
        [DataMember(Name="DefaultCommission", EmitDefaultValue=false)]
        public DecimalValue DefaultCommission { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=false)]
        public BooleanValue IsActive { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public StringValue Name { get; set; }

        /// <summary>
        /// Gets or Sets SalespersonID
        /// </summary>
        [DataMember(Name="SalespersonID", EmitDefaultValue=false)]
        public StringValue SalespersonID { get; set; }

        /// <summary>
        /// Gets or Sets SalesSubaccount
        /// </summary>
        [DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
        public StringValue SalesSubaccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Salesperson {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  DefaultCommission: ").Append(DefaultCommission).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SalespersonID: ").Append(SalespersonID).Append("\n");
            sb.Append("  SalesSubaccount: ").Append(SalesSubaccount).Append("\n");
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
            return this.Equals(input as Salesperson);
        }

        /// <summary>
        /// Returns true if Salesperson instances are equal
        /// </summary>
        /// <param name="input">Instance of Salesperson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Salesperson input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) && 
                (
                    this.DefaultCommission == input.DefaultCommission ||
                    (this.DefaultCommission != null &&
                    this.DefaultCommission.Equals(input.DefaultCommission))
                ) && base.Equals(input) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.SalespersonID == input.SalespersonID ||
                    (this.SalespersonID != null &&
                    this.SalespersonID.Equals(input.SalespersonID))
                ) && base.Equals(input) && 
                (
                    this.SalesSubaccount == input.SalesSubaccount ||
                    (this.SalesSubaccount != null &&
                    this.SalesSubaccount.Equals(input.SalesSubaccount))
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
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.DefaultCommission != null)
                    hashCode = hashCode * 59 + this.DefaultCommission.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SalespersonID != null)
                    hashCode = hashCode * 59 + this.SalespersonID.GetHashCode();
                if (this.SalesSubaccount != null)
                    hashCode = hashCode * 59 + this.SalesSubaccount.GetHashCode();
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
