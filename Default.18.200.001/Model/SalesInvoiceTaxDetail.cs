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
    /// SalesInvoiceTaxDetail
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceTaxDetail : Entity,  IEquatable<SalesInvoiceTaxDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceTaxDetail" /> class.
        /// </summary>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="taxID">taxID.</param>
        public SalesInvoiceTaxDetail(DecimalValue taxableAmount = default(DecimalValue), DecimalValue taxAmount = default(DecimalValue), StringValue taxID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
            this.TaxID = taxID;
        }
        
        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
        public DecimalValue TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public DecimalValue TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxID
        /// </summary>
        [DataMember(Name="TaxID", EmitDefaultValue=false)]
        public StringValue TaxID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesInvoiceTaxDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxID: ").Append(TaxID).Append("\n");
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
            return this.Equals(input as SalesInvoiceTaxDetail);
        }

        /// <summary>
        /// Returns true if SalesInvoiceTaxDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesInvoiceTaxDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceTaxDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.TaxableAmount == input.TaxableAmount ||
                    (this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(input.TaxableAmount))
                ) && base.Equals(input) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && base.Equals(input) && 
                (
                    this.TaxID == input.TaxID ||
                    (this.TaxID != null &&
                    this.TaxID.Equals(input.TaxID))
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
                if (this.TaxableAmount != null)
                    hashCode = hashCode * 59 + this.TaxableAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxID != null)
                    hashCode = hashCode * 59 + this.TaxID.GetHashCode();
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
