/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.4
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
    /// NameMatchCandidateOut
    /// </summary>
    [DataContract]
    public partial class NameMatchCandidateOut :  IEquatable<NameMatchCandidateOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameMatchCandidateOut" /> class.
        /// </summary>
        /// <param name="candidateName">candidateName.</param>
        /// <param name="probability">probability.</param>
        public NameMatchCandidateOut(string candidateName = default(string), double? probability = default(double?))
        {
            this.CandidateName = candidateName;
            this.Probability = probability;
        }
        
        /// <summary>
        /// Gets or Sets CandidateName
        /// </summary>
        [DataMember(Name="candidateName", EmitDefaultValue=false)]
        public string CandidateName { get; set; }

        /// <summary>
        /// Gets or Sets Probability
        /// </summary>
        [DataMember(Name="probability", EmitDefaultValue=false)]
        public double? Probability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NameMatchCandidateOut {\n");
            sb.Append("  CandidateName: ").Append(CandidateName).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
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
            return this.Equals(input as NameMatchCandidateOut);
        }

        /// <summary>
        /// Returns true if NameMatchCandidateOut instances are equal
        /// </summary>
        /// <param name="input">Instance of NameMatchCandidateOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NameMatchCandidateOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CandidateName == input.CandidateName ||
                    (this.CandidateName != null &&
                    this.CandidateName.Equals(input.CandidateName))
                ) && 
                (
                    this.Probability == input.Probability ||
                    (this.Probability != null &&
                    this.Probability.Equals(input.Probability))
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
                if (this.CandidateName != null)
                    hashCode = hashCode * 59 + this.CandidateName.GetHashCode();
                if (this.Probability != null)
                    hashCode = hashCode * 59 + this.Probability.GetHashCode();
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
