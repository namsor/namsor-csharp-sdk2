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
    /// APIClassifierOut
    /// </summary>
    [DataContract]
    public partial class APIClassifierOut :  IEquatable<APIClassifierOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIClassifierOut" /> class.
        /// </summary>
        /// <param name="classifierName">classifierName.</param>
        /// <param name="serving">serving.</param>
        /// <param name="learning">learning.</param>
        /// <param name="shuttingDown">shuttingDown.</param>
        /// <param name="probabilityCalibrated">probabilityCalibrated.</param>
        public APIClassifierOut(string classifierName = default(string), bool? serving = default(bool?), bool? learning = default(bool?), bool? shuttingDown = default(bool?), bool? probabilityCalibrated = default(bool?))
        {
            this.ClassifierName = classifierName;
            this.Serving = serving;
            this.Learning = learning;
            this.ShuttingDown = shuttingDown;
            this.ProbabilityCalibrated = probabilityCalibrated;
        }
        
        /// <summary>
        /// Gets or Sets ClassifierName
        /// </summary>
        [DataMember(Name="classifierName", EmitDefaultValue=false)]
        public string ClassifierName { get; set; }

        /// <summary>
        /// Gets or Sets Serving
        /// </summary>
        [DataMember(Name="serving", EmitDefaultValue=false)]
        public bool? Serving { get; set; }

        /// <summary>
        /// Gets or Sets Learning
        /// </summary>
        [DataMember(Name="learning", EmitDefaultValue=false)]
        public bool? Learning { get; set; }

        /// <summary>
        /// Gets or Sets ShuttingDown
        /// </summary>
        [DataMember(Name="shuttingDown", EmitDefaultValue=false)]
        public bool? ShuttingDown { get; set; }

        /// <summary>
        /// Gets or Sets ProbabilityCalibrated
        /// </summary>
        [DataMember(Name="probabilityCalibrated", EmitDefaultValue=false)]
        public bool? ProbabilityCalibrated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIClassifierOut {\n");
            sb.Append("  ClassifierName: ").Append(ClassifierName).Append("\n");
            sb.Append("  Serving: ").Append(Serving).Append("\n");
            sb.Append("  Learning: ").Append(Learning).Append("\n");
            sb.Append("  ShuttingDown: ").Append(ShuttingDown).Append("\n");
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
            return this.Equals(input as APIClassifierOut);
        }

        /// <summary>
        /// Returns true if APIClassifierOut instances are equal
        /// </summary>
        /// <param name="input">Instance of APIClassifierOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIClassifierOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassifierName == input.ClassifierName ||
                    (this.ClassifierName != null &&
                    this.ClassifierName.Equals(input.ClassifierName))
                ) && 
                (
                    this.Serving == input.Serving ||
                    (this.Serving != null &&
                    this.Serving.Equals(input.Serving))
                ) && 
                (
                    this.Learning == input.Learning ||
                    (this.Learning != null &&
                    this.Learning.Equals(input.Learning))
                ) && 
                (
                    this.ShuttingDown == input.ShuttingDown ||
                    (this.ShuttingDown != null &&
                    this.ShuttingDown.Equals(input.ShuttingDown))
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
                if (this.ClassifierName != null)
                    hashCode = hashCode * 59 + this.ClassifierName.GetHashCode();
                if (this.Serving != null)
                    hashCode = hashCode * 59 + this.Serving.GetHashCode();
                if (this.Learning != null)
                    hashCode = hashCode * 59 + this.Learning.GetHashCode();
                if (this.ShuttingDown != null)
                    hashCode = hashCode * 59 + this.ShuttingDown.GetHashCode();
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
