# Org.OpenAPITools.Api.PolygonApi

All URIs are relative to *https://api.prod.gallop.run/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPolCollectionForecasts**](PolygonApi.md#getpolcollectionforecasts) | **POST** /insights/pol/getCollectionForecasts | Price Forecast by Collection |
| [**GetPolCollectionOwners**](PolygonApi.md#getpolcollectionowners) | **POST** /data/pol/getCollectionOwners | Wallet Owners by Collection |
| [**GetPolCollectionPriceDiff**](PolygonApi.md#getpolcollectionpricediff) | **POST** /analytics/pol/getCollectionPriceDiff | Price Differentiation by Trait |
| [**GetPolCollectionSalesOHLC**](PolygonApi.md#getpolcollectionsalesohlc) | **POST** /analytics/pol/getCollectionSalesOHLC | Collection Sales Price Candlesticks |
| [**GetPolCollectionSummary**](PolygonApi.md#getpolcollectionsummary) | **POST** /analytics/pol/getCollectionSummary | Summary Statistics by Collection |
| [**GetPolCollectionTraits**](PolygonApi.md#getpolcollectiontraits) | **POST** /data/pol/getCollectionTraits | Traits by Collection |
| [**GetPolCollectionTransactions**](PolygonApi.md#getpolcollectiontransactions) | **POST** /data/pol/getCollectionTransactions | Transactions by Collection |
| [**GetPolCollections**](PolygonApi.md#getpolcollections) | **POST** /data/pol/getCollections | Aggregated Collections Supported by Gallop |
| [**GetPolCustomCollectionRisk**](PolygonApi.md#getpolcustomcollectionrisk) | **POST** /insights/pol/getCustomCollectionRisk | Custom Volatility &amp; Risk Metrics by Collection |
| [**GetPolCustomTokenRisk**](PolygonApi.md#getpolcustomtokenrisk) | **POST** /insights/pol/getCustomTokenRisk | Custom Volatility &amp; Risk Metrics by Token |
| [**GetPolDefaultCollectionRisk**](PolygonApi.md#getpoldefaultcollectionrisk) | **POST** /insights/pol/getDefaultCollectionRisk | Default Volatility &amp; Risk Metrics by Collection |
| [**GetPolDefaultTokenRisk**](PolygonApi.md#getpoldefaulttokenrisk) | **POST** /insights/pol/getDefaultTokenRisk | Default Volatility &amp; Risk Metrics by Token |
| [**GetPolHistoricalTransactions**](PolygonApi.md#getpolhistoricaltransactions) | **POST** /data/pol/getHistoricalTransactions | Historical Transactions by Collection |
| [**GetPolLeaderBoard**](PolygonApi.md#getpolleaderboard) | **POST** /analytics/pol/getLeaderBoard | Polygon Leaderboard by Collection |
| [**GetPolMarketplaceData**](PolygonApi.md#getpolmarketplacedata) | **POST** /data/pol/getMarketplaceData | Collection Summary by Marketplace |
| [**GetPolMarketplaceFloorPrice**](PolygonApi.md#getpolmarketplacefloorprice) | **POST** /data/pol/getMarketplaceFloorPrice | Marketplace Floor Price by Collection |
| [**GetPolRarity**](PolygonApi.md#getpolrarity) | **POST** /analytics/pol/getRarity | Token Rarity by Collection |
| [**GetPolTokenAppraisal**](PolygonApi.md#getpoltokenappraisal) | **POST** /insights/pol/getTokenAppraisal | Liquidation &amp; Appraisal Estimate by Token |
| [**GetPolTokenForecasts**](PolygonApi.md#getpoltokenforecasts) | **POST** /insights/pol/getTokenForecasts | Price Forecast by Token |
| [**GetPolTokenSummary**](PolygonApi.md#getpoltokensummary) | **POST** /analytics/pol/getTokenSummary | Summary Statistics by Token |
| [**GetPolTokenTransactions**](PolygonApi.md#getpoltokentransactions) | **POST** /data/pol/getTokenTransactions | Transactions by Token |
| [**GetPolTokens**](PolygonApi.md#getpoltokens) | **POST** /data/pol/getTokens | Tokens by Collection |
| [**GetPolWalletLabels**](PolygonApi.md#getpolwalletlabels) | **POST** /insights/pol/getWalletLabels | Wallet Activity Labels |
| [**GetPolWalletNFTs**](PolygonApi.md#getpolwalletnfts) | **POST** /data/pol/getWalletNFTs | Tokens Owned by Wallet |
| [**GetPolWalletTransactions**](PolygonApi.md#getpolwallettransactions) | **POST** /data/pol/getWalletTransactions | Historical Token Transactions by Wallet |
| [**GetPolWashTrade**](PolygonApi.md#getpolwashtrade) | **POST** /analytics/pol/getWashTrade | Wash Trades by Transaction |
| [**GetPolWashTransactions**](PolygonApi.md#getpolwashtransactions) | **POST** /analytics/pol/getWashTransactions | Wash Trades by Collection |

<a name="getpolcollectionforecasts"></a>
# **GetPolCollectionForecasts**
> void GetPolCollectionForecasts (GetPolCollectionForecastsRequest getPolCollectionForecastsRequest = null)

Price Forecast by Collection

Returns price, return, and volatility forecast for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionForecastsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionForecastsRequest = new GetPolCollectionForecastsRequest(); // GetPolCollectionForecastsRequest |  (optional) 

            try
            {
                // Price Forecast by Collection
                apiInstance.GetPolCollectionForecasts(getPolCollectionForecastsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollectionForecasts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionForecastsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Forecast by Collection
    apiInstance.GetPolCollectionForecastsWithHttpInfo(getPolCollectionForecastsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionForecastsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionForecastsRequest** | [**GetPolCollectionForecastsRequest**](GetPolCollectionForecastsRequest.md) |  | [optional]  |

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
| **200** | An object containing a set of forecasts for a (set of) collection percentile(s). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolcollectionowners"></a>
# **GetPolCollectionOwners**
> void GetPolCollectionOwners (GetPolCollectionOwnersRequest getPolCollectionOwnersRequest = null)

Wallet Owners by Collection

Returns all wallet owners for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionOwnersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionOwnersRequest = new GetPolCollectionOwnersRequest(); // GetPolCollectionOwnersRequest |  (optional) 

            try
            {
                // Wallet Owners by Collection
                apiInstance.GetPolCollectionOwners(getPolCollectionOwnersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollectionOwners: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionOwnersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wallet Owners by Collection
    apiInstance.GetPolCollectionOwnersWithHttpInfo(getPolCollectionOwnersRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionOwnersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionOwnersRequest** | [**GetPolCollectionOwnersRequest**](GetPolCollectionOwnersRequest.md) |  | [optional]  |

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

<a name="getpolcollectionpricediff"></a>
# **GetPolCollectionPriceDiff**
> void GetPolCollectionPriceDiff (GetPolCollectionPriceDiffRequest getPolCollectionPriceDiffRequest = null)

Price Differentiation by Trait

Returns how trait differentiates price for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionPriceDiffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionPriceDiffRequest = new GetPolCollectionPriceDiffRequest(); // GetPolCollectionPriceDiffRequest |  (optional) 

            try
            {
                // Price Differentiation by Trait
                apiInstance.GetPolCollectionPriceDiff(getPolCollectionPriceDiffRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollectionPriceDiff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionPriceDiffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Differentiation by Trait
    apiInstance.GetPolCollectionPriceDiffWithHttpInfo(getPolCollectionPriceDiffRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionPriceDiffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionPriceDiffRequest** | [**GetPolCollectionPriceDiffRequest**](GetPolCollectionPriceDiffRequest.md) |  | [optional]  |

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
| **200** | An object containing the collection&#39;s price differentiation |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolcollectionsalesohlc"></a>
# **GetPolCollectionSalesOHLC**
> void GetPolCollectionSalesOHLC (GetPolCollectionSalesOHLCRequest getPolCollectionSalesOHLCRequest = null)

Collection Sales Price Candlesticks

Returns collection sales price open, high, low, close and volume at a selected time interval

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionSalesOHLCExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionSalesOHLCRequest = new GetPolCollectionSalesOHLCRequest(); // GetPolCollectionSalesOHLCRequest |  (optional) 

            try
            {
                // Collection Sales Price Candlesticks
                apiInstance.GetPolCollectionSalesOHLC(getPolCollectionSalesOHLCRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollectionSalesOHLC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionSalesOHLCWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Sales Price Candlesticks
    apiInstance.GetPolCollectionSalesOHLCWithHttpInfo(getPolCollectionSalesOHLCRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionSalesOHLCWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionSalesOHLCRequest** | [**GetPolCollectionSalesOHLCRequest**](GetPolCollectionSalesOHLCRequest.md) |  | [optional]  |

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
| **200** | An object containing the collection sales OHLC prices |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolcollectionsummary"></a>
# **GetPolCollectionSummary**
> void GetPolCollectionSummary (GetPolCollectionSummaryRequest getPolCollectionSummaryRequest = null)

Summary Statistics by Collection

Returns summary analytics for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionSummaryRequest = new GetPolCollectionSummaryRequest(); // GetPolCollectionSummaryRequest |  (optional) 

            try
            {
                // Summary Statistics by Collection
                apiInstance.GetPolCollectionSummary(getPolCollectionSummaryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollectionSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summary Statistics by Collection
    apiInstance.GetPolCollectionSummaryWithHttpInfo(getPolCollectionSummaryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionSummaryRequest** | [**GetPolCollectionSummaryRequest**](GetPolCollectionSummaryRequest.md) |  | [optional]  |

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
| **200** | An object containing the collection&#39;s analytical summary. |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolcollectiontraits"></a>
# **GetPolCollectionTraits**
> void GetPolCollectionTraits (GetPolCollectionTraitsRequest getPolCollectionTraitsRequest = null)

Traits by Collection

Returns a list of traits for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionTraitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionTraitsRequest = new GetPolCollectionTraitsRequest(); // GetPolCollectionTraitsRequest |  (optional) 

            try
            {
                // Traits by Collection
                apiInstance.GetPolCollectionTraits(getPolCollectionTraitsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollectionTraits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionTraitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Traits by Collection
    apiInstance.GetPolCollectionTraitsWithHttpInfo(getPolCollectionTraitsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionTraitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionTraitsRequest** | [**GetPolCollectionTraitsRequest**](GetPolCollectionTraitsRequest.md) |  | [optional]  |

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

<a name="getpolcollectiontransactions"></a>
# **GetPolCollectionTransactions**
> void GetPolCollectionTransactions (GetPolCollectionTransactionsRequest getPolCollectionTransactionsRequest = null)

Transactions by Collection

Returns all transactions for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionTransactionsRequest = new GetPolCollectionTransactionsRequest(); // GetPolCollectionTransactionsRequest |  (optional) 

            try
            {
                // Transactions by Collection
                apiInstance.GetPolCollectionTransactions(getPolCollectionTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollectionTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transactions by Collection
    apiInstance.GetPolCollectionTransactionsWithHttpInfo(getPolCollectionTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionTransactionsRequest** | [**GetPolCollectionTransactionsRequest**](GetPolCollectionTransactionsRequest.md) |  | [optional]  |

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

<a name="getpolcollections"></a>
# **GetPolCollections**
> void GetPolCollections (GetPolCollectionsRequest getPolCollectionsRequest = null)

Aggregated Collections Supported by Gallop

Returns all Gallop aggregated collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCollectionsRequest = new GetPolCollectionsRequest(); // GetPolCollectionsRequest |  (optional) 

            try
            {
                // Aggregated Collections Supported by Gallop
                apiInstance.GetPolCollections(getPolCollectionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Aggregated Collections Supported by Gallop
    apiInstance.GetPolCollectionsWithHttpInfo(getPolCollectionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCollectionsRequest** | [**GetPolCollectionsRequest**](GetPolCollectionsRequest.md) |  | [optional]  |

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

<a name="getpolcustomcollectionrisk"></a>
# **GetPolCustomCollectionRisk**
> void GetPolCustomCollectionRisk (GetPolCustomCollectionRiskRequest getPolCustomCollectionRiskRequest = null)

Custom Volatility & Risk Metrics by Collection

Returns summary of customizable volatility and risk metrics for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCustomCollectionRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCustomCollectionRiskRequest = new GetPolCustomCollectionRiskRequest(); // GetPolCustomCollectionRiskRequest |  (optional) 

            try
            {
                // Custom Volatility & Risk Metrics by Collection
                apiInstance.GetPolCustomCollectionRisk(getPolCustomCollectionRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCustomCollectionRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCustomCollectionRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom Volatility & Risk Metrics by Collection
    apiInstance.GetPolCustomCollectionRiskWithHttpInfo(getPolCustomCollectionRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCustomCollectionRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCustomCollectionRiskRequest** | [**GetPolCustomCollectionRiskRequest**](GetPolCustomCollectionRiskRequest.md) |  | [optional]  |

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
| **200** | An object containing a summary of volatility and risk metrics for a (set of) collection percentile(s). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolcustomtokenrisk"></a>
# **GetPolCustomTokenRisk**
> void GetPolCustomTokenRisk (GetPolCustomTokenRiskRequest getPolCustomTokenRiskRequest = null)

Custom Volatility & Risk Metrics by Token

Returns summary of customizable volatility and risk metrics for a given token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolCustomTokenRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolCustomTokenRiskRequest = new GetPolCustomTokenRiskRequest(); // GetPolCustomTokenRiskRequest |  (optional) 

            try
            {
                // Custom Volatility & Risk Metrics by Token
                apiInstance.GetPolCustomTokenRisk(getPolCustomTokenRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolCustomTokenRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolCustomTokenRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom Volatility & Risk Metrics by Token
    apiInstance.GetPolCustomTokenRiskWithHttpInfo(getPolCustomTokenRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolCustomTokenRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolCustomTokenRiskRequest** | [**GetPolCustomTokenRiskRequest**](GetPolCustomTokenRiskRequest.md) |  | [optional]  |

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
| **200** | An object containing a summary of volatility and risk metrics for a (set of) given token id(s). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoldefaultcollectionrisk"></a>
# **GetPolDefaultCollectionRisk**
> void GetPolDefaultCollectionRisk (GetPolDefaultCollectionRiskRequest getPolDefaultCollectionRiskRequest = null)

Default Volatility & Risk Metrics by Collection

Returns summary of default volatility and risk metrics for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolDefaultCollectionRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolDefaultCollectionRiskRequest = new GetPolDefaultCollectionRiskRequest(); // GetPolDefaultCollectionRiskRequest |  (optional) 

            try
            {
                // Default Volatility & Risk Metrics by Collection
                apiInstance.GetPolDefaultCollectionRisk(getPolDefaultCollectionRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolDefaultCollectionRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolDefaultCollectionRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Default Volatility & Risk Metrics by Collection
    apiInstance.GetPolDefaultCollectionRiskWithHttpInfo(getPolDefaultCollectionRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolDefaultCollectionRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolDefaultCollectionRiskRequest** | [**GetPolDefaultCollectionRiskRequest**](GetPolDefaultCollectionRiskRequest.md) |  | [optional]  |

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
| **200** | An object containing a summary of volatility and risk metrics for a (set of) collection percentile(s). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoldefaulttokenrisk"></a>
# **GetPolDefaultTokenRisk**
> void GetPolDefaultTokenRisk (GetPolDefaultTokenRiskRequest getPolDefaultTokenRiskRequest = null)

Default Volatility & Risk Metrics by Token

Returns summary of default volatility and risk metrics for a given token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolDefaultTokenRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolDefaultTokenRiskRequest = new GetPolDefaultTokenRiskRequest(); // GetPolDefaultTokenRiskRequest |  (optional) 

            try
            {
                // Default Volatility & Risk Metrics by Token
                apiInstance.GetPolDefaultTokenRisk(getPolDefaultTokenRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolDefaultTokenRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolDefaultTokenRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Default Volatility & Risk Metrics by Token
    apiInstance.GetPolDefaultTokenRiskWithHttpInfo(getPolDefaultTokenRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolDefaultTokenRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolDefaultTokenRiskRequest** | [**GetPolDefaultTokenRiskRequest**](GetPolDefaultTokenRiskRequest.md) |  | [optional]  |

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
| **200** | An object containing a summary of volatility and risk metrics for a (set of) given token id(s). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolhistoricaltransactions"></a>
# **GetPolHistoricalTransactions**
> void GetPolHistoricalTransactions (GetPolHistoricalTransactionsRequest getPolHistoricalTransactionsRequest = null)

Historical Transactions by Collection

Returns all transactions for a given collection in bulk

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolHistoricalTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolHistoricalTransactionsRequest = new GetPolHistoricalTransactionsRequest(); // GetPolHistoricalTransactionsRequest |  (optional) 

            try
            {
                // Historical Transactions by Collection
                apiInstance.GetPolHistoricalTransactions(getPolHistoricalTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolHistoricalTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolHistoricalTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Transactions by Collection
    apiInstance.GetPolHistoricalTransactionsWithHttpInfo(getPolHistoricalTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolHistoricalTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolHistoricalTransactionsRequest** | [**GetPolHistoricalTransactionsRequest**](GetPolHistoricalTransactionsRequest.md) |  | [optional]  |

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
| **200** | An object of property arrays. |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolleaderboard"></a>
# **GetPolLeaderBoard**
> void GetPolLeaderBoard (GetEthLeaderBoardRequest getEthLeaderBoardRequest = null)

Polygon Leaderboard by Collection

Returns top collections by volume transaction volume or sales count

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolLeaderBoardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getEthLeaderBoardRequest = new GetEthLeaderBoardRequest(); // GetEthLeaderBoardRequest |  (optional) 

            try
            {
                // Polygon Leaderboard by Collection
                apiInstance.GetPolLeaderBoard(getEthLeaderBoardRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolLeaderBoard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolLeaderBoardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Polygon Leaderboard by Collection
    apiInstance.GetPolLeaderBoardWithHttpInfo(getEthLeaderBoardRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolLeaderBoardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthLeaderBoardRequest** | [**GetEthLeaderBoardRequest**](GetEthLeaderBoardRequest.md) |  | [optional]  |

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

<a name="getpolmarketplacedata"></a>
# **GetPolMarketplaceData**
> void GetPolMarketplaceData (GetPolMarketplaceDataRequest getPolMarketplaceDataRequest = null)

Collection Summary by Marketplace

Returns summary statistics for collections by marketplace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolMarketplaceDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolMarketplaceDataRequest = new GetPolMarketplaceDataRequest(); // GetPolMarketplaceDataRequest |  (optional) 

            try
            {
                // Collection Summary by Marketplace
                apiInstance.GetPolMarketplaceData(getPolMarketplaceDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolMarketplaceData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolMarketplaceDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Summary by Marketplace
    apiInstance.GetPolMarketplaceDataWithHttpInfo(getPolMarketplaceDataRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolMarketplaceDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolMarketplaceDataRequest** | [**GetPolMarketplaceDataRequest**](GetPolMarketplaceDataRequest.md) |  | [optional]  |

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

<a name="getpolmarketplacefloorprice"></a>
# **GetPolMarketplaceFloorPrice**
> void GetPolMarketplaceFloorPrice (GetPolMarketplaceFloorPriceRequest getPolMarketplaceFloorPriceRequest = null)

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
    public class GetPolMarketplaceFloorPriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolMarketplaceFloorPriceRequest = new GetPolMarketplaceFloorPriceRequest(); // GetPolMarketplaceFloorPriceRequest |  (optional) 

            try
            {
                // Marketplace Floor Price by Collection
                apiInstance.GetPolMarketplaceFloorPrice(getPolMarketplaceFloorPriceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolMarketplaceFloorPrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolMarketplaceFloorPriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marketplace Floor Price by Collection
    apiInstance.GetPolMarketplaceFloorPriceWithHttpInfo(getPolMarketplaceFloorPriceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolMarketplaceFloorPriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolMarketplaceFloorPriceRequest** | [**GetPolMarketplaceFloorPriceRequest**](GetPolMarketplaceFloorPriceRequest.md) |  | [optional]  |

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

<a name="getpolrarity"></a>
# **GetPolRarity**
> void GetPolRarity (GetPolRarityRequest getPolRarityRequest = null)

Token Rarity by Collection

Returns rarity by token for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolRarityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolRarityRequest = new GetPolRarityRequest(); // GetPolRarityRequest |  (optional) 

            try
            {
                // Token Rarity by Collection
                apiInstance.GetPolRarity(getPolRarityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolRarity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolRarityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Token Rarity by Collection
    apiInstance.GetPolRarityWithHttpInfo(getPolRarityRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolRarityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolRarityRequest** | [**GetPolRarityRequest**](GetPolRarityRequest.md) |  | [optional]  |

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

<a name="getpoltokenappraisal"></a>
# **GetPolTokenAppraisal**
> void GetPolTokenAppraisal (GetPolTokenAppraisalRequest getPolTokenAppraisalRequest = null)

Liquidation & Appraisal Estimate by Token

Get estimates of appraisal and liquidation values for a set of tokens. The app returns nowcasts by default, but if provided a `horizon` and `frequency`, it will return forcasts for `horizon` periods out at interval `frequency`. The app is does not deliver individualized financial advice, but merely provides analytical estimates of token appraisal and liquidation values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolTokenAppraisalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolTokenAppraisalRequest = new GetPolTokenAppraisalRequest(); // GetPolTokenAppraisalRequest |  (optional) 

            try
            {
                // Liquidation & Appraisal Estimate by Token
                apiInstance.GetPolTokenAppraisal(getPolTokenAppraisalRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolTokenAppraisal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolTokenAppraisalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Liquidation & Appraisal Estimate by Token
    apiInstance.GetPolTokenAppraisalWithHttpInfo(getPolTokenAppraisalRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolTokenAppraisalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolTokenAppraisalRequest** | [**GetPolTokenAppraisalRequest**](GetPolTokenAppraisalRequest.md) |  | [optional]  |

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
| **200** | An object containing appraisal and liquidation value estimates for a (set of) given token id(s). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoltokenforecasts"></a>
# **GetPolTokenForecasts**
> void GetPolTokenForecasts (GetPolTokenForecastsRequest getPolTokenForecastsRequest = null)

Price Forecast by Token

Returns price, return, and volatility forecast for a given token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolTokenForecastsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolTokenForecastsRequest = new GetPolTokenForecastsRequest(); // GetPolTokenForecastsRequest |  (optional) 

            try
            {
                // Price Forecast by Token
                apiInstance.GetPolTokenForecasts(getPolTokenForecastsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolTokenForecasts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolTokenForecastsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Forecast by Token
    apiInstance.GetPolTokenForecastsWithHttpInfo(getPolTokenForecastsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolTokenForecastsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolTokenForecastsRequest** | [**GetPolTokenForecastsRequest**](GetPolTokenForecastsRequest.md) |  | [optional]  |

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
| **200** | An object containing a set of forecasts for a (set of) collection percentile(s). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoltokensummary"></a>
# **GetPolTokenSummary**
> void GetPolTokenSummary (GetPolTokenSummaryRequest getPolTokenSummaryRequest = null)

Summary Statistics by Token

Returns summary analytics for a given token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolTokenSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolTokenSummaryRequest = new GetPolTokenSummaryRequest(); // GetPolTokenSummaryRequest |  (optional) 

            try
            {
                // Summary Statistics by Token
                apiInstance.GetPolTokenSummary(getPolTokenSummaryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolTokenSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolTokenSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summary Statistics by Token
    apiInstance.GetPolTokenSummaryWithHttpInfo(getPolTokenSummaryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolTokenSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolTokenSummaryRequest** | [**GetPolTokenSummaryRequest**](GetPolTokenSummaryRequest.md) |  | [optional]  |

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
| **200** | An object containing the token&#39;s analytical summary. |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoltokentransactions"></a>
# **GetPolTokenTransactions**
> void GetPolTokenTransactions (GetPolTokenTransactionsRequest getPolTokenTransactionsRequest = null)

Transactions by Token

Returns all transactions for a given token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolTokenTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolTokenTransactionsRequest = new GetPolTokenTransactionsRequest(); // GetPolTokenTransactionsRequest |  (optional) 

            try
            {
                // Transactions by Token
                apiInstance.GetPolTokenTransactions(getPolTokenTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolTokenTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolTokenTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transactions by Token
    apiInstance.GetPolTokenTransactionsWithHttpInfo(getPolTokenTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolTokenTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolTokenTransactionsRequest** | [**GetPolTokenTransactionsRequest**](GetPolTokenTransactionsRequest.md) |  | [optional]  |

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

<a name="getpoltokens"></a>
# **GetPolTokens**
> void GetPolTokens (GetPolTokensRequest getPolTokensRequest = null)

Tokens by Collection

Returns all tokens for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolTokensRequest = new GetPolTokensRequest(); // GetPolTokensRequest |  (optional) 

            try
            {
                // Tokens by Collection
                apiInstance.GetPolTokens(getPolTokensRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tokens by Collection
    apiInstance.GetPolTokensWithHttpInfo(getPolTokensRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolTokensRequest** | [**GetPolTokensRequest**](GetPolTokensRequest.md) |  | [optional]  |

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

<a name="getpolwalletlabels"></a>
# **GetPolWalletLabels**
> void GetPolWalletLabels (GetEthWalletLabelsRequest getEthWalletLabelsRequest = null)

Wallet Activity Labels

Classifies a wallet's behaviour according to its on-chain activity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolWalletLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getEthWalletLabelsRequest = new GetEthWalletLabelsRequest(); // GetEthWalletLabelsRequest |  (optional) 

            try
            {
                // Wallet Activity Labels
                apiInstance.GetPolWalletLabels(getEthWalletLabelsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolWalletLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolWalletLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wallet Activity Labels
    apiInstance.GetPolWalletLabelsWithHttpInfo(getEthWalletLabelsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolWalletLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthWalletLabelsRequest** | [**GetEthWalletLabelsRequest**](GetEthWalletLabelsRequest.md) |  | [optional]  |

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
| **200** | An object containing the wallet labels |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolwalletnfts"></a>
# **GetPolWalletNFTs**
> void GetPolWalletNFTs (GetPolWalletNFTsRequest getPolWalletNFTsRequest = null)

Tokens Owned by Wallet

Returns all tokens owned for a given wallet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolWalletNFTsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolWalletNFTsRequest = new GetPolWalletNFTsRequest(); // GetPolWalletNFTsRequest |  (optional) 

            try
            {
                // Tokens Owned by Wallet
                apiInstance.GetPolWalletNFTs(getPolWalletNFTsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolWalletNFTs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolWalletNFTsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tokens Owned by Wallet
    apiInstance.GetPolWalletNFTsWithHttpInfo(getPolWalletNFTsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolWalletNFTsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolWalletNFTsRequest** | [**GetPolWalletNFTsRequest**](GetPolWalletNFTsRequest.md) |  | [optional]  |

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
| **200** | An object containing the tokens owned by this wallet |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolwallettransactions"></a>
# **GetPolWalletTransactions**
> void GetPolWalletTransactions (GetPolWalletTransactionsRequest getPolWalletTransactionsRequest = null)

Historical Token Transactions by Wallet

Returns all historical token transactions for a given wallet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolWalletTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolWalletTransactionsRequest = new GetPolWalletTransactionsRequest(); // GetPolWalletTransactionsRequest |  (optional) 

            try
            {
                // Historical Token Transactions by Wallet
                apiInstance.GetPolWalletTransactions(getPolWalletTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolWalletTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolWalletTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Token Transactions by Wallet
    apiInstance.GetPolWalletTransactionsWithHttpInfo(getPolWalletTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolWalletTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolWalletTransactionsRequest** | [**GetPolWalletTransactionsRequest**](GetPolWalletTransactionsRequest.md) |  | [optional]  |

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

<a name="getpolwashtrade"></a>
# **GetPolWashTrade**
> void GetPolWashTrade (GetPolWashTradeRequest getPolWashTradeRequest = null)

Wash Trades by Transaction

Returns suspected wash trades for a given transaction hash

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolWashTradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolWashTradeRequest = new GetPolWashTradeRequest(); // GetPolWashTradeRequest |  (optional) 

            try
            {
                // Wash Trades by Transaction
                apiInstance.GetPolWashTrade(getPolWashTradeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolWashTrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolWashTradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wash Trades by Transaction
    apiInstance.GetPolWashTradeWithHttpInfo(getPolWashTradeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolWashTradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolWashTradeRequest** | [**GetPolWashTradeRequest**](GetPolWashTradeRequest.md) |  | [optional]  |

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

<a name="getpolwashtransactions"></a>
# **GetPolWashTransactions**
> void GetPolWashTransactions (GetPolWashTransactionsRequest getPolWashTransactionsRequest = null)

Wash Trades by Collection

Returns suspected wash trades by token for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPolWashTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PolygonApi(config);
            var getPolWashTransactionsRequest = new GetPolWashTransactionsRequest(); // GetPolWashTransactionsRequest |  (optional) 

            try
            {
                // Wash Trades by Collection
                apiInstance.GetPolWashTransactions(getPolWashTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolygonApi.GetPolWashTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolWashTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wash Trades by Collection
    apiInstance.GetPolWashTransactionsWithHttpInfo(getPolWashTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolygonApi.GetPolWashTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPolWashTransactionsRequest** | [**GetPolWashTransactionsRequest**](GetPolWashTransactionsRequest.md) |  | [optional]  |

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

