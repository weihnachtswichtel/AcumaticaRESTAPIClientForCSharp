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
    /// KitStockComponent
    /// </summary>
    [DataContract]
    public partial class KitStockComponent : Entity,  IEquatable<KitStockComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KitStockComponent" /> class.
        /// </summary>
        /// <param name="allowComponentQtyVariance">allowComponentQtyVariance.</param>
        /// <param name="componentQty">componentQty.</param>
        /// <param name="maxComponentQty">maxComponentQty.</param>
        /// <param name="minComponentQty">minComponentQty.</param>
        /// <param name="stockInventoryID">stockInventoryID.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="uOM">uOM.</param>
        public KitStockComponent(BooleanValue allowComponentQtyVariance = default(BooleanValue), DecimalValue componentQty = default(DecimalValue), DecimalValue maxComponentQty = default(DecimalValue), DecimalValue minComponentQty = default(DecimalValue), StringValue stockInventoryID = default(StringValue), StringValue subitem = default(StringValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AllowComponentQtyVariance = allowComponentQtyVariance;
            this.ComponentQty = componentQty;
            this.MaxComponentQty = maxComponentQty;
            this.MinComponentQty = minComponentQty;
            this.StockInventoryID = stockInventoryID;
            this.Subitem = subitem;
            this.UOM = uOM;
        }
        
        /// <summary>
        /// Gets or Sets AllowComponentQtyVariance
        /// </summary>
        [DataMember(Name="AllowComponentQtyVariance", EmitDefaultValue=false)]
        public BooleanValue AllowComponentQtyVariance { get; set; }

        /// <summary>
        /// Gets or Sets ComponentQty
        /// </summary>
        [DataMember(Name="ComponentQty", EmitDefaultValue=false)]
        public DecimalValue ComponentQty { get; set; }

        /// <summary>
        /// Gets or Sets MaxComponentQty
        /// </summary>
        [DataMember(Name="MaxComponentQty", EmitDefaultValue=false)]
        public DecimalValue MaxComponentQty { get; set; }

        /// <summary>
        /// Gets or Sets MinComponentQty
        /// </summary>
        [DataMember(Name="MinComponentQty", EmitDefaultValue=false)]
        public DecimalValue MinComponentQty { get; set; }

        /// <summary>
        /// Gets or Sets StockInventoryID
        /// </summary>
        [DataMember(Name="StockInventoryID", EmitDefaultValue=false)]
        public StringValue StockInventoryID { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KitStockComponent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AllowComponentQtyVariance: ").Append(AllowComponentQtyVariance).Append("\n");
            sb.Append("  ComponentQty: ").Append(ComponentQty).Append("\n");
            sb.Append("  MaxComponentQty: ").Append(MaxComponentQty).Append("\n");
            sb.Append("  MinComponentQty: ").Append(MinComponentQty).Append("\n");
            sb.Append("  StockInventoryID: ").Append(StockInventoryID).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as KitStockComponent);
        }

        /// <summary>
        /// Returns true if KitStockComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of KitStockComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KitStockComponent input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AllowComponentQtyVariance == input.AllowComponentQtyVariance ||
                    (this.AllowComponentQtyVariance != null &&
                    this.AllowComponentQtyVariance.Equals(input.AllowComponentQtyVariance))
                ) && base.Equals(input) && 
                (
                    this.ComponentQty == input.ComponentQty ||
                    (this.ComponentQty != null &&
                    this.ComponentQty.Equals(input.ComponentQty))
                ) && base.Equals(input) && 
                (
                    this.MaxComponentQty == input.MaxComponentQty ||
                    (this.MaxComponentQty != null &&
                    this.MaxComponentQty.Equals(input.MaxComponentQty))
                ) && base.Equals(input) && 
                (
                    this.MinComponentQty == input.MinComponentQty ||
                    (this.MinComponentQty != null &&
                    this.MinComponentQty.Equals(input.MinComponentQty))
                ) && base.Equals(input) && 
                (
                    this.StockInventoryID == input.StockInventoryID ||
                    (this.StockInventoryID != null &&
                    this.StockInventoryID.Equals(input.StockInventoryID))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.AllowComponentQtyVariance != null)
                    hashCode = hashCode * 59 + this.AllowComponentQtyVariance.GetHashCode();
                if (this.ComponentQty != null)
                    hashCode = hashCode * 59 + this.ComponentQty.GetHashCode();
                if (this.MaxComponentQty != null)
                    hashCode = hashCode * 59 + this.MaxComponentQty.GetHashCode();
                if (this.MinComponentQty != null)
                    hashCode = hashCode * 59 + this.MinComponentQty.GetHashCode();
                if (this.StockInventoryID != null)
                    hashCode = hashCode * 59 + this.StockInventoryID.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
