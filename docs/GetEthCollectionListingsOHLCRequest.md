# Org.OpenAPITools.Model.GetEthCollectionListingsOHLCRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionAddress** | **string** | The Ethereum contract address to identify the collection. | 
**FloorOnly** | **bool** | If &#x60;true&#x60;, report only historical floor prices. Otherwise, report OHFC candlesticks, number of active listings, number of unique owners and the average age of open listings. | [optional] 
**Frequency** | **string** | The interval at which to return Floor prices / OHLF, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc. Must be &gt;&#x3D; &#x60;6H&#x60; | [optional] 
**ReptCurr** | **string** | The currency to report results in | [optional] 
**ReportStartDate** | **string** | The ISO 8601 start date/datetime to return results for | [optional] 
**ReportEndDate** | **string** | The ISO 8601 end date/datetime to return results for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

