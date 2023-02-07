# Org.OpenAPITools.Api.StarknetApi

All URIs are relative to *https://api.prod.gallop.run/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSknMarketplaceData**](StarknetApi.md#getsknmarketplacedata) | **POST** /data/skn/getMarketplaceData | Gallop Marketplace Data |
| [**GetSknMarketplaceFloorPrice**](StarknetApi.md#getsknmarketplacefloorprice) | **POST** /data/skn/getMarketplaceFloorPrice | Marketplace Floor Price by Collection |

<a name="getsknmarketplacedata"></a>
# **GetSknMarketplaceData**
> void GetSknMarketplaceData (GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = null)

Gallop Marketplace Data

Lists marketplace data from contract address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSknMarketplaceDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new StarknetApi(config);
            var getSknMarketplaceDataRequest = new GetSknMarketplaceDataRequest(); // GetSknMarketplaceDataRequest |  (optional) 

            try
            {
                // Gallop Marketplace Data
                apiInstance.GetSknMarketplaceData(getSknMarketplaceDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StarknetApi.GetSknMarketplaceData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSknMarketplaceDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gallop Marketplace Data
    apiInstance.GetSknMarketplaceDataWithHttpInfo(getSknMarketplaceDataRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StarknetApi.GetSknMarketplaceDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSknMarketplaceDataRequest** | [**GetSknMarketplaceDataRequest**](GetSknMarketplaceDataRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsknmarketplacefloorprice"></a>
# **GetSknMarketplaceFloorPrice**
> void GetSknMarketplaceFloorPrice (GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = null)

Marketplace Floor Price by Collection

Returns current floor price for all collections by marketplace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSknMarketplaceFloorPriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new StarknetApi(config);
            var getSknMarketplaceFloorPriceRequest = new GetSknMarketplaceFloorPriceRequest(); // GetSknMarketplaceFloorPriceRequest |  (optional) 

            try
            {
                // Marketplace Floor Price by Collection
                apiInstance.GetSknMarketplaceFloorPrice(getSknMarketplaceFloorPriceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StarknetApi.GetSknMarketplaceFloorPrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSknMarketplaceFloorPriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marketplace Floor Price by Collection
    apiInstance.GetSknMarketplaceFloorPriceWithHttpInfo(getSknMarketplaceFloorPriceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StarknetApi.GetSknMarketplaceFloorPriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSknMarketplaceFloorPriceRequest** | [**GetSknMarketplaceFloorPriceRequest**](GetSknMarketplaceFloorPriceRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

