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
    ///  Class for testing BatchPersonalNameGenderedOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BatchPersonalNameGenderedOutTests
    {
        // TODO uncomment below to declare an instance variable for BatchPersonalNameGenderedOut
        //private BatchPersonalNameGenderedOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BatchPersonalNameGenderedOut
            //instance = new BatchPersonalNameGenderedOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BatchPersonalNameGenderedOut
        /// </summary>
        [Test]
        public void BatchPersonalNameGenderedOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BatchPersonalNameGenderedOut
            //Assert.IsInstanceOfType<BatchPersonalNameGenderedOut> (instance, "variable 'instance' is a BatchPersonalNameGenderedOut");
        }


        /// <summary>
        /// Test the property 'PersonalNames'
        /// </summary>
        [Test]
        public void PersonalNamesTest()
        {
            // TODO unit test for the property 'PersonalNames'
        }

    }

}
