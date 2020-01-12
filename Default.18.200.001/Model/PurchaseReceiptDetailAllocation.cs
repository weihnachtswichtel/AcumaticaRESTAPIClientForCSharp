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
    /// PurchaseReceiptDetailAllocation
    /// </summary>
    [DataContract]
    public partial class PurchaseReceiptDetailAllocation : Entity,  IEquatable<PurchaseReceiptDetailAllocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseReceiptDetailAllocation" /> class.
        /// </summary>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="location">location.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="qty">qty.</param>
        /// <param name="receiptNbr">receiptNbr.</param>
        /// <param name="splitLineNbr">splitLineNbr.</param>
        public PurchaseReceiptDetailAllocation(IntValue lineNbr = default(IntValue), StringValue location = default(StringValue), StringValue lotSerialNbr = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue receiptNbr = default(StringValue), IntValue splitLineNbr = default(IntValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.LineNbr = lineNbr;
            this.Location = location;
            this.LotSerialNbr = lotSerialNbr;
            this.Qty = qty;
            this.ReceiptNbr = receiptNbr;
            this.SplitLineNbr = splitLineNbr;
        }
        
        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets LotSerialNbr
        /// </summary>
        [DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
        public StringValue LotSerialNbr { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptNbr
        /// </summary>
        [DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
        public StringValue ReceiptNbr { get; set; }

        /// <summary>
        /// Gets or Sets SplitLineNbr
        /// </summary>
        [DataMember(Name="SplitLineNbr", EmitDefaultValue=false)]
        public IntValue SplitLineNbr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseReceiptDetailAllocation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ReceiptNbr: ").Append(ReceiptNbr).Append("\n");
            sb.Append("  SplitLineNbr: ").Append(SplitLineNbr).Append("\n");
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
            return this.Equals(input as PurchaseReceiptDetailAllocation);
        }

        /// <summary>
        /// Returns true if PurchaseReceiptDetailAllocation instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseReceiptDetailAllocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseReceiptDetailAllocation input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) && 
                (
                    this.LotSerialNbr == input.LotSerialNbr ||
                    (this.LotSerialNbr != null &&
                    this.LotSerialNbr.Equals(input.LotSerialNbr))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.ReceiptNbr == input.ReceiptNbr ||
                    (this.ReceiptNbr != null &&
                    this.ReceiptNbr.Equals(input.ReceiptNbr))
                ) && base.Equals(input) && 
                (
                    this.SplitLineNbr == input.SplitLineNbr ||
                    (this.SplitLineNbr != null &&
                    this.SplitLineNbr.Equals(input.SplitLineNbr))
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
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.ReceiptNbr != null)
                    hashCode = hashCode * 59 + this.ReceiptNbr.GetHashCode();
                if (this.SplitLineNbr != null)
                    hashCode = hashCode * 59 + this.SplitLineNbr.GetHashCode();
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
