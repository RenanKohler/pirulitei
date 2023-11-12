# IO.Swagger.Model.MessageObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier, which can be referenced in API endpoints. | 
**_Object** | **string** | The object type, which is always &#x60;thread.message&#x60;. | 
**CreatedAt** | **int?** | The Unix timestamp (in seconds) for when the message was created. | 
**ThreadId** | **string** | The [thread](/docs/api-reference/threads) ID that this message belongs to. | 
**Role** | **string** | The entity that produced the message. One of &#x60;user&#x60; or &#x60;assistant&#x60;. | 
**Content** | **List&lt;OneOfMessageObjectContentItems&gt;** | The content of the message in array of text and/or images. | 
**AssistantId** | **string** | If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message. | 
**RunId** | **string** | If applicable, the ID of the [run](/docs/api-reference/runs) associated with the authoring of this message. | 
**FileIds** | **List&lt;string&gt;** | A list of [file](/docs/api-reference/files) IDs that the assistant should use. Useful for tools like retrieval and code_interpreter that can access files. A maximum of 10 files can be attached to a message. | [default to []]
**Metadata** | **Object** | Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

