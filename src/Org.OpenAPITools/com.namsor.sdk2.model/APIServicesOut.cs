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
    /// APIServicesOut
    /// </summary>
    [DataContract]
    public partial class APIServicesOut :  IEquatable<APIServicesOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIServicesOut" /> class.
        /// </summary>
        /// <param name="apiServices">apiServices.</param>
        public APIServicesOut(List<APIServiceOut> apiServices = default(List<APIServiceOut>))
        {
            this.ApiServices = apiServices;
        }
        
        /// <summary>
        /// Gets or Sets ApiServices
        /// </summary>
        [DataMember(Name="apiServices", EmitDefaultValue=false)]
        public List<APIServiceOut> ApiServices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIServicesOut {\n");
            sb.Append("  ApiServices: ").Append(ApiServices).Append("\n");
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
            return this.Equals(input as APIServicesOut);
        }

        /// <summary>
        /// Returns true if APIServicesOut instances are equal
        /// </summary>
        /// <param name="input">Instance of APIServicesOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIServicesOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiServices == input.ApiServices ||
                    this.ApiServices != null &&
                    this.ApiServices.SequenceEqual(input.ApiServices)
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
                if (this.ApiServices != null)
                    hashCode = hashCode * 59 + this.ApiServices.GetHashCode();
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
