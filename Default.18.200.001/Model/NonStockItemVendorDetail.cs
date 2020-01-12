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
    /// NonStockItemVendorDetail
    /// </summary>
    [DataContract]
    public partial class NonStockItemVendorDetail : Entity,  IEquatable<NonStockItemVendorDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonStockItemVendorDetail" /> class.
        /// </summary>
        /// <param name="vendorID">vendorID.</param>
        /// <param name="vendorName">vendorName.</param>
        public NonStockItemVendorDetail(StringValue vendorID = default(StringValue), StringValue vendorName = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.VendorID = vendorID;
            this.VendorName = vendorName;
        }
        
        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="VendorID", EmitDefaultValue=false)]
        public StringValue VendorID { get; set; }

        /// <summary>
        /// Gets or Sets VendorName
        /// </summary>
        [DataMember(Name="VendorName", EmitDefaultValue=false)]
        public StringValue VendorName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonStockItemVendorDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
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
            return this.Equals(input as NonStockItemVendorDetail);
        }

        /// <summary>
        /// Returns true if NonStockItemVendorDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of NonStockItemVendorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonStockItemVendorDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.VendorID == input.VendorID ||
                    (this.VendorID != null &&
                    this.VendorID.Equals(input.VendorID))
                ) && base.Equals(input) && 
                (
                    this.VendorName == input.VendorName ||
                    (this.VendorName != null &&
                    this.VendorName.Equals(input.VendorName))
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
                if (this.VendorID != null)
                    hashCode = hashCode * 59 + this.VendorID.GetHashCode();
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
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
