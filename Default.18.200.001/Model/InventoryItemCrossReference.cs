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
    /// InventoryItemCrossReference
    /// </summary>
    [DataContract]
    public partial class InventoryItemCrossReference : Entity,  IEquatable<InventoryItemCrossReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItemCrossReference" /> class.
        /// </summary>
        /// <param name="alternateID">alternateID.</param>
        /// <param name="alternateType">alternateType.</param>
        /// <param name="description">description.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="vendorOrCustomer">vendorOrCustomer.</param>
        public InventoryItemCrossReference(StringValue alternateID = default(StringValue), StringValue alternateType = default(StringValue), StringValue description = default(StringValue), StringValue subitem = default(StringValue), StringValue vendorOrCustomer = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AlternateID = alternateID;
            this.AlternateType = alternateType;
            this.Description = description;
            this.Subitem = subitem;
            this.VendorOrCustomer = vendorOrCustomer;
        }
        
        /// <summary>
        /// Gets or Sets AlternateID
        /// </summary>
        [DataMember(Name="AlternateID", EmitDefaultValue=false)]
        public StringValue AlternateID { get; set; }

        /// <summary>
        /// Gets or Sets AlternateType
        /// </summary>
        [DataMember(Name="AlternateType", EmitDefaultValue=false)]
        public StringValue AlternateType { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets VendorOrCustomer
        /// </summary>
        [DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
        public StringValue VendorOrCustomer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryItemCrossReference {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AlternateID: ").Append(AlternateID).Append("\n");
            sb.Append("  AlternateType: ").Append(AlternateType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  VendorOrCustomer: ").Append(VendorOrCustomer).Append("\n");
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
            return this.Equals(input as InventoryItemCrossReference);
        }

        /// <summary>
        /// Returns true if InventoryItemCrossReference instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryItemCrossReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryItemCrossReference input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AlternateID == input.AlternateID ||
                    (this.AlternateID != null &&
                    this.AlternateID.Equals(input.AlternateID))
                ) && base.Equals(input) && 
                (
                    this.AlternateType == input.AlternateType ||
                    (this.AlternateType != null &&
                    this.AlternateType.Equals(input.AlternateType))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.VendorOrCustomer == input.VendorOrCustomer ||
                    (this.VendorOrCustomer != null &&
                    this.VendorOrCustomer.Equals(input.VendorOrCustomer))
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
                if (this.AlternateID != null)
                    hashCode = hashCode * 59 + this.AlternateID.GetHashCode();
                if (this.AlternateType != null)
                    hashCode = hashCode * 59 + this.AlternateType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.VendorOrCustomer != null)
                    hashCode = hashCode * 59 + this.VendorOrCustomer.GetHashCode();
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
