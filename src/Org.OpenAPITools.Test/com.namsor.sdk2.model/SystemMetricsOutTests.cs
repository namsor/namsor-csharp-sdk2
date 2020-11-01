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
    ///  Class for testing SystemMetricsOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SystemMetricsOutTests
    {
        // TODO uncomment below to declare an instance variable for SystemMetricsOut
        //private SystemMetricsOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SystemMetricsOut
            //instance = new SystemMetricsOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SystemMetricsOut
        /// </summary>
        [Test]
        public void SystemMetricsOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SystemMetricsOut
            //Assert.IsInstanceOfType<SystemMetricsOut> (instance, "variable 'instance' is a SystemMetricsOut");
        }


        /// <summary>
        /// Test the property 'CacheMetrics'
        /// </summary>
        [Test]
        public void CacheMetricsTest()
        {
            // TODO unit test for the property 'CacheMetrics'
        }
        /// <summary>
        /// Test the property 'ClassifierMetrics'
        /// </summary>
        [Test]
        public void ClassifierMetricsTest()
        {
            // TODO unit test for the property 'ClassifierMetrics'
        }
        /// <summary>
        /// Test the property 'SourceMetrics'
        /// </summary>
        [Test]
        public void SourceMetricsTest()
        {
            // TODO unit test for the property 'SourceMetrics'
        }
        /// <summary>
        /// Test the property 'TotalMem'
        /// </summary>
        [Test]
        public void TotalMemTest()
        {
            // TODO unit test for the property 'TotalMem'
        }
        /// <summary>
        /// Test the property 'FreeMem'
        /// </summary>
        [Test]
        public void FreeMemTest()
        {
            // TODO unit test for the property 'FreeMem'
        }
        /// <summary>
        /// Test the property 'MaxMem'
        /// </summary>
        [Test]
        public void MaxMemTest()
        {
            // TODO unit test for the property 'MaxMem'
        }

    }

}
