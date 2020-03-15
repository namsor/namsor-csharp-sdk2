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
    /// Simple metrics system caches
    /// </summary>
    [DataContract]
    public partial class CacheMetricsOut :  IEquatable<CacheMetricsOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheMetricsOut" /> class.
        /// </summary>
        /// <param name="cacheName">cacheName.</param>
        /// <param name="cacheStats">cacheStats.</param>
        public CacheMetricsOut(string cacheName = default(string), string cacheStats = default(string))
        {
            this.CacheName = cacheName;
            this.CacheStats = cacheStats;
        }
        
        /// <summary>
        /// Gets or Sets CacheName
        /// </summary>
        [DataMember(Name="cacheName", EmitDefaultValue=false)]
        public string CacheName { get; set; }

        /// <summary>
        /// Gets or Sets CacheStats
        /// </summary>
        [DataMember(Name="cacheStats", EmitDefaultValue=false)]
        public string CacheStats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CacheMetricsOut {\n");
            sb.Append("  CacheName: ").Append(CacheName).Append("\n");
            sb.Append("  CacheStats: ").Append(CacheStats).Append("\n");
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
            return this.Equals(input as CacheMetricsOut);
        }

        /// <summary>
        /// Returns true if CacheMetricsOut instances are equal
        /// </summary>
        /// <param name="input">Instance of CacheMetricsOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CacheMetricsOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CacheName == input.CacheName ||
                    (this.CacheName != null &&
                    this.CacheName.Equals(input.CacheName))
                ) && 
                (
                    this.CacheStats == input.CacheStats ||
                    (this.CacheStats != null &&
                    this.CacheStats.Equals(input.CacheStats))
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
                if (this.CacheName != null)
                    hashCode = hashCode * 59 + this.CacheName.GetHashCode();
                if (this.CacheStats != null)
                    hashCode = hashCode * 59 + this.CacheStats.GetHashCode();
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