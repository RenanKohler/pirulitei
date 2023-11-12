# IO.Swagger.Model.CreateFineTuningJobRequestHyperparameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchSize** | **OneOfCreateFineTuningJobRequestHyperparametersBatchSize** | Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.  | [optional] [default to auto]
**LearningRateMultiplier** | **OneOfCreateFineTuningJobRequestHyperparametersLearningRateMultiplier** | Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.  | [optional] [default to auto]
**NEpochs** | **OneOfCreateFineTuningJobRequestHyperparametersNEpochs** | The number of epochs to train the model for. An epoch refers to one full cycle  through the training dataset.  | [optional] [default to auto]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

