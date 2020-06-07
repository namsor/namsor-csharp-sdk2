/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.10
 * Contact: contact@namsor.com
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.com.namsor.sdk2.model
{
    /// <summary>
    /// StripeCardOut
    /// </summary>
    [DataContract]
    public partial class StripeCardOut :  IEquatable<StripeCardOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCardOut" /> class.
        /// </summary>
        /// <param name="defaultCard">defaultCard.</param>
        /// <param name="sourceId">sourceId.</param>
        /// <param name="expMonth">expMonth.</param>
        /// <param name="expYear">expYear.</param>
        /// <param name="last4">last4.</param>
        /// <param name="brand">brand.</param>
        public StripeCardOut(bool? defaultCard = default(bool?), string sourceId = default(string), long? expMonth = default(long?), long? expYear = default(long?), string last4 = default(string), string brand = default(string))
        {
            this.DefaultCard = defaultCard;
            this.SourceId = sourceId;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Last4 = last4;
            this.Brand = brand;
        }
        
        /// <summary>
        /// Gets or Sets DefaultCard
        /// </summary>
        [DataMember(Name="defaultCard", EmitDefaultValue=false)]
        public bool? DefaultCard { get; set; }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name="expMonth", EmitDefaultValue=false)]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name="expYear", EmitDefaultValue=false)]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue=false)]
        public string Last4 { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripeCardOut {\n");
            sb.Append("  DefaultCard: ").Append(DefaultCard).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as StripeCardOut);
        }

        /// <summary>
        /// Returns true if StripeCardOut instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeCardOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeCardOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultCard == input.DefaultCard ||
                    (this.DefaultCard != null &&
                    this.DefaultCard.Equals(input.DefaultCard))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.ExpMonth == input.ExpMonth ||
                    (this.ExpMonth != null &&
                    this.ExpMonth.Equals(input.ExpMonth))
                ) && 
                (
                    this.ExpYear == input.ExpYear ||
                    (this.ExpYear != null &&
                    this.ExpYear.Equals(input.ExpYear))
                ) && 
                (
                    this.Last4 == input.Last4 ||
                    (this.Last4 != null &&
                    this.Last4.Equals(input.Last4))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
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
                int hashCode = 41;
                if (this.DefaultCard != null)
                    hashCode = hashCode * 59 + this.DefaultCard.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.ExpMonth != null)
                    hashCode = hashCode * 59 + this.ExpMonth.GetHashCode();
                if (this.ExpYear != null)
                    hashCode = hashCode * 59 + this.ExpYear.GetHashCode();
                if (this.Last4 != null)
                    hashCode = hashCode * 59 + this.Last4.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
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
            yield break;
        }
    }

}
