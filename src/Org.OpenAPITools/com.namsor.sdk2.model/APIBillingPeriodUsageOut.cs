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
    /// APIBillingPeriodUsageOut
    /// </summary>
    [DataContract]
    public partial class APIBillingPeriodUsageOut :  IEquatable<APIBillingPeriodUsageOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIBillingPeriodUsageOut" /> class.
        /// </summary>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="subscriptionStarted">subscriptionStarted.</param>
        /// <param name="periodStarted">periodStarted.</param>
        /// <param name="periodEnded">periodEnded.</param>
        /// <param name="stripeCurrentPeriodEnd">stripeCurrentPeriodEnd.</param>
        /// <param name="stripeCurrentPeriodStart">stripeCurrentPeriodStart.</param>
        /// <param name="billingStatus">billingStatus.</param>
        /// <param name="usage">usage.</param>
        /// <param name="softLimit">softLimit.</param>
        /// <param name="hardLimit">hardLimit.</param>
        public APIBillingPeriodUsageOut(string apiKey = default(string), long? subscriptionStarted = default(long?), long? periodStarted = default(long?), long? periodEnded = default(long?), long? stripeCurrentPeriodEnd = default(long?), long? stripeCurrentPeriodStart = default(long?), string billingStatus = default(string), long? usage = default(long?), long? softLimit = default(long?), long? hardLimit = default(long?))
        {
            this.ApiKey = apiKey;
            this.SubscriptionStarted = subscriptionStarted;
            this.PeriodStarted = periodStarted;
            this.PeriodEnded = periodEnded;
            this.StripeCurrentPeriodEnd = stripeCurrentPeriodEnd;
            this.StripeCurrentPeriodStart = stripeCurrentPeriodStart;
            this.BillingStatus = billingStatus;
            this.Usage = usage;
            this.SoftLimit = softLimit;
            this.HardLimit = hardLimit;
        }
        
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionStarted
        /// </summary>
        [DataMember(Name="subscriptionStarted", EmitDefaultValue=false)]
        public long? SubscriptionStarted { get; set; }

        /// <summary>
        /// Gets or Sets PeriodStarted
        /// </summary>
        [DataMember(Name="periodStarted", EmitDefaultValue=false)]
        public long? PeriodStarted { get; set; }

        /// <summary>
        /// Gets or Sets PeriodEnded
        /// </summary>
        [DataMember(Name="periodEnded", EmitDefaultValue=false)]
        public long? PeriodEnded { get; set; }

        /// <summary>
        /// Gets or Sets StripeCurrentPeriodEnd
        /// </summary>
        [DataMember(Name="stripeCurrentPeriodEnd", EmitDefaultValue=false)]
        public long? StripeCurrentPeriodEnd { get; set; }

        /// <summary>
        /// Gets or Sets StripeCurrentPeriodStart
        /// </summary>
        [DataMember(Name="stripeCurrentPeriodStart", EmitDefaultValue=false)]
        public long? StripeCurrentPeriodStart { get; set; }

        /// <summary>
        /// Gets or Sets BillingStatus
        /// </summary>
        [DataMember(Name="billingStatus", EmitDefaultValue=false)]
        public string BillingStatus { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public long? Usage { get; set; }

        /// <summary>
        /// Gets or Sets SoftLimit
        /// </summary>
        [DataMember(Name="softLimit", EmitDefaultValue=false)]
        public long? SoftLimit { get; set; }

        /// <summary>
        /// Gets or Sets HardLimit
        /// </summary>
        [DataMember(Name="hardLimit", EmitDefaultValue=false)]
        public long? HardLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIBillingPeriodUsageOut {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  SubscriptionStarted: ").Append(SubscriptionStarted).Append("\n");
            sb.Append("  PeriodStarted: ").Append(PeriodStarted).Append("\n");
            sb.Append("  PeriodEnded: ").Append(PeriodEnded).Append("\n");
            sb.Append("  StripeCurrentPeriodEnd: ").Append(StripeCurrentPeriodEnd).Append("\n");
            sb.Append("  StripeCurrentPeriodStart: ").Append(StripeCurrentPeriodStart).Append("\n");
            sb.Append("  BillingStatus: ").Append(BillingStatus).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  SoftLimit: ").Append(SoftLimit).Append("\n");
            sb.Append("  HardLimit: ").Append(HardLimit).Append("\n");
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
            return this.Equals(input as APIBillingPeriodUsageOut);
        }

        /// <summary>
        /// Returns true if APIBillingPeriodUsageOut instances are equal
        /// </summary>
        /// <param name="input">Instance of APIBillingPeriodUsageOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIBillingPeriodUsageOut input)
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
                    this.SubscriptionStarted == input.SubscriptionStarted ||
                    (this.SubscriptionStarted != null &&
                    this.SubscriptionStarted.Equals(input.SubscriptionStarted))
                ) && 
                (
                    this.PeriodStarted == input.PeriodStarted ||
                    (this.PeriodStarted != null &&
                    this.PeriodStarted.Equals(input.PeriodStarted))
                ) && 
                (
                    this.PeriodEnded == input.PeriodEnded ||
                    (this.PeriodEnded != null &&
                    this.PeriodEnded.Equals(input.PeriodEnded))
                ) && 
                (
                    this.StripeCurrentPeriodEnd == input.StripeCurrentPeriodEnd ||
                    (this.StripeCurrentPeriodEnd != null &&
                    this.StripeCurrentPeriodEnd.Equals(input.StripeCurrentPeriodEnd))
                ) && 
                (
                    this.StripeCurrentPeriodStart == input.StripeCurrentPeriodStart ||
                    (this.StripeCurrentPeriodStart != null &&
                    this.StripeCurrentPeriodStart.Equals(input.StripeCurrentPeriodStart))
                ) && 
                (
                    this.BillingStatus == input.BillingStatus ||
                    (this.BillingStatus != null &&
                    this.BillingStatus.Equals(input.BillingStatus))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
                ) && 
                (
                    this.SoftLimit == input.SoftLimit ||
                    (this.SoftLimit != null &&
                    this.SoftLimit.Equals(input.SoftLimit))
                ) && 
                (
                    this.HardLimit == input.HardLimit ||
                    (this.HardLimit != null &&
                    this.HardLimit.Equals(input.HardLimit))
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
                if (this.SubscriptionStarted != null)
                    hashCode = hashCode * 59 + this.SubscriptionStarted.GetHashCode();
                if (this.PeriodStarted != null)
                    hashCode = hashCode * 59 + this.PeriodStarted.GetHashCode();
                if (this.PeriodEnded != null)
                    hashCode = hashCode * 59 + this.PeriodEnded.GetHashCode();
                if (this.StripeCurrentPeriodEnd != null)
                    hashCode = hashCode * 59 + this.StripeCurrentPeriodEnd.GetHashCode();
                if (this.StripeCurrentPeriodStart != null)
                    hashCode = hashCode * 59 + this.StripeCurrentPeriodStart.GetHashCode();
                if (this.BillingStatus != null)
                    hashCode = hashCode * 59 + this.BillingStatus.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.SoftLimit != null)
                    hashCode = hashCode * 59 + this.SoftLimit.GetHashCode();
                if (this.HardLimit != null)
                    hashCode = hashCode * 59 + this.HardLimit.GetHashCode();
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
