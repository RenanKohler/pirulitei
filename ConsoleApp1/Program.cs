using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Diagnostics;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apiInstance = new AssistantApi();
            var body = new ModifyAssistantRequest(); // ModifyAssistantRequest | 
            var assistantId = "asst_yMIlk3nq2bQ3Q2uO6Fe8XlnI";  // string | The ID of the assistant to modify.

            //apiInstance.Configuration.AddApiKey("default", "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");
            apiInstance.Configuration.AccessToken = "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";
            //apiInstance.AddDefaultHeader("Bearer", apiInstance.Configuration.ApiKey["default"]); ;
            try
            {                // Modifies an assistant.
                apiInstance.Configuration.AddDefaultHeader("Content-Type", "application/json");
                //Please try again by setting the header 'OpenAI-Beta: assistants=v1'
                apiInstance.Configuration.AddDefaultHeader("OpenAI-Beta", "assistants=v1");

                AssistantObject result = apiInstance.ModifyAssistant(body, assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.ModifyAssistant: " + e.Message);
            }
        }
    }
}
