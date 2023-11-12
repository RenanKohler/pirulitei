# IO.Swagger.Api.EditsApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEdit**](EditsApi.md#createedit) | **POST** /edits | Creates a new edit for the provided input, instruction, and parameters.

<a name="createedit"></a>
# **CreateEdit**
> CreateEditResponse CreateEdit (CreateEditRequest body)

Creates a new edit for the provided input, instruction, and parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateEditExample
    {
        public void main()
        {

            var apiInstance = new EditsApi();
            var body = new CreateEditRequest(); // CreateEditRequest | 

            try
            {
                // Creates a new edit for the provided input, instruction, and parameters.
                CreateEditResponse result = apiInstance.CreateEdit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditsApi.CreateEdit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateEditRequest**](CreateEditRequest.md)|  | 

### Return type

[**CreateEditResponse**](CreateEditResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
