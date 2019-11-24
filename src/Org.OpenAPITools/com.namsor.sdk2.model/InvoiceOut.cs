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
    /// InvoiceOut
    /// </summary>
    [DataContract]
    public partial class InvoiceOut :  IEquatable<InvoiceOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceOut" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="userId">userId.</param>
        /// <param name="invoiceId">invoiceId.</param>
        /// <param name="isStriped">isStriped.</param>
        /// <param name="stripeCustomerId">stripeCustomerId.</param>
        /// <param name="amountDue">amountDue.</param>
        /// <param name="amountPaid">amountPaid.</param>
        /// <param name="amountRemaining">amountRemaining.</param>
        /// <param name="attempted">attempted.</param>
        /// <param name="currency">currency.</param>
        /// <param name="invoiceDate">invoiceDate.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="description">description.</param>
        /// <param name="invoicePdf">invoicePdf.</param>
        /// <param name="periodStart">periodStart.</param>
        /// <param name="periodEnd">periodEnd.</param>
        /// <param name="receiptNumber">receiptNumber.</param>
        /// <param name="invoiceStatus">invoiceStatus.</param>
        /// <param name="subTotal">subTotal.</param>
        /// <param name="tax">tax.</param>
        /// <param name="taxPercent">taxPercent.</param>
        /// <param name="total">total.</param>
        public InvoiceOut(List<InvoiceItemOut> items = default(List<InvoiceItemOut>), string userId = default(string), string invoiceId = default(string), bool? isStriped = default(bool?), string stripeCustomerId = default(string), long? amountDue = default(long?), long? amountPaid = default(long?), long? amountRemaining = default(long?), bool? attempted = default(bool?), string currency = default(string), DateTime? invoiceDate = default(DateTime?), DateTime? dueDate = default(DateTime?), string description = default(string), string invoicePdf = default(string), DateTime? periodStart = default(DateTime?), DateTime? periodEnd = default(DateTime?), string receiptNumber = default(string), string invoiceStatus = default(string), long? subTotal = default(long?), long? tax = default(long?), long? taxPercent = default(long?), long? total = default(long?))
        {
            this.Items = items;
            this.UserId = userId;
            this.InvoiceId = invoiceId;
            this.IsStriped = isStriped;
            this.StripeCustomerId = stripeCustomerId;
            this.AmountDue = amountDue;
            this.AmountPaid = amountPaid;
            this.AmountRemaining = amountRemaining;
            this.Attempted = attempted;
            this.Currency = currency;
            this.InvoiceDate = invoiceDate;
            this.DueDate = dueDate;
            this.Description = description;
            this.InvoicePdf = invoicePdf;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.ReceiptNumber = receiptNumber;
            this.InvoiceStatus = invoiceStatus;
            this.SubTotal = subTotal;
            this.Tax = tax;
            this.TaxPercent = taxPercent;
            this.Total = total;
        }
        
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<InvoiceItemOut> Items { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceId
        /// </summary>
        [DataMember(Name="invoiceId", EmitDefaultValue=false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets IsStriped
        /// </summary>
        [DataMember(Name="isStriped", EmitDefaultValue=false)]
        public bool? IsStriped { get; set; }

        /// <summary>
        /// Gets or Sets StripeCustomerId
        /// </summary>
        [DataMember(Name="stripeCustomerId", EmitDefaultValue=false)]
        public string StripeCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets AmountDue
        /// </summary>
        [DataMember(Name="amountDue", EmitDefaultValue=false)]
        public long? AmountDue { get; set; }

        /// <summary>
        /// Gets or Sets AmountPaid
        /// </summary>
        [DataMember(Name="amountPaid", EmitDefaultValue=false)]
        public long? AmountPaid { get; set; }

        /// <summary>
        /// Gets or Sets AmountRemaining
        /// </summary>
        [DataMember(Name="amountRemaining", EmitDefaultValue=false)]
        public long? AmountRemaining { get; set; }

        /// <summary>
        /// Gets or Sets Attempted
        /// </summary>
        [DataMember(Name="attempted", EmitDefaultValue=false)]
        public bool? Attempted { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDate
        /// </summary>
        [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets InvoicePdf
        /// </summary>
        [DataMember(Name="invoicePdf", EmitDefaultValue=false)]
        public string InvoicePdf { get; set; }

        /// <summary>
        /// Gets or Sets PeriodStart
        /// </summary>
        [DataMember(Name="periodStart", EmitDefaultValue=false)]
        public DateTime? PeriodStart { get; set; }

        /// <summary>
        /// Gets or Sets PeriodEnd
        /// </summary>
        [DataMember(Name="periodEnd", EmitDefaultValue=false)]
        public DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptNumber
        /// </summary>
        [DataMember(Name="receiptNumber", EmitDefaultValue=false)]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceStatus
        /// </summary>
        [DataMember(Name="invoiceStatus", EmitDefaultValue=false)]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// Gets or Sets SubTotal
        /// </summary>
        [DataMember(Name="subTotal", EmitDefaultValue=false)]
        public long? SubTotal { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public long? Tax { get; set; }

        /// <summary>
        /// Gets or Sets TaxPercent
        /// </summary>
        [DataMember(Name="taxPercent", EmitDefaultValue=false)]
        public long? TaxPercent { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceOut {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  IsStriped: ").Append(IsStriped).Append("\n");
            sb.Append("  StripeCustomerId: ").Append(StripeCustomerId).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  AmountRemaining: ").Append(AmountRemaining).Append("\n");
            sb.Append("  Attempted: ").Append(Attempted).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InvoicePdf: ").Append(InvoicePdf).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  ReceiptNumber: ").Append(ReceiptNumber).Append("\n");
            sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxPercent: ").Append(TaxPercent).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as InvoiceOut);
        }

        /// <summary>
        /// Returns true if InvoiceOut instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.IsStriped == input.IsStriped ||
                    (this.IsStriped != null &&
                    this.IsStriped.Equals(input.IsStriped))
                ) && 
                (
                    this.StripeCustomerId == input.StripeCustomerId ||
                    (this.StripeCustomerId != null &&
                    this.StripeCustomerId.Equals(input.StripeCustomerId))
                ) && 
                (
                    this.AmountDue == input.AmountDue ||
                    (this.AmountDue != null &&
                    this.AmountDue.Equals(input.AmountDue))
                ) && 
                (
                    this.AmountPaid == input.AmountPaid ||
                    (this.AmountPaid != null &&
                    this.AmountPaid.Equals(input.AmountPaid))
                ) && 
                (
                    this.AmountRemaining == input.AmountRemaining ||
                    (this.AmountRemaining != null &&
                    this.AmountRemaining.Equals(input.AmountRemaining))
                ) && 
                (
                    this.Attempted == input.Attempted ||
                    (this.Attempted != null &&
                    this.Attempted.Equals(input.Attempted))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InvoicePdf == input.InvoicePdf ||
                    (this.InvoicePdf != null &&
                    this.InvoicePdf.Equals(input.InvoicePdf))
                ) && 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && 
                (
                    this.PeriodEnd == input.PeriodEnd ||
                    (this.PeriodEnd != null &&
                    this.PeriodEnd.Equals(input.PeriodEnd))
                ) && 
                (
                    this.ReceiptNumber == input.ReceiptNumber ||
                    (this.ReceiptNumber != null &&
                    this.ReceiptNumber.Equals(input.ReceiptNumber))
                ) && 
                (
                    this.InvoiceStatus == input.InvoiceStatus ||
                    (this.InvoiceStatus != null &&
                    this.InvoiceStatus.Equals(input.InvoiceStatus))
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.TaxPercent == input.TaxPercent ||
                    (this.TaxPercent != null &&
                    this.TaxPercent.Equals(input.TaxPercent))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.IsStriped != null)
                    hashCode = hashCode * 59 + this.IsStriped.GetHashCode();
                if (this.StripeCustomerId != null)
                    hashCode = hashCode * 59 + this.StripeCustomerId.GetHashCode();
                if (this.AmountDue != null)
                    hashCode = hashCode * 59 + this.AmountDue.GetHashCode();
                if (this.AmountPaid != null)
                    hashCode = hashCode * 59 + this.AmountPaid.GetHashCode();
                if (this.AmountRemaining != null)
                    hashCode = hashCode * 59 + this.AmountRemaining.GetHashCode();
                if (this.Attempted != null)
                    hashCode = hashCode * 59 + this.Attempted.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.InvoiceDate != null)
                    hashCode = hashCode * 59 + this.InvoiceDate.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InvoicePdf != null)
                    hashCode = hashCode * 59 + this.InvoicePdf.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.PeriodEnd != null)
                    hashCode = hashCode * 59 + this.PeriodEnd.GetHashCode();
                if (this.ReceiptNumber != null)
                    hashCode = hashCode * 59 + this.ReceiptNumber.GetHashCode();
                if (this.InvoiceStatus != null)
                    hashCode = hashCode * 59 + this.InvoiceStatus.GetHashCode();
                if (this.SubTotal != null)
                    hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.TaxPercent != null)
                    hashCode = hashCode * 59 + this.TaxPercent.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
