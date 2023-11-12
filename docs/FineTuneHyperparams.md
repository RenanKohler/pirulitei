# IO.Swagger.Model.FineTuneHyperparams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchSize** | **int?** | The batch size to use for training. The batch size is the number of training examples used to train a single forward and backward pass.  | 
**ClassificationNClasses** | **int?** | The number of classes to use for computing classification metrics.  | [optional] 
**ClassificationPositiveClass** | **string** | The positive class to use for computing classification metrics.  | [optional] 
**ComputeClassificationMetrics** | **bool?** | The classification metrics to compute using the validation dataset at the end of every epoch.  | [optional] 
**LearningRateMultiplier** | [**decimal?**](BigDecimal.md) | The learning rate multiplier to use for training.  | 
**NEpochs** | **int?** | The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.  | 
**PromptLossWeight** | [**decimal?**](BigDecimal.md) | The weight to use for loss on the prompt tokens.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

