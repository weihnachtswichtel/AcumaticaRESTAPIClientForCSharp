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
    /// KitAssemblyStockComponent
    /// </summary>
    [DataContract]
    public partial class KitAssemblyStockComponent : Entity,  IEquatable<KitAssemblyStockComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KitAssemblyStockComponent" /> class.
        /// </summary>
        /// <param name="allocations">allocations.</param>
        /// <param name="componentQty">componentQty.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="qty">qty.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="stockInventoryID">stockInventoryID.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="uOM">uOM.</param>
        public KitAssemblyStockComponent(List<KitAssemblyStockComponentAllocation> allocations = default(List<KitAssemblyStockComponentAllocation>), DecimalValue componentQty = default(DecimalValue), IntValue lineNbr = default(IntValue), StringValue locationID = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue reasonCode = default(StringValue), StringValue stockInventoryID = default(StringValue), StringValue subitem = default(StringValue), DecimalValue unitCost = default(DecimalValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Allocations = allocations;
            this.ComponentQty = componentQty;
            this.LineNbr = lineNbr;
            this.LocationID = locationID;
            this.Qty = qty;
            this.ReasonCode = reasonCode;
            this.StockInventoryID = stockInventoryID;
            this.Subitem = subitem;
            this.UnitCost = unitCost;
            this.UOM = uOM;
        }
        
        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<KitAssemblyStockComponentAllocation> Allocations { get; set; }

        /// <summary>
        /// Gets or Sets ComponentQty
        /// </summary>
        [DataMember(Name="ComponentQty", EmitDefaultValue=false)]
        public DecimalValue ComponentQty { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
        public StringValue ReasonCode { get; set; }

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
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=false)]
        public DecimalValue UnitCost { get; set; }

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
            sb.Append("class KitAssemblyStockComponent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  ComponentQty: ").Append(ComponentQty).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  StockInventoryID: ").Append(StockInventoryID).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
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
            return this.Equals(input as KitAssemblyStockComponent);
        }

        /// <summary>
        /// Returns true if KitAssemblyStockComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of KitAssemblyStockComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KitAssemblyStockComponent input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && base.Equals(input) && 
                (
                    this.ComponentQty == input.ComponentQty ||
                    (this.ComponentQty != null &&
                    this.ComponentQty.Equals(input.ComponentQty))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
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
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
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
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                if (this.ComponentQty != null)
                    hashCode = hashCode * 59 + this.ComponentQty.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.StockInventoryID != null)
                    hashCode = hashCode * 59 + this.StockInventoryID.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
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
