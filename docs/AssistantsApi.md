# IO.Swagger.Api.AssistantsApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelRun**](AssistantsApi.md#cancelrun) | **POST** /threads/{thread_id}/runs/{run_id}/cancel | Cancels a run that is &#x60;in_progress&#x60;.
[**CreateAssistant**](AssistantsApi.md#createassistant) | **POST** /assistants | Create an assistant with a model and instructions.
[**CreateAssistantFile**](AssistantsApi.md#createassistantfile) | **POST** /assistants/{assistant_id}/files | Create an assistant file by attaching a [File](/docs/api-reference/files) to an [assistant](/docs/api-reference/assistants).
[**CreateMessage**](AssistantsApi.md#createmessage) | **POST** /threads/{thread_id}/messages | Create a message.
[**CreateRun**](AssistantsApi.md#createrun) | **POST** /threads/{thread_id}/runs | Create a run.
[**CreateThread**](AssistantsApi.md#createthread) | **POST** /threads | Create a thread.
[**CreateThreadAndRun**](AssistantsApi.md#createthreadandrun) | **POST** /threads/runs | Create a thread and run it in one request.
[**DeleteAssistant**](AssistantsApi.md#deleteassistant) | **DELETE** /assistants/{assistant_id} | Delete an assistant.
[**DeleteAssistantFile**](AssistantsApi.md#deleteassistantfile) | **DELETE** /assistants/{assistant_id}/files/{file_id} | Delete an assistant file.
[**DeleteThread**](AssistantsApi.md#deletethread) | **DELETE** /threads/{thread_id} | Delete a thread.
[**GetAssistant**](AssistantsApi.md#getassistant) | **GET** /assistants/{assistant_id} | Retrieves an assistant.
[**GetAssistantFile**](AssistantsApi.md#getassistantfile) | **GET** /assistants/{assistant_id}/files/{file_id} | Retrieves an AssistantFile.
[**GetMessage**](AssistantsApi.md#getmessage) | **GET** /threads/{thread_id}/messages/{message_id} | Retrieve a message.
[**GetMessageFile**](AssistantsApi.md#getmessagefile) | **GET** /threads/{thread_id}/messages/{message_id}/files/{file_id} | Retrieves a message file.
[**GetRun**](AssistantsApi.md#getrun) | **GET** /threads/{thread_id}/runs/{run_id} | Retrieves a run.
[**GetRunStep**](AssistantsApi.md#getrunstep) | **GET** /threads/{thread_id}/runs/{run_id}/steps/{step_id} | Retrieves a run step.
[**GetThread**](AssistantsApi.md#getthread) | **GET** /threads/{thread_id} | Retrieves a thread.
[**ListAssistantFiles**](AssistantsApi.md#listassistantfiles) | **GET** /assistants/{assistant_id}/files | Returns a list of assistant files.
[**ListAssistants**](AssistantsApi.md#listassistants) | **GET** /assistants | Returns a list of assistants.
[**ListMessageFiles**](AssistantsApi.md#listmessagefiles) | **GET** /threads/{thread_id}/messages/{message_id}/files | Returns a list of message files.
[**ListMessages**](AssistantsApi.md#listmessages) | **GET** /threads/{thread_id}/messages | Returns a list of messages for a given thread.
[**ListRunSteps**](AssistantsApi.md#listrunsteps) | **GET** /threads/{thread_id}/runs/{run_id}/steps | Returns a list of run steps belonging to a run.
[**ListRuns**](AssistantsApi.md#listruns) | **GET** /threads/{thread_id}/runs | Returns a list of runs belonging to a thread.
[**ModifyMessage**](AssistantsApi.md#modifymessage) | **POST** /threads/{thread_id}/messages/{message_id} | Modifies a message.
[**ModifyRun**](AssistantsApi.md#modifyrun) | **POST** /threads/{thread_id}/runs/{run_id} | Modifies a run.
[**ModifyThread**](AssistantsApi.md#modifythread) | **POST** /threads/{thread_id} | Modifies a thread.
[**SubmitToolOuputsToRun**](AssistantsApi.md#submittoolouputstorun) | **POST** /threads/{thread_id}/runs/{run_id}/submit_tool_outputs | When a run has the &#x60;status: \&quot;requires_action\&quot;&#x60; and &#x60;required_action.type&#x60; is &#x60;submit_tool_outputs&#x60;, this endpoint can be used to submit the outputs from the tool calls once they&#x27;re all completed. All outputs must be submitted in a single request. 

<a name="cancelrun"></a>
# **CancelRun**
> RunObject CancelRun (string threadId, string runId)

Cancels a run that is `in_progress`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelRunExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread to which this run belongs.
            var runId = runId_example;  // string | The ID of the run to cancel.

            try
            {
                // Cancels a run that is `in_progress`.
                RunObject result = apiInstance.CancelRun(threadId, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.CancelRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread to which this run belongs. | 
 **runId** | **string**| The ID of the run to cancel. | 

### Return type

[**RunObject**](RunObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createassistant"></a>
# **CreateAssistant**
> AssistantObject CreateAssistant (CreateAssistantRequest body)

Create an assistant with a model and instructions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAssistantExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new CreateAssistantRequest(); // CreateAssistantRequest | 

            try
            {
                // Create an assistant with a model and instructions.
                AssistantObject result = apiInstance.CreateAssistant(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.CreateAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAssistantRequest**](CreateAssistantRequest.md)|  | 

### Return type

[**AssistantObject**](AssistantObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createassistantfile"></a>
# **CreateAssistantFile**
> AssistantFileObject CreateAssistantFile (CreateAssistantFileRequest body, string assistantId)

Create an assistant file by attaching a [File](/docs/api-reference/files) to an [assistant](/docs/api-reference/assistants).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAssistantFileExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new CreateAssistantFileRequest(); // CreateAssistantFileRequest | 
            var assistantId = assistantId_example;  // string | The ID of the assistant for which to create a File. 

            try
            {
                // Create an assistant file by attaching a [File](/docs/api-reference/files) to an [assistant](/docs/api-reference/assistants).
                AssistantFileObject result = apiInstance.CreateAssistantFile(body, assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.CreateAssistantFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAssistantFileRequest**](CreateAssistantFileRequest.md)|  | 
 **assistantId** | **string**| The ID of the assistant for which to create a File.  | 

### Return type

[**AssistantFileObject**](AssistantFileObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createmessage"></a>
# **CreateMessage**
> MessageObject CreateMessage (CreateMessageRequest body, string threadId)

Create a message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMessageExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new CreateMessageRequest(); // CreateMessageRequest | 
            var threadId = threadId_example;  // string | The ID of the [thread](/docs/api-reference/threads) to create a message for.

            try
            {
                // Create a message.
                MessageObject result = apiInstance.CreateMessage(body, threadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.CreateMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateMessageRequest**](CreateMessageRequest.md)|  | 
 **threadId** | **string**| The ID of the [thread](/docs/api-reference/threads) to create a message for. | 

### Return type

[**MessageObject**](MessageObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createrun"></a>
# **CreateRun**
> RunObject CreateRun (CreateRunRequest body, string threadId)

Create a run.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRunExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new CreateRunRequest(); // CreateRunRequest | 
            var threadId = threadId_example;  // string | The ID of the thread to run.

            try
            {
                // Create a run.
                RunObject result = apiInstance.CreateRun(body, threadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.CreateRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRunRequest**](CreateRunRequest.md)|  | 
 **threadId** | **string**| The ID of the thread to run. | 

### Return type

[**RunObject**](RunObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createthread"></a>
# **CreateThread**
> ThreadObject CreateThread (CreateThreadRequest body = null)

Create a thread.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateThreadExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new CreateThreadRequest(); // CreateThreadRequest |  (optional) 

            try
            {
                // Create a thread.
                ThreadObject result = apiInstance.CreateThread(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.CreateThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateThreadRequest**](CreateThreadRequest.md)|  | [optional] 

### Return type

[**ThreadObject**](ThreadObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createthreadandrun"></a>
# **CreateThreadAndRun**
> RunObject CreateThreadAndRun (CreateThreadAndRunRequest body)

Create a thread and run it in one request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateThreadAndRunExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new CreateThreadAndRunRequest(); // CreateThreadAndRunRequest | 

            try
            {
                // Create a thread and run it in one request.
                RunObject result = apiInstance.CreateThreadAndRun(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.CreateThreadAndRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateThreadAndRunRequest**](CreateThreadAndRunRequest.md)|  | 

### Return type

[**RunObject**](RunObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteassistant"></a>
# **DeleteAssistant**
> DeleteAssistantResponse DeleteAssistant (string assistantId)

Delete an assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAssistantExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var assistantId = assistantId_example;  // string | The ID of the assistant to delete.

            try
            {
                // Delete an assistant.
                DeleteAssistantResponse result = apiInstance.DeleteAssistant(assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.DeleteAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assistantId** | **string**| The ID of the assistant to delete. | 

### Return type

[**DeleteAssistantResponse**](DeleteAssistantResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteassistantfile"></a>
# **DeleteAssistantFile**
> DeleteAssistantFileResponse DeleteAssistantFile (string assistantId, string fileId)

Delete an assistant file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAssistantFileExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var assistantId = assistantId_example;  // string | The ID of the assistant that the file belongs to.
            var fileId = fileId_example;  // string | The ID of the file to delete.

            try
            {
                // Delete an assistant file.
                DeleteAssistantFileResponse result = apiInstance.DeleteAssistantFile(assistantId, fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.DeleteAssistantFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assistantId** | **string**| The ID of the assistant that the file belongs to. | 
 **fileId** | **string**| The ID of the file to delete. | 

### Return type

[**DeleteAssistantFileResponse**](DeleteAssistantFileResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletethread"></a>
# **DeleteThread**
> DeleteThreadResponse DeleteThread (string threadId)

Delete a thread.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteThreadExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread to delete.

            try
            {
                // Delete a thread.
                DeleteThreadResponse result = apiInstance.DeleteThread(threadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.DeleteThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread to delete. | 

### Return type

[**DeleteThreadResponse**](DeleteThreadResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassistant"></a>
# **GetAssistant**
> AssistantObject GetAssistant (string assistantId)

Retrieves an assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssistantExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var assistantId = assistantId_example;  // string | The ID of the assistant to retrieve.

            try
            {
                // Retrieves an assistant.
                AssistantObject result = apiInstance.GetAssistant(assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.GetAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assistantId** | **string**| The ID of the assistant to retrieve. | 

### Return type

[**AssistantObject**](AssistantObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassistantfile"></a>
# **GetAssistantFile**
> AssistantFileObject GetAssistantFile (string assistantId, string fileId)

Retrieves an AssistantFile.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssistantFileExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var assistantId = assistantId_example;  // string | The ID of the assistant who the file belongs to.
            var fileId = fileId_example;  // string | The ID of the file we're getting.

            try
            {
                // Retrieves an AssistantFile.
                AssistantFileObject result = apiInstance.GetAssistantFile(assistantId, fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.GetAssistantFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assistantId** | **string**| The ID of the assistant who the file belongs to. | 
 **fileId** | **string**| The ID of the file we&#x27;re getting. | 

### Return type

[**AssistantFileObject**](AssistantFileObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmessage"></a>
# **GetMessage**
> MessageObject GetMessage (string threadId, string messageId)

Retrieve a message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMessageExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the [thread](/docs/api-reference/threads) to which this message belongs.
            var messageId = messageId_example;  // string | The ID of the message to retrieve.

            try
            {
                // Retrieve a message.
                MessageObject result = apiInstance.GetMessage(threadId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.GetMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the [thread](/docs/api-reference/threads) to which this message belongs. | 
 **messageId** | **string**| The ID of the message to retrieve. | 

### Return type

[**MessageObject**](MessageObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmessagefile"></a>
# **GetMessageFile**
> MessageFileObject GetMessageFile (string threadId, string messageId, string fileId)

Retrieves a message file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMessageFileExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread to which the message and File belong.
            var messageId = messageId_example;  // string | The ID of the message the file belongs to.
            var fileId = fileId_example;  // string | The ID of the file being retrieved.

            try
            {
                // Retrieves a message file.
                MessageFileObject result = apiInstance.GetMessageFile(threadId, messageId, fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.GetMessageFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread to which the message and File belong. | 
 **messageId** | **string**| The ID of the message the file belongs to. | 
 **fileId** | **string**| The ID of the file being retrieved. | 

### Return type

[**MessageFileObject**](MessageFileObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrun"></a>
# **GetRun**
> RunObject GetRun (string threadId, string runId)

Retrieves a run.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRunExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the [thread](/docs/api-reference/threads) that was run.
            var runId = runId_example;  // string | The ID of the run to retrieve.

            try
            {
                // Retrieves a run.
                RunObject result = apiInstance.GetRun(threadId, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.GetRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the [thread](/docs/api-reference/threads) that was run. | 
 **runId** | **string**| The ID of the run to retrieve. | 

### Return type

[**RunObject**](RunObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrunstep"></a>
# **GetRunStep**
> RunStepObject GetRunStep (string threadId, string runId, string stepId)

Retrieves a run step.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRunStepExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread to which the run and run step belongs.
            var runId = runId_example;  // string | The ID of the run to which the run step belongs.
            var stepId = stepId_example;  // string | The ID of the run step to retrieve.

            try
            {
                // Retrieves a run step.
                RunStepObject result = apiInstance.GetRunStep(threadId, runId, stepId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.GetRunStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread to which the run and run step belongs. | 
 **runId** | **string**| The ID of the run to which the run step belongs. | 
 **stepId** | **string**| The ID of the run step to retrieve. | 

### Return type

[**RunStepObject**](RunStepObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getthread"></a>
# **GetThread**
> ThreadObject GetThread (string threadId)

Retrieves a thread.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetThreadExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread to retrieve.

            try
            {
                // Retrieves a thread.
                ThreadObject result = apiInstance.GetThread(threadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.GetThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread to retrieve. | 

### Return type

[**ThreadObject**](ThreadObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listassistantfiles"></a>
# **ListAssistantFiles**
> ListAssistantFilesResponse ListAssistantFiles (string assistantId, int? limit = null, string order = null, string after = null, string before = null)

Returns a list of assistant files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAssistantFilesExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var assistantId = assistantId_example;  // string | The ID of the assistant the file belongs to.
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  (optional)  (default to 20)
            var order = order_example;  // string | Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.  (optional)  (default to desc)
            var after = after_example;  // string | A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.  (optional) 
            var before = before_example;  // string | A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.  (optional) 

            try
            {
                // Returns a list of assistant files.
                ListAssistantFilesResponse result = apiInstance.ListAssistantFiles(assistantId, limit, order, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ListAssistantFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assistantId** | **string**| The ID of the assistant the file belongs to. | 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  | [optional] [default to 20]
 **order** | **string**| Sort order by the &#x60;created_at&#x60; timestamp of the objects. &#x60;asc&#x60; for ascending order and &#x60;desc&#x60; for descending order.  | [optional] [default to desc]
 **after** | **string**| A cursor for use in pagination. &#x60;after&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after&#x3D;obj_foo in order to fetch the next page of the list.  | [optional] 
 **before** | **string**| A cursor for use in pagination. &#x60;before&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before&#x3D;obj_foo in order to fetch the previous page of the list.  | [optional] 

### Return type

[**ListAssistantFilesResponse**](ListAssistantFilesResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listassistants"></a>
# **ListAssistants**
> ListAssistantsResponse ListAssistants (int? limit = null, string order = null, string after = null, string before = null)

Returns a list of assistants.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAssistantsExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  (optional)  (default to 20)
            var order = order_example;  // string | Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.  (optional)  (default to desc)
            var after = after_example;  // string | A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.  (optional) 
            var before = before_example;  // string | A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.  (optional) 

            try
            {
                // Returns a list of assistants.
                ListAssistantsResponse result = apiInstance.ListAssistants(limit, order, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ListAssistants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  | [optional] [default to 20]
 **order** | **string**| Sort order by the &#x60;created_at&#x60; timestamp of the objects. &#x60;asc&#x60; for ascending order and &#x60;desc&#x60; for descending order.  | [optional] [default to desc]
 **after** | **string**| A cursor for use in pagination. &#x60;after&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after&#x3D;obj_foo in order to fetch the next page of the list.  | [optional] 
 **before** | **string**| A cursor for use in pagination. &#x60;before&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before&#x3D;obj_foo in order to fetch the previous page of the list.  | [optional] 

### Return type

[**ListAssistantsResponse**](ListAssistantsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listmessagefiles"></a>
# **ListMessageFiles**
> ListMessageFilesResponse ListMessageFiles (string threadId, string messageId, int? limit = null, string order = null, string after = null, string before = null)

Returns a list of message files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMessageFilesExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread that the message and files belong to.
            var messageId = messageId_example;  // string | The ID of the message that the files belongs to.
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  (optional)  (default to 20)
            var order = order_example;  // string | Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.  (optional)  (default to desc)
            var after = after_example;  // string | A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.  (optional) 
            var before = before_example;  // string | A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.  (optional) 

            try
            {
                // Returns a list of message files.
                ListMessageFilesResponse result = apiInstance.ListMessageFiles(threadId, messageId, limit, order, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ListMessageFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread that the message and files belong to. | 
 **messageId** | **string**| The ID of the message that the files belongs to. | 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  | [optional] [default to 20]
 **order** | **string**| Sort order by the &#x60;created_at&#x60; timestamp of the objects. &#x60;asc&#x60; for ascending order and &#x60;desc&#x60; for descending order.  | [optional] [default to desc]
 **after** | **string**| A cursor for use in pagination. &#x60;after&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after&#x3D;obj_foo in order to fetch the next page of the list.  | [optional] 
 **before** | **string**| A cursor for use in pagination. &#x60;before&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before&#x3D;obj_foo in order to fetch the previous page of the list.  | [optional] 

### Return type

[**ListMessageFilesResponse**](ListMessageFilesResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listmessages"></a>
# **ListMessages**
> ListMessagesResponse ListMessages (string threadId, int? limit = null, string order = null, string after = null, string before = null)

Returns a list of messages for a given thread.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMessagesExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the [thread](/docs/api-reference/threads) the messages belong to.
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  (optional)  (default to 20)
            var order = order_example;  // string | Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.  (optional)  (default to desc)
            var after = after_example;  // string | A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.  (optional) 
            var before = before_example;  // string | A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.  (optional) 

            try
            {
                // Returns a list of messages for a given thread.
                ListMessagesResponse result = apiInstance.ListMessages(threadId, limit, order, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ListMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the [thread](/docs/api-reference/threads) the messages belong to. | 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  | [optional] [default to 20]
 **order** | **string**| Sort order by the &#x60;created_at&#x60; timestamp of the objects. &#x60;asc&#x60; for ascending order and &#x60;desc&#x60; for descending order.  | [optional] [default to desc]
 **after** | **string**| A cursor for use in pagination. &#x60;after&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after&#x3D;obj_foo in order to fetch the next page of the list.  | [optional] 
 **before** | **string**| A cursor for use in pagination. &#x60;before&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before&#x3D;obj_foo in order to fetch the previous page of the list.  | [optional] 

### Return type

[**ListMessagesResponse**](ListMessagesResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listrunsteps"></a>
# **ListRunSteps**
> ListRunStepsResponse ListRunSteps (string threadId, string runId, int? limit = null, string order = null, string after = null, string before = null)

Returns a list of run steps belonging to a run.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListRunStepsExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread the run and run steps belong to.
            var runId = runId_example;  // string | The ID of the run the run steps belong to.
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  (optional)  (default to 20)
            var order = order_example;  // string | Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.  (optional)  (default to desc)
            var after = after_example;  // string | A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.  (optional) 
            var before = before_example;  // string | A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.  (optional) 

            try
            {
                // Returns a list of run steps belonging to a run.
                ListRunStepsResponse result = apiInstance.ListRunSteps(threadId, runId, limit, order, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ListRunSteps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread the run and run steps belong to. | 
 **runId** | **string**| The ID of the run the run steps belong to. | 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  | [optional] [default to 20]
 **order** | **string**| Sort order by the &#x60;created_at&#x60; timestamp of the objects. &#x60;asc&#x60; for ascending order and &#x60;desc&#x60; for descending order.  | [optional] [default to desc]
 **after** | **string**| A cursor for use in pagination. &#x60;after&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after&#x3D;obj_foo in order to fetch the next page of the list.  | [optional] 
 **before** | **string**| A cursor for use in pagination. &#x60;before&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before&#x3D;obj_foo in order to fetch the previous page of the list.  | [optional] 

### Return type

[**ListRunStepsResponse**](ListRunStepsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listruns"></a>
# **ListRuns**
> ListRunsResponse ListRuns (string threadId, int? limit = null, string order = null, string after = null, string before = null)

Returns a list of runs belonging to a thread.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListRunsExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var threadId = threadId_example;  // string | The ID of the thread the run belongs to.
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  (optional)  (default to 20)
            var order = order_example;  // string | Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.  (optional)  (default to desc)
            var after = after_example;  // string | A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.  (optional) 
            var before = before_example;  // string | A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.  (optional) 

            try
            {
                // Returns a list of runs belonging to a thread.
                ListRunsResponse result = apiInstance.ListRuns(threadId, limit, order, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ListRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| The ID of the thread the run belongs to. | 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.  | [optional] [default to 20]
 **order** | **string**| Sort order by the &#x60;created_at&#x60; timestamp of the objects. &#x60;asc&#x60; for ascending order and &#x60;desc&#x60; for descending order.  | [optional] [default to desc]
 **after** | **string**| A cursor for use in pagination. &#x60;after&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after&#x3D;obj_foo in order to fetch the next page of the list.  | [optional] 
 **before** | **string**| A cursor for use in pagination. &#x60;before&#x60; is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include before&#x3D;obj_foo in order to fetch the previous page of the list.  | [optional] 

### Return type

[**ListRunsResponse**](ListRunsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modifymessage"></a>
# **ModifyMessage**
> MessageObject ModifyMessage (ModifyMessageRequest body, string threadId, string messageId)

Modifies a message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModifyMessageExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new ModifyMessageRequest(); // ModifyMessageRequest | 
            var threadId = threadId_example;  // string | The ID of the thread to which this message belongs.
            var messageId = messageId_example;  // string | The ID of the message to modify.

            try
            {
                // Modifies a message.
                MessageObject result = apiInstance.ModifyMessage(body, threadId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ModifyMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifyMessageRequest**](ModifyMessageRequest.md)|  | 
 **threadId** | **string**| The ID of the thread to which this message belongs. | 
 **messageId** | **string**| The ID of the message to modify. | 

### Return type

[**MessageObject**](MessageObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modifyrun"></a>
# **ModifyRun**
> RunObject ModifyRun (ModifyRunRequest body, string threadId, string runId)

Modifies a run.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModifyRunExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new ModifyRunRequest(); // ModifyRunRequest | 
            var threadId = threadId_example;  // string | The ID of the [thread](/docs/api-reference/threads) that was run.
            var runId = runId_example;  // string | The ID of the run to modify.

            try
            {
                // Modifies a run.
                RunObject result = apiInstance.ModifyRun(body, threadId, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ModifyRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifyRunRequest**](ModifyRunRequest.md)|  | 
 **threadId** | **string**| The ID of the [thread](/docs/api-reference/threads) that was run. | 
 **runId** | **string**| The ID of the run to modify. | 

### Return type

[**RunObject**](RunObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modifythread"></a>
# **ModifyThread**
> ThreadObject ModifyThread (ModifyThreadRequest body, string threadId)

Modifies a thread.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModifyThreadExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new ModifyThreadRequest(); // ModifyThreadRequest | 
            var threadId = threadId_example;  // string | The ID of the thread to modify. Only the `metadata` can be modified.

            try
            {
                // Modifies a thread.
                ThreadObject result = apiInstance.ModifyThread(body, threadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.ModifyThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifyThreadRequest**](ModifyThreadRequest.md)|  | 
 **threadId** | **string**| The ID of the thread to modify. Only the &#x60;metadata&#x60; can be modified. | 

### Return type

[**ThreadObject**](ThreadObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="submittoolouputstorun"></a>
# **SubmitToolOuputsToRun**
> RunObject SubmitToolOuputsToRun (SubmitToolOutputsRunRequest body, string threadId, string runId)

When a run has the `status: \"requires_action\"` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitToolOuputsToRunExample
    {
        public void main()
        {

            var apiInstance = new AssistantsApi();
            var body = new SubmitToolOutputsRunRequest(); // SubmitToolOutputsRunRequest | 
            var threadId = threadId_example;  // string | The ID of the [thread](/docs/api-reference/threads) to which this run belongs.
            var runId = runId_example;  // string | The ID of the run that requires the tool output submission.

            try
            {
                // When a run has the `status: \"requires_action\"` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request. 
                RunObject result = apiInstance.SubmitToolOuputsToRun(body, threadId, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantsApi.SubmitToolOuputsToRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitToolOutputsRunRequest**](SubmitToolOutputsRunRequest.md)|  | 
 **threadId** | **string**| The ID of the [thread](/docs/api-reference/threads) to which this run belongs. | 
 **runId** | **string**| The ID of the run that requires the tool output submission. | 

### Return type

[**RunObject**](RunObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
