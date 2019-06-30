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
    /// PersonalNameGenderedOut
    /// </summary>
    [DataContract]
    public partial class PersonalNameGenderedOut :  IEquatable<PersonalNameGenderedOut>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="PersonalNameGenderedOut" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="likelyGender">Most likely gender.</param>
        /// <param name="genderScale">Compatibility to NamSor_v1 Gender Scale M[-1..U..+1]F value.</param>
        /// <param name="score">score.</param>
        public PersonalNameGenderedOut(string id = default(string), string name = default(string), LikelyGenderEnum? likelyGender = default(LikelyGenderEnum?), double? genderScale = default(double?), double? score = default(double?))
        {
            this.Id = id;
            this.Name = name;
            this.LikelyGender = likelyGender;
            this.GenderScale = genderScale;
            this.Score = score;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalNameGenderedOut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LikelyGender: ").Append(LikelyGender).Append("\n");
            sb.Append("  GenderScale: ").Append(GenderScale).Append("\n");
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
            return this.Equals(input as PersonalNameGenderedOut);
        }

        /// <summary>
        /// Returns true if PersonalNameGenderedOut instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonalNameGenderedOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalNameGenderedOut input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LikelyGender != null)
                    hashCode = hashCode * 59 + this.LikelyGender.GetHashCode();
                if (this.GenderScale != null)
                    hashCode = hashCode * 59 + this.GenderScale.GetHashCode();
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
