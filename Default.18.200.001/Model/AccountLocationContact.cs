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
    /// AccountLocationContact
    /// </summary>
    [DataContract]
    public partial class AccountLocationContact : Entity,  IEquatable<AccountLocationContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLocationContact" /> class.
        /// </summary>
        /// <param name="attention">attention.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="email">email.</param>
        /// <param name="fax">fax.</param>
        /// <param name="faxType">faxType.</param>
        /// <param name="phone1">phone1.</param>
        /// <param name="phone1Type">phone1Type.</param>
        /// <param name="phone2">phone2.</param>
        /// <param name="phone2Type">phone2Type.</param>
        /// <param name="sameAsMain">sameAsMain.</param>
        /// <param name="webSite">webSite.</param>
        public AccountLocationContact(StringValue attention = default(StringValue), StringValue companyName = default(StringValue), StringValue email = default(StringValue), StringValue fax = default(StringValue), StringValue faxType = default(StringValue), StringValue phone1 = default(StringValue), StringValue phone1Type = default(StringValue), StringValue phone2 = default(StringValue), StringValue phone2Type = default(StringValue), BooleanValue sameAsMain = default(BooleanValue), StringValue webSite = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Attention = attention;
            this.CompanyName = companyName;
            this.Email = email;
            this.Fax = fax;
            this.FaxType = faxType;
            this.Phone1 = phone1;
            this.Phone1Type = phone1Type;
            this.Phone2 = phone2;
            this.Phone2Type = phone2Type;
            this.SameAsMain = sameAsMain;
            this.WebSite = webSite;
        }
        
        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name="Attention", EmitDefaultValue=false)]
        public StringValue Attention { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="CompanyName", EmitDefaultValue=false)]
        public StringValue CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public StringValue Email { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="Fax", EmitDefaultValue=false)]
        public StringValue Fax { get; set; }

        /// <summary>
        /// Gets or Sets FaxType
        /// </summary>
        [DataMember(Name="FaxType", EmitDefaultValue=false)]
        public StringValue FaxType { get; set; }

        /// <summary>
        /// Gets or Sets Phone1
        /// </summary>
        [DataMember(Name="Phone1", EmitDefaultValue=false)]
        public StringValue Phone1 { get; set; }

        /// <summary>
        /// Gets or Sets Phone1Type
        /// </summary>
        [DataMember(Name="Phone1Type", EmitDefaultValue=false)]
        public StringValue Phone1Type { get; set; }

        /// <summary>
        /// Gets or Sets Phone2
        /// </summary>
        [DataMember(Name="Phone2", EmitDefaultValue=false)]
        public StringValue Phone2 { get; set; }

        /// <summary>
        /// Gets or Sets Phone2Type
        /// </summary>
        [DataMember(Name="Phone2Type", EmitDefaultValue=false)]
        public StringValue Phone2Type { get; set; }

        /// <summary>
        /// Gets or Sets SameAsMain
        /// </summary>
        [DataMember(Name="SameAsMain", EmitDefaultValue=false)]
        public BooleanValue SameAsMain { get; set; }

        /// <summary>
        /// Gets or Sets WebSite
        /// </summary>
        [DataMember(Name="WebSite", EmitDefaultValue=false)]
        public StringValue WebSite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountLocationContact {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  FaxType: ").Append(FaxType).Append("\n");
            sb.Append("  Phone1: ").Append(Phone1).Append("\n");
            sb.Append("  Phone1Type: ").Append(Phone1Type).Append("\n");
            sb.Append("  Phone2: ").Append(Phone2).Append("\n");
            sb.Append("  Phone2Type: ").Append(Phone2Type).Append("\n");
            sb.Append("  SameAsMain: ").Append(SameAsMain).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
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
            return this.Equals(input as AccountLocationContact);
        }

        /// <summary>
        /// Returns true if AccountLocationContact instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountLocationContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountLocationContact input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Attention == input.Attention ||
                    (this.Attention != null &&
                    this.Attention.Equals(input.Attention))
                ) && base.Equals(input) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && base.Equals(input) && 
                (
                    this.FaxType == input.FaxType ||
                    (this.FaxType != null &&
                    this.FaxType.Equals(input.FaxType))
                ) && base.Equals(input) && 
                (
                    this.Phone1 == input.Phone1 ||
                    (this.Phone1 != null &&
                    this.Phone1.Equals(input.Phone1))
                ) && base.Equals(input) && 
                (
                    this.Phone1Type == input.Phone1Type ||
                    (this.Phone1Type != null &&
                    this.Phone1Type.Equals(input.Phone1Type))
                ) && base.Equals(input) && 
                (
                    this.Phone2 == input.Phone2 ||
                    (this.Phone2 != null &&
                    this.Phone2.Equals(input.Phone2))
                ) && base.Equals(input) && 
                (
                    this.Phone2Type == input.Phone2Type ||
                    (this.Phone2Type != null &&
                    this.Phone2Type.Equals(input.Phone2Type))
                ) && base.Equals(input) && 
                (
                    this.SameAsMain == input.SameAsMain ||
                    (this.SameAsMain != null &&
                    this.SameAsMain.Equals(input.SameAsMain))
                ) && base.Equals(input) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
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
                if (this.Attention != null)
                    hashCode = hashCode * 59 + this.Attention.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.FaxType != null)
                    hashCode = hashCode * 59 + this.FaxType.GetHashCode();
                if (this.Phone1 != null)
                    hashCode = hashCode * 59 + this.Phone1.GetHashCode();
                if (this.Phone1Type != null)
                    hashCode = hashCode * 59 + this.Phone1Type.GetHashCode();
                if (this.Phone2 != null)
                    hashCode = hashCode * 59 + this.Phone2.GetHashCode();
                if (this.Phone2Type != null)
                    hashCode = hashCode * 59 + this.Phone2Type.GetHashCode();
                if (this.SameAsMain != null)
                    hashCode = hashCode * 59 + this.SameAsMain.GetHashCode();
                if (this.WebSite != null)
                    hashCode = hashCode * 59 + this.WebSite.GetHashCode();
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
