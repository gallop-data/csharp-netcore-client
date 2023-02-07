# Org.OpenAPITools.Model.GetEthTokenForecastsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionAddress** | **string** | The contract address of the token collection. | 
**TokenId** | **List&lt;string&gt;** | The id(s) for the token(s). | 
**Voltype** | **string** | Type of statistical forecasting model to be calculated as a 3-char string, e.g. &#x60;arc&#x60; for ARCH | [optional] 
**Horizon** | **int** | The forecast horizon (i.e. the number of periods to forecast out) | [optional] 
**Frequency** | **string** | The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc. | [optional] 
**Dist** | **string** | The distribution assumed to calculate parametric risk for. | [optional] 
**StartDate** | **string** | The start date to pull data for calculations | [optional] 
**EndDate** | **string** | The end date to pull data for calculations | [optional] 
**ReturnPriceForecasts** | **bool** | Set to True, returns confidencve intervals at alpha significance for price on top of forecasts for returns and volatilities | [optional] 
**Alpha** | **decimal** | The significance level, e.g. 0.05 for 95% confidence | [optional] 
**ReptCurr** | **string** | The currency to report results in | [optional] 
**ExcludeWash** | **bool** | Exclude suspected wash transactions? | [optional] 
**ArchParams** | [**GetEthCollectionForecastsRequestArchParams**](GetEthCollectionForecastsRequestArchParams.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

