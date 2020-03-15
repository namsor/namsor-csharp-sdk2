/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.9
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
    ///  Class for testing RomanizedNameOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RomanizedNameOutTests
    {
        // TODO uncomment below to declare an instance variable for RomanizedNameOut
        //private RomanizedNameOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RomanizedNameOut
            //instance = new RomanizedNameOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RomanizedNameOut
        /// </summary>
        [Test]
        public void RomanizedNameOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RomanizedNameOut
            //Assert.IsInstanceOfType<RomanizedNameOut> (instance, "variable 'instance' is a RomanizedNameOut");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'LatinName'
        /// </summary>
        [Test]
        public void LatinNameTest()
        {
            // TODO unit test for the property 'LatinName'
        }
        /// <summary>
        /// Test the property 'OriginalName'
        /// </summary>
        [Test]
        public void OriginalNameTest()
        {
            // TODO unit test for the property 'OriginalName'
        }
        /// <summary>
        /// Test the property 'SourceLanguage'
        /// </summary>
        [Test]
        public void SourceLanguageTest()
        {
            // TODO unit test for the property 'SourceLanguage'
        }
        /// <summary>
        /// Test the property 'TargetLanguage'
        /// </summary>
        [Test]
        public void TargetLanguageTest()
        {
            // TODO unit test for the property 'TargetLanguage'
        }
        /// <summary>
        /// Test the property 'SourceScript'
        /// </summary>
        [Test]
        public void SourceScriptTest()
        {
            // TODO unit test for the property 'SourceScript'
        }
        /// <summary>
        /// Test the property 'TargetScript'
        /// </summary>
        [Test]
        public void TargetScriptTest()
        {
            // TODO unit test for the property 'TargetScript'
        }
        /// <summary>
        /// Test the property 'Score'
        /// </summary>
        [Test]
        public void ScoreTest()
        {
            // TODO unit test for the property 'Score'
        }

    }

}
