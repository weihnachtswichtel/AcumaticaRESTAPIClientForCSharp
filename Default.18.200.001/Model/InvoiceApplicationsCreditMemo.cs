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
    /// InvoiceApplicationsCreditMemo
    /// </summary>
    [DataContract]
    public partial class InvoiceApplicationsCreditMemo : Entity,  IEquatable<InvoiceApplicationsCreditMemo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApplicationsCreditMemo" /> class.
        /// </summary>
        /// <param name="amountPaid">amountPaid.</param>
        /// <param name="balance">balance.</param>
        /// <param name="customer">customer.</param>
        /// <param name="customerOrder">customerOrder.</param>
        /// <param name="description">description.</param>
        /// <param name="docType">docType.</param>
        /// <param name="postPeriod">postPeriod.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="status">status.</param>
        public InvoiceApplicationsCreditMemo(DecimalValue amountPaid = default(DecimalValue), DecimalValue balance = default(DecimalValue), StringValue customer = default(StringValue), StringValue customerOrder = default(StringValue), StringValue description = default(StringValue), StringValue docType = default(StringValue), StringValue postPeriod = default(StringValue), StringValue referenceNbr = default(StringValue), StringValue status = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AmountPaid = amountPaid;
            this.Balance = balance;
            this.Customer = customer;
            this.CustomerOrder = customerOrder;
            this.Description = description;
            this.DocType = docType;
            this.PostPeriod = postPeriod;
            this.ReferenceNbr = referenceNbr;
            this.Status = status;
        }
        
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
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="Customer", EmitDefaultValue=false)]
        public StringValue Customer { get; set; }

        /// <summary>
        /// Gets or Sets CustomerOrder
        /// </summary>
        [DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
        public StringValue CustomerOrder { get; set; }

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
        /// Gets or Sets PostPeriod
        /// </summary>
        [DataMember(Name="PostPeriod", EmitDefaultValue=false)]
        public StringValue PostPeriod { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

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
            sb.Append("class InvoiceApplicationsCreditMemo {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  CustomerOrder: ").Append(CustomerOrder).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocType: ").Append(DocType).Append("\n");
            sb.Append("  PostPeriod: ").Append(PostPeriod).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
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
            return this.Equals(input as InvoiceApplicationsCreditMemo);
        }

        /// <summary>
        /// Returns true if InvoiceApplicationsCreditMemo instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceApplicationsCreditMemo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceApplicationsCreditMemo input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && base.Equals(input) && 
                (
                    this.CustomerOrder == input.CustomerOrder ||
                    (this.CustomerOrder != null &&
                    this.CustomerOrder.Equals(input.CustomerOrder))
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
                    this.PostPeriod == input.PostPeriod ||
                    (this.PostPeriod != null &&
                    this.PostPeriod.Equals(input.PostPeriod))
                ) && base.Equals(input) && 
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
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
                if (this.AmountPaid != null)
                    hashCode = hashCode * 59 + this.AmountPaid.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.CustomerOrder != null)
                    hashCode = hashCode * 59 + this.CustomerOrder.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DocType != null)
                    hashCode = hashCode * 59 + this.DocType.GetHashCode();
                if (this.PostPeriod != null)
                    hashCode = hashCode * 59 + this.PostPeriod.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
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
