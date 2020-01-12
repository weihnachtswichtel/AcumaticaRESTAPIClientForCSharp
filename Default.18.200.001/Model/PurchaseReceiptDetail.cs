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
    /// PurchaseReceiptDetail
    /// </summary>
    [DataContract]
    public partial class PurchaseReceiptDetail : Entity,  IEquatable<PurchaseReceiptDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseReceiptDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="accrualAccount">accrualAccount.</param>
        /// <param name="accrualSubaccount">accrualSubaccount.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="branch">branch.</param>
        /// <param name="description">description.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="extendedCost">extendedCost.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="lineType">lineType.</param>
        /// <param name="location">location.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="openQty">openQty.</param>
        /// <param name="orderedQty">orderedQty.</param>
        /// <param name="pOLineNbr">pOLineNbr.</param>
        /// <param name="pOOrderNbr">pOOrderNbr.</param>
        /// <param name="pOOrderType">pOOrderType.</param>
        /// <param name="receiptQty">receiptQty.</param>
        /// <param name="subaccount">subaccount.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="transactionDescription">transactionDescription.</param>
        /// <param name="transferOrderNbr">transferOrderNbr.</param>
        /// <param name="transferOrderType">transferOrderType.</param>
        /// <param name="transferShipmentNbr">transferShipmentNbr.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouse">warehouse.</param>
        public PurchaseReceiptDetail(StringValue account = default(StringValue), StringValue accrualAccount = default(StringValue), StringValue accrualSubaccount = default(StringValue), List<PurchaseReceiptDetailAllocation> allocations = default(List<PurchaseReceiptDetailAllocation>), StringValue branch = default(StringValue), StringValue description = default(StringValue), DateTimeValue expirationDate = default(DateTimeValue), DecimalValue extendedCost = default(DecimalValue), StringValue inventoryID = default(StringValue), IntValue lineNbr = default(IntValue), StringValue lineType = default(StringValue), StringValue location = default(StringValue), StringValue lotSerialNbr = default(StringValue), DecimalValue openQty = default(DecimalValue), DecimalValue orderedQty = default(DecimalValue), IntValue pOLineNbr = default(IntValue), StringValue pOOrderNbr = default(StringValue), StringValue pOOrderType = default(StringValue), DecimalValue receiptQty = default(DecimalValue), StringValue subaccount = default(StringValue), StringValue subitem = default(StringValue), StringValue transactionDescription = default(StringValue), StringValue transferOrderNbr = default(StringValue), StringValue transferOrderType = default(StringValue), StringValue transferShipmentNbr = default(StringValue), DecimalValue unitCost = default(DecimalValue), StringValue uOM = default(StringValue), StringValue warehouse = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.AccrualAccount = accrualAccount;
            this.AccrualSubaccount = accrualSubaccount;
            this.Allocations = allocations;
            this.Branch = branch;
            this.Description = description;
            this.ExpirationDate = expirationDate;
            this.ExtendedCost = extendedCost;
            this.InventoryID = inventoryID;
            this.LineNbr = lineNbr;
            this.LineType = lineType;
            this.Location = location;
            this.LotSerialNbr = lotSerialNbr;
            this.OpenQty = openQty;
            this.OrderedQty = orderedQty;
            this.POLineNbr = pOLineNbr;
            this.POOrderNbr = pOOrderNbr;
            this.POOrderType = pOOrderType;
            this.ReceiptQty = receiptQty;
            this.Subaccount = subaccount;
            this.Subitem = subitem;
            this.TransactionDescription = transactionDescription;
            this.TransferOrderNbr = transferOrderNbr;
            this.TransferOrderType = transferOrderType;
            this.TransferShipmentNbr = transferShipmentNbr;
            this.UnitCost = unitCost;
            this.UOM = uOM;
            this.Warehouse = warehouse;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets AccrualAccount
        /// </summary>
        [DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
        public StringValue AccrualAccount { get; set; }

        /// <summary>
        /// Gets or Sets AccrualSubaccount
        /// </summary>
        [DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
        public StringValue AccrualSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<PurchaseReceiptDetailAllocation> Allocations { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedCost
        /// </summary>
        [DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
        public DecimalValue ExtendedCost { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets LineType
        /// </summary>
        [DataMember(Name="LineType", EmitDefaultValue=false)]
        public StringValue LineType { get; set; }

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
        /// Gets or Sets OpenQty
        /// </summary>
        [DataMember(Name="OpenQty", EmitDefaultValue=false)]
        public DecimalValue OpenQty { get; set; }

        /// <summary>
        /// Gets or Sets OrderedQty
        /// </summary>
        [DataMember(Name="OrderedQty", EmitDefaultValue=false)]
        public DecimalValue OrderedQty { get; set; }

        /// <summary>
        /// Gets or Sets POLineNbr
        /// </summary>
        [DataMember(Name="POLineNbr", EmitDefaultValue=false)]
        public IntValue POLineNbr { get; set; }

        /// <summary>
        /// Gets or Sets POOrderNbr
        /// </summary>
        [DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
        public StringValue POOrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets POOrderType
        /// </summary>
        [DataMember(Name="POOrderType", EmitDefaultValue=false)]
        public StringValue POOrderType { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptQty
        /// </summary>
        [DataMember(Name="ReceiptQty", EmitDefaultValue=false)]
        public DecimalValue ReceiptQty { get; set; }

        /// <summary>
        /// Gets or Sets Subaccount
        /// </summary>
        [DataMember(Name="Subaccount", EmitDefaultValue=false)]
        public StringValue Subaccount { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDescription
        /// </summary>
        [DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
        public StringValue TransactionDescription { get; set; }

        /// <summary>
        /// Gets or Sets TransferOrderNbr
        /// </summary>
        [DataMember(Name="TransferOrderNbr", EmitDefaultValue=false)]
        public StringValue TransferOrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets TransferOrderType
        /// </summary>
        [DataMember(Name="TransferOrderType", EmitDefaultValue=false)]
        public StringValue TransferOrderType { get; set; }

        /// <summary>
        /// Gets or Sets TransferShipmentNbr
        /// </summary>
        [DataMember(Name="TransferShipmentNbr", EmitDefaultValue=false)]
        public StringValue TransferShipmentNbr { get; set; }

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
        /// Gets or Sets Warehouse
        /// </summary>
        [DataMember(Name="Warehouse", EmitDefaultValue=false)]
        public StringValue Warehouse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseReceiptDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AccrualAccount: ").Append(AccrualAccount).Append("\n");
            sb.Append("  AccrualSubaccount: ").Append(AccrualSubaccount).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  OpenQty: ").Append(OpenQty).Append("\n");
            sb.Append("  OrderedQty: ").Append(OrderedQty).Append("\n");
            sb.Append("  POLineNbr: ").Append(POLineNbr).Append("\n");
            sb.Append("  POOrderNbr: ").Append(POOrderNbr).Append("\n");
            sb.Append("  POOrderType: ").Append(POOrderType).Append("\n");
            sb.Append("  ReceiptQty: ").Append(ReceiptQty).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  TransferOrderNbr: ").Append(TransferOrderNbr).Append("\n");
            sb.Append("  TransferOrderType: ").Append(TransferOrderType).Append("\n");
            sb.Append("  TransferShipmentNbr: ").Append(TransferShipmentNbr).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
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
            return this.Equals(input as PurchaseReceiptDetail);
        }

        /// <summary>
        /// Returns true if PurchaseReceiptDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseReceiptDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseReceiptDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.AccrualAccount == input.AccrualAccount ||
                    (this.AccrualAccount != null &&
                    this.AccrualAccount.Equals(input.AccrualAccount))
                ) && base.Equals(input) && 
                (
                    this.AccrualSubaccount == input.AccrualSubaccount ||
                    (this.AccrualSubaccount != null &&
                    this.AccrualSubaccount.Equals(input.AccrualSubaccount))
                ) && base.Equals(input) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) && 
                (
                    this.ExtendedCost == input.ExtendedCost ||
                    (this.ExtendedCost != null &&
                    this.ExtendedCost.Equals(input.ExtendedCost))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.LineType == input.LineType ||
                    (this.LineType != null &&
                    this.LineType.Equals(input.LineType))
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
                    this.OpenQty == input.OpenQty ||
                    (this.OpenQty != null &&
                    this.OpenQty.Equals(input.OpenQty))
                ) && base.Equals(input) && 
                (
                    this.OrderedQty == input.OrderedQty ||
                    (this.OrderedQty != null &&
                    this.OrderedQty.Equals(input.OrderedQty))
                ) && base.Equals(input) && 
                (
                    this.POLineNbr == input.POLineNbr ||
                    (this.POLineNbr != null &&
                    this.POLineNbr.Equals(input.POLineNbr))
                ) && base.Equals(input) && 
                (
                    this.POOrderNbr == input.POOrderNbr ||
                    (this.POOrderNbr != null &&
                    this.POOrderNbr.Equals(input.POOrderNbr))
                ) && base.Equals(input) && 
                (
                    this.POOrderType == input.POOrderType ||
                    (this.POOrderType != null &&
                    this.POOrderType.Equals(input.POOrderType))
                ) && base.Equals(input) && 
                (
                    this.ReceiptQty == input.ReceiptQty ||
                    (this.ReceiptQty != null &&
                    this.ReceiptQty.Equals(input.ReceiptQty))
                ) && base.Equals(input) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
                ) && base.Equals(input) && 
                (
                    this.TransferOrderNbr == input.TransferOrderNbr ||
                    (this.TransferOrderNbr != null &&
                    this.TransferOrderNbr.Equals(input.TransferOrderNbr))
                ) && base.Equals(input) && 
                (
                    this.TransferOrderType == input.TransferOrderType ||
                    (this.TransferOrderType != null &&
                    this.TransferOrderType.Equals(input.TransferOrderType))
                ) && base.Equals(input) && 
                (
                    this.TransferShipmentNbr == input.TransferShipmentNbr ||
                    (this.TransferShipmentNbr != null &&
                    this.TransferShipmentNbr.Equals(input.TransferShipmentNbr))
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
                ) && base.Equals(input) && 
                (
                    this.Warehouse == input.Warehouse ||
                    (this.Warehouse != null &&
                    this.Warehouse.Equals(input.Warehouse))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AccrualAccount != null)
                    hashCode = hashCode * 59 + this.AccrualAccount.GetHashCode();
                if (this.AccrualSubaccount != null)
                    hashCode = hashCode * 59 + this.AccrualSubaccount.GetHashCode();
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.ExtendedCost != null)
                    hashCode = hashCode * 59 + this.ExtendedCost.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.LineType != null)
                    hashCode = hashCode * 59 + this.LineType.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.OpenQty != null)
                    hashCode = hashCode * 59 + this.OpenQty.GetHashCode();
                if (this.OrderedQty != null)
                    hashCode = hashCode * 59 + this.OrderedQty.GetHashCode();
                if (this.POLineNbr != null)
                    hashCode = hashCode * 59 + this.POLineNbr.GetHashCode();
                if (this.POOrderNbr != null)
                    hashCode = hashCode * 59 + this.POOrderNbr.GetHashCode();
                if (this.POOrderType != null)
                    hashCode = hashCode * 59 + this.POOrderType.GetHashCode();
                if (this.ReceiptQty != null)
                    hashCode = hashCode * 59 + this.ReceiptQty.GetHashCode();
                if (this.Subaccount != null)
                    hashCode = hashCode * 59 + this.Subaccount.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.TransferOrderNbr != null)
                    hashCode = hashCode * 59 + this.TransferOrderNbr.GetHashCode();
                if (this.TransferOrderType != null)
                    hashCode = hashCode * 59 + this.TransferOrderType.GetHashCode();
                if (this.TransferShipmentNbr != null)
                    hashCode = hashCode * 59 + this.TransferShipmentNbr.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.Warehouse != null)
                    hashCode = hashCode * 59 + this.Warehouse.GetHashCode();
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
