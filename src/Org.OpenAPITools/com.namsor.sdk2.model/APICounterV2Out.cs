/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.6
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
    /// APICounterV2Out
    /// </summary>
    [DataContract]
    public partial class APICounterV2Out :  IEquatable<APICounterV2Out>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APICounterV2Out" /> class.
        /// </summary>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="apiService">apiService.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="totalUsage">totalUsage.</param>
        /// <param name="lastFlushedDateTime">lastFlushedDateTime.</param>
        /// <param name="lastUsedDateTime">lastUsedDateTime.</param>
        /// <param name="serviceFeaturesUsage">serviceFeaturesUsage.</param>
        public APICounterV2Out(APIKeyOut apiKey = default(APIKeyOut), string apiService = default(string), long? createdDateTime = default(long?), long? totalUsage = default(long?), long? lastFlushedDateTime = default(long?), long? lastUsedDateTime = default(long?), Dictionary<string, long?> serviceFeaturesUsage = default(Dictionary<string, long?>))
        {
            this.ApiKey = apiKey;
            this.ApiService = apiService;
            this.CreatedDateTime = createdDateTime;
            this.TotalUsage = totalUsage;
            this.LastFlushedDateTime = lastFlushedDateTime;
            this.LastUsedDateTime = lastUsedDateTime;
            this.ServiceFeaturesUsage = serviceFeaturesUsage;
        }
        
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public APIKeyOut ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets ApiService
        /// </summary>
        [DataMember(Name="apiService", EmitDefaultValue=false)]
        public string ApiService { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public long? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalUsage
        /// </summary>
        [DataMember(Name="totalUsage", EmitDefaultValue=false)]
        public long? TotalUsage { get; set; }

        /// <summary>
        /// Gets or Sets LastFlushedDateTime
        /// </summary>
        [DataMember(Name="lastFlushedDateTime", EmitDefaultValue=false)]
        public long? LastFlushedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastUsedDateTime
        /// </summary>
        [DataMember(Name="lastUsedDateTime", EmitDefaultValue=false)]
        public long? LastUsedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ServiceFeaturesUsage
        /// </summary>
        [DataMember(Name="serviceFeaturesUsage", EmitDefaultValue=false)]
        public Dictionary<string, long?> ServiceFeaturesUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APICounterV2Out {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  ApiService: ").Append(ApiService).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  TotalUsage: ").Append(TotalUsage).Append("\n");
            sb.Append("  LastFlushedDateTime: ").Append(LastFlushedDateTime).Append("\n");
            sb.Append("  LastUsedDateTime: ").Append(LastUsedDateTime).Append("\n");
            sb.Append("  ServiceFeaturesUsage: ").Append(ServiceFeaturesUsage).Append("\n");
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
            return this.Equals(input as APICounterV2Out);
        }

        /// <summary>
        /// Returns true if APICounterV2Out instances are equal
        /// </summary>
        /// <param name="input">Instance of APICounterV2Out to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APICounterV2Out input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.ApiService == input.ApiService ||
                    (this.ApiService != null &&
                    this.ApiService.Equals(input.ApiService))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.TotalUsage == input.TotalUsage ||
                    (this.TotalUsage != null &&
                    this.TotalUsage.Equals(input.TotalUsage))
                ) && 
                (
                    this.LastFlushedDateTime == input.LastFlushedDateTime ||
                    (this.LastFlushedDateTime != null &&
                    this.LastFlushedDateTime.Equals(input.LastFlushedDateTime))
                ) && 
                (
                    this.LastUsedDateTime == input.LastUsedDateTime ||
                    (this.LastUsedDateTime != null &&
                    this.LastUsedDateTime.Equals(input.LastUsedDateTime))
                ) && 
                (
                    this.ServiceFeaturesUsage == input.ServiceFeaturesUsage ||
                    this.ServiceFeaturesUsage != null &&
                    this.ServiceFeaturesUsage.SequenceEqual(input.ServiceFeaturesUsage)
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
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.ApiService != null)
                    hashCode = hashCode * 59 + this.ApiService.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.TotalUsage != null)
                    hashCode = hashCode * 59 + this.TotalUsage.GetHashCode();
                if (this.LastFlushedDateTime != null)
                    hashCode = hashCode * 59 + this.LastFlushedDateTime.GetHashCode();
                if (this.LastUsedDateTime != null)
                    hashCode = hashCode * 59 + this.LastUsedDateTime.GetHashCode();
                if (this.ServiceFeaturesUsage != null)
                    hashCode = hashCode * 59 + this.ServiceFeaturesUsage.GetHashCode();
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
