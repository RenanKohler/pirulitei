# IO.Swagger.Model.CreateEditRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instruction** | **string** | The instruction that tells the model how to edit the prompt. | 
**Model** | **AnyOfCreateEditRequestModel** | ID of the model to use. You can use the &#x60;text-davinci-edit-001&#x60; or &#x60;code-davinci-edit-001&#x60; model with this endpoint. | 
**Input** | **string** | The input text to use as a starting point for the edit. | [optional] [default to ""]
**N** | **int?** | How many edits to generate for the input and instruction. | [optional] [default to 1]
**Temperature** | [**decimal?**](BigDecimal.md) | What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.  We generally recommend altering this or &#x60;top_p&#x60; but not both.  | [optional] [default to 1]
**TopP** | [**decimal?**](BigDecimal.md) | An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or &#x60;temperature&#x60; but not both.  | [optional] [default to 1]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

