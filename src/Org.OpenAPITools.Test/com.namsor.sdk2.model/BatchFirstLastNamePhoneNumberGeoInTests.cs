/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.10
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
    ///  Class for testing BatchFirstLastNamePhoneNumberGeoIn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BatchFirstLastNamePhoneNumberGeoInTests
    {
        // TODO uncomment below to declare an instance variable for BatchFirstLastNamePhoneNumberGeoIn
        //private BatchFirstLastNamePhoneNumberGeoIn instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BatchFirstLastNamePhoneNumberGeoIn
            //instance = new BatchFirstLastNamePhoneNumberGeoIn();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BatchFirstLastNamePhoneNumberGeoIn
        /// </summary>
        [Test]
        public void BatchFirstLastNamePhoneNumberGeoInInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BatchFirstLastNamePhoneNumberGeoIn
            //Assert.IsInstanceOfType<BatchFirstLastNamePhoneNumberGeoIn> (instance, "variable 'instance' is a BatchFirstLastNamePhoneNumberGeoIn");
        }


        /// <summary>
        /// Test the property 'PersonalNamesWithPhoneNumbers'
        /// </summary>
        [Test]
        public void PersonalNamesWithPhoneNumbersTest()
        {
            // TODO unit test for the property 'PersonalNamesWithPhoneNumbers'
        }

    }

}
