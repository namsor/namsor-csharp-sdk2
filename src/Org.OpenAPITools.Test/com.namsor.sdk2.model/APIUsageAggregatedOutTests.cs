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
    ///  Class for testing APIUsageAggregatedOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class APIUsageAggregatedOutTests
    {
        // TODO uncomment below to declare an instance variable for APIUsageAggregatedOut
        //private APIUsageAggregatedOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of APIUsageAggregatedOut
            //instance = new APIUsageAggregatedOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APIUsageAggregatedOut
        /// </summary>
        [Test]
        public void APIUsageAggregatedOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" APIUsageAggregatedOut
            //Assert.IsInstanceOfType<APIUsageAggregatedOut> (instance, "variable 'instance' is a APIUsageAggregatedOut");
        }


        /// <summary>
        /// Test the property 'TimeUnit'
        /// </summary>
        [Test]
        public void TimeUnitTest()
        {
            // TODO unit test for the property 'TimeUnit'
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
        /// Test the property 'TotalUsage'
        /// </summary>
        [Test]
        public void TotalUsageTest()
        {
            // TODO unit test for the property 'TotalUsage'
        }
        /// <summary>
        /// Test the property 'HistoryTruncated'
        /// </summary>
        [Test]
        public void HistoryTruncatedTest()
        {
            // TODO unit test for the property 'HistoryTruncated'
        }
        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }
        /// <summary>
        /// Test the property 'ColHeaders'
        /// </summary>
        [Test]
        public void ColHeadersTest()
        {
            // TODO unit test for the property 'ColHeaders'
        }
        /// <summary>
        /// Test the property 'RowHeaders'
        /// </summary>
        [Test]
        public void RowHeadersTest()
        {
            // TODO unit test for the property 'RowHeaders'
        }

    }

}