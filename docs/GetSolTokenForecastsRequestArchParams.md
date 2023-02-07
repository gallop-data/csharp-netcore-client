# Org.OpenAPITools.Model.GetSolTokenForecastsRequestArchParams
JSON containing options for the ARCH family model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mean** | **string** | Estimator for the location model of the time series, e.g: &#x60;Zero&#x60;, &#x60;Constant&#x60;, &#x60;ARX&#x60;, ... .  | [optional] 
**Lags** | **int** | Number of time time period lags considered. Note that the time period is set by the &#x60;frequency&#x60; parameter, so a value of 2 will assume 2-day lags if &#x60;frequency&#x3D;&#x3D;&#39;1D&#39;&#x60;. | [optional] 
**Vol** | **string** | Estimator used for the volatility process of the time series, e.g: &#x60;Constant&#x60;, &#x60;ARCH&#x60;, &#x60;GARCH&#x60;, ...  | [optional] 
**P** | **int** | Order of the symmetric innovation(s). | [optional] 
**Dist** | **string** | Return distribution assumed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

