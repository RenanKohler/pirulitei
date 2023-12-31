# IO.Swagger - the C# library for the OpenAI API

The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen
    For more information, please visit [https://help.openai.com/](https://help.openai.com/)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new AssistantApi();
            var body = new ModifyAssistantRequest(); // ModifyAssistantRequest | 
            var assistantId = assistantId_example;  // string | The ID of the assistant to modify.

            try
            {
                // Modifies an assistant.
                AssistantObject result = apiInstance.ModifyAssistant(body, assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.ModifyAssistant: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.openai.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AssistantApi* | [**ModifyAssistant**](docs/AssistantApi.md#modifyassistant) | **POST** /assistants/{assistant_id} | Modifies an assistant.
*AssistantsApi* | [**CancelRun**](docs/AssistantsApi.md#cancelrun) | **POST** /threads/{thread_id}/runs/{run_id}/cancel | Cancels a run that is `in_progress`.
*AssistantsApi* | [**CreateAssistant**](docs/AssistantsApi.md#createassistant) | **POST** /assistants | Create an assistant with a model and instructions.
*AssistantsApi* | [**CreateAssistantFile**](docs/AssistantsApi.md#createassistantfile) | **POST** /assistants/{assistant_id}/files | Create an assistant file by attaching a [File](/docs/api-reference/files) to an [assistant](/docs/api-reference/assistants).
*AssistantsApi* | [**CreateMessage**](docs/AssistantsApi.md#createmessage) | **POST** /threads/{thread_id}/messages | Create a message.
*AssistantsApi* | [**CreateRun**](docs/AssistantsApi.md#createrun) | **POST** /threads/{thread_id}/runs | Create a run.
*AssistantsApi* | [**CreateThread**](docs/AssistantsApi.md#createthread) | **POST** /threads | Create a thread.
*AssistantsApi* | [**CreateThreadAndRun**](docs/AssistantsApi.md#createthreadandrun) | **POST** /threads/runs | Create a thread and run it in one request.
*AssistantsApi* | [**DeleteAssistant**](docs/AssistantsApi.md#deleteassistant) | **DELETE** /assistants/{assistant_id} | Delete an assistant.
*AssistantsApi* | [**DeleteAssistantFile**](docs/AssistantsApi.md#deleteassistantfile) | **DELETE** /assistants/{assistant_id}/files/{file_id} | Delete an assistant file.
*AssistantsApi* | [**DeleteThread**](docs/AssistantsApi.md#deletethread) | **DELETE** /threads/{thread_id} | Delete a thread.
*AssistantsApi* | [**GetAssistant**](docs/AssistantsApi.md#getassistant) | **GET** /assistants/{assistant_id} | Retrieves an assistant.
*AssistantsApi* | [**GetAssistantFile**](docs/AssistantsApi.md#getassistantfile) | **GET** /assistants/{assistant_id}/files/{file_id} | Retrieves an AssistantFile.
*AssistantsApi* | [**GetMessage**](docs/AssistantsApi.md#getmessage) | **GET** /threads/{thread_id}/messages/{message_id} | Retrieve a message.
*AssistantsApi* | [**GetMessageFile**](docs/AssistantsApi.md#getmessagefile) | **GET** /threads/{thread_id}/messages/{message_id}/files/{file_id} | Retrieves a message file.
*AssistantsApi* | [**GetRun**](docs/AssistantsApi.md#getrun) | **GET** /threads/{thread_id}/runs/{run_id} | Retrieves a run.
*AssistantsApi* | [**GetRunStep**](docs/AssistantsApi.md#getrunstep) | **GET** /threads/{thread_id}/runs/{run_id}/steps/{step_id} | Retrieves a run step.
*AssistantsApi* | [**GetThread**](docs/AssistantsApi.md#getthread) | **GET** /threads/{thread_id} | Retrieves a thread.
*AssistantsApi* | [**ListAssistantFiles**](docs/AssistantsApi.md#listassistantfiles) | **GET** /assistants/{assistant_id}/files | Returns a list of assistant files.
*AssistantsApi* | [**ListAssistants**](docs/AssistantsApi.md#listassistants) | **GET** /assistants | Returns a list of assistants.
*AssistantsApi* | [**ListMessageFiles**](docs/AssistantsApi.md#listmessagefiles) | **GET** /threads/{thread_id}/messages/{message_id}/files | Returns a list of message files.
*AssistantsApi* | [**ListMessages**](docs/AssistantsApi.md#listmessages) | **GET** /threads/{thread_id}/messages | Returns a list of messages for a given thread.
*AssistantsApi* | [**ListRunSteps**](docs/AssistantsApi.md#listrunsteps) | **GET** /threads/{thread_id}/runs/{run_id}/steps | Returns a list of run steps belonging to a run.
*AssistantsApi* | [**ListRuns**](docs/AssistantsApi.md#listruns) | **GET** /threads/{thread_id}/runs | Returns a list of runs belonging to a thread.
*AssistantsApi* | [**ModifyMessage**](docs/AssistantsApi.md#modifymessage) | **POST** /threads/{thread_id}/messages/{message_id} | Modifies a message.
*AssistantsApi* | [**ModifyRun**](docs/AssistantsApi.md#modifyrun) | **POST** /threads/{thread_id}/runs/{run_id} | Modifies a run.
*AssistantsApi* | [**ModifyThread**](docs/AssistantsApi.md#modifythread) | **POST** /threads/{thread_id} | Modifies a thread.
*AssistantsApi* | [**SubmitToolOuputsToRun**](docs/AssistantsApi.md#submittoolouputstorun) | **POST** /threads/{thread_id}/runs/{run_id}/submit_tool_outputs | When a run has the `status: \"requires_action\"` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request. 
*AudioApi* | [**CreateSpeech**](docs/AudioApi.md#createspeech) | **POST** /audio/speech | Generates audio from the input text.
*AudioApi* | [**CreateTranscription**](docs/AudioApi.md#createtranscription) | **POST** /audio/transcriptions | Transcribes audio into the input language.
*AudioApi* | [**CreateTranslation**](docs/AudioApi.md#createtranslation) | **POST** /audio/translations | Translates audio into English.
*ChatApi* | [**CreateChatCompletion**](docs/ChatApi.md#createchatcompletion) | **POST** /chat/completions | Creates a model response for the given chat conversation.
*CompletionsApi* | [**CreateCompletion**](docs/CompletionsApi.md#createcompletion) | **POST** /completions | Creates a completion for the provided prompt and parameters.
*EditsApi* | [**CreateEdit**](docs/EditsApi.md#createedit) | **POST** /edits | Creates a new edit for the provided input, instruction, and parameters.
*EmbeddingsApi* | [**CreateEmbedding**](docs/EmbeddingsApi.md#createembedding) | **POST** /embeddings | Creates an embedding vector representing the input text.
*FilesApi* | [**CreateFile**](docs/FilesApi.md#createfile) | **POST** /files | Upload a file that can be used across various endpoints/features. The size of all the files uploaded by one organization can be up to 100 GB.  The size of individual files for can be a maximum of 512MB. See the [Assistants Tools guide](/docs/assistants/tools) to learn more about the types of files supported. The Fine-tuning API only supports `.jsonl` files.  Please [contact us](https://help.openai.com/) if you need to increase these storage limits. 
*FilesApi* | [**DeleteFile**](docs/FilesApi.md#deletefile) | **DELETE** /files/{file_id} | Delete a file.
*FilesApi* | [**DownloadFile**](docs/FilesApi.md#downloadfile) | **GET** /files/{file_id}/content | Returns the contents of the specified file.
*FilesApi* | [**ListFiles**](docs/FilesApi.md#listfiles) | **GET** /files | Returns a list of files that belong to the user's organization.
*FilesApi* | [**RetrieveFile**](docs/FilesApi.md#retrievefile) | **GET** /files/{file_id} | Returns information about a specific file.
*FineTunesApi* | [**CancelFineTune**](docs/FineTunesApi.md#cancelfinetune) | **POST** /fine-tunes/{fine_tune_id}/cancel | Immediately cancel a fine-tune job. 
*FineTunesApi* | [**CreateFineTune**](docs/FineTunesApi.md#createfinetune) | **POST** /fine-tunes | Creates a job that fine-tunes a specified model from a given dataset.  Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.  [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning) 
*FineTunesApi* | [**ListFineTuneEvents**](docs/FineTunesApi.md#listfinetuneevents) | **GET** /fine-tunes/{fine_tune_id}/events | Get fine-grained status updates for a fine-tune job. 
*FineTunesApi* | [**ListFineTunes**](docs/FineTunesApi.md#listfinetunes) | **GET** /fine-tunes | List your organization's fine-tuning jobs 
*FineTunesApi* | [**RetrieveFineTune**](docs/FineTunesApi.md#retrievefinetune) | **GET** /fine-tunes/{fine_tune_id} | Gets info about the fine-tune job.  [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning) 
*FineTuningApi* | [**CancelFineTuningJob**](docs/FineTuningApi.md#cancelfinetuningjob) | **POST** /fine_tuning/jobs/{fine_tuning_job_id}/cancel | Immediately cancel a fine-tune job. 
*FineTuningApi* | [**CreateFineTuningJob**](docs/FineTuningApi.md#createfinetuningjob) | **POST** /fine_tuning/jobs | Creates a job that fine-tunes a specified model from a given dataset.  Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 
*FineTuningApi* | [**ListFineTuningEvents**](docs/FineTuningApi.md#listfinetuningevents) | **GET** /fine_tuning/jobs/{fine_tuning_job_id}/events | Get status updates for a fine-tuning job. 
*FineTuningApi* | [**ListPaginatedFineTuningJobs**](docs/FineTuningApi.md#listpaginatedfinetuningjobs) | **GET** /fine_tuning/jobs | List your organization's fine-tuning jobs 
*FineTuningApi* | [**RetrieveFineTuningJob**](docs/FineTuningApi.md#retrievefinetuningjob) | **GET** /fine_tuning/jobs/{fine_tuning_job_id} | Get info about a fine-tuning job.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 
*ImagesApi* | [**CreateImage**](docs/ImagesApi.md#createimage) | **POST** /images/generations | Creates an image given a prompt.
*ImagesApi* | [**CreateImageEdit**](docs/ImagesApi.md#createimageedit) | **POST** /images/edits | Creates an edited or extended image given an original image and a prompt.
*ImagesApi* | [**CreateImageVariation**](docs/ImagesApi.md#createimagevariation) | **POST** /images/variations | Creates a variation of a given image.
*ModelsApi* | [**DeleteModel**](docs/ModelsApi.md#deletemodel) | **DELETE** /models/{model} | Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.
*ModelsApi* | [**ListModels**](docs/ModelsApi.md#listmodels) | **GET** /models | Lists the currently available models, and provides basic information about each one such as the owner and availability.
*ModelsApi* | [**RetrieveModel**](docs/ModelsApi.md#retrievemodel) | **GET** /models/{model} | Retrieves a model instance, providing basic information about the model such as the owner and permissioning.
*ModerationsApi* | [**CreateModeration**](docs/ModerationsApi.md#createmoderation) | **POST** /moderations | Classifies if text violates OpenAI's Content Policy

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AnyOfCreateAssistantRequestModel](docs/AnyOfCreateAssistantRequestModel.md)
 - [Model.AnyOfCreateChatCompletionRequestModel](docs/AnyOfCreateChatCompletionRequestModel.md)
 - [Model.AnyOfCreateCompletionRequestModel](docs/AnyOfCreateCompletionRequestModel.md)
 - [Model.AnyOfCreateEditRequestModel](docs/AnyOfCreateEditRequestModel.md)
 - [Model.AnyOfCreateEmbeddingRequestModel](docs/AnyOfCreateEmbeddingRequestModel.md)
 - [Model.AnyOfCreateFineTuneRequestModel](docs/AnyOfCreateFineTuneRequestModel.md)
 - [Model.AnyOfCreateFineTuningJobRequestModel](docs/AnyOfCreateFineTuningJobRequestModel.md)
 - [Model.AnyOfCreateImageEditRequestModel](docs/AnyOfCreateImageEditRequestModel.md)
 - [Model.AnyOfCreateImageRequestModel](docs/AnyOfCreateImageRequestModel.md)
 - [Model.AnyOfCreateImageVariationRequestModel](docs/AnyOfCreateImageVariationRequestModel.md)
 - [Model.AnyOfCreateModerationRequestModel](docs/AnyOfCreateModerationRequestModel.md)
 - [Model.AnyOfCreateSpeechRequestModel](docs/AnyOfCreateSpeechRequestModel.md)
 - [Model.AnyOfCreateTranscriptionRequestModel](docs/AnyOfCreateTranscriptionRequestModel.md)
 - [Model.AnyOfCreateTranslationRequestModel](docs/AnyOfCreateTranslationRequestModel.md)
 - [Model.AnyOfModifyAssistantRequestModel](docs/AnyOfModifyAssistantRequestModel.md)
 - [Model.AssistantFileObject](docs/AssistantFileObject.md)
 - [Model.AssistantObject](docs/AssistantObject.md)
 - [Model.AssistantToolsCode](docs/AssistantToolsCode.md)
 - [Model.AssistantToolsFunction](docs/AssistantToolsFunction.md)
 - [Model.AssistantToolsRetrieval](docs/AssistantToolsRetrieval.md)
 - [Model.ChatCompletionFunctionCallOption](docs/ChatCompletionFunctionCallOption.md)
 - [Model.ChatCompletionFunctions](docs/ChatCompletionFunctions.md)
 - [Model.ChatCompletionMessageToolCall](docs/ChatCompletionMessageToolCall.md)
 - [Model.ChatCompletionMessageToolCallChunk](docs/ChatCompletionMessageToolCallChunk.md)
 - [Model.ChatCompletionMessageToolCallChunkFunction](docs/ChatCompletionMessageToolCallChunkFunction.md)
 - [Model.ChatCompletionMessageToolCallFunction](docs/ChatCompletionMessageToolCallFunction.md)
 - [Model.ChatCompletionMessageToolCalls](docs/ChatCompletionMessageToolCalls.md)
 - [Model.ChatCompletionNamedToolChoice](docs/ChatCompletionNamedToolChoice.md)
 - [Model.ChatCompletionNamedToolChoiceFunction](docs/ChatCompletionNamedToolChoiceFunction.md)
 - [Model.ChatCompletionRequestAssistantMessage](docs/ChatCompletionRequestAssistantMessage.md)
 - [Model.ChatCompletionRequestAssistantMessageFunctionCall](docs/ChatCompletionRequestAssistantMessageFunctionCall.md)
 - [Model.ChatCompletionRequestFunctionMessage](docs/ChatCompletionRequestFunctionMessage.md)
 - [Model.ChatCompletionRequestMessage](docs/ChatCompletionRequestMessage.md)
 - [Model.ChatCompletionRequestMessageContentPart](docs/ChatCompletionRequestMessageContentPart.md)
 - [Model.ChatCompletionRequestMessageContentPartImage](docs/ChatCompletionRequestMessageContentPartImage.md)
 - [Model.ChatCompletionRequestMessageContentPartImageImageUrl](docs/ChatCompletionRequestMessageContentPartImageImageUrl.md)
 - [Model.ChatCompletionRequestMessageContentPartText](docs/ChatCompletionRequestMessageContentPartText.md)
 - [Model.ChatCompletionRequestSystemMessage](docs/ChatCompletionRequestSystemMessage.md)
 - [Model.ChatCompletionRequestToolMessage](docs/ChatCompletionRequestToolMessage.md)
 - [Model.ChatCompletionRequestUserMessage](docs/ChatCompletionRequestUserMessage.md)
 - [Model.ChatCompletionResponseMessage](docs/ChatCompletionResponseMessage.md)
 - [Model.ChatCompletionRole](docs/ChatCompletionRole.md)
 - [Model.ChatCompletionStreamResponseDelta](docs/ChatCompletionStreamResponseDelta.md)
 - [Model.ChatCompletionStreamResponseDeltaFunctionCall](docs/ChatCompletionStreamResponseDeltaFunctionCall.md)
 - [Model.ChatCompletionTool](docs/ChatCompletionTool.md)
 - [Model.ChatCompletionToolChoiceOption](docs/ChatCompletionToolChoiceOption.md)
 - [Model.CompletionUsage](docs/CompletionUsage.md)
 - [Model.CreateAssistantFileRequest](docs/CreateAssistantFileRequest.md)
 - [Model.CreateAssistantRequest](docs/CreateAssistantRequest.md)
 - [Model.CreateChatCompletionFunctionResponse](docs/CreateChatCompletionFunctionResponse.md)
 - [Model.CreateChatCompletionFunctionResponseChoices](docs/CreateChatCompletionFunctionResponseChoices.md)
 - [Model.CreateChatCompletionImageResponse](docs/CreateChatCompletionImageResponse.md)
 - [Model.CreateChatCompletionRequest](docs/CreateChatCompletionRequest.md)
 - [Model.CreateChatCompletionRequestResponseFormat](docs/CreateChatCompletionRequestResponseFormat.md)
 - [Model.CreateChatCompletionResponse](docs/CreateChatCompletionResponse.md)
 - [Model.CreateChatCompletionResponseChoices](docs/CreateChatCompletionResponseChoices.md)
 - [Model.CreateChatCompletionStreamResponse](docs/CreateChatCompletionStreamResponse.md)
 - [Model.CreateChatCompletionStreamResponseChoices](docs/CreateChatCompletionStreamResponseChoices.md)
 - [Model.CreateCompletionRequest](docs/CreateCompletionRequest.md)
 - [Model.CreateCompletionResponse](docs/CreateCompletionResponse.md)
 - [Model.CreateCompletionResponseChoices](docs/CreateCompletionResponseChoices.md)
 - [Model.CreateCompletionResponseLogprobs](docs/CreateCompletionResponseLogprobs.md)
 - [Model.CreateEditRequest](docs/CreateEditRequest.md)
 - [Model.CreateEditResponse](docs/CreateEditResponse.md)
 - [Model.CreateEditResponseChoices](docs/CreateEditResponseChoices.md)
 - [Model.CreateEmbeddingRequest](docs/CreateEmbeddingRequest.md)
 - [Model.CreateEmbeddingResponse](docs/CreateEmbeddingResponse.md)
 - [Model.CreateEmbeddingResponseUsage](docs/CreateEmbeddingResponseUsage.md)
 - [Model.CreateFileRequest](docs/CreateFileRequest.md)
 - [Model.CreateFineTuneRequest](docs/CreateFineTuneRequest.md)
 - [Model.CreateFineTuneRequestHyperparameters](docs/CreateFineTuneRequestHyperparameters.md)
 - [Model.CreateFineTuningJobRequest](docs/CreateFineTuningJobRequest.md)
 - [Model.CreateFineTuningJobRequestHyperparameters](docs/CreateFineTuningJobRequestHyperparameters.md)
 - [Model.CreateImageEditRequest](docs/CreateImageEditRequest.md)
 - [Model.CreateImageRequest](docs/CreateImageRequest.md)
 - [Model.CreateImageVariationRequest](docs/CreateImageVariationRequest.md)
 - [Model.CreateMessageRequest](docs/CreateMessageRequest.md)
 - [Model.CreateModerationRequest](docs/CreateModerationRequest.md)
 - [Model.CreateModerationResponse](docs/CreateModerationResponse.md)
 - [Model.CreateModerationResponseCategories](docs/CreateModerationResponseCategories.md)
 - [Model.CreateModerationResponseCategoryScores](docs/CreateModerationResponseCategoryScores.md)
 - [Model.CreateModerationResponseResults](docs/CreateModerationResponseResults.md)
 - [Model.CreateRunRequest](docs/CreateRunRequest.md)
 - [Model.CreateSpeechRequest](docs/CreateSpeechRequest.md)
 - [Model.CreateThreadAndRunRequest](docs/CreateThreadAndRunRequest.md)
 - [Model.CreateThreadRequest](docs/CreateThreadRequest.md)
 - [Model.CreateTranscriptionRequest](docs/CreateTranscriptionRequest.md)
 - [Model.CreateTranscriptionResponse](docs/CreateTranscriptionResponse.md)
 - [Model.CreateTranslationRequest](docs/CreateTranslationRequest.md)
 - [Model.CreateTranslationResponse](docs/CreateTranslationResponse.md)
 - [Model.DeleteAssistantFileResponse](docs/DeleteAssistantFileResponse.md)
 - [Model.DeleteAssistantResponse](docs/DeleteAssistantResponse.md)
 - [Model.DeleteFileResponse](docs/DeleteFileResponse.md)
 - [Model.DeleteMessageResponse](docs/DeleteMessageResponse.md)
 - [Model.DeleteModelResponse](docs/DeleteModelResponse.md)
 - [Model.DeleteThreadResponse](docs/DeleteThreadResponse.md)
 - [Model.Embedding](docs/Embedding.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.FineTune](docs/FineTune.md)
 - [Model.FineTuneEvent](docs/FineTuneEvent.md)
 - [Model.FineTuneHyperparams](docs/FineTuneHyperparams.md)
 - [Model.FineTuningJob](docs/FineTuningJob.md)
 - [Model.FineTuningJobError](docs/FineTuningJobError.md)
 - [Model.FineTuningJobEvent](docs/FineTuningJobEvent.md)
 - [Model.FineTuningJobHyperparameters](docs/FineTuningJobHyperparameters.md)
 - [Model.FunctionObject](docs/FunctionObject.md)
 - [Model.FunctionParameters](docs/FunctionParameters.md)
 - [Model.Image](docs/Image.md)
 - [Model.ImagesResponse](docs/ImagesResponse.md)
 - [Model.ListAssistantFilesResponse](docs/ListAssistantFilesResponse.md)
 - [Model.ListAssistantsResponse](docs/ListAssistantsResponse.md)
 - [Model.ListFilesResponse](docs/ListFilesResponse.md)
 - [Model.ListFineTuneEventsResponse](docs/ListFineTuneEventsResponse.md)
 - [Model.ListFineTunesResponse](docs/ListFineTunesResponse.md)
 - [Model.ListFineTuningJobEventsResponse](docs/ListFineTuningJobEventsResponse.md)
 - [Model.ListMessageFilesResponse](docs/ListMessageFilesResponse.md)
 - [Model.ListMessagesResponse](docs/ListMessagesResponse.md)
 - [Model.ListModelsResponse](docs/ListModelsResponse.md)
 - [Model.ListPaginatedFineTuningJobsResponse](docs/ListPaginatedFineTuningJobsResponse.md)
 - [Model.ListRunStepsResponse](docs/ListRunStepsResponse.md)
 - [Model.ListRunsResponse](docs/ListRunsResponse.md)
 - [Model.ListThreadsResponse](docs/ListThreadsResponse.md)
 - [Model.MessageContentImageFileObject](docs/MessageContentImageFileObject.md)
 - [Model.MessageContentImageFileObjectImageFile](docs/MessageContentImageFileObjectImageFile.md)
 - [Model.MessageContentTextAnnotationsFileCitationObject](docs/MessageContentTextAnnotationsFileCitationObject.md)
 - [Model.MessageContentTextAnnotationsFileCitationObjectFileCitation](docs/MessageContentTextAnnotationsFileCitationObjectFileCitation.md)
 - [Model.MessageContentTextAnnotationsFilePathObject](docs/MessageContentTextAnnotationsFilePathObject.md)
 - [Model.MessageContentTextAnnotationsFilePathObjectFilePath](docs/MessageContentTextAnnotationsFilePathObjectFilePath.md)
 - [Model.MessageContentTextObject](docs/MessageContentTextObject.md)
 - [Model.MessageContentTextObjectText](docs/MessageContentTextObjectText.md)
 - [Model.MessageFileObject](docs/MessageFileObject.md)
 - [Model.MessageObject](docs/MessageObject.md)
 - [Model.Model](docs/Model.md)
 - [Model.ModifyAssistantRequest](docs/ModifyAssistantRequest.md)
 - [Model.ModifyMessageRequest](docs/ModifyMessageRequest.md)
 - [Model.ModifyRunRequest](docs/ModifyRunRequest.md)
 - [Model.ModifyThreadRequest](docs/ModifyThreadRequest.md)
 - [Model.OneOfAssistantObjectToolsItems](docs/OneOfAssistantObjectToolsItems.md)
 - [Model.OneOfChatCompletionRequestUserMessageContent](docs/OneOfChatCompletionRequestUserMessageContent.md)
 - [Model.OneOfCreateAssistantRequestToolsItems](docs/OneOfCreateAssistantRequestToolsItems.md)
 - [Model.OneOfCreateChatCompletionRequestFunctionCall](docs/OneOfCreateChatCompletionRequestFunctionCall.md)
 - [Model.OneOfCreateChatCompletionRequestStop](docs/OneOfCreateChatCompletionRequestStop.md)
 - [Model.OneOfCreateCompletionRequestPrompt](docs/OneOfCreateCompletionRequestPrompt.md)
 - [Model.OneOfCreateCompletionRequestStop](docs/OneOfCreateCompletionRequestStop.md)
 - [Model.OneOfCreateEmbeddingRequestInput](docs/OneOfCreateEmbeddingRequestInput.md)
 - [Model.OneOfCreateFineTuneRequestHyperparametersNEpochs](docs/OneOfCreateFineTuneRequestHyperparametersNEpochs.md)
 - [Model.OneOfCreateFineTuningJobRequestHyperparametersBatchSize](docs/OneOfCreateFineTuningJobRequestHyperparametersBatchSize.md)
 - [Model.OneOfCreateFineTuningJobRequestHyperparametersLearningRateMultiplier](docs/OneOfCreateFineTuningJobRequestHyperparametersLearningRateMultiplier.md)
 - [Model.OneOfCreateFineTuningJobRequestHyperparametersNEpochs](docs/OneOfCreateFineTuningJobRequestHyperparametersNEpochs.md)
 - [Model.OneOfCreateModerationRequestInput](docs/OneOfCreateModerationRequestInput.md)
 - [Model.OneOfCreateRunRequestToolsItems](docs/OneOfCreateRunRequestToolsItems.md)
 - [Model.OneOfCreateThreadAndRunRequestToolsItems](docs/OneOfCreateThreadAndRunRequestToolsItems.md)
 - [Model.OneOfFineTuningJobHyperparametersNEpochs](docs/OneOfFineTuningJobHyperparametersNEpochs.md)
 - [Model.OneOfMessageContentTextObjectTextAnnotationsItems](docs/OneOfMessageContentTextObjectTextAnnotationsItems.md)
 - [Model.OneOfMessageObjectContentItems](docs/OneOfMessageObjectContentItems.md)
 - [Model.OneOfModifyAssistantRequestToolsItems](docs/OneOfModifyAssistantRequestToolsItems.md)
 - [Model.OneOfRunObjectToolsItems](docs/OneOfRunObjectToolsItems.md)
 - [Model.OneOfRunStepDetailsToolCallsCodeObjectCodeInterpreterOutputsItems](docs/OneOfRunStepDetailsToolCallsCodeObjectCodeInterpreterOutputsItems.md)
 - [Model.OneOfRunStepDetailsToolCallsObjectToolCallsItems](docs/OneOfRunStepDetailsToolCallsObjectToolCallsItems.md)
 - [Model.OneOfRunStepObjectStepDetails](docs/OneOfRunStepObjectStepDetails.md)
 - [Model.OpenAIFile](docs/OpenAIFile.md)
 - [Model.RunObject](docs/RunObject.md)
 - [Model.RunObjectLastError](docs/RunObjectLastError.md)
 - [Model.RunObjectRequiredAction](docs/RunObjectRequiredAction.md)
 - [Model.RunObjectRequiredActionSubmitToolOutputs](docs/RunObjectRequiredActionSubmitToolOutputs.md)
 - [Model.RunStepDetailsMessageCreationObject](docs/RunStepDetailsMessageCreationObject.md)
 - [Model.RunStepDetailsMessageCreationObjectMessageCreation](docs/RunStepDetailsMessageCreationObjectMessageCreation.md)
 - [Model.RunStepDetailsToolCallsCodeObject](docs/RunStepDetailsToolCallsCodeObject.md)
 - [Model.RunStepDetailsToolCallsCodeObjectCodeInterpreter](docs/RunStepDetailsToolCallsCodeObjectCodeInterpreter.md)
 - [Model.RunStepDetailsToolCallsCodeOutputImageObject](docs/RunStepDetailsToolCallsCodeOutputImageObject.md)
 - [Model.RunStepDetailsToolCallsCodeOutputImageObjectImage](docs/RunStepDetailsToolCallsCodeOutputImageObjectImage.md)
 - [Model.RunStepDetailsToolCallsCodeOutputLogsObject](docs/RunStepDetailsToolCallsCodeOutputLogsObject.md)
 - [Model.RunStepDetailsToolCallsFunctionObject](docs/RunStepDetailsToolCallsFunctionObject.md)
 - [Model.RunStepDetailsToolCallsFunctionObjectFunction](docs/RunStepDetailsToolCallsFunctionObjectFunction.md)
 - [Model.RunStepDetailsToolCallsObject](docs/RunStepDetailsToolCallsObject.md)
 - [Model.RunStepDetailsToolCallsRetrievalObject](docs/RunStepDetailsToolCallsRetrievalObject.md)
 - [Model.RunStepObject](docs/RunStepObject.md)
 - [Model.RunStepObjectLastError](docs/RunStepObjectLastError.md)
 - [Model.RunToolCallObject](docs/RunToolCallObject.md)
 - [Model.RunToolCallObjectFunction](docs/RunToolCallObjectFunction.md)
 - [Model.SubmitToolOutputsRunRequest](docs/SubmitToolOutputsRunRequest.md)
 - [Model.SubmitToolOutputsRunRequestToolOutputs](docs/SubmitToolOutputsRunRequestToolOutputs.md)
 - [Model.ThreadObject](docs/ThreadObject.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth


