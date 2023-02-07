# Org.OpenAPITools.Model.GetEthCustomCollectionRiskRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionAddress** | **string** | The contract address of the token collection. | 
**HoldingPeriod** | **string** | The holding period to evaluate risk for, e.g. &#x60;12M&#x60; | 
**Percentiles** | **List&lt;int&gt;** | The collection percentile(s) | [optional] 
**Amount** | **int** | The amount of tokens in your portfolio | [optional] 
**Dist** | **string** | The distribution assumed to calculate parametric risk for | [optional] 
**StartDate** | **string** | The start date to pull data for calculations | [optional] 
**EndDate** | **string** | The end date to pull data for calculations | [optional] 
**RiskFreeRate** | **decimal** | The rate of return for an asset deemed risk free in the contemplated holding period | [optional] 
**WinsOutliers** | **bool** | Whether to winsorize time series outliers prior to calculating risk | [optional] 
**Frequency** | **string** | The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc. | [optional] 
**ReptCurr** | **string** | The currency to report results in | [optional] 
**ExcludeWash** | **bool** | Exclude suspected wash transactions? | [optional] 
**Drawdown** | **bool** | If true, report drawdown volatility (based on negative returns only). | [optional] 
**ArcParams** | [**GetEthCustomCollectionRiskRequestArcParams**](GetEthCustomCollectionRiskRequestArcParams.md) |  | [optional] 
**GarParams** | [**GetEthCustomCollectionRiskRequestGarParams**](GetEthCustomCollectionRiskRequestGarParams.md) |  | [optional] 
**HarParams** | [**GetEthCustomCollectionRiskRequestHarParams**](GetEthCustomCollectionRiskRequestHarParams.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

