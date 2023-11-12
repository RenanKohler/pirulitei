# IO.Swagger.Api.FineTuningApi

All URIs are relative to *https://api.openai.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelFineTuningJob**](FineTuningApi.md#cancelfinetuningjob) | **POST** /fine_tuning/jobs/{fine_tuning_job_id}/cancel | Immediately cancel a fine-tune job. 
[**CreateFineTuningJob**](FineTuningApi.md#createfinetuningjob) | **POST** /fine_tuning/jobs | Creates a job that fine-tunes a specified model from a given dataset.  Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 
[**ListFineTuningEvents**](FineTuningApi.md#listfinetuningevents) | **GET** /fine_tuning/jobs/{fine_tuning_job_id}/events | Get status updates for a fine-tuning job. 
[**ListPaginatedFineTuningJobs**](FineTuningApi.md#listpaginatedfinetuningjobs) | **GET** /fine_tuning/jobs | List your organization&#x27;s fine-tuning jobs 
[**RetrieveFineTuningJob**](FineTuningApi.md#retrievefinetuningjob) | **GET** /fine_tuning/jobs/{fine_tuning_job_id} | Get info about a fine-tuning job.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 

<a name="cancelfinetuningjob"></a>
# **CancelFineTuningJob**
> FineTuningJob CancelFineTuningJob (string fineTuningJobId)

Immediately cancel a fine-tune job. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelFineTuningJobExample
    {
        public void main()
        {

            var apiInstance = new FineTuningApi();
            var fineTuningJobId = fineTuningJobId_example;  // string | The ID of the fine-tuning job to cancel. 

            try
            {
                // Immediately cancel a fine-tune job. 
                FineTuningJob result = apiInstance.CancelFineTuningJob(fineTuningJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FineTuningApi.CancelFineTuningJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fineTuningJobId** | **string**| The ID of the fine-tuning job to cancel.  | 

### Return type

[**FineTuningJob**](FineTuningJob.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createfinetuningjob"></a>
# **CreateFineTuningJob**
> FineTuningJob CreateFineTuningJob (CreateFineTuningJobRequest body)

Creates a job that fine-tunes a specified model from a given dataset.  Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFineTuningJobExample
    {
        public void main()
        {

            var apiInstance = new FineTuningApi();
            var body = new CreateFineTuningJobRequest(); // CreateFineTuningJobRequest | 

            try
            {
                // Creates a job that fine-tunes a specified model from a given dataset.  Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 
                FineTuningJob result = apiInstance.CreateFineTuningJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FineTuningApi.CreateFineTuningJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateFineTuningJobRequest**](CreateFineTuningJobRequest.md)|  | 

### Return type

[**FineTuningJob**](FineTuningJob.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listfinetuningevents"></a>
# **ListFineTuningEvents**
> ListFineTuningJobEventsResponse ListFineTuningEvents (string fineTuningJobId, string after = null, int? limit = null)

Get status updates for a fine-tuning job. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListFineTuningEventsExample
    {
        public void main()
        {

            var apiInstance = new FineTuningApi();
            var fineTuningJobId = fineTuningJobId_example;  // string | The ID of the fine-tuning job to get events for. 
            var after = after_example;  // string | Identifier for the last event from the previous pagination request. (optional) 
            var limit = 56;  // int? | Number of events to retrieve. (optional)  (default to 20)

            try
            {
                // Get status updates for a fine-tuning job. 
                ListFineTuningJobEventsResponse result = apiInstance.ListFineTuningEvents(fineTuningJobId, after, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FineTuningApi.ListFineTuningEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fineTuningJobId** | **string**| The ID of the fine-tuning job to get events for.  | 
 **after** | **string**| Identifier for the last event from the previous pagination request. | [optional] 
 **limit** | **int?**| Number of events to retrieve. | [optional] [default to 20]

### Return type

[**ListFineTuningJobEventsResponse**](ListFineTuningJobEventsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listpaginatedfinetuningjobs"></a>
# **ListPaginatedFineTuningJobs**
> ListPaginatedFineTuningJobsResponse ListPaginatedFineTuningJobs (string after = null, int? limit = null)

List your organization's fine-tuning jobs 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPaginatedFineTuningJobsExample
    {
        public void main()
        {

            var apiInstance = new FineTuningApi();
            var after = after_example;  // string | Identifier for the last job from the previous pagination request. (optional) 
            var limit = 56;  // int? | Number of fine-tuning jobs to retrieve. (optional)  (default to 20)

            try
            {
                // List your organization's fine-tuning jobs 
                ListPaginatedFineTuningJobsResponse result = apiInstance.ListPaginatedFineTuningJobs(after, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FineTuningApi.ListPaginatedFineTuningJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **string**| Identifier for the last job from the previous pagination request. | [optional] 
 **limit** | **int?**| Number of fine-tuning jobs to retrieve. | [optional] [default to 20]

### Return type

[**ListPaginatedFineTuningJobsResponse**](ListPaginatedFineTuningJobsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievefinetuningjob"></a>
# **RetrieveFineTuningJob**
> FineTuningJob RetrieveFineTuningJob (string fineTuningJobId)

Get info about a fine-tuning job.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveFineTuningJobExample
    {
        public void main()
        {

            var apiInstance = new FineTuningApi();
            var fineTuningJobId = fineTuningJobId_example;  // string | The ID of the fine-tuning job. 

            try
            {
                // Get info about a fine-tuning job.  [Learn more about fine-tuning](/docs/guides/fine-tuning) 
                FineTuningJob result = apiInstance.RetrieveFineTuningJob(fineTuningJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FineTuningApi.RetrieveFineTuningJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fineTuningJobId** | **string**| The ID of the fine-tuning job.  | 

### Return type

[**FineTuningJob**](FineTuningJob.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
