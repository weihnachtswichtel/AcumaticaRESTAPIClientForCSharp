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
    /// LotSerialClassSegment
    /// </summary>
    [DataContract]
    public partial class LotSerialClassSegment : Entity,  IEquatable<LotSerialClassSegment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LotSerialClassSegment" /> class.
        /// </summary>
        /// <param name="segmentNbr">segmentNbr.</param>
        /// <param name="type">type.</param>
        /// <param name="value">value.</param>
        public LotSerialClassSegment(ShortValue segmentNbr = default(ShortValue), StringValue type = default(StringValue), StringValue value = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.SegmentNbr = segmentNbr;
            this.Type = type;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets SegmentNbr
        /// </summary>
        [DataMember(Name="SegmentNbr", EmitDefaultValue=false)]
        public ShortValue SegmentNbr { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public StringValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LotSerialClassSegment {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SegmentNbr: ").Append(SegmentNbr).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as LotSerialClassSegment);
        }

        /// <summary>
        /// Returns true if LotSerialClassSegment instances are equal
        /// </summary>
        /// <param name="input">Instance of LotSerialClassSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LotSerialClassSegment input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.SegmentNbr == input.SegmentNbr ||
                    (this.SegmentNbr != null &&
                    this.SegmentNbr.Equals(input.SegmentNbr))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.SegmentNbr != null)
                    hashCode = hashCode * 59 + this.SegmentNbr.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
