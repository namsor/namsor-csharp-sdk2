/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.9
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
    /// CurrenciesOut
    /// </summary>
    [DataContract]
    public partial class CurrenciesOut :  IEquatable<CurrenciesOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesOut" /> class.
        /// </summary>
        /// <param name="currenciesIso3">currenciesIso3.</param>
        public CurrenciesOut(List<string> currenciesIso3 = default(List<string>))
        {
            this.CurrenciesIso3 = currenciesIso3;
        }
        
        /// <summary>
        /// Gets or Sets CurrenciesIso3
        /// </summary>
        [DataMember(Name="currenciesIso3", EmitDefaultValue=false)]
        public List<string> CurrenciesIso3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrenciesOut {\n");
            sb.Append("  CurrenciesIso3: ").Append(CurrenciesIso3).Append("\n");
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
            return this.Equals(input as CurrenciesOut);
        }

        /// <summary>
        /// Returns true if CurrenciesOut instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrenciesOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrenciesOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrenciesIso3 == input.CurrenciesIso3 ||
                    this.CurrenciesIso3 != null &&
                    this.CurrenciesIso3.SequenceEqual(input.CurrenciesIso3)
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
                if (this.CurrenciesIso3 != null)
                    hashCode = hashCode * 59 + this.CurrenciesIso3.GetHashCode();
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
