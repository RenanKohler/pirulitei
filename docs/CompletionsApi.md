# IO.Swagger.Api.CompletionsApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCompletion**](CompletionsApi.md#createcompletion) | **POST** /completions | Creates a completion for the provided prompt and parameters.

<a name="createcompletion"></a>
# **CreateCompletion**
> CreateCompletionResponse CreateCompletion (CreateCompletionRequest body)

Creates a completion for the provided prompt and parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCompletionExample
    {
        public void main()
        {

            var apiInstance = new CompletionsApi();
            var body = new CreateCompletionRequest(); // CreateCompletionRequest | 

            try
            {
                // Creates a completion for the provided prompt and parameters.
                CreateCompletionResponse result = apiInstance.CreateCompletion(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompletionsApi.CreateCompletion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCompletionRequest**](CreateCompletionRequest.md)|  | 

### Return type

[**CreateCompletionResponse**](CreateCompletionResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
