# Org.OpenAPITools.Model.GetEthHistoricalEventsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionAddress** | **string** | The contract address of a collection. | 
**TokenId** | **string** | The id for the token. | [optional] 
**Page** | **int** | The pagination cursor. | [optional] 
**PageSize** | **int** | The number of records returned per page. | [optional] 
**EventDate** | **string** | Only return events occuring after this day [YYYY-MM-DD] | [optional] 
**EventType** | **string** | The type of event: list, transfer, offer, mint, sale, cancel_list or cancel_offer | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

