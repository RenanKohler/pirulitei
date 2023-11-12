# IO.Swagger.Model.RunObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier, which can be referenced in API endpoints. | 
**_Object** | **string** | The object type, which is always &#x60;thread.run&#x60;. | 
**CreatedAt** | **int?** | The Unix timestamp (in seconds) for when the run was created. | 
**ThreadId** | **string** | The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run. | 
**AssistantId** | **string** | The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run. | 
**Status** | **string** | The status of the run, which can be either &#x60;queued&#x60;, &#x60;in_progress&#x60;, &#x60;requires_action&#x60;, &#x60;cancelling&#x60;, &#x60;cancelled&#x60;, &#x60;failed&#x60;, &#x60;completed&#x60;, or &#x60;expired&#x60;. | 
**RequiredAction** | [**RunObjectRequiredAction**](RunObjectRequiredAction.md) |  | 
**LastError** | [**RunObjectLastError**](RunObjectLastError.md) |  | 
**ExpiresAt** | **int?** | The Unix timestamp (in seconds) for when the run will expire. | 
**StartedAt** | **int?** | The Unix timestamp (in seconds) for when the run was started. | 
**CancelledAt** | **int?** | The Unix timestamp (in seconds) for when the run was cancelled. | 
**FailedAt** | **int?** | The Unix timestamp (in seconds) for when the run failed. | 
**CompletedAt** | **int?** | The Unix timestamp (in seconds) for when the run was completed. | 
**Model** | **string** | The model that the [assistant](/docs/api-reference/assistants) used for this run. | 
**Instructions** | **string** | The instructions that the [assistant](/docs/api-reference/assistants) used for this run. | 
**Tools** | **List&lt;OneOfRunObjectToolsItems&gt;** | The list of tools that the [assistant](/docs/api-reference/assistants) used for this run. | [default to []]
**FileIds** | **List&lt;string&gt;** | The list of [File](/docs/api-reference/files) IDs the [assistant](/docs/api-reference/assistants) used for this run. | [default to []]
**Metadata** | **Object** | Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

