# IO.Swagger.Api.ChatApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChatCompletion**](ChatApi.md#createchatcompletion) | **POST** /chat/completions | Creates a model response for the given chat conversation.

<a name="createchatcompletion"></a>
# **CreateChatCompletion**
> CreateChatCompletionResponse CreateChatCompletion (CreateChatCompletionRequest body)

Creates a model response for the given chat conversation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateChatCompletionExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var body = new CreateChatCompletionRequest(); // CreateChatCompletionRequest | 

            try
            {
                // Creates a model response for the given chat conversation.
                CreateChatCompletionResponse result = apiInstance.CreateChatCompletion(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.CreateChatCompletion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateChatCompletionRequest**](CreateChatCompletionRequest.md)|  | 

### Return type

[**CreateChatCompletionResponse**](CreateChatCompletionResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
