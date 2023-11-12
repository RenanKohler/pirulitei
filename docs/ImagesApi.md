# IO.Swagger.Api.ImagesApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateImage**](ImagesApi.md#createimage) | **POST** /images/generations | Creates an image given a prompt.
[**CreateImageEdit**](ImagesApi.md#createimageedit) | **POST** /images/edits | Creates an edited or extended image given an original image and a prompt.
[**CreateImageVariation**](ImagesApi.md#createimagevariation) | **POST** /images/variations | Creates a variation of a given image.

<a name="createimage"></a>
# **CreateImage**
> ImagesResponse CreateImage (CreateImageRequest body)

Creates an image given a prompt.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateImageExample
    {
        public void main()
        {

            var apiInstance = new ImagesApi();
            var body = new CreateImageRequest(); // CreateImageRequest | 

            try
            {
                // Creates an image given a prompt.
                ImagesResponse result = apiInstance.CreateImage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImagesApi.CreateImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateImageRequest**](CreateImageRequest.md)|  | 

### Return type

[**ImagesResponse**](ImagesResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createimageedit"></a>
# **CreateImageEdit**
> ImagesResponse CreateImageEdit (byte[] image, string prompt, byte[] mask, Object model, int? n, string size, string responseFormat, string user)

Creates an edited or extended image given an original image and a prompt.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateImageEditExample
    {
        public void main()
        {

            var apiInstance = new ImagesApi();
            var image = image_example;  // byte[] | 
            var prompt = prompt_example;  // string | 
            var mask = mask_example;  // byte[] | 
            var model = new Object(); // Object | 
            var n = 56;  // int? | 
            var size = size_example;  // string | 
            var responseFormat = responseFormat_example;  // string | 
            var user = user_example;  // string | 

            try
            {
                // Creates an edited or extended image given an original image and a prompt.
                ImagesResponse result = apiInstance.CreateImageEdit(image, prompt, mask, model, n, size, responseFormat, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImagesApi.CreateImageEdit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **prompt** | **string**|  | 
 **mask** | **byte[]****byte[]**|  | 
 **model** | [**Object**](Object.md)|  | 
 **n** | **int?**|  | 
 **size** | **string**|  | 
 **responseFormat** | **string**|  | 
 **user** | **string**|  | 

### Return type

[**ImagesResponse**](ImagesResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createimagevariation"></a>
# **CreateImageVariation**
> ImagesResponse CreateImageVariation (byte[] image, Object model, int? n, string responseFormat, string size, string user)

Creates a variation of a given image.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateImageVariationExample
    {
        public void main()
        {

            var apiInstance = new ImagesApi();
            var image = image_example;  // byte[] | 
            var model = new Object(); // Object | 
            var n = 56;  // int? | 
            var responseFormat = responseFormat_example;  // string | 
            var size = size_example;  // string | 
            var user = user_example;  // string | 

            try
            {
                // Creates a variation of a given image.
                ImagesResponse result = apiInstance.CreateImageVariation(image, model, n, responseFormat, size, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImagesApi.CreateImageVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **model** | [**Object**](Object.md)|  | 
 **n** | **int?**|  | 
 **responseFormat** | **string**|  | 
 **size** | **string**|  | 
 **user** | **string**|  | 

### Return type

[**ImagesResponse**](ImagesResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
