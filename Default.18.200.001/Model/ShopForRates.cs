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
    /// ShopForRates
    /// </summary>
    [DataContract]
    public partial class ShopForRates : Entity,  IEquatable<ShopForRates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopForRates" /> class.
        /// </summary>
        /// <param name="isManualPackage">isManualPackage.</param>
        /// <param name="orderWeight">orderWeight.</param>
        /// <param name="packageWeight">packageWeight.</param>
        public ShopForRates(BooleanValue isManualPackage = default(BooleanValue), DecimalValue orderWeight = default(DecimalValue), DecimalValue packageWeight = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.IsManualPackage = isManualPackage;
            this.OrderWeight = orderWeight;
            this.PackageWeight = packageWeight;
        }
        
        /// <summary>
        /// Gets or Sets IsManualPackage
        /// </summary>
        [DataMember(Name="IsManualPackage", EmitDefaultValue=false)]
        public BooleanValue IsManualPackage { get; set; }

        /// <summary>
        /// Gets or Sets OrderWeight
        /// </summary>
        [DataMember(Name="OrderWeight", EmitDefaultValue=false)]
        public DecimalValue OrderWeight { get; set; }

        /// <summary>
        /// Gets or Sets PackageWeight
        /// </summary>
        [DataMember(Name="PackageWeight", EmitDefaultValue=false)]
        public DecimalValue PackageWeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopForRates {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  IsManualPackage: ").Append(IsManualPackage).Append("\n");
            sb.Append("  OrderWeight: ").Append(OrderWeight).Append("\n");
            sb.Append("  PackageWeight: ").Append(PackageWeight).Append("\n");
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
            return this.Equals(input as ShopForRates);
        }

        /// <summary>
        /// Returns true if ShopForRates instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopForRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopForRates input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.IsManualPackage == input.IsManualPackage ||
                    (this.IsManualPackage != null &&
                    this.IsManualPackage.Equals(input.IsManualPackage))
                ) && base.Equals(input) && 
                (
                    this.OrderWeight == input.OrderWeight ||
                    (this.OrderWeight != null &&
                    this.OrderWeight.Equals(input.OrderWeight))
                ) && base.Equals(input) && 
                (
                    this.PackageWeight == input.PackageWeight ||
                    (this.PackageWeight != null &&
                    this.PackageWeight.Equals(input.PackageWeight))
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
                if (this.IsManualPackage != null)
                    hashCode = hashCode * 59 + this.IsManualPackage.GetHashCode();
                if (this.OrderWeight != null)
                    hashCode = hashCode * 59 + this.OrderWeight.GetHashCode();
                if (this.PackageWeight != null)
                    hashCode = hashCode * 59 + this.PackageWeight.GetHashCode();
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
