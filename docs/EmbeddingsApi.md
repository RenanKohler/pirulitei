# IO.Swagger.Api.EmbeddingsApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmbedding**](EmbeddingsApi.md#createembedding) | **POST** /embeddings | Creates an embedding vector representing the input text.

<a name="createembedding"></a>
# **CreateEmbedding**
> CreateEmbeddingResponse CreateEmbedding (CreateEmbeddingRequest body)

Creates an embedding vector representing the input text.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateEmbeddingExample
    {
        public void main()
        {

            var apiInstance = new EmbeddingsApi();
            var body = new CreateEmbeddingRequest(); // CreateEmbeddingRequest | 

            try
            {
                // Creates an embedding vector representing the input text.
                CreateEmbeddingResponse result = apiInstance.CreateEmbedding(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmbeddingsApi.CreateEmbedding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateEmbeddingRequest**](CreateEmbeddingRequest.md)|  | 

### Return type

[**CreateEmbeddingResponse**](CreateEmbeddingResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
