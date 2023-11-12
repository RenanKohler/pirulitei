# IO.Swagger.Api.ModerationsApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateModeration**](ModerationsApi.md#createmoderation) | **POST** /moderations | Classifies if text violates OpenAI&#x27;s Content Policy

<a name="createmoderation"></a>
# **CreateModeration**
> CreateModerationResponse CreateModeration (CreateModerationRequest body)

Classifies if text violates OpenAI's Content Policy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateModerationExample
    {
        public void main()
        {

            var apiInstance = new ModerationsApi();
            var body = new CreateModerationRequest(); // CreateModerationRequest | 

            try
            {
                // Classifies if text violates OpenAI's Content Policy
                CreateModerationResponse result = apiInstance.CreateModeration(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModerationsApi.CreateModeration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateModerationRequest**](CreateModerationRequest.md)|  | 

### Return type

[**CreateModerationResponse**](CreateModerationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
