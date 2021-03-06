/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.11
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
    /// StripeCustomerOut
    /// </summary>
    [DataContract]
    public partial class StripeCustomerOut :  IEquatable<StripeCustomerOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCustomerOut" /> class.
        /// </summary>
        /// <param name="stripeCustomerId">stripeCustomerId.</param>
        /// <param name="sourceCountry">sourceCountry.</param>
        /// <param name="sourceCurrency">sourceCurrency.</param>
        /// <param name="stripedCards">stripedCards.</param>
        public StripeCustomerOut(string stripeCustomerId = default(string), string sourceCountry = default(string), string sourceCurrency = default(string), List<StripeCardOut> stripedCards = default(List<StripeCardOut>))
        {
            this.StripeCustomerId = stripeCustomerId;
            this.SourceCountry = sourceCountry;
            this.SourceCurrency = sourceCurrency;
            this.StripedCards = stripedCards;
        }
        
        /// <summary>
        /// Gets or Sets StripeCustomerId
        /// </summary>
        [DataMember(Name="stripeCustomerId", EmitDefaultValue=false)]
        public string StripeCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets SourceCountry
        /// </summary>
        [DataMember(Name="sourceCountry", EmitDefaultValue=false)]
        public string SourceCountry { get; set; }

        /// <summary>
        /// Gets or Sets SourceCurrency
        /// </summary>
        [DataMember(Name="sourceCurrency", EmitDefaultValue=false)]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// Gets or Sets StripedCards
        /// </summary>
        [DataMember(Name="stripedCards", EmitDefaultValue=false)]
        public List<StripeCardOut> StripedCards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripeCustomerOut {\n");
            sb.Append("  StripeCustomerId: ").Append(StripeCustomerId).Append("\n");
            sb.Append("  SourceCountry: ").Append(SourceCountry).Append("\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  StripedCards: ").Append(StripedCards).Append("\n");
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
            return this.Equals(input as StripeCustomerOut);
        }

        /// <summary>
        /// Returns true if StripeCustomerOut instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeCustomerOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeCustomerOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StripeCustomerId == input.StripeCustomerId ||
                    (this.StripeCustomerId != null &&
                    this.StripeCustomerId.Equals(input.StripeCustomerId))
                ) && 
                (
                    this.SourceCountry == input.SourceCountry ||
                    (this.SourceCountry != null &&
                    this.SourceCountry.Equals(input.SourceCountry))
                ) && 
                (
                    this.SourceCurrency == input.SourceCurrency ||
                    (this.SourceCurrency != null &&
                    this.SourceCurrency.Equals(input.SourceCurrency))
                ) && 
                (
                    this.StripedCards == input.StripedCards ||
                    this.StripedCards != null &&
                    this.StripedCards.SequenceEqual(input.StripedCards)
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
                if (this.StripeCustomerId != null)
                    hashCode = hashCode * 59 + this.StripeCustomerId.GetHashCode();
                if (this.SourceCountry != null)
                    hashCode = hashCode * 59 + this.SourceCountry.GetHashCode();
                if (this.SourceCurrency != null)
                    hashCode = hashCode * 59 + this.SourceCurrency.GetHashCode();
                if (this.StripedCards != null)
                    hashCode = hashCode * 59 + this.StripedCards.GetHashCode();
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
