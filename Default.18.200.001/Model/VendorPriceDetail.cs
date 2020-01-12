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
    /// VendorPriceDetail
    /// </summary>
    [DataContract]
    public partial class VendorPriceDetail : Entity,  IEquatable<VendorPriceDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorPriceDetail" /> class.
        /// </summary>
        /// <param name="breakQty">breakQty.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="description">description.</param>
        /// <param name="effectiveDate">effectiveDate.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="price">price.</param>
        /// <param name="promotional">promotional.</param>
        /// <param name="recordID">recordID.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="vendor">vendor.</param>
        /// <param name="vendorName">vendorName.</param>
        public VendorPriceDetail(DecimalValue breakQty = default(DecimalValue), DateTimeValue createdDateTime = default(DateTimeValue), StringValue currencyID = default(StringValue), StringValue description = default(StringValue), DateTimeValue effectiveDate = default(DateTimeValue), DateTimeValue expirationDate = default(DateTimeValue), StringValue inventoryID = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), DecimalValue price = default(DecimalValue), BooleanValue promotional = default(BooleanValue), IntValue recordID = default(IntValue), StringValue uOM = default(StringValue), StringValue vendor = default(StringValue), StringValue vendorName = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BreakQty = breakQty;
            this.CreatedDateTime = createdDateTime;
            this.CurrencyID = currencyID;
            this.Description = description;
            this.EffectiveDate = effectiveDate;
            this.ExpirationDate = expirationDate;
            this.InventoryID = inventoryID;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.Price = price;
            this.Promotional = promotional;
            this.RecordID = recordID;
            this.UOM = uOM;
            this.Vendor = vendor;
            this.VendorName = vendorName;
        }
        
        /// <summary>
        /// Gets or Sets BreakQty
        /// </summary>
        [DataMember(Name="BreakQty", EmitDefaultValue=false)]
        public DecimalValue BreakQty { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
        public DateTimeValue EffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public DecimalValue Price { get; set; }

        /// <summary>
        /// Gets or Sets Promotional
        /// </summary>
        [DataMember(Name="Promotional", EmitDefaultValue=false)]
        public BooleanValue Promotional { get; set; }

        /// <summary>
        /// Gets or Sets RecordID
        /// </summary>
        [DataMember(Name="RecordID", EmitDefaultValue=false)]
        public IntValue RecordID { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="Vendor", EmitDefaultValue=false)]
        public StringValue Vendor { get; set; }

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
            sb.Append("class VendorPriceDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BreakQty: ").Append(BreakQty).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Promotional: ").Append(Promotional).Append("\n");
            sb.Append("  RecordID: ").Append(RecordID).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
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
            return this.Equals(input as VendorPriceDetail);
        }

        /// <summary>
        /// Returns true if VendorPriceDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorPriceDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorPriceDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BreakQty == input.BreakQty ||
                    (this.BreakQty != null &&
                    this.BreakQty.Equals(input.BreakQty))
                ) && base.Equals(input) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && base.Equals(input) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && base.Equals(input) && 
                (
                    this.Promotional == input.Promotional ||
                    (this.Promotional != null &&
                    this.Promotional.Equals(input.Promotional))
                ) && base.Equals(input) && 
                (
                    this.RecordID == input.RecordID ||
                    (this.RecordID != null &&
                    this.RecordID.Equals(input.RecordID))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
                ) && base.Equals(input) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
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
                if (this.BreakQty != null)
                    hashCode = hashCode * 59 + this.BreakQty.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Promotional != null)
                    hashCode = hashCode * 59 + this.Promotional.GetHashCode();
                if (this.RecordID != null)
                    hashCode = hashCode * 59 + this.RecordID.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.Vendor != null)
                    hashCode = hashCode * 59 + this.Vendor.GetHashCode();
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
