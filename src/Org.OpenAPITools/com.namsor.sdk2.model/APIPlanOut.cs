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
    /// APIPlanOut
    /// </summary>
    [DataContract]
    public partial class APIPlanOut :  IEquatable<APIPlanOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIPlanOut" /> class.
        /// </summary>
        /// <param name="planName">planName.</param>
        /// <param name="planQuota">planQuota.</param>
        /// <param name="price">price.</param>
        /// <param name="priceOverage">priceOverage.</param>
        public APIPlanOut(string planName = default(string), long? planQuota = default(long?), double? price = default(double?), double? priceOverage = default(double?))
        {
            this.PlanName = planName;
            this.PlanQuota = planQuota;
            this.Price = price;
            this.PriceOverage = priceOverage;
        }
        
        /// <summary>
        /// Gets or Sets PlanName
        /// </summary>
        [DataMember(Name="planName", EmitDefaultValue=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// Gets or Sets PlanQuota
        /// </summary>
        [DataMember(Name="planQuota", EmitDefaultValue=false)]
        public long? PlanQuota { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets PriceOverage
        /// </summary>
        [DataMember(Name="priceOverage", EmitDefaultValue=false)]
        public double? PriceOverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIPlanOut {\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("  PlanQuota: ").Append(PlanQuota).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceOverage: ").Append(PriceOverage).Append("\n");
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
            return this.Equals(input as APIPlanOut);
        }

        /// <summary>
        /// Returns true if APIPlanOut instances are equal
        /// </summary>
        /// <param name="input">Instance of APIPlanOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIPlanOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlanName == input.PlanName ||
                    (this.PlanName != null &&
                    this.PlanName.Equals(input.PlanName))
                ) && 
                (
                    this.PlanQuota == input.PlanQuota ||
                    (this.PlanQuota != null &&
                    this.PlanQuota.Equals(input.PlanQuota))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PriceOverage == input.PriceOverage ||
                    (this.PriceOverage != null &&
                    this.PriceOverage.Equals(input.PriceOverage))
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
                if (this.PlanName != null)
                    hashCode = hashCode * 59 + this.PlanName.GetHashCode();
                if (this.PlanQuota != null)
                    hashCode = hashCode * 59 + this.PlanQuota.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PriceOverage != null)
                    hashCode = hashCode * 59 + this.PriceOverage.GetHashCode();
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
