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
    /// Represents the output of inferring the LIKELY gender from a personal name.
    /// </summary>
    [DataContract]
    public partial class FirstLastNameGenderedOut :  IEquatable<FirstLastNameGenderedOut>, IValidatableObject
    {
        /// <summary>
        /// Most likely gender
        /// </summary>
        /// <value>Most likely gender</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LikelyGenderEnum
        {
            /// <summary>
            /// Enum Male for value: male
            /// </summary>
            [EnumMember(Value = "male")]
            Male = 1,

            /// <summary>
            /// Enum Female for value: female
            /// </summary>
            [EnumMember(Value = "female")]
            Female = 2,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 3

        }

        /// <summary>
        /// Most likely gender
        /// </summary>
        /// <value>Most likely gender</value>
        [DataMember(Name="likelyGender", EmitDefaultValue=false)]
        public LikelyGenderEnum? LikelyGender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstLastNameGenderedOut" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="likelyGender">Most likely gender.</param>
        /// <param name="genderScale">Compatibility to NamSor_v1 Gender Scale M[-1..U..+1]F value.</param>
        /// <param name="score">score.</param>
        /// <param name="probabilityCalibrated">probabilityCalibrated.</param>
        public FirstLastNameGenderedOut(string id = default(string), string firstName = default(string), string lastName = default(string), LikelyGenderEnum? likelyGender = default(LikelyGenderEnum?), double? genderScale = default(double?), double? score = default(double?), double? probabilityCalibrated = default(double?))
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.LikelyGender = likelyGender;
            this.GenderScale = genderScale;
            this.Score = score;
            this.ProbabilityCalibrated = probabilityCalibrated;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }


        /// <summary>
        /// Compatibility to NamSor_v1 Gender Scale M[-1..U..+1]F value
        /// </summary>
        /// <value>Compatibility to NamSor_v1 Gender Scale M[-1..U..+1]F value</value>
        [DataMember(Name="genderScale", EmitDefaultValue=false)]
        public double? GenderScale { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or Sets ProbabilityCalibrated
        /// </summary>
        [DataMember(Name="probabilityCalibrated", EmitDefaultValue=false)]
        public double? ProbabilityCalibrated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirstLastNameGenderedOut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LikelyGender: ").Append(LikelyGender).Append("\n");
            sb.Append("  GenderScale: ").Append(GenderScale).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  ProbabilityCalibrated: ").Append(ProbabilityCalibrated).Append("\n");
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
            return this.Equals(input as FirstLastNameGenderedOut);
        }

        /// <summary>
        /// Returns true if FirstLastNameGenderedOut instances are equal
        /// </summary>
        /// <param name="input">Instance of FirstLastNameGenderedOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirstLastNameGenderedOut input)
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
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.LikelyGender == input.LikelyGender ||
                    (this.LikelyGender != null &&
                    this.LikelyGender.Equals(input.LikelyGender))
                ) && 
                (
                    this.GenderScale == input.GenderScale ||
                    (this.GenderScale != null &&
                    this.GenderScale.Equals(input.GenderScale))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.ProbabilityCalibrated == input.ProbabilityCalibrated ||
                    (this.ProbabilityCalibrated != null &&
                    this.ProbabilityCalibrated.Equals(input.ProbabilityCalibrated))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.LikelyGender != null)
                    hashCode = hashCode * 59 + this.LikelyGender.GetHashCode();
                if (this.GenderScale != null)
                    hashCode = hashCode * 59 + this.GenderScale.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.ProbabilityCalibrated != null)
                    hashCode = hashCode * 59 + this.ProbabilityCalibrated.GetHashCode();
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
