# Org.OpenAPITools.Model.GetEthDefaultTokenRiskRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionAddress** | **string** | The contract address of the token collection. | 
**TokenId** | **List&lt;string&gt;** | The id(s) for the token(s). | 
**HoldingPeriod** | **string** | The holding period to evaluate risk for, e.g. &#39;12M&#39; | 
**ReptCurr** | **string** | The currency to report results in | [optional] 
**Drawdown** | **bool** | If true, report drawdown volatility (based on negative returns only). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

