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
    ///  Class for testing PersonalNameGenderedOut
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PersonalNameGenderedOutTests
    {
        // TODO uncomment below to declare an instance variable for PersonalNameGenderedOut
        //private PersonalNameGenderedOut instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PersonalNameGenderedOut
            //instance = new PersonalNameGenderedOut();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PersonalNameGenderedOut
        /// </summary>
        [Test]
        public void PersonalNameGenderedOutInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PersonalNameGenderedOut
            //Assert.IsInstanceOfType<PersonalNameGenderedOut> (instance, "variable 'instance' is a PersonalNameGenderedOut");
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
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'LikelyGender'
        /// </summary>
        [Test]
        public void LikelyGenderTest()
        {
            // TODO unit test for the property 'LikelyGender'
        }
        /// <summary>
        /// Test the property 'GenderScale'
        /// </summary>
        [Test]
        public void GenderScaleTest()
        {
            // TODO unit test for the property 'GenderScale'
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