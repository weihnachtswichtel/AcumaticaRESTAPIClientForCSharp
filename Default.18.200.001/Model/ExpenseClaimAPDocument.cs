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
    /// ExpenseClaimAPDocument
    /// </summary>
    [DataContract]
    public partial class ExpenseClaimAPDocument : Entity,  IEquatable<ExpenseClaimAPDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseClaimAPDocument" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="refNbr">refNbr.</param>
        /// <param name="status">status.</param>
        /// <param name="taxZone">taxZone.</param>
        /// <param name="type">type.</param>
        public ExpenseClaimAPDocument(DecimalValue amount = default(DecimalValue), StringValue refNbr = default(StringValue), StringValue status = default(StringValue), StringValue taxZone = default(StringValue), StringValue type = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Amount = amount;
            this.RefNbr = refNbr;
            this.Status = status;
            this.TaxZone = taxZone;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets RefNbr
        /// </summary>
        [DataMember(Name="RefNbr", EmitDefaultValue=false)]
        public StringValue RefNbr { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TaxZone
        /// </summary>
        [DataMember(Name="TaxZone", EmitDefaultValue=false)]
        public StringValue TaxZone { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseClaimAPDocument {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RefNbr: ").Append(RefNbr).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaxZone: ").Append(TaxZone).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ExpenseClaimAPDocument);
        }

        /// <summary>
        /// Returns true if ExpenseClaimAPDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseClaimAPDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseClaimAPDocument input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.RefNbr == input.RefNbr ||
                    (this.RefNbr != null &&
                    this.RefNbr.Equals(input.RefNbr))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TaxZone == input.TaxZone ||
                    (this.TaxZone != null &&
                    this.TaxZone.Equals(input.TaxZone))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.RefNbr != null)
                    hashCode = hashCode * 59 + this.RefNbr.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaxZone != null)
                    hashCode = hashCode * 59 + this.TaxZone.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
