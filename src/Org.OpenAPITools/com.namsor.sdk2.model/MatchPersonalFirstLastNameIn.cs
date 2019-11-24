/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.7
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
    /// MatchPersonalFirstLastNameIn
    /// </summary>
    [DataContract]
    public partial class MatchPersonalFirstLastNameIn :  IEquatable<MatchPersonalFirstLastNameIn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchPersonalFirstLastNameIn" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name1">name1.</param>
        /// <param name="name2">name2.</param>
        /// <param name="name">name.</param>
        public MatchPersonalFirstLastNameIn(string id = default(string), FirstLastNameIn name1 = default(FirstLastNameIn), PersonalNameIn name2 = default(PersonalNameIn), string name = default(string))
        {
            this.Id = id;
            this.Name1 = name1;
            this.Name2 = name2;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name1
        /// </summary>
        [DataMember(Name="name1", EmitDefaultValue=false)]
        public FirstLastNameIn Name1 { get; set; }

        /// <summary>
        /// Gets or Sets Name2
        /// </summary>
        [DataMember(Name="name2", EmitDefaultValue=false)]
        public PersonalNameIn Name2 { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchPersonalFirstLastNameIn {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name1: ").Append(Name1).Append("\n");
            sb.Append("  Name2: ").Append(Name2).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as MatchPersonalFirstLastNameIn);
        }

        /// <summary>
        /// Returns true if MatchPersonalFirstLastNameIn instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchPersonalFirstLastNameIn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchPersonalFirstLastNameIn input)
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
                    this.Name1 == input.Name1 ||
                    (this.Name1 != null &&
                    this.Name1.Equals(input.Name1))
                ) && 
                (
                    this.Name2 == input.Name2 ||
                    (this.Name2 != null &&
                    this.Name2.Equals(input.Name2))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name1 != null)
                    hashCode = hashCode * 59 + this.Name1.GetHashCode();
                if (this.Name2 != null)
                    hashCode = hashCode * 59 + this.Name2.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
