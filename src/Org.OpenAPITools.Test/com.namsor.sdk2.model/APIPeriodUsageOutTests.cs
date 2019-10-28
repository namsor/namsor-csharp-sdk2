/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.6
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
    ///  Class for testing APIPeriodUsageOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class APIPeriodUsageOutTests
    {
        // TODO uncomment below to declare an instance variable for APIPeriodUsageOut
        //private APIPeriodUsageOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of APIPeriodUsageOut
            //instance = new APIPeriodUsageOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APIPeriodUsageOut
        /// </summary>
        [Test]
        public void APIPeriodUsageOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" APIPeriodUsageOut
            //Assert.IsInstanceOfType<APIPeriodUsageOut> (instance, "variable 'instance' is a APIPeriodUsageOut");
        }


        /// <summary>
        /// Test the property 'Subscription'
        /// </summary>
        [Test]
        public void SubscriptionTest()
        {
            // TODO unit test for the property 'Subscription'
        }
        /// <summary>
        /// Test the property 'BillingPeriod'
        /// </summary>
        [Test]
        public void BillingPeriodTest()
        {
            // TODO unit test for the property 'BillingPeriod'
        }
        /// <summary>
        /// Test the property 'OverageExclTax'
        /// </summary>
        [Test]
        public void OverageExclTaxTest()
        {
            // TODO unit test for the property 'OverageExclTax'
        }
        /// <summary>
        /// Test the property 'OverageInclTax'
        /// </summary>
        [Test]
        public void OverageInclTaxTest()
        {
            // TODO unit test for the property 'OverageInclTax'
        }
        /// <summary>
        /// Test the property 'OverageCurrency'
        /// </summary>
        [Test]
        public void OverageCurrencyTest()
        {
            // TODO unit test for the property 'OverageCurrency'
        }
        /// <summary>
        /// Test the property 'OverageQuantity'
        /// </summary>
        [Test]
        public void OverageQuantityTest()
        {
            // TODO unit test for the property 'OverageQuantity'
        }

    }

}
