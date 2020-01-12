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
    /// JournalTransactionDetail
    /// </summary>
    [DataContract]
    public partial class JournalTransactionDetail : Entity,  IEquatable<JournalTransactionDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalTransactionDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="branchID">branchID.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="creditAmount">creditAmount.</param>
        /// <param name="debitAmount">debitAmount.</param>
        /// <param name="description">description.</param>
        /// <param name="isNonPM">isNonPM.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="nonBillable">nonBillable.</param>
        /// <param name="project">project.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="projectTransactionID">projectTransactionID.</param>
        /// <param name="qty">qty.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="subaccount">subaccount.</param>
        /// <param name="transactionDescription">transactionDescription.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="vendorOrCustomer">vendorOrCustomer.</param>
        public JournalTransactionDetail(StringValue account = default(StringValue), StringValue branchID = default(StringValue), StringValue costCode = default(StringValue), DecimalValue creditAmount = default(DecimalValue), DecimalValue debitAmount = default(DecimalValue), StringValue description = default(StringValue), BooleanValue isNonPM = default(BooleanValue), IntValue lineNbr = default(IntValue), BooleanValue nonBillable = default(BooleanValue), StringValue project = default(StringValue), StringValue projectTask = default(StringValue), LongValue projectTransactionID = default(LongValue), DecimalValue qty = default(DecimalValue), StringValue referenceNbr = default(StringValue), StringValue subaccount = default(StringValue), StringValue transactionDescription = default(StringValue), StringValue uOM = default(StringValue), StringValue vendorOrCustomer = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.BranchID = branchID;
            this.CostCode = costCode;
            this.CreditAmount = creditAmount;
            this.DebitAmount = debitAmount;
            this.Description = description;
            this.IsNonPM = isNonPM;
            this.LineNbr = lineNbr;
            this.NonBillable = nonBillable;
            this.Project = project;
            this.ProjectTask = projectTask;
            this.ProjectTransactionID = projectTransactionID;
            this.Qty = qty;
            this.ReferenceNbr = referenceNbr;
            this.Subaccount = subaccount;
            this.TransactionDescription = transactionDescription;
            this.UOM = uOM;
            this.VendorOrCustomer = vendorOrCustomer;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets BranchID
        /// </summary>
        [DataMember(Name="BranchID", EmitDefaultValue=false)]
        public StringValue BranchID { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmount
        /// </summary>
        [DataMember(Name="CreditAmount", EmitDefaultValue=false)]
        public DecimalValue CreditAmount { get; set; }

        /// <summary>
        /// Gets or Sets DebitAmount
        /// </summary>
        [DataMember(Name="DebitAmount", EmitDefaultValue=false)]
        public DecimalValue DebitAmount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets IsNonPM
        /// </summary>
        [DataMember(Name="IsNonPM", EmitDefaultValue=false)]
        public BooleanValue IsNonPM { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets NonBillable
        /// </summary>
        [DataMember(Name="NonBillable", EmitDefaultValue=false)]
        public BooleanValue NonBillable { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTransactionID
        /// </summary>
        [DataMember(Name="ProjectTransactionID", EmitDefaultValue=false)]
        public LongValue ProjectTransactionID { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets Subaccount
        /// </summary>
        [DataMember(Name="Subaccount", EmitDefaultValue=false)]
        public StringValue Subaccount { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDescription
        /// </summary>
        [DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
        public StringValue TransactionDescription { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

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
            sb.Append("class JournalTransactionDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  BranchID: ").Append(BranchID).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  CreditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  DebitAmount: ").Append(DebitAmount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsNonPM: ").Append(IsNonPM).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  NonBillable: ").Append(NonBillable).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  ProjectTransactionID: ").Append(ProjectTransactionID).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as JournalTransactionDetail);
        }

        /// <summary>
        /// Returns true if JournalTransactionDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalTransactionDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalTransactionDetail input)
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
                    this.BranchID == input.BranchID ||
                    (this.BranchID != null &&
                    this.BranchID.Equals(input.BranchID))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.CreditAmount == input.CreditAmount ||
                    (this.CreditAmount != null &&
                    this.CreditAmount.Equals(input.CreditAmount))
                ) && base.Equals(input) && 
                (
                    this.DebitAmount == input.DebitAmount ||
                    (this.DebitAmount != null &&
                    this.DebitAmount.Equals(input.DebitAmount))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.IsNonPM == input.IsNonPM ||
                    (this.IsNonPM != null &&
                    this.IsNonPM.Equals(input.IsNonPM))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.NonBillable == input.NonBillable ||
                    (this.NonBillable != null &&
                    this.NonBillable.Equals(input.NonBillable))
                ) && base.Equals(input) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) && 
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) && 
                (
                    this.ProjectTransactionID == input.ProjectTransactionID ||
                    (this.ProjectTransactionID != null &&
                    this.ProjectTransactionID.Equals(input.ProjectTransactionID))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
                ) && base.Equals(input) && 
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.BranchID != null)
                    hashCode = hashCode * 59 + this.BranchID.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.CreditAmount != null)
                    hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.DebitAmount != null)
                    hashCode = hashCode * 59 + this.DebitAmount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsNonPM != null)
                    hashCode = hashCode * 59 + this.IsNonPM.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.NonBillable != null)
                    hashCode = hashCode * 59 + this.NonBillable.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.ProjectTransactionID != null)
                    hashCode = hashCode * 59 + this.ProjectTransactionID.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.Subaccount != null)
                    hashCode = hashCode * 59 + this.Subaccount.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
