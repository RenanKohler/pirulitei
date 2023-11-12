/* 
 * OpenAI API
 *
 * The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ChatApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ChatApiTests
    {
        private ChatApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChatApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChatApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChatApi
            //Assert.IsInstanceOfType(typeof(ChatApi), instance, "instance is a ChatApi");
        }

        /// <summary>
        /// Test CreateChatCompletion
        /// </summary>
        [Test]
        public void CreateChatCompletionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateChatCompletionRequest body = null;
            //var response = instance.CreateChatCompletion(body);
            //Assert.IsInstanceOf<CreateChatCompletionResponse> (response, "response is CreateChatCompletionResponse");
        }
    }

}
