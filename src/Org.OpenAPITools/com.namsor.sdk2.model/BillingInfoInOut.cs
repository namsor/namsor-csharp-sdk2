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
    /// BillingInfoInOut
    /// </summary>
    [DataContract]
    public partial class BillingInfoInOut :  IEquatable<BillingInfoInOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInfoInOut" /> class.
        /// </summary>
        /// <param name="billingEmail">billingEmail.</param>
        /// <param name="preferredCurrency">preferredCurrency.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="customerPhone">customerPhone.</param>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="addressCity">addressCity.</param>
        /// <param name="addressPostalCode">addressPostalCode.</param>
        /// <param name="addressState">addressState.</param>
        /// <param name="addressCountry">addressCountry.</param>
        /// <param name="vatID">vatID.</param>
        public BillingInfoInOut(string billingEmail = default(string), string preferredCurrency = default(string), string customerName = default(string), string customerPhone = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressCity = default(string), string addressPostalCode = default(string), string addressState = default(string), string addressCountry = default(string), string vatID = default(string))
        {
            this.BillingEmail = billingEmail;
            this.PreferredCurrency = preferredCurrency;
            this.CustomerName = customerName;
            this.CustomerPhone = customerPhone;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressCity = addressCity;
            this.AddressPostalCode = addressPostalCode;
            this.AddressState = addressState;
            this.AddressCountry = addressCountry;
            this.VatID = vatID;
        }
        
        /// <summary>
        /// Gets or Sets BillingEmail
        /// </summary>
        [DataMember(Name="billingEmail", EmitDefaultValue=false)]
        public string BillingEmail { get; set; }

        /// <summary>
        /// Gets or Sets PreferredCurrency
        /// </summary>
        [DataMember(Name="preferredCurrency", EmitDefaultValue=false)]
        public string PreferredCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets CustomerPhone
        /// </summary>
        [DataMember(Name="customerPhone", EmitDefaultValue=false)]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressCity
        /// </summary>
        [DataMember(Name="addressCity", EmitDefaultValue=false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Gets or Sets AddressPostalCode
        /// </summary>
        [DataMember(Name="addressPostalCode", EmitDefaultValue=false)]
        public string AddressPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets AddressState
        /// </summary>
        [DataMember(Name="addressState", EmitDefaultValue=false)]
        public string AddressState { get; set; }

        /// <summary>
        /// Gets or Sets AddressCountry
        /// </summary>
        [DataMember(Name="addressCountry", EmitDefaultValue=false)]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Gets or Sets VatID
        /// </summary>
        [DataMember(Name="vatID", EmitDefaultValue=false)]
        public string VatID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingInfoInOut {\n");
            sb.Append("  BillingEmail: ").Append(BillingEmail).Append("\n");
            sb.Append("  PreferredCurrency: ").Append(PreferredCurrency).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  CustomerPhone: ").Append(CustomerPhone).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressPostalCode: ").Append(AddressPostalCode).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
            sb.Append("  VatID: ").Append(VatID).Append("\n");
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
            return this.Equals(input as BillingInfoInOut);
        }

        /// <summary>
        /// Returns true if BillingInfoInOut instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingInfoInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingInfoInOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingEmail == input.BillingEmail ||
                    (this.BillingEmail != null &&
                    this.BillingEmail.Equals(input.BillingEmail))
                ) && 
                (
                    this.PreferredCurrency == input.PreferredCurrency ||
                    (this.PreferredCurrency != null &&
                    this.PreferredCurrency.Equals(input.PreferredCurrency))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.CustomerPhone == input.CustomerPhone ||
                    (this.CustomerPhone != null &&
                    this.CustomerPhone.Equals(input.CustomerPhone))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressCity == input.AddressCity ||
                    (this.AddressCity != null &&
                    this.AddressCity.Equals(input.AddressCity))
                ) && 
                (
                    this.AddressPostalCode == input.AddressPostalCode ||
                    (this.AddressPostalCode != null &&
                    this.AddressPostalCode.Equals(input.AddressPostalCode))
                ) && 
                (
                    this.AddressState == input.AddressState ||
                    (this.AddressState != null &&
                    this.AddressState.Equals(input.AddressState))
                ) && 
                (
                    this.AddressCountry == input.AddressCountry ||
                    (this.AddressCountry != null &&
                    this.AddressCountry.Equals(input.AddressCountry))
                ) && 
                (
                    this.VatID == input.VatID ||
                    (this.VatID != null &&
                    this.VatID.Equals(input.VatID))
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
                if (this.BillingEmail != null)
                    hashCode = hashCode * 59 + this.BillingEmail.GetHashCode();
                if (this.PreferredCurrency != null)
                    hashCode = hashCode * 59 + this.PreferredCurrency.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.CustomerPhone != null)
                    hashCode = hashCode * 59 + this.CustomerPhone.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressCity != null)
                    hashCode = hashCode * 59 + this.AddressCity.GetHashCode();
                if (this.AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.AddressPostalCode.GetHashCode();
                if (this.AddressState != null)
                    hashCode = hashCode * 59 + this.AddressState.GetHashCode();
                if (this.AddressCountry != null)
                    hashCode = hashCode * 59 + this.AddressCountry.GetHashCode();
                if (this.VatID != null)
                    hashCode = hashCode * 59 + this.VatID.GetHashCode();
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
