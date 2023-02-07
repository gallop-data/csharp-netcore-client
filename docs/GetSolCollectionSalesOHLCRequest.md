# Org.OpenAPITools.Model.GetSolCollectionSalesOHLCRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionTag** | **string** | The Gallop tag to identify the collection. | 
**Frequency** | **string** | The interval at which to return OHLC, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc. | [optional] 
**GroupBy** | **string** | An attribute of the NFT to group results by. | [optional] 
**Volume** | **bool** | If &#39;true&#39;, response dicts contain OHLCV | [optional] 
**ReptCurr** | **string** | The currency to report results in | [optional] 
**StartDate** | **string** | The start date to pull data for calculations | [optional] 
**EndDate** | **string** | The end date to pull data for calculations | [optional] 
**ExcludeWash** | **bool** | Exclude suspected wash transactions? | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

