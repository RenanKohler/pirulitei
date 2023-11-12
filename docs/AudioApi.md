# IO.Swagger.Api.AudioApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSpeech**](AudioApi.md#createspeech) | **POST** /audio/speech | Generates audio from the input text.
[**CreateTranscription**](AudioApi.md#createtranscription) | **POST** /audio/transcriptions | Transcribes audio into the input language.
[**CreateTranslation**](AudioApi.md#createtranslation) | **POST** /audio/translations | Translates audio into English.

<a name="createspeech"></a>
# **CreateSpeech**
> byte[] CreateSpeech (CreateSpeechRequest body)

Generates audio from the input text.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSpeechExample
    {
        public void main()
        {

            var apiInstance = new AudioApi();
            var body = new CreateSpeechRequest(); // CreateSpeechRequest | 

            try
            {
                // Generates audio from the input text.
                byte[] result = apiInstance.CreateSpeech(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AudioApi.CreateSpeech: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSpeechRequest**](CreateSpeechRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createtranscription"></a>
# **CreateTranscription**
> CreateTranscriptionResponse CreateTranscription (byte[] file, Object model, string language, string prompt, string responseFormat, decimal? temperature)

Transcribes audio into the input language.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTranscriptionExample
    {
        public void main()
        {

            var apiInstance = new AudioApi();
            var file = file_example;  // byte[] | 
            var model = new Object(); // Object | 
            var language = language_example;  // string | 
            var prompt = prompt_example;  // string | 
            var responseFormat = responseFormat_example;  // string | 
            var temperature = 1.2;  // decimal? | 

            try
            {
                // Transcribes audio into the input language.
                CreateTranscriptionResponse result = apiInstance.CreateTranscription(file, model, language, prompt, responseFormat, temperature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AudioApi.CreateTranscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **byte[]****byte[]**|  | 
 **model** | [**Object**](Object.md)|  | 
 **language** | **string**|  | 
 **prompt** | **string**|  | 
 **responseFormat** | **string**|  | 
 **temperature** | **decimal?**|  | 

### Return type

[**CreateTranscriptionResponse**](CreateTranscriptionResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createtranslation"></a>
# **CreateTranslation**
> CreateTranslationResponse CreateTranslation (byte[] file, Object model, string prompt, string responseFormat, decimal? temperature)

Translates audio into English.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTranslationExample
    {
        public void main()
        {

            var apiInstance = new AudioApi();
            var file = file_example;  // byte[] | 
            var model = new Object(); // Object | 
            var prompt = prompt_example;  // string | 
            var responseFormat = responseFormat_example;  // string | 
            var temperature = 1.2;  // decimal? | 

            try
            {
                // Translates audio into English.
                CreateTranslationResponse result = apiInstance.CreateTranslation(file, model, prompt, responseFormat, temperature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AudioApi.CreateTranslation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **byte[]****byte[]**|  | 
 **model** | [**Object**](Object.md)|  | 
 **prompt** | **string**|  | 
 **responseFormat** | **string**|  | 
 **temperature** | **decimal?**|  | 

### Return type

[**CreateTranslationResponse**](CreateTranslationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
