/* 
 * OpenAI API
 *
 * The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CreateFineTuningJobRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateFineTuningJobRequestTests
    {
        // TODO uncomment below to declare an instance variable for CreateFineTuningJobRequest
        //private CreateFineTuningJobRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreateFineTuningJobRequest
            //instance = new CreateFineTuningJobRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateFineTuningJobRequest
        /// </summary>
        [Test]
        public void CreateFineTuningJobRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateFineTuningJobRequest
            //Assert.IsInstanceOfType<CreateFineTuningJobRequest> (instance, "variable 'instance' is a CreateFineTuningJobRequest");
        }


        /// <summary>
        /// Test the property 'Model'
        /// </summary>
        [Test]
        public void ModelTest()
        {
            // TODO unit test for the property 'Model'
        }
        /// <summary>
        /// Test the property 'TrainingFile'
        /// </summary>
        [Test]
        public void TrainingFileTest()
        {
            // TODO unit test for the property 'TrainingFile'
        }
        /// <summary>
        /// Test the property 'Hyperparameters'
        /// </summary>
        [Test]
        public void HyperparametersTest()
        {
            // TODO unit test for the property 'Hyperparameters'
        }
        /// <summary>
        /// Test the property 'Suffix'
        /// </summary>
        [Test]
        public void SuffixTest()
        {
            // TODO unit test for the property 'Suffix'
        }
        /// <summary>
        /// Test the property 'ValidationFile'
        /// </summary>
        [Test]
        public void ValidationFileTest()
        {
            // TODO unit test for the property 'ValidationFile'
        }

    }

}