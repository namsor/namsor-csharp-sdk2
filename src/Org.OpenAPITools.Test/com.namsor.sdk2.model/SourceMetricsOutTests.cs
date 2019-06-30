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
    ///  Class for testing SourceMetricsOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SourceMetricsOutTests
    {
        // TODO uncomment below to declare an instance variable for SourceMetricsOut
        //private SourceMetricsOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SourceMetricsOut
            //instance = new SourceMetricsOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SourceMetricsOut
        /// </summary>
        [Test]
        public void SourceMetricsOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SourceMetricsOut
            //Assert.IsInstanceOfType<SourceMetricsOut> (instance, "variable 'instance' is a SourceMetricsOut");
        }


        /// <summary>
        /// Test the property 'ClassifierName'
        /// </summary>
        [Test]
        public void ClassifierNameTest()
        {
            // TODO unit test for the property 'ClassifierName'
        }
        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Test]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }
        /// <summary>
        /// Test the property 'AiEstimateTotal'
        /// </summary>
        [Test]
        public void AiEstimateTotalTest()
        {
            // TODO unit test for the property 'AiEstimateTotal'
        }
        /// <summary>
        /// Test the property 'AiEstimatePrecision'
        /// </summary>
        [Test]
        public void AiEstimatePrecisionTest()
        {
            // TODO unit test for the property 'AiEstimatePrecision'
        }
        /// <summary>
        /// Test the property 'AiEstimateRecall'
        /// </summary>
        [Test]
        public void AiEstimateRecallTest()
        {
            // TODO unit test for the property 'AiEstimateRecall'
        }
        /// <summary>
        /// Test the property 'MetricTimeStamp'
        /// </summary>
        [Test]
        public void MetricTimeStampTest()
        {
            // TODO unit test for the property 'MetricTimeStamp'
        }
        /// <summary>
        /// Test the property 'AiStartTime'
        /// </summary>
        [Test]
        public void AiStartTimeTest()
        {
            // TODO unit test for the property 'AiStartTime'
        }
        /// <summary>
        /// Test the property 'AiLearnTotal'
        /// </summary>
        [Test]
        public void AiLearnTotalTest()
        {
            // TODO unit test for the property 'AiLearnTotal'
        }
        /// <summary>
        /// Test the property 'SnapshotDate'
        /// </summary>
        [Test]
        public void SnapshotDateTest()
        {
            // TODO unit test for the property 'SnapshotDate'
        }

    }

}
