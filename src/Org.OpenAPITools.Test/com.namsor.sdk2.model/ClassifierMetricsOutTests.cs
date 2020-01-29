/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.8
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
    ///  Class for testing ClassifierMetricsOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ClassifierMetricsOutTests
    {
        // TODO uncomment below to declare an instance variable for ClassifierMetricsOut
        //private ClassifierMetricsOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ClassifierMetricsOut
            //instance = new ClassifierMetricsOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ClassifierMetricsOut
        /// </summary>
        [Test]
        public void ClassifierMetricsOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ClassifierMetricsOut
            //Assert.IsInstanceOfType<ClassifierMetricsOut> (instance, "variable 'instance' is a ClassifierMetricsOut");
        }


        /// <summary>
        /// Test the property 'SoftwareVersion'
        /// </summary>
        [Test]
        public void SoftwareVersionTest()
        {
            // TODO unit test for the property 'SoftwareVersion'
        }
        /// <summary>
        /// Test the property 'HostAddress'
        /// </summary>
        [Test]
        public void HostAddressTest()
        {
            // TODO unit test for the property 'HostAddress'
        }
        /// <summary>
        /// Test the property 'LearnQueueSize'
        /// </summary>
        [Test]
        public void LearnQueueSizeTest()
        {
            // TODO unit test for the property 'LearnQueueSize'
        }
        /// <summary>
        /// Test the property 'BufferSize'
        /// </summary>
        [Test]
        public void BufferSizeTest()
        {
            // TODO unit test for the property 'BufferSize'
        }
        /// <summary>
        /// Test the property 'PreClassifyQueueSize'
        /// </summary>
        [Test]
        public void PreClassifyQueueSizeTest()
        {
            // TODO unit test for the property 'PreClassifyQueueSize'
        }
        /// <summary>
        /// Test the property 'FactKeysSize'
        /// </summary>
        [Test]
        public void FactKeysSizeTest()
        {
            // TODO unit test for the property 'FactKeysSize'
        }
        /// <summary>
        /// Test the property 'FactsLearned'
        /// </summary>
        [Test]
        public void FactsLearnedTest()
        {
            // TODO unit test for the property 'FactsLearned'
        }
        /// <summary>
        /// Test the property 'ClassifyDurationsCurrent'
        /// </summary>
        [Test]
        public void ClassifyDurationsCurrentTest()
        {
            // TODO unit test for the property 'ClassifyDurationsCurrent'
        }
        /// <summary>
        /// Test the property 'ClassifyDurationsSummary'
        /// </summary>
        [Test]
        public void ClassifyDurationsSummaryTest()
        {
            // TODO unit test for the property 'ClassifyDurationsSummary'
        }
        /// <summary>
        /// Test the property 'LearnDurationsCurrent'
        /// </summary>
        [Test]
        public void LearnDurationsCurrentTest()
        {
            // TODO unit test for the property 'LearnDurationsCurrent'
        }
        /// <summary>
        /// Test the property 'LearnDurationsSummary'
        /// </summary>
        [Test]
        public void LearnDurationsSummaryTest()
        {
            // TODO unit test for the property 'LearnDurationsSummary'
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
        /// Test the property 'FeaturesSize'
        /// </summary>
        [Test]
        public void FeaturesSizeTest()
        {
            // TODO unit test for the property 'FeaturesSize'
        }
        /// <summary>
        /// Test the property 'AiVettedEstimateTotal'
        /// </summary>
        [Test]
        public void AiVettedEstimateTotalTest()
        {
            // TODO unit test for the property 'AiVettedEstimateTotal'
        }
        /// <summary>
        /// Test the property 'AiVettedEstimatePrecision'
        /// </summary>
        [Test]
        public void AiVettedEstimatePrecisionTest()
        {
            // TODO unit test for the property 'AiVettedEstimatePrecision'
        }
        /// <summary>
        /// Test the property 'AiVettedEstimateRecall'
        /// </summary>
        [Test]
        public void AiVettedEstimateRecallTest()
        {
            // TODO unit test for the property 'AiVettedEstimateRecall'
        }
        /// <summary>
        /// Test the property 'AiVettedLearnTotal'
        /// </summary>
        [Test]
        public void AiVettedLearnTotalTest()
        {
            // TODO unit test for the property 'AiVettedLearnTotal'
        }
        /// <summary>
        /// Test the property 'AiNonVettedEstimateTotal'
        /// </summary>
        [Test]
        public void AiNonVettedEstimateTotalTest()
        {
            // TODO unit test for the property 'AiNonVettedEstimateTotal'
        }
        /// <summary>
        /// Test the property 'AiNonVettedEstimatePrecision'
        /// </summary>
        [Test]
        public void AiNonVettedEstimatePrecisionTest()
        {
            // TODO unit test for the property 'AiNonVettedEstimatePrecision'
        }
        /// <summary>
        /// Test the property 'AiNonVettedEstimateRecall'
        /// </summary>
        [Test]
        public void AiNonVettedEstimateRecallTest()
        {
            // TODO unit test for the property 'AiNonVettedEstimateRecall'
        }
        /// <summary>
        /// Test the property 'AiNonVettedLearnTotal'
        /// </summary>
        [Test]
        public void AiNonVettedLearnTotalTest()
        {
            // TODO unit test for the property 'AiNonVettedLearnTotal'
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
        /// Test the property 'AiVettedExpectedClassMetrics'
        /// </summary>
        [Test]
        public void AiVettedExpectedClassMetricsTest()
        {
            // TODO unit test for the property 'AiVettedExpectedClassMetrics'
        }
        /// <summary>
        /// Test the property 'AiNonVettedExpectedClassMetrics'
        /// </summary>
        [Test]
        public void AiNonVettedExpectedClassMetricsTest()
        {
            // TODO unit test for the property 'AiNonVettedExpectedClassMetrics'
        }

    }

}
