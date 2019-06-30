/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.4
 * Contact: contact@namsor.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.com.namsor.sdk2.model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing InvoiceOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InvoiceOutTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceOut
        //private InvoiceOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceOut
            //instance = new InvoiceOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceOut
        /// </summary>
        [Test]
        public void InvoiceOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceOut
            //Assert.IsInstanceOfType<InvoiceOut> (instance, "variable 'instance' is a InvoiceOut");
        }


        /// <summary>
        /// Test the property 'Items'
        /// </summary>
        [Test]
        public void ItemsTest()
        {
            // TODO unit test for the property 'Items'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'InvoiceId'
        /// </summary>
        [Test]
        public void InvoiceIdTest()
        {
            // TODO unit test for the property 'InvoiceId'
        }
        /// <summary>
        /// Test the property 'IsStriped'
        /// </summary>
        [Test]
        public void IsStripedTest()
        {
            // TODO unit test for the property 'IsStriped'
        }
        /// <summary>
        /// Test the property 'StripeCustomerId'
        /// </summary>
        [Test]
        public void StripeCustomerIdTest()
        {
            // TODO unit test for the property 'StripeCustomerId'
        }
        /// <summary>
        /// Test the property 'AmountDue'
        /// </summary>
        [Test]
        public void AmountDueTest()
        {
            // TODO unit test for the property 'AmountDue'
        }
        /// <summary>
        /// Test the property 'AmountPaid'
        /// </summary>
        [Test]
        public void AmountPaidTest()
        {
            // TODO unit test for the property 'AmountPaid'
        }
        /// <summary>
        /// Test the property 'AmountRemaining'
        /// </summary>
        [Test]
        public void AmountRemainingTest()
        {
            // TODO unit test for the property 'AmountRemaining'
        }
        /// <summary>
        /// Test the property 'Attempted'
        /// </summary>
        [Test]
        public void AttemptedTest()
        {
            // TODO unit test for the property 'Attempted'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'InvoiceDate'
        /// </summary>
        [Test]
        public void InvoiceDateTest()
        {
            // TODO unit test for the property 'InvoiceDate'
        }
        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Test]
        public void DueDateTest()
        {
            // TODO unit test for the property 'DueDate'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'InvoicePdf'
        /// </summary>
        [Test]
        public void InvoicePdfTest()
        {
            // TODO unit test for the property 'InvoicePdf'
        }
        /// <summary>
        /// Test the property 'PeriodStart'
        /// </summary>
        [Test]
        public void PeriodStartTest()
        {
            // TODO unit test for the property 'PeriodStart'
        }
        /// <summary>
        /// Test the property 'PeriodEnd'
        /// </summary>
        [Test]
        public void PeriodEndTest()
        {
            // TODO unit test for the property 'PeriodEnd'
        }
        /// <summary>
        /// Test the property 'ReceiptNumber'
        /// </summary>
        [Test]
        public void ReceiptNumberTest()
        {
            // TODO unit test for the property 'ReceiptNumber'
        }
        /// <summary>
        /// Test the property 'InvoiceStatus'
        /// </summary>
        [Test]
        public void InvoiceStatusTest()
        {
            // TODO unit test for the property 'InvoiceStatus'
        }
        /// <summary>
        /// Test the property 'SubTotal'
        /// </summary>
        [Test]
        public void SubTotalTest()
        {
            // TODO unit test for the property 'SubTotal'
        }
        /// <summary>
        /// Test the property 'Tax'
        /// </summary>
        [Test]
        public void TaxTest()
        {
            // TODO unit test for the property 'Tax'
        }
        /// <summary>
        /// Test the property 'TaxPercent'
        /// </summary>
        [Test]
        public void TaxPercentTest()
        {
            // TODO unit test for the property 'TaxPercent'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }

    }

}
