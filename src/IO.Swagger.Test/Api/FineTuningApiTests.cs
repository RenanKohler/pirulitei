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
    ///  Class for testing FineTuningApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FineTuningApiTests
    {
        private FineTuningApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FineTuningApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FineTuningApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FineTuningApi
            //Assert.IsInstanceOfType(typeof(FineTuningApi), instance, "instance is a FineTuningApi");
        }

        /// <summary>
        /// Test CancelFineTuningJob
        /// </summary>
        [Test]
        public void CancelFineTuningJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fineTuningJobId = null;
            //var response = instance.CancelFineTuningJob(fineTuningJobId);
            //Assert.IsInstanceOf<FineTuningJob> (response, "response is FineTuningJob");
        }
        /// <summary>
        /// Test CreateFineTuningJob
        /// </summary>
        [Test]
        public void CreateFineTuningJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFineTuningJobRequest body = null;
            //var response = instance.CreateFineTuningJob(body);
            //Assert.IsInstanceOf<FineTuningJob> (response, "response is FineTuningJob");
        }
        /// <summary>
        /// Test ListFineTuningEvents
        /// </summary>
        [Test]
        public void ListFineTuningEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fineTuningJobId = null;
            //string after = null;
            //int? limit = null;
            //var response = instance.ListFineTuningEvents(fineTuningJobId, after, limit);
            //Assert.IsInstanceOf<ListFineTuningJobEventsResponse> (response, "response is ListFineTuningJobEventsResponse");
        }
        /// <summary>
        /// Test ListPaginatedFineTuningJobs
        /// </summary>
        [Test]
        public void ListPaginatedFineTuningJobsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string after = null;
            //int? limit = null;
            //var response = instance.ListPaginatedFineTuningJobs(after, limit);
            //Assert.IsInstanceOf<ListPaginatedFineTuningJobsResponse> (response, "response is ListPaginatedFineTuningJobsResponse");
        }
        /// <summary>
        /// Test RetrieveFineTuningJob
        /// </summary>
        [Test]
        public void RetrieveFineTuningJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fineTuningJobId = null;
            //var response = instance.RetrieveFineTuningJob(fineTuningJobId);
            //Assert.IsInstanceOf<FineTuningJob> (response, "response is FineTuningJob");
        }
    }

}