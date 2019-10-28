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
    /// SystemMetricsOut
    /// </summary>
    [DataContract]
    public partial class SystemMetricsOut :  IEquatable<SystemMetricsOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMetricsOut" /> class.
        /// </summary>
        /// <param name="classifierMetrics">classifierMetrics.</param>
        /// <param name="sourceMetrics">sourceMetrics.</param>
        /// <param name="totalMem">totalMem.</param>
        /// <param name="freeMem">freeMem.</param>
        /// <param name="maxMem">maxMem.</param>
        public SystemMetricsOut(List<ClassifierMetricsOut> classifierMetrics = default(List<ClassifierMetricsOut>), List<SourceMetricsOut> sourceMetrics = default(List<SourceMetricsOut>), long? totalMem = default(long?), long? freeMem = default(long?), long? maxMem = default(long?))
        {
            this.ClassifierMetrics = classifierMetrics;
            this.SourceMetrics = sourceMetrics;
            this.TotalMem = totalMem;
            this.FreeMem = freeMem;
            this.MaxMem = maxMem;
        }
        
        /// <summary>
        /// Gets or Sets ClassifierMetrics
        /// </summary>
        [DataMember(Name="classifierMetrics", EmitDefaultValue=false)]
        public List<ClassifierMetricsOut> ClassifierMetrics { get; set; }

        /// <summary>
        /// Gets or Sets SourceMetrics
        /// </summary>
        [DataMember(Name="sourceMetrics", EmitDefaultValue=false)]
        public List<SourceMetricsOut> SourceMetrics { get; set; }

        /// <summary>
        /// Gets or Sets TotalMem
        /// </summary>
        [DataMember(Name="totalMem", EmitDefaultValue=false)]
        public long? TotalMem { get; set; }

        /// <summary>
        /// Gets or Sets FreeMem
        /// </summary>
        [DataMember(Name="freeMem", EmitDefaultValue=false)]
        public long? FreeMem { get; set; }

        /// <summary>
        /// Gets or Sets MaxMem
        /// </summary>
        [DataMember(Name="maxMem", EmitDefaultValue=false)]
        public long? MaxMem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemMetricsOut {\n");
            sb.Append("  ClassifierMetrics: ").Append(ClassifierMetrics).Append("\n");
            sb.Append("  SourceMetrics: ").Append(SourceMetrics).Append("\n");
            sb.Append("  TotalMem: ").Append(TotalMem).Append("\n");
            sb.Append("  FreeMem: ").Append(FreeMem).Append("\n");
            sb.Append("  MaxMem: ").Append(MaxMem).Append("\n");
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
            return this.Equals(input as SystemMetricsOut);
        }

        /// <summary>
        /// Returns true if SystemMetricsOut instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemMetricsOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemMetricsOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassifierMetrics == input.ClassifierMetrics ||
                    this.ClassifierMetrics != null &&
                    this.ClassifierMetrics.SequenceEqual(input.ClassifierMetrics)
                ) && 
                (
                    this.SourceMetrics == input.SourceMetrics ||
                    this.SourceMetrics != null &&
                    this.SourceMetrics.SequenceEqual(input.SourceMetrics)
                ) && 
                (
                    this.TotalMem == input.TotalMem ||
                    (this.TotalMem != null &&
                    this.TotalMem.Equals(input.TotalMem))
                ) && 
                (
                    this.FreeMem == input.FreeMem ||
                    (this.FreeMem != null &&
                    this.FreeMem.Equals(input.FreeMem))
                ) && 
                (
                    this.MaxMem == input.MaxMem ||
                    (this.MaxMem != null &&
                    this.MaxMem.Equals(input.MaxMem))
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
                if (this.ClassifierMetrics != null)
                    hashCode = hashCode * 59 + this.ClassifierMetrics.GetHashCode();
                if (this.SourceMetrics != null)
                    hashCode = hashCode * 59 + this.SourceMetrics.GetHashCode();
                if (this.TotalMem != null)
                    hashCode = hashCode * 59 + this.TotalMem.GetHashCode();
                if (this.FreeMem != null)
                    hashCode = hashCode * 59 + this.FreeMem.GetHashCode();
                if (this.MaxMem != null)
                    hashCode = hashCode * 59 + this.MaxMem.GetHashCode();
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
