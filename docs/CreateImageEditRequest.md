# IO.Swagger.Model.CreateImageEditRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Image** | **byte[]** | The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not provided, image must have transparency, which will be used as the mask. | 
**Prompt** | **string** | A text description of the desired image(s). The maximum length is 1000 characters. | 
**Mask** | **byte[]** | An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where &#x60;image&#x60; should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as &#x60;image&#x60;. | [optional] 
**Model** | **AnyOfCreateImageEditRequestModel** | The model to use for image generation. Only &#x60;dall-e-2&#x60; is supported at this time. | [optional] [default to dall-e-2]
**N** | **int?** | The number of images to generate. Must be between 1 and 10. | [optional] [default to 1]
**Size** | **string** | The size of the generated images. Must be one of &#x60;256x256&#x60;, &#x60;512x512&#x60;, or &#x60;1024x1024&#x60;. | [optional] [default to SizeEnum._1024x1024]
**ResponseFormat** | **string** | The format in which the generated images are returned. Must be one of &#x60;url&#x60; or &#x60;b64_json&#x60;. | [optional] [default to ResponseFormatEnum.Url]
**User** | **string** | A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

