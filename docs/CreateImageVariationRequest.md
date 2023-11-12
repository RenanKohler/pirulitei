# IO.Swagger.Model.CreateImageVariationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Image** | **byte[]** | The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square. | 
**Model** | **AnyOfCreateImageVariationRequestModel** | The model to use for image generation. Only &#x60;dall-e-2&#x60; is supported at this time. | [optional] [default to dall-e-2]
**N** | **int?** | The number of images to generate. Must be between 1 and 10. For &#x60;dall-e-3&#x60;, only &#x60;n&#x3D;1&#x60; is supported. | [optional] [default to 1]
**ResponseFormat** | **string** | The format in which the generated images are returned. Must be one of &#x60;url&#x60; or &#x60;b64_json&#x60;. | [optional] [default to ResponseFormatEnum.Url]
**Size** | **string** | The size of the generated images. Must be one of &#x60;256x256&#x60;, &#x60;512x512&#x60;, or &#x60;1024x1024&#x60;. | [optional] [default to SizeEnum._1024x1024]
**User** | **string** | A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

