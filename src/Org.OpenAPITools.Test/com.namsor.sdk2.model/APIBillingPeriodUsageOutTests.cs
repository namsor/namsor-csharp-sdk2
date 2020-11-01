/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.11
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
    ///  Class for testing APIBillingPeriodUsageOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class APIBillingPeriodUsageOutTests
    {
        // TODO uncomment below to declare an instance variable for APIBillingPeriodUsageOut
        //private APIBillingPeriodUsageOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of APIBillingPeriodUsageOut
            //instance = new APIBillingPeriodUsageOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APIBillingPeriodUsageOut
        /// </summary>
        [Test]
        public void APIBillingPeriodUsageOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" APIBillingPeriodUsageOut
            //Assert.IsInstanceOfType<APIBillingPeriodUsageOut> (instance, "variable 'instance' is a APIBillingPeriodUsageOut");
        }


        /// <summary>
        /// Test the property 'ApiKey'
        /// </summary>
        [Test]
        public void ApiKeyTest()
        {
            // TODO unit test for the property 'ApiKey'
        }
        /// <summary>
        /// Test the property 'SubscriptionStarted'
        /// </summary>
        [Test]
        public void SubscriptionStartedTest()
        {
            // TODO unit test for the property 'SubscriptionStarted'
        }
        /// <summary>
        /// Test the property 'PeriodStarted'
        /// </summary>
        [Test]
        public void PeriodStartedTest()
        {
            // TODO unit test for the property 'PeriodStarted'
        }
        /// <summary>
        /// Test the property 'PeriodEnded'
        /// </summary>
        [Test]
        public void PeriodEndedTest()
        {
            // TODO unit test for the property 'PeriodEnded'
        }
        /// <summary>
        /// Test the property 'StripeCurrentPeriodEnd'
        /// </summary>
        [Test]
        public void StripeCurrentPeriodEndTest()
        {
            // TODO unit test for the property 'StripeCurrentPeriodEnd'
        }
        /// <summary>
        /// Test the property 'StripeCurrentPeriodStart'
        /// </summary>
        [Test]
        public void StripeCurrentPeriodStartTest()
        {
            // TODO unit test for the property 'StripeCurrentPeriodStart'
        }
        /// <summary>
        /// Test the property 'BillingStatus'
        /// </summary>
        [Test]
        public void BillingStatusTest()
        {
            // TODO unit test for the property 'BillingStatus'
        }
        /// <summary>
        /// Test the property 'Usage'
        /// </summary>
        [Test]
        public void UsageTest()
        {
            // TODO unit test for the property 'Usage'
        }
        /// <summary>
        /// Test the property 'SoftLimit'
        /// </summary>
        [Test]
        public void SoftLimitTest()
        {
            // TODO unit test for the property 'SoftLimit'
        }
        /// <summary>
        /// Test the property 'HardLimit'
        /// </summary>
        [Test]
        public void HardLimitTest()
        {
            // TODO unit test for the property 'HardLimit'
        }

    }

}
