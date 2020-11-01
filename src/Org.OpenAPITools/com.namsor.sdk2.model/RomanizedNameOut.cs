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
    /// RomanizedNameOut
    /// </summary>
    [DataContract]
    public partial class RomanizedNameOut :  IEquatable<RomanizedNameOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RomanizedNameOut" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="latinName">latinName.</param>
        /// <param name="originalName">originalName.</param>
        /// <param name="sourceLanguage">sourceLanguage.</param>
        /// <param name="targetLanguage">targetLanguage.</param>
        /// <param name="sourceScript">sourceScript.</param>
        /// <param name="targetScript">targetScript.</param>
        /// <param name="score">score.</param>
        public RomanizedNameOut(string id = default(string), string latinName = default(string), string originalName = default(string), string sourceLanguage = default(string), string targetLanguage = default(string), string sourceScript = default(string), string targetScript = default(string), double? score = default(double?))
        {
            this.Id = id;
            this.LatinName = latinName;
            this.OriginalName = originalName;
            this.SourceLanguage = sourceLanguage;
            this.TargetLanguage = targetLanguage;
            this.SourceScript = sourceScript;
            this.TargetScript = targetScript;
            this.Score = score;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LatinName
        /// </summary>
        [DataMember(Name="latinName", EmitDefaultValue=false)]
        public string LatinName { get; set; }

        /// <summary>
        /// Gets or Sets OriginalName
        /// </summary>
        [DataMember(Name="originalName", EmitDefaultValue=false)]
        public string OriginalName { get; set; }

        /// <summary>
        /// Gets or Sets SourceLanguage
        /// </summary>
        [DataMember(Name="sourceLanguage", EmitDefaultValue=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// Gets or Sets TargetLanguage
        /// </summary>
        [DataMember(Name="targetLanguage", EmitDefaultValue=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// Gets or Sets SourceScript
        /// </summary>
        [DataMember(Name="sourceScript", EmitDefaultValue=false)]
        public string SourceScript { get; set; }

        /// <summary>
        /// Gets or Sets TargetScript
        /// </summary>
        [DataMember(Name="targetScript", EmitDefaultValue=false)]
        public string TargetScript { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RomanizedNameOut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LatinName: ").Append(LatinName).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguage: ").Append(TargetLanguage).Append("\n");
            sb.Append("  SourceScript: ").Append(SourceScript).Append("\n");
            sb.Append("  TargetScript: ").Append(TargetScript).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as RomanizedNameOut);
        }

        /// <summary>
        /// Returns true if RomanizedNameOut instances are equal
        /// </summary>
        /// <param name="input">Instance of RomanizedNameOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RomanizedNameOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LatinName == input.LatinName ||
                    (this.LatinName != null &&
                    this.LatinName.Equals(input.LatinName))
                ) && 
                (
                    this.OriginalName == input.OriginalName ||
                    (this.OriginalName != null &&
                    this.OriginalName.Equals(input.OriginalName))
                ) && 
                (
                    this.SourceLanguage == input.SourceLanguage ||
                    (this.SourceLanguage != null &&
                    this.SourceLanguage.Equals(input.SourceLanguage))
                ) && 
                (
                    this.TargetLanguage == input.TargetLanguage ||
                    (this.TargetLanguage != null &&
                    this.TargetLanguage.Equals(input.TargetLanguage))
                ) && 
                (
                    this.SourceScript == input.SourceScript ||
                    (this.SourceScript != null &&
                    this.SourceScript.Equals(input.SourceScript))
                ) && 
                (
                    this.TargetScript == input.TargetScript ||
                    (this.TargetScript != null &&
                    this.TargetScript.Equals(input.TargetScript))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LatinName != null)
                    hashCode = hashCode * 59 + this.LatinName.GetHashCode();
                if (this.OriginalName != null)
                    hashCode = hashCode * 59 + this.OriginalName.GetHashCode();
                if (this.SourceLanguage != null)
                    hashCode = hashCode * 59 + this.SourceLanguage.GetHashCode();
                if (this.TargetLanguage != null)
                    hashCode = hashCode * 59 + this.TargetLanguage.GetHashCode();
                if (this.SourceScript != null)
                    hashCode = hashCode * 59 + this.SourceScript.GetHashCode();
                if (this.TargetScript != null)
                    hashCode = hashCode * 59 + this.TargetScript.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
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
