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
    /// Simple metrics on a classifier
    /// </summary>
    [DataContract]
    public partial class ClassifierMetricsOut :  IEquatable<ClassifierMetricsOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierMetricsOut" /> class.
        /// </summary>
        /// <param name="learnQueueSize">learnQueueSize.</param>
        /// <param name="bufferSize">bufferSize.</param>
        /// <param name="preClassifyQueueSize">preClassifyQueueSize.</param>
        /// <param name="factKeysSize">factKeysSize.</param>
        /// <param name="factsLearned">factsLearned.</param>
        /// <param name="classifyDurationsCurrent">classifyDurationsCurrent.</param>
        /// <param name="classifyDurationsSummary">classifyDurationsSummary.</param>
        /// <param name="learnDurationsCurrent">learnDurationsCurrent.</param>
        /// <param name="learnDurationsSummary">learnDurationsSummary.</param>
        /// <param name="classifierName">classifierName.</param>
        /// <param name="featuresSize">featuresSize.</param>
        /// <param name="aiVettedEstimateTotal">aiVettedEstimateTotal.</param>
        /// <param name="aiVettedEstimatePrecision">aiVettedEstimatePrecision.</param>
        /// <param name="aiVettedEstimateRecall">aiVettedEstimateRecall.</param>
        /// <param name="aiVettedLearnTotal">aiVettedLearnTotal.</param>
        /// <param name="aiNonVettedEstimateTotal">aiNonVettedEstimateTotal.</param>
        /// <param name="aiNonVettedEstimatePrecision">aiNonVettedEstimatePrecision.</param>
        /// <param name="aiNonVettedEstimateRecall">aiNonVettedEstimateRecall.</param>
        /// <param name="aiNonVettedLearnTotal">aiNonVettedLearnTotal.</param>
        /// <param name="metricTimeStamp">metricTimeStamp.</param>
        /// <param name="aiStartTime">aiStartTime.</param>
        /// <param name="aiVettedExpectedClassMetrics">aiVettedExpectedClassMetrics.</param>
        /// <param name="aiNonVettedExpectedClassMetrics">aiNonVettedExpectedClassMetrics.</param>
        public ClassifierMetricsOut(int? learnQueueSize = default(int?), int? bufferSize = default(int?), int? preClassifyQueueSize = default(int?), int? factKeysSize = default(int?), long? factsLearned = default(long?), double? classifyDurationsCurrent = default(double?), double? classifyDurationsSummary = default(double?), double? learnDurationsCurrent = default(double?), double? learnDurationsSummary = default(double?), string classifierName = default(string), long? featuresSize = default(long?), long? aiVettedEstimateTotal = default(long?), double? aiVettedEstimatePrecision = default(double?), double? aiVettedEstimateRecall = default(double?), long? aiVettedLearnTotal = default(long?), long? aiNonVettedEstimateTotal = default(long?), double? aiNonVettedEstimatePrecision = default(double?), double? aiNonVettedEstimateRecall = default(double?), long? aiNonVettedLearnTotal = default(long?), long? metricTimeStamp = default(long?), long? aiStartTime = default(long?), List<ExpectedClassMetricsOut> aiVettedExpectedClassMetrics = default(List<ExpectedClassMetricsOut>), List<ExpectedClassMetricsOut> aiNonVettedExpectedClassMetrics = default(List<ExpectedClassMetricsOut>))
        {
            this.LearnQueueSize = learnQueueSize;
            this.BufferSize = bufferSize;
            this.PreClassifyQueueSize = preClassifyQueueSize;
            this.FactKeysSize = factKeysSize;
            this.FactsLearned = factsLearned;
            this.ClassifyDurationsCurrent = classifyDurationsCurrent;
            this.ClassifyDurationsSummary = classifyDurationsSummary;
            this.LearnDurationsCurrent = learnDurationsCurrent;
            this.LearnDurationsSummary = learnDurationsSummary;
            this.ClassifierName = classifierName;
            this.FeaturesSize = featuresSize;
            this.AiVettedEstimateTotal = aiVettedEstimateTotal;
            this.AiVettedEstimatePrecision = aiVettedEstimatePrecision;
            this.AiVettedEstimateRecall = aiVettedEstimateRecall;
            this.AiVettedLearnTotal = aiVettedLearnTotal;
            this.AiNonVettedEstimateTotal = aiNonVettedEstimateTotal;
            this.AiNonVettedEstimatePrecision = aiNonVettedEstimatePrecision;
            this.AiNonVettedEstimateRecall = aiNonVettedEstimateRecall;
            this.AiNonVettedLearnTotal = aiNonVettedLearnTotal;
            this.MetricTimeStamp = metricTimeStamp;
            this.AiStartTime = aiStartTime;
            this.AiVettedExpectedClassMetrics = aiVettedExpectedClassMetrics;
            this.AiNonVettedExpectedClassMetrics = aiNonVettedExpectedClassMetrics;
        }
        
        /// <summary>
        /// Gets or Sets LearnQueueSize
        /// </summary>
        [DataMember(Name="learnQueueSize", EmitDefaultValue=false)]
        public int? LearnQueueSize { get; set; }

        /// <summary>
        /// Gets or Sets BufferSize
        /// </summary>
        [DataMember(Name="bufferSize", EmitDefaultValue=false)]
        public int? BufferSize { get; set; }

        /// <summary>
        /// Gets or Sets PreClassifyQueueSize
        /// </summary>
        [DataMember(Name="preClassifyQueueSize", EmitDefaultValue=false)]
        public int? PreClassifyQueueSize { get; set; }

        /// <summary>
        /// Gets or Sets FactKeysSize
        /// </summary>
        [DataMember(Name="factKeysSize", EmitDefaultValue=false)]
        public int? FactKeysSize { get; set; }

        /// <summary>
        /// Gets or Sets FactsLearned
        /// </summary>
        [DataMember(Name="factsLearned", EmitDefaultValue=false)]
        public long? FactsLearned { get; set; }

        /// <summary>
        /// Gets or Sets ClassifyDurationsCurrent
        /// </summary>
        [DataMember(Name="classifyDurationsCurrent", EmitDefaultValue=false)]
        public double? ClassifyDurationsCurrent { get; set; }

        /// <summary>
        /// Gets or Sets ClassifyDurationsSummary
        /// </summary>
        [DataMember(Name="classifyDurationsSummary", EmitDefaultValue=false)]
        public double? ClassifyDurationsSummary { get; set; }

        /// <summary>
        /// Gets or Sets LearnDurationsCurrent
        /// </summary>
        [DataMember(Name="learnDurationsCurrent", EmitDefaultValue=false)]
        public double? LearnDurationsCurrent { get; set; }

        /// <summary>
        /// Gets or Sets LearnDurationsSummary
        /// </summary>
        [DataMember(Name="learnDurationsSummary", EmitDefaultValue=false)]
        public double? LearnDurationsSummary { get; set; }

        /// <summary>
        /// Gets or Sets ClassifierName
        /// </summary>
        [DataMember(Name="classifierName", EmitDefaultValue=false)]
        public string ClassifierName { get; set; }

        /// <summary>
        /// Gets or Sets FeaturesSize
        /// </summary>
        [DataMember(Name="featuresSize", EmitDefaultValue=false)]
        public long? FeaturesSize { get; set; }

        /// <summary>
        /// Gets or Sets AiVettedEstimateTotal
        /// </summary>
        [DataMember(Name="aiVettedEstimateTotal", EmitDefaultValue=false)]
        public long? AiVettedEstimateTotal { get; set; }

        /// <summary>
        /// Gets or Sets AiVettedEstimatePrecision
        /// </summary>
        [DataMember(Name="aiVettedEstimatePrecision", EmitDefaultValue=false)]
        public double? AiVettedEstimatePrecision { get; set; }

        /// <summary>
        /// Gets or Sets AiVettedEstimateRecall
        /// </summary>
        [DataMember(Name="aiVettedEstimateRecall", EmitDefaultValue=false)]
        public double? AiVettedEstimateRecall { get; set; }

        /// <summary>
        /// Gets or Sets AiVettedLearnTotal
        /// </summary>
        [DataMember(Name="aiVettedLearnTotal", EmitDefaultValue=false)]
        public long? AiVettedLearnTotal { get; set; }

        /// <summary>
        /// Gets or Sets AiNonVettedEstimateTotal
        /// </summary>
        [DataMember(Name="aiNonVettedEstimateTotal", EmitDefaultValue=false)]
        public long? AiNonVettedEstimateTotal { get; set; }

        /// <summary>
        /// Gets or Sets AiNonVettedEstimatePrecision
        /// </summary>
        [DataMember(Name="aiNonVettedEstimatePrecision", EmitDefaultValue=false)]
        public double? AiNonVettedEstimatePrecision { get; set; }

        /// <summary>
        /// Gets or Sets AiNonVettedEstimateRecall
        /// </summary>
        [DataMember(Name="aiNonVettedEstimateRecall", EmitDefaultValue=false)]
        public double? AiNonVettedEstimateRecall { get; set; }

        /// <summary>
        /// Gets or Sets AiNonVettedLearnTotal
        /// </summary>
        [DataMember(Name="aiNonVettedLearnTotal", EmitDefaultValue=false)]
        public long? AiNonVettedLearnTotal { get; set; }

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
        /// Gets or Sets AiVettedExpectedClassMetrics
        /// </summary>
        [DataMember(Name="aiVettedExpectedClassMetrics", EmitDefaultValue=false)]
        public List<ExpectedClassMetricsOut> AiVettedExpectedClassMetrics { get; set; }

        /// <summary>
        /// Gets or Sets AiNonVettedExpectedClassMetrics
        /// </summary>
        [DataMember(Name="aiNonVettedExpectedClassMetrics", EmitDefaultValue=false)]
        public List<ExpectedClassMetricsOut> AiNonVettedExpectedClassMetrics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassifierMetricsOut {\n");
            sb.Append("  LearnQueueSize: ").Append(LearnQueueSize).Append("\n");
            sb.Append("  BufferSize: ").Append(BufferSize).Append("\n");
            sb.Append("  PreClassifyQueueSize: ").Append(PreClassifyQueueSize).Append("\n");
            sb.Append("  FactKeysSize: ").Append(FactKeysSize).Append("\n");
            sb.Append("  FactsLearned: ").Append(FactsLearned).Append("\n");
            sb.Append("  ClassifyDurationsCurrent: ").Append(ClassifyDurationsCurrent).Append("\n");
            sb.Append("  ClassifyDurationsSummary: ").Append(ClassifyDurationsSummary).Append("\n");
            sb.Append("  LearnDurationsCurrent: ").Append(LearnDurationsCurrent).Append("\n");
            sb.Append("  LearnDurationsSummary: ").Append(LearnDurationsSummary).Append("\n");
            sb.Append("  ClassifierName: ").Append(ClassifierName).Append("\n");
            sb.Append("  FeaturesSize: ").Append(FeaturesSize).Append("\n");
            sb.Append("  AiVettedEstimateTotal: ").Append(AiVettedEstimateTotal).Append("\n");
            sb.Append("  AiVettedEstimatePrecision: ").Append(AiVettedEstimatePrecision).Append("\n");
            sb.Append("  AiVettedEstimateRecall: ").Append(AiVettedEstimateRecall).Append("\n");
            sb.Append("  AiVettedLearnTotal: ").Append(AiVettedLearnTotal).Append("\n");
            sb.Append("  AiNonVettedEstimateTotal: ").Append(AiNonVettedEstimateTotal).Append("\n");
            sb.Append("  AiNonVettedEstimatePrecision: ").Append(AiNonVettedEstimatePrecision).Append("\n");
            sb.Append("  AiNonVettedEstimateRecall: ").Append(AiNonVettedEstimateRecall).Append("\n");
            sb.Append("  AiNonVettedLearnTotal: ").Append(AiNonVettedLearnTotal).Append("\n");
            sb.Append("  MetricTimeStamp: ").Append(MetricTimeStamp).Append("\n");
            sb.Append("  AiStartTime: ").Append(AiStartTime).Append("\n");
            sb.Append("  AiVettedExpectedClassMetrics: ").Append(AiVettedExpectedClassMetrics).Append("\n");
            sb.Append("  AiNonVettedExpectedClassMetrics: ").Append(AiNonVettedExpectedClassMetrics).Append("\n");
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
            return this.Equals(input as ClassifierMetricsOut);
        }

        /// <summary>
        /// Returns true if ClassifierMetricsOut instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassifierMetricsOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassifierMetricsOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LearnQueueSize == input.LearnQueueSize ||
                    (this.LearnQueueSize != null &&
                    this.LearnQueueSize.Equals(input.LearnQueueSize))
                ) && 
                (
                    this.BufferSize == input.BufferSize ||
                    (this.BufferSize != null &&
                    this.BufferSize.Equals(input.BufferSize))
                ) && 
                (
                    this.PreClassifyQueueSize == input.PreClassifyQueueSize ||
                    (this.PreClassifyQueueSize != null &&
                    this.PreClassifyQueueSize.Equals(input.PreClassifyQueueSize))
                ) && 
                (
                    this.FactKeysSize == input.FactKeysSize ||
                    (this.FactKeysSize != null &&
                    this.FactKeysSize.Equals(input.FactKeysSize))
                ) && 
                (
                    this.FactsLearned == input.FactsLearned ||
                    (this.FactsLearned != null &&
                    this.FactsLearned.Equals(input.FactsLearned))
                ) && 
                (
                    this.ClassifyDurationsCurrent == input.ClassifyDurationsCurrent ||
                    (this.ClassifyDurationsCurrent != null &&
                    this.ClassifyDurationsCurrent.Equals(input.ClassifyDurationsCurrent))
                ) && 
                (
                    this.ClassifyDurationsSummary == input.ClassifyDurationsSummary ||
                    (this.ClassifyDurationsSummary != null &&
                    this.ClassifyDurationsSummary.Equals(input.ClassifyDurationsSummary))
                ) && 
                (
                    this.LearnDurationsCurrent == input.LearnDurationsCurrent ||
                    (this.LearnDurationsCurrent != null &&
                    this.LearnDurationsCurrent.Equals(input.LearnDurationsCurrent))
                ) && 
                (
                    this.LearnDurationsSummary == input.LearnDurationsSummary ||
                    (this.LearnDurationsSummary != null &&
                    this.LearnDurationsSummary.Equals(input.LearnDurationsSummary))
                ) && 
                (
                    this.ClassifierName == input.ClassifierName ||
                    (this.ClassifierName != null &&
                    this.ClassifierName.Equals(input.ClassifierName))
                ) && 
                (
                    this.FeaturesSize == input.FeaturesSize ||
                    (this.FeaturesSize != null &&
                    this.FeaturesSize.Equals(input.FeaturesSize))
                ) && 
                (
                    this.AiVettedEstimateTotal == input.AiVettedEstimateTotal ||
                    (this.AiVettedEstimateTotal != null &&
                    this.AiVettedEstimateTotal.Equals(input.AiVettedEstimateTotal))
                ) && 
                (
                    this.AiVettedEstimatePrecision == input.AiVettedEstimatePrecision ||
                    (this.AiVettedEstimatePrecision != null &&
                    this.AiVettedEstimatePrecision.Equals(input.AiVettedEstimatePrecision))
                ) && 
                (
                    this.AiVettedEstimateRecall == input.AiVettedEstimateRecall ||
                    (this.AiVettedEstimateRecall != null &&
                    this.AiVettedEstimateRecall.Equals(input.AiVettedEstimateRecall))
                ) && 
                (
                    this.AiVettedLearnTotal == input.AiVettedLearnTotal ||
                    (this.AiVettedLearnTotal != null &&
                    this.AiVettedLearnTotal.Equals(input.AiVettedLearnTotal))
                ) && 
                (
                    this.AiNonVettedEstimateTotal == input.AiNonVettedEstimateTotal ||
                    (this.AiNonVettedEstimateTotal != null &&
                    this.AiNonVettedEstimateTotal.Equals(input.AiNonVettedEstimateTotal))
                ) && 
                (
                    this.AiNonVettedEstimatePrecision == input.AiNonVettedEstimatePrecision ||
                    (this.AiNonVettedEstimatePrecision != null &&
                    this.AiNonVettedEstimatePrecision.Equals(input.AiNonVettedEstimatePrecision))
                ) && 
                (
                    this.AiNonVettedEstimateRecall == input.AiNonVettedEstimateRecall ||
                    (this.AiNonVettedEstimateRecall != null &&
                    this.AiNonVettedEstimateRecall.Equals(input.AiNonVettedEstimateRecall))
                ) && 
                (
                    this.AiNonVettedLearnTotal == input.AiNonVettedLearnTotal ||
                    (this.AiNonVettedLearnTotal != null &&
                    this.AiNonVettedLearnTotal.Equals(input.AiNonVettedLearnTotal))
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
                    this.AiVettedExpectedClassMetrics == input.AiVettedExpectedClassMetrics ||
                    this.AiVettedExpectedClassMetrics != null &&
                    this.AiVettedExpectedClassMetrics.SequenceEqual(input.AiVettedExpectedClassMetrics)
                ) && 
                (
                    this.AiNonVettedExpectedClassMetrics == input.AiNonVettedExpectedClassMetrics ||
                    this.AiNonVettedExpectedClassMetrics != null &&
                    this.AiNonVettedExpectedClassMetrics.SequenceEqual(input.AiNonVettedExpectedClassMetrics)
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
                if (this.LearnQueueSize != null)
                    hashCode = hashCode * 59 + this.LearnQueueSize.GetHashCode();
                if (this.BufferSize != null)
                    hashCode = hashCode * 59 + this.BufferSize.GetHashCode();
                if (this.PreClassifyQueueSize != null)
                    hashCode = hashCode * 59 + this.PreClassifyQueueSize.GetHashCode();
                if (this.FactKeysSize != null)
                    hashCode = hashCode * 59 + this.FactKeysSize.GetHashCode();
                if (this.FactsLearned != null)
                    hashCode = hashCode * 59 + this.FactsLearned.GetHashCode();
                if (this.ClassifyDurationsCurrent != null)
                    hashCode = hashCode * 59 + this.ClassifyDurationsCurrent.GetHashCode();
                if (this.ClassifyDurationsSummary != null)
                    hashCode = hashCode * 59 + this.ClassifyDurationsSummary.GetHashCode();
                if (this.LearnDurationsCurrent != null)
                    hashCode = hashCode * 59 + this.LearnDurationsCurrent.GetHashCode();
                if (this.LearnDurationsSummary != null)
                    hashCode = hashCode * 59 + this.LearnDurationsSummary.GetHashCode();
                if (this.ClassifierName != null)
                    hashCode = hashCode * 59 + this.ClassifierName.GetHashCode();
                if (this.FeaturesSize != null)
                    hashCode = hashCode * 59 + this.FeaturesSize.GetHashCode();
                if (this.AiVettedEstimateTotal != null)
                    hashCode = hashCode * 59 + this.AiVettedEstimateTotal.GetHashCode();
                if (this.AiVettedEstimatePrecision != null)
                    hashCode = hashCode * 59 + this.AiVettedEstimatePrecision.GetHashCode();
                if (this.AiVettedEstimateRecall != null)
                    hashCode = hashCode * 59 + this.AiVettedEstimateRecall.GetHashCode();
                if (this.AiVettedLearnTotal != null)
                    hashCode = hashCode * 59 + this.AiVettedLearnTotal.GetHashCode();
                if (this.AiNonVettedEstimateTotal != null)
                    hashCode = hashCode * 59 + this.AiNonVettedEstimateTotal.GetHashCode();
                if (this.AiNonVettedEstimatePrecision != null)
                    hashCode = hashCode * 59 + this.AiNonVettedEstimatePrecision.GetHashCode();
                if (this.AiNonVettedEstimateRecall != null)
                    hashCode = hashCode * 59 + this.AiNonVettedEstimateRecall.GetHashCode();
                if (this.AiNonVettedLearnTotal != null)
                    hashCode = hashCode * 59 + this.AiNonVettedLearnTotal.GetHashCode();
                if (this.MetricTimeStamp != null)
                    hashCode = hashCode * 59 + this.MetricTimeStamp.GetHashCode();
                if (this.AiStartTime != null)
                    hashCode = hashCode * 59 + this.AiStartTime.GetHashCode();
                if (this.AiVettedExpectedClassMetrics != null)
                    hashCode = hashCode * 59 + this.AiVettedExpectedClassMetrics.GetHashCode();
                if (this.AiNonVettedExpectedClassMetrics != null)
                    hashCode = hashCode * 59 + this.AiNonVettedExpectedClassMetrics.GetHashCode();
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