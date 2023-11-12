# IO.Swagger.Api.AssistantApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ModifyAssistant**](AssistantApi.md#modifyassistant) | **POST** /assistants/{assistant_id} | Modifies an assistant.

<a name="modifyassistant"></a>
# **ModifyAssistant**
> AssistantObject ModifyAssistant (ModifyAssistantRequest body, string assistantId)

Modifies an assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModifyAssistantExample
    {
        public void main()
        {

            var apiInstance = new AssistantApi();
            var body = new ModifyAssistantRequest(); // ModifyAssistantRequest | 
            var assistantId = assistantId_example;  // string | The ID of the assistant to modify.

            try
            {
                // Modifies an assistant.
                AssistantObject result = apiInstance.ModifyAssistant(body, assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.ModifyAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifyAssistantRequest**](ModifyAssistantRequest.md)|  | 
 **assistantId** | **string**| The ID of the assistant to modify. | 

### Return type

[**AssistantObject**](AssistantObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
