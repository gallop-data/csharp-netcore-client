# Org.OpenAPITools.Model.GetEthTokenAppraisalRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionAddress** | **string** | The contract address of the token collection. | 
**TokenId** | **List&lt;string&gt;** | The id(s) for the token(s). | 
**ReptCurr** | **string** | The currency to report results in | [optional] 
**Frequency** | **string** | The interval at which to calculate intermediate results and forecasts. | [optional] 
**Horizon** | **int** | The forecast horizon (i.e. the number of periods to forecast out). Defaults to zero which only returns nowcasts. | [optional] 
**Alpha** | **decimal** | The significance level for the liquidation estimate, e.g. 0.05 for 95% confidence | [optional] 
**ExcludeWash** | **bool** | Exclude suspected wash transactions? | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

