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
    /// Simple metrics on a classifier, for a given source
    /// </summary>
    [DataContract]
    public partial class SourceMetricsOut :  IEquatable<SourceMetricsOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceMetricsOut" /> class.
        /// </summary>
        /// <param name="classifierName">classifierName.</param>
        /// <param name="source">source.</param>
        /// <param name="aiEstimateTotal">aiEstimateTotal.</param>
        /// <param name="aiEstimatePrecision">aiEstimatePrecision.</param>
        /// <param name="aiEstimateRecall">aiEstimateRecall.</param>
        /// <param name="metricTimeStamp">metricTimeStamp.</param>
        /// <param name="aiStartTime">aiStartTime.</param>
        /// <param name="aiLearnTotal">aiLearnTotal.</param>
        /// <param name="snapshotDate">snapshotDate.</param>
        public SourceMetricsOut(string classifierName = default(string), APIKeyOut source = default(APIKeyOut), long? aiEstimateTotal = default(long?), double? aiEstimatePrecision = default(double?), double? aiEstimateRecall = default(double?), long? metricTimeStamp = default(long?), long? aiStartTime = default(long?), long? aiLearnTotal = default(long?), long? snapshotDate = default(long?))
        {
            this.ClassifierName = classifierName;
            this.Source = source;
            this.AiEstimateTotal = aiEstimateTotal;
            this.AiEstimatePrecision = aiEstimatePrecision;
            this.AiEstimateRecall = aiEstimateRecall;
            this.MetricTimeStamp = metricTimeStamp;
            this.AiStartTime = aiStartTime;
            this.AiLearnTotal = aiLearnTotal;
            this.SnapshotDate = snapshotDate;
        }
        
        /// <summary>
        /// Gets or Sets ClassifierName
        /// </summary>
        [DataMember(Name="classifierName", EmitDefaultValue=false)]
        public string ClassifierName { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public APIKeyOut Source { get; set; }

        /// <summary>
        /// Gets or Sets AiEstimateTotal
        /// </summary>
        [DataMember(Name="aiEstimateTotal", EmitDefaultValue=false)]
        public long? AiEstimateTotal { get; set; }

        /// <summary>
        /// Gets or Sets AiEstimatePrecision
        /// </summary>
        [DataMember(Name="aiEstimatePrecision", EmitDefaultValue=false)]
        public double? AiEstimatePrecision { get; set; }

        /// <summary>
        /// Gets or Sets AiEstimateRecall
        /// </summary>
        [DataMember(Name="aiEstimateRecall", EmitDefaultValue=false)]
        public double? AiEstimateRecall { get; set; }

        /// <summary>
        /// Gets or Sets MetricTimeStamp
        /// </summary>
        [DataMember(Name="metricTimeStamp", EmitDefaultValue=false)]
        public long? MetricTimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets AiStartTime
        /// </summary>
        [DataMember(Name="aiStartTime", EmitDefaultValue=false)]
        public long? AiStartTime { get; set; }

        /// <summary>
        /// Gets or Sets AiLearnTotal
        /// </summary>
        [DataMember(Name="aiLearnTotal", EmitDefaultValue=false)]
        public long? AiLearnTotal { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotDate
        /// </summary>
        [DataMember(Name="snapshotDate", EmitDefaultValue=false)]
        public long? SnapshotDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceMetricsOut {\n");
            sb.Append("  ClassifierName: ").Append(ClassifierName).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  AiEstimateTotal: ").Append(AiEstimateTotal).Append("\n");
            sb.Append("  AiEstimatePrecision: ").Append(AiEstimatePrecision).Append("\n");
            sb.Append("  AiEstimateRecall: ").Append(AiEstimateRecall).Append("\n");
            sb.Append("  MetricTimeStamp: ").Append(MetricTimeStamp).Append("\n");
            sb.Append("  AiStartTime: ").Append(AiStartTime).Append("\n");
            sb.Append("  AiLearnTotal: ").Append(AiLearnTotal).Append("\n");
            sb.Append("  SnapshotDate: ").Append(SnapshotDate).Append("\n");
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
            return this.Equals(input as SourceMetricsOut);
        }

        /// <summary>
        /// Returns true if SourceMetricsOut instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceMetricsOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceMetricsOut input)
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
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.AiEstimateTotal == input.AiEstimateTotal ||
                    (this.AiEstimateTotal != null &&
                    this.AiEstimateTotal.Equals(input.AiEstimateTotal))
                ) && 
                (
                    this.AiEstimatePrecision == input.AiEstimatePrecision ||
                    (this.AiEstimatePrecision != null &&
                    this.AiEstimatePrecision.Equals(input.AiEstimatePrecision))
                ) && 
                (
                    this.AiEstimateRecall == input.AiEstimateRecall ||
                    (this.AiEstimateRecall != null &&
                    this.AiEstimateRecall.Equals(input.AiEstimateRecall))
                ) && 
                (
                    this.MetricTimeStamp == input.MetricTimeStamp ||
                    (this.MetricTimeStamp != null &&
                    this.MetricTimeStamp.Equals(input.MetricTimeStamp))
                ) && 
                (
                    this.AiStartTime == input.AiStartTime ||
                    (this.AiStartTime != null &&
                    this.AiStartTime.Equals(input.AiStartTime))
                ) && 
                (
                    this.AiLearnTotal == input.AiLearnTotal ||
                    (this.AiLearnTotal != null &&
                    this.AiLearnTotal.Equals(input.AiLearnTotal))
                ) && 
                (
                    this.SnapshotDate == input.SnapshotDate ||
                    (this.SnapshotDate != null &&
                    this.SnapshotDate.Equals(input.SnapshotDate))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.AiEstimateTotal != null)
                    hashCode = hashCode * 59 + this.AiEstimateTotal.GetHashCode();
                if (this.AiEstimatePrecision != null)
                    hashCode = hashCode * 59 + this.AiEstimatePrecision.GetHashCode();
                if (this.AiEstimateRecall != null)
                    hashCode = hashCode * 59 + this.AiEstimateRecall.GetHashCode();
                if (this.MetricTimeStamp != null)
                    hashCode = hashCode * 59 + this.MetricTimeStamp.GetHashCode();
                if (this.AiStartTime != null)
                    hashCode = hashCode * 59 + this.AiStartTime.GetHashCode();
                if (this.AiLearnTotal != null)
                    hashCode = hashCode * 59 + this.AiLearnTotal.GetHashCode();
                if (this.SnapshotDate != null)
                    hashCode = hashCode * 59 + this.SnapshotDate.GetHashCode();
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
