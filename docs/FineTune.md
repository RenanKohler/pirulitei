# IO.Swagger.Model.FineTune
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The object identifier, which can be referenced in the API endpoints. | 
**CreatedAt** | **int?** | The Unix timestamp (in seconds) for when the fine-tuning job was created. | 
**Events** | [**List&lt;FineTuneEvent&gt;**](FineTuneEvent.md) | The list of events that have been observed in the lifecycle of the FineTune job. | [optional] 
**FineTunedModel** | **string** | The name of the fine-tuned model that is being created. | 
**Hyperparams** | [**FineTuneHyperparams**](FineTuneHyperparams.md) |  | 
**Model** | **string** | The base model that is being fine-tuned. | 
**_Object** | **string** | The object type, which is always \&quot;fine-tune\&quot;. | 
**OrganizationId** | **string** | The organization that owns the fine-tuning job. | 
**ResultFiles** | [**List&lt;OpenAIFile&gt;**](OpenAIFile.md) | The compiled results files for the fine-tuning job. | 
**Status** | **string** | The current status of the fine-tuning job, which can be either &#x60;created&#x60;, &#x60;running&#x60;, &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;cancelled&#x60;. | 
**TrainingFiles** | [**List&lt;OpenAIFile&gt;**](OpenAIFile.md) | The list of files used for training. | 
**UpdatedAt** | **int?** | The Unix timestamp (in seconds) for when the fine-tuning job was last updated. | 
**ValidationFiles** | [**List&lt;OpenAIFile&gt;**](OpenAIFile.md) | The list of files used for validation. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

