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
    /// SalesInvoiceApplicationInvoice
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceApplicationInvoice : Entity,  IEquatable<SalesInvoiceApplicationInvoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceApplicationInvoice" /> class.
        /// </summary>
        /// <param name="adjustedDocReferenceNbr">adjustedDocReferenceNbr.</param>
        /// <param name="adjustingDocReferenceNbr">adjustingDocReferenceNbr.</param>
        /// <param name="adjustmentNbr">adjustmentNbr.</param>
        /// <param name="amountPaid">amountPaid.</param>
        /// <param name="balance">balance.</param>
        /// <param name="cashDiscountTaken">cashDiscountTaken.</param>
        /// <param name="currency">currency.</param>
        /// <param name="customer">customer.</param>
        /// <param name="description">description.</param>
        /// <param name="docType">docType.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="paymentDate">paymentDate.</param>
        /// <param name="paymentPeriod">paymentPeriod.</param>
        /// <param name="paymentRef">paymentRef.</param>
        /// <param name="status">status.</param>
        public SalesInvoiceApplicationInvoice(StringValue adjustedDocReferenceNbr = default(StringValue), StringValue adjustingDocReferenceNbr = default(StringValue), IntValue adjustmentNbr = default(IntValue), DecimalValue amountPaid = default(DecimalValue), DecimalValue balance = default(DecimalValue), DecimalValue cashDiscountTaken = default(DecimalValue), StringValue currency = default(StringValue), StringValue customer = default(StringValue), StringValue description = default(StringValue), StringValue docType = default(StringValue), StringValue documentType = default(StringValue), DateTimeValue paymentDate = default(DateTimeValue), StringValue paymentPeriod = default(StringValue), StringValue paymentRef = default(StringValue), StringValue status = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AdjustedDocReferenceNbr = adjustedDocReferenceNbr;
            this.AdjustingDocReferenceNbr = adjustingDocReferenceNbr;
            this.AdjustmentNbr = adjustmentNbr;
            this.AmountPaid = amountPaid;
            this.Balance = balance;
            this.CashDiscountTaken = cashDiscountTaken;
            this.Currency = currency;
            this.Customer = customer;
            this.Description = description;
            this.DocType = docType;
            this.DocumentType = documentType;
            this.PaymentDate = paymentDate;
            this.PaymentPeriod = paymentPeriod;
            this.PaymentRef = paymentRef;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets AdjustedDocReferenceNbr
        /// </summary>
        [DataMember(Name="AdjustedDocReferenceNbr", EmitDefaultValue=false)]
        public StringValue AdjustedDocReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets AdjustingDocReferenceNbr
        /// </summary>
        [DataMember(Name="AdjustingDocReferenceNbr", EmitDefaultValue=false)]
        public StringValue AdjustingDocReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentNbr
        /// </summary>
        [DataMember(Name="AdjustmentNbr", EmitDefaultValue=false)]
        public IntValue AdjustmentNbr { get; set; }

        /// <summary>
        /// Gets or Sets AmountPaid
        /// </summary>
        [DataMember(Name="AmountPaid", EmitDefaultValue=false)]
        public DecimalValue AmountPaid { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public DecimalValue Balance { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountTaken
        /// </summary>
        [DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
        public DecimalValue CashDiscountTaken { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public StringValue Currency { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="Customer", EmitDefaultValue=false)]
        public StringValue Customer { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets DocType
        /// </summary>
        [DataMember(Name="DocType", EmitDefaultValue=false)]
        public StringValue DocType { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name="DocumentType", EmitDefaultValue=false)]
        public StringValue DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDate
        /// </summary>
        [DataMember(Name="PaymentDate", EmitDefaultValue=false)]
        public DateTimeValue PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentPeriod
        /// </summary>
        [DataMember(Name="PaymentPeriod", EmitDefaultValue=false)]
        public StringValue PaymentPeriod { get; set; }

        /// <summary>
        /// Gets or Sets PaymentRef
        /// </summary>
        [DataMember(Name="PaymentRef", EmitDefaultValue=false)]
        public StringValue PaymentRef { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesInvoiceApplicationInvoice {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AdjustedDocReferenceNbr: ").Append(AdjustedDocReferenceNbr).Append("\n");
            sb.Append("  AdjustingDocReferenceNbr: ").Append(AdjustingDocReferenceNbr).Append("\n");
            sb.Append("  AdjustmentNbr: ").Append(AdjustmentNbr).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CashDiscountTaken: ").Append(CashDiscountTaken).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocType: ").Append(DocType).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PaymentPeriod: ").Append(PaymentPeriod).Append("\n");
            sb.Append("  PaymentRef: ").Append(PaymentRef).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SalesInvoiceApplicationInvoice);
        }

        /// <summary>
        /// Returns true if SalesInvoiceApplicationInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesInvoiceApplicationInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceApplicationInvoice input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AdjustedDocReferenceNbr == input.AdjustedDocReferenceNbr ||
                    (this.AdjustedDocReferenceNbr != null &&
                    this.AdjustedDocReferenceNbr.Equals(input.AdjustedDocReferenceNbr))
                ) && base.Equals(input) && 
                (
                    this.AdjustingDocReferenceNbr == input.AdjustingDocReferenceNbr ||
                    (this.AdjustingDocReferenceNbr != null &&
                    this.AdjustingDocReferenceNbr.Equals(input.AdjustingDocReferenceNbr))
                ) && base.Equals(input) && 
                (
                    this.AdjustmentNbr == input.AdjustmentNbr ||
                    (this.AdjustmentNbr != null &&
                    this.AdjustmentNbr.Equals(input.AdjustmentNbr))
                ) && base.Equals(input) && 
                (
                    this.AmountPaid == input.AmountPaid ||
                    (this.AmountPaid != null &&
                    this.AmountPaid.Equals(input.AmountPaid))
                ) && base.Equals(input) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && base.Equals(input) && 
                (
                    this.CashDiscountTaken == input.CashDiscountTaken ||
                    (this.CashDiscountTaken != null &&
                    this.CashDiscountTaken.Equals(input.CashDiscountTaken))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.DocType == input.DocType ||
                    (this.DocType != null &&
                    this.DocType.Equals(input.DocType))
                ) && base.Equals(input) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && base.Equals(input) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && base.Equals(input) && 
                (
                    this.PaymentPeriod == input.PaymentPeriod ||
                    (this.PaymentPeriod != null &&
                    this.PaymentPeriod.Equals(input.PaymentPeriod))
                ) && base.Equals(input) && 
                (
                    this.PaymentRef == input.PaymentRef ||
                    (this.PaymentRef != null &&
                    this.PaymentRef.Equals(input.PaymentRef))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AdjustedDocReferenceNbr != null)
                    hashCode = hashCode * 59 + this.AdjustedDocReferenceNbr.GetHashCode();
                if (this.AdjustingDocReferenceNbr != null)
                    hashCode = hashCode * 59 + this.AdjustingDocReferenceNbr.GetHashCode();
                if (this.AdjustmentNbr != null)
                    hashCode = hashCode * 59 + this.AdjustmentNbr.GetHashCode();
                if (this.AmountPaid != null)
                    hashCode = hashCode * 59 + this.AmountPaid.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.CashDiscountTaken != null)
                    hashCode = hashCode * 59 + this.CashDiscountTaken.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DocType != null)
                    hashCode = hashCode * 59 + this.DocType.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.PaymentPeriod != null)
                    hashCode = hashCode * 59 + this.PaymentPeriod.GetHashCode();
                if (this.PaymentRef != null)
                    hashCode = hashCode * 59 + this.PaymentRef.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
