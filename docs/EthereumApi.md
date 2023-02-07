# Org.OpenAPITools.Api.EthereumApi

All URIs are relative to *https://api.prod.gallop.run/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEthCollectionFloorPriceOHLC**](EthereumApi.md#getethcollectionfloorpriceohlc) | **POST** /analytics/eth/getCollectionFloorPriceOHLC | Intraday Marketplace Floor Price by Collection |
| [**GetEthCollectionForecasts**](EthereumApi.md#getethcollectionforecasts) | **POST** /insights/eth/getCollectionForecasts | Price Forecast by Collection |
| [**GetEthCollectionListingsOHLC**](EthereumApi.md#getethcollectionlistingsohlc) | **POST** /analytics/eth/getCollectionListingsOHLC | Collection Price Listings Candlesticks |
| [**GetEthCollectionOwners**](EthereumApi.md#getethcollectionowners) | **POST** /data/eth/getCollectionOwners | Wallet Owners by Collection |
| [**GetEthCollectionPriceDiff**](EthereumApi.md#getethcollectionpricediff) | **POST** /analytics/eth/getCollectionPriceDiff | Price Differentiation by Trait |
| [**GetEthCollectionSalesOHLC**](EthereumApi.md#getethcollectionsalesohlc) | **POST** /analytics/eth/getCollectionSalesOHLC | Collection Sales Price Candlesticks |
| [**GetEthCollectionSummary**](EthereumApi.md#getethcollectionsummary) | **POST** /analytics/eth/getCollectionSummary | Summary Statistics by Collection |
| [**GetEthCollectionTransactions**](EthereumApi.md#getethcollectiontransactions) | **POST** /data/eth/getCollectionTransactions | Transactions by Collection |
| [**GetEthCollections**](EthereumApi.md#getethcollections) | **POST** /data/eth/getCollections | Aggregated Collections Supported by Gallop |
| [**GetEthCustomCollectionRisk**](EthereumApi.md#getethcustomcollectionrisk) | **POST** /insights/eth/getCustomCollectionRisk | Custom Volatility &amp; Risk Metrics by Collection |
| [**GetEthCustomTokenRisk**](EthereumApi.md#getethcustomtokenrisk) | **POST** /insights/eth/getCustomTokenRisk | Custom Volatility &amp; Risk Metrics by Token |
| [**GetEthDefaultCollectionRisk**](EthereumApi.md#getethdefaultcollectionrisk) | **POST** /insights/eth/getDefaultCollectionRisk | Default Volatility &amp; Risk Metrics by Collection |
| [**GetEthDefaultTokenRisk**](EthereumApi.md#getethdefaulttokenrisk) | **POST** /insights/eth/getDefaultTokenRisk | Default Volatility &amp; Risk Metrics by Token |
| [**GetEthHistoricalEvents**](EthereumApi.md#getethhistoricalevents) | **POST** /data/eth/getHistoricalEvents | Marketplace Activity by Collection |
| [**GetEthHistoricalTransactions**](EthereumApi.md#getethhistoricaltransactions) | **POST** /data/eth/getHistoricalTransactions | Historical Transactions by Collection |
| [**GetEthLeaderBoard**](EthereumApi.md#getethleaderboard) | **POST** /analytics/eth/getLeaderBoard | Ethereum Leaderboard by Collection |
| [**GetEthMarketplaceData**](EthereumApi.md#getethmarketplacedata) | **POST** /data/eth/getMarketplaceData | Collection Summary by Marketplace |
| [**GetEthMarketplaceFloorPrice**](EthereumApi.md#getethmarketplacefloorprice) | **POST** /data/eth/getMarketplaceFloorPrice | Marketplace Floor Price by Collection |
| [**GetEthMarketplaceTraitData**](EthereumApi.md#getethmarketplacetraitdata) | **POST** /data/eth/getMarketplaceTraitData | Collection Listings by Trait &amp; Marketplace |
| [**GetEthRarity**](EthereumApi.md#getethrarity) | **POST** /analytics/eth/getRarity | Token Rarity by Collection |
| [**GetEthTokenAppraisal**](EthereumApi.md#getethtokenappraisal) | **POST** /insights/eth/getTokenAppraisal | Liquidation &amp; Appraisal Estimate by Token |
| [**GetEthTokenForecasts**](EthereumApi.md#getethtokenforecasts) | **POST** /insights/eth/getTokenForecasts | Price Forecast by Token |
| [**GetEthTokenSummary**](EthereumApi.md#getethtokensummary) | **POST** /analytics/eth/getTokenSummary | Summary Statistics by Token |
| [**GetEthTokenTransactions**](EthereumApi.md#getethtokentransactions) | **POST** /data/eth/getTokenTransactions | Transactions by Token |
| [**GetEthTokens**](EthereumApi.md#getethtokens) | **POST** /data/eth/getTokens | Tokens by Collection |
| [**GetEthWalletLabels**](EthereumApi.md#getethwalletlabels) | **POST** /insights/eth/getWalletLabels | Wallet Activity Labels |
| [**GetEthWalletNFTs**](EthereumApi.md#getethwalletnfts) | **POST** /data/eth/getWalletNFTs | Tokens Owned by Wallet |
| [**GetEthWalletTransactions**](EthereumApi.md#getethwallettransactions) | **POST** /data/eth/getWalletTransactions | Historical Token Transactions by Wallet |
| [**GetEthWashTrade**](EthereumApi.md#getethwashtrade) | **POST** /analytics/eth/getWashTrade | Wash Trades by Transaction |
| [**GetEthWashTransactions**](EthereumApi.md#getethwashtransactions) | **POST** /analytics/eth/getWashTransactions | Wash Trades by Collection |

<a name="getethcollectionfloorpriceohlc"></a>
# **GetEthCollectionFloorPriceOHLC**
> void GetEthCollectionFloorPriceOHLC (GetEthCollectionFloorPriceOHLCRequest getEthCollectionFloorPriceOHLCRequest = null)

Intraday Marketplace Floor Price by Collection

Returns intraday floor price for a given collection by marketplace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEthCollectionFloorPriceOHLCExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionFloorPriceOHLCRequest = new GetEthCollectionFloorPriceOHLCRequest(); // GetEthCollectionFloorPriceOHLCRequest |  (optional) 

            try
            {
                // Intraday Marketplace Floor Price by Collection
                apiInstance.GetEthCollectionFloorPriceOHLC(getEthCollectionFloorPriceOHLCRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionFloorPriceOHLC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionFloorPriceOHLCWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Intraday Marketplace Floor Price by Collection
    apiInstance.GetEthCollectionFloorPriceOHLCWithHttpInfo(getEthCollectionFloorPriceOHLCRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionFloorPriceOHLCWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionFloorPriceOHLCRequest** | [**GetEthCollectionFloorPriceOHLCRequest**](GetEthCollectionFloorPriceOHLCRequest.md) |  | [optional]  |

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

<a name="getethcollectionforecasts"></a>
# **GetEthCollectionForecasts**
> void GetEthCollectionForecasts (GetEthCollectionForecastsRequest getEthCollectionForecastsRequest = null)

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
    public class GetEthCollectionForecastsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionForecastsRequest = new GetEthCollectionForecastsRequest(); // GetEthCollectionForecastsRequest |  (optional) 

            try
            {
                // Price Forecast by Collection
                apiInstance.GetEthCollectionForecasts(getEthCollectionForecastsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionForecasts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionForecastsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Forecast by Collection
    apiInstance.GetEthCollectionForecastsWithHttpInfo(getEthCollectionForecastsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionForecastsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionForecastsRequest** | [**GetEthCollectionForecastsRequest**](GetEthCollectionForecastsRequest.md) |  | [optional]  |

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

<a name="getethcollectionlistingsohlc"></a>
# **GetEthCollectionListingsOHLC**
> void GetEthCollectionListingsOHLC (GetEthCollectionListingsOHLCRequest getEthCollectionListingsOHLCRequest = null)

Collection Price Listings Candlesticks

Returns open, high, low, close candlesticks for collection listings at marketplaces at a selected time interval, as well as the number of active listings and the number of unique owners

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEthCollectionListingsOHLCExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionListingsOHLCRequest = new GetEthCollectionListingsOHLCRequest(); // GetEthCollectionListingsOHLCRequest |  (optional) 

            try
            {
                // Collection Price Listings Candlesticks
                apiInstance.GetEthCollectionListingsOHLC(getEthCollectionListingsOHLCRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionListingsOHLC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionListingsOHLCWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Price Listings Candlesticks
    apiInstance.GetEthCollectionListingsOHLCWithHttpInfo(getEthCollectionListingsOHLCRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionListingsOHLCWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionListingsOHLCRequest** | [**GetEthCollectionListingsOHLCRequest**](GetEthCollectionListingsOHLCRequest.md) |  | [optional]  |

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

<a name="getethcollectionowners"></a>
# **GetEthCollectionOwners**
> void GetEthCollectionOwners (GetEthCollectionOwnersRequest getEthCollectionOwnersRequest = null)

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
    public class GetEthCollectionOwnersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionOwnersRequest = new GetEthCollectionOwnersRequest(); // GetEthCollectionOwnersRequest |  (optional) 

            try
            {
                // Wallet Owners by Collection
                apiInstance.GetEthCollectionOwners(getEthCollectionOwnersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionOwners: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionOwnersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wallet Owners by Collection
    apiInstance.GetEthCollectionOwnersWithHttpInfo(getEthCollectionOwnersRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionOwnersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionOwnersRequest** | [**GetEthCollectionOwnersRequest**](GetEthCollectionOwnersRequest.md) |  | [optional]  |

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

<a name="getethcollectionpricediff"></a>
# **GetEthCollectionPriceDiff**
> void GetEthCollectionPriceDiff (GetEthCollectionPriceDiffRequest getEthCollectionPriceDiffRequest = null)

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
    public class GetEthCollectionPriceDiffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionPriceDiffRequest = new GetEthCollectionPriceDiffRequest(); // GetEthCollectionPriceDiffRequest |  (optional) 

            try
            {
                // Price Differentiation by Trait
                apiInstance.GetEthCollectionPriceDiff(getEthCollectionPriceDiffRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionPriceDiff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionPriceDiffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Differentiation by Trait
    apiInstance.GetEthCollectionPriceDiffWithHttpInfo(getEthCollectionPriceDiffRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionPriceDiffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionPriceDiffRequest** | [**GetEthCollectionPriceDiffRequest**](GetEthCollectionPriceDiffRequest.md) |  | [optional]  |

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

<a name="getethcollectionsalesohlc"></a>
# **GetEthCollectionSalesOHLC**
> void GetEthCollectionSalesOHLC (GetEthCollectionSalesOHLCRequest getEthCollectionSalesOHLCRequest = null)

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
    public class GetEthCollectionSalesOHLCExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionSalesOHLCRequest = new GetEthCollectionSalesOHLCRequest(); // GetEthCollectionSalesOHLCRequest |  (optional) 

            try
            {
                // Collection Sales Price Candlesticks
                apiInstance.GetEthCollectionSalesOHLC(getEthCollectionSalesOHLCRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionSalesOHLC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionSalesOHLCWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Sales Price Candlesticks
    apiInstance.GetEthCollectionSalesOHLCWithHttpInfo(getEthCollectionSalesOHLCRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionSalesOHLCWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionSalesOHLCRequest** | [**GetEthCollectionSalesOHLCRequest**](GetEthCollectionSalesOHLCRequest.md) |  | [optional]  |

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

<a name="getethcollectionsummary"></a>
# **GetEthCollectionSummary**
> void GetEthCollectionSummary (GetEthCollectionSummaryRequest getEthCollectionSummaryRequest = null)

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
    public class GetEthCollectionSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionSummaryRequest = new GetEthCollectionSummaryRequest(); // GetEthCollectionSummaryRequest |  (optional) 

            try
            {
                // Summary Statistics by Collection
                apiInstance.GetEthCollectionSummary(getEthCollectionSummaryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summary Statistics by Collection
    apiInstance.GetEthCollectionSummaryWithHttpInfo(getEthCollectionSummaryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionSummaryRequest** | [**GetEthCollectionSummaryRequest**](GetEthCollectionSummaryRequest.md) |  | [optional]  |

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

<a name="getethcollectiontransactions"></a>
# **GetEthCollectionTransactions**
> void GetEthCollectionTransactions (GetEthCollectionTransactionsRequest getEthCollectionTransactionsRequest = null)

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
    public class GetEthCollectionTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionTransactionsRequest = new GetEthCollectionTransactionsRequest(); // GetEthCollectionTransactionsRequest |  (optional) 

            try
            {
                // Transactions by Collection
                apiInstance.GetEthCollectionTransactions(getEthCollectionTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transactions by Collection
    apiInstance.GetEthCollectionTransactionsWithHttpInfo(getEthCollectionTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionTransactionsRequest** | [**GetEthCollectionTransactionsRequest**](GetEthCollectionTransactionsRequest.md) |  | [optional]  |

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

<a name="getethcollections"></a>
# **GetEthCollections**
> void GetEthCollections (GetEthCollectionsRequest getEthCollectionsRequest = null)

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
    public class GetEthCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionsRequest = new GetEthCollectionsRequest(); // GetEthCollectionsRequest |  (optional) 

            try
            {
                // Aggregated Collections Supported by Gallop
                apiInstance.GetEthCollections(getEthCollectionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Aggregated Collections Supported by Gallop
    apiInstance.GetEthCollectionsWithHttpInfo(getEthCollectionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCollectionsRequest** | [**GetEthCollectionsRequest**](GetEthCollectionsRequest.md) |  | [optional]  |

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

<a name="getethcustomcollectionrisk"></a>
# **GetEthCustomCollectionRisk**
> void GetEthCustomCollectionRisk (GetEthCustomCollectionRiskRequest getEthCustomCollectionRiskRequest = null)

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
    public class GetEthCustomCollectionRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCustomCollectionRiskRequest = new GetEthCustomCollectionRiskRequest(); // GetEthCustomCollectionRiskRequest |  (optional) 

            try
            {
                // Custom Volatility & Risk Metrics by Collection
                apiInstance.GetEthCustomCollectionRisk(getEthCustomCollectionRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCustomCollectionRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCustomCollectionRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom Volatility & Risk Metrics by Collection
    apiInstance.GetEthCustomCollectionRiskWithHttpInfo(getEthCustomCollectionRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCustomCollectionRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCustomCollectionRiskRequest** | [**GetEthCustomCollectionRiskRequest**](GetEthCustomCollectionRiskRequest.md) |  | [optional]  |

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

<a name="getethcustomtokenrisk"></a>
# **GetEthCustomTokenRisk**
> void GetEthCustomTokenRisk (GetEthCustomTokenRiskRequest getEthCustomTokenRiskRequest = null)

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
    public class GetEthCustomTokenRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCustomTokenRiskRequest = new GetEthCustomTokenRiskRequest(); // GetEthCustomTokenRiskRequest |  (optional) 

            try
            {
                // Custom Volatility & Risk Metrics by Token
                apiInstance.GetEthCustomTokenRisk(getEthCustomTokenRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCustomTokenRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthCustomTokenRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom Volatility & Risk Metrics by Token
    apiInstance.GetEthCustomTokenRiskWithHttpInfo(getEthCustomTokenRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthCustomTokenRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthCustomTokenRiskRequest** | [**GetEthCustomTokenRiskRequest**](GetEthCustomTokenRiskRequest.md) |  | [optional]  |

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

<a name="getethdefaultcollectionrisk"></a>
# **GetEthDefaultCollectionRisk**
> void GetEthDefaultCollectionRisk (GetEthDefaultCollectionRiskRequest getEthDefaultCollectionRiskRequest = null)

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
    public class GetEthDefaultCollectionRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthDefaultCollectionRiskRequest = new GetEthDefaultCollectionRiskRequest(); // GetEthDefaultCollectionRiskRequest |  (optional) 

            try
            {
                // Default Volatility & Risk Metrics by Collection
                apiInstance.GetEthDefaultCollectionRisk(getEthDefaultCollectionRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthDefaultCollectionRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthDefaultCollectionRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Default Volatility & Risk Metrics by Collection
    apiInstance.GetEthDefaultCollectionRiskWithHttpInfo(getEthDefaultCollectionRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthDefaultCollectionRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthDefaultCollectionRiskRequest** | [**GetEthDefaultCollectionRiskRequest**](GetEthDefaultCollectionRiskRequest.md) |  | [optional]  |

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

<a name="getethdefaulttokenrisk"></a>
# **GetEthDefaultTokenRisk**
> void GetEthDefaultTokenRisk (GetEthDefaultTokenRiskRequest getEthDefaultTokenRiskRequest = null)

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
    public class GetEthDefaultTokenRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthDefaultTokenRiskRequest = new GetEthDefaultTokenRiskRequest(); // GetEthDefaultTokenRiskRequest |  (optional) 

            try
            {
                // Default Volatility & Risk Metrics by Token
                apiInstance.GetEthDefaultTokenRisk(getEthDefaultTokenRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthDefaultTokenRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthDefaultTokenRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Default Volatility & Risk Metrics by Token
    apiInstance.GetEthDefaultTokenRiskWithHttpInfo(getEthDefaultTokenRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthDefaultTokenRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthDefaultTokenRiskRequest** | [**GetEthDefaultTokenRiskRequest**](GetEthDefaultTokenRiskRequest.md) |  | [optional]  |

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

<a name="getethhistoricalevents"></a>
# **GetEthHistoricalEvents**
> void GetEthHistoricalEvents (GetEthHistoricalEventsRequest getEthHistoricalEventsRequest = null)

Marketplace Activity by Collection

Returns marketplace activity for a given collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEthHistoricalEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthHistoricalEventsRequest = new GetEthHistoricalEventsRequest(); // GetEthHistoricalEventsRequest |  (optional) 

            try
            {
                // Marketplace Activity by Collection
                apiInstance.GetEthHistoricalEvents(getEthHistoricalEventsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthHistoricalEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthHistoricalEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marketplace Activity by Collection
    apiInstance.GetEthHistoricalEventsWithHttpInfo(getEthHistoricalEventsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthHistoricalEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthHistoricalEventsRequest** | [**GetEthHistoricalEventsRequest**](GetEthHistoricalEventsRequest.md) |  | [optional]  |

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

<a name="getethhistoricaltransactions"></a>
# **GetEthHistoricalTransactions**
> void GetEthHistoricalTransactions (GetEthHistoricalTransactionsRequest getEthHistoricalTransactionsRequest = null)

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
    public class GetEthHistoricalTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthHistoricalTransactionsRequest = new GetEthHistoricalTransactionsRequest(); // GetEthHistoricalTransactionsRequest |  (optional) 

            try
            {
                // Historical Transactions by Collection
                apiInstance.GetEthHistoricalTransactions(getEthHistoricalTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthHistoricalTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthHistoricalTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Transactions by Collection
    apiInstance.GetEthHistoricalTransactionsWithHttpInfo(getEthHistoricalTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthHistoricalTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthHistoricalTransactionsRequest** | [**GetEthHistoricalTransactionsRequest**](GetEthHistoricalTransactionsRequest.md) |  | [optional]  |

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

<a name="getethleaderboard"></a>
# **GetEthLeaderBoard**
> void GetEthLeaderBoard (GetEthLeaderBoardRequest getEthLeaderBoardRequest = null)

Ethereum Leaderboard by Collection

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
    public class GetEthLeaderBoardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthLeaderBoardRequest = new GetEthLeaderBoardRequest(); // GetEthLeaderBoardRequest |  (optional) 

            try
            {
                // Ethereum Leaderboard by Collection
                apiInstance.GetEthLeaderBoard(getEthLeaderBoardRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthLeaderBoard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthLeaderBoardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ethereum Leaderboard by Collection
    apiInstance.GetEthLeaderBoardWithHttpInfo(getEthLeaderBoardRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthLeaderBoardWithHttpInfo: " + e.Message);
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

<a name="getethmarketplacedata"></a>
# **GetEthMarketplaceData**
> void GetEthMarketplaceData (GetEthMarketplaceDataRequest getEthMarketplaceDataRequest = null)

Collection Summary by Marketplace

Returns summary statistics for a collection by marketplace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEthMarketplaceDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthMarketplaceDataRequest = new GetEthMarketplaceDataRequest(); // GetEthMarketplaceDataRequest |  (optional) 

            try
            {
                // Collection Summary by Marketplace
                apiInstance.GetEthMarketplaceData(getEthMarketplaceDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthMarketplaceData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthMarketplaceDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Summary by Marketplace
    apiInstance.GetEthMarketplaceDataWithHttpInfo(getEthMarketplaceDataRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthMarketplaceDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthMarketplaceDataRequest** | [**GetEthMarketplaceDataRequest**](GetEthMarketplaceDataRequest.md) |  | [optional]  |

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

<a name="getethmarketplacefloorprice"></a>
# **GetEthMarketplaceFloorPrice**
> void GetEthMarketplaceFloorPrice (GetEthMarketplaceFloorPriceRequest getEthMarketplaceFloorPriceRequest = null)

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
    public class GetEthMarketplaceFloorPriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthMarketplaceFloorPriceRequest = new GetEthMarketplaceFloorPriceRequest(); // GetEthMarketplaceFloorPriceRequest |  (optional) 

            try
            {
                // Marketplace Floor Price by Collection
                apiInstance.GetEthMarketplaceFloorPrice(getEthMarketplaceFloorPriceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthMarketplaceFloorPrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthMarketplaceFloorPriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marketplace Floor Price by Collection
    apiInstance.GetEthMarketplaceFloorPriceWithHttpInfo(getEthMarketplaceFloorPriceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthMarketplaceFloorPriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthMarketplaceFloorPriceRequest** | [**GetEthMarketplaceFloorPriceRequest**](GetEthMarketplaceFloorPriceRequest.md) |  | [optional]  |

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

<a name="getethmarketplacetraitdata"></a>
# **GetEthMarketplaceTraitData**
> void GetEthMarketplaceTraitData (GetEthMarketplaceTraitDataRequest getEthMarketplaceTraitDataRequest = null)

Collection Listings by Trait & Marketplace

Returns listing statistics for a collection by trait and marketplace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEthMarketplaceTraitDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthMarketplaceTraitDataRequest = new GetEthMarketplaceTraitDataRequest(); // GetEthMarketplaceTraitDataRequest |  (optional) 

            try
            {
                // Collection Listings by Trait & Marketplace
                apiInstance.GetEthMarketplaceTraitData(getEthMarketplaceTraitDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthMarketplaceTraitData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthMarketplaceTraitDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Listings by Trait & Marketplace
    apiInstance.GetEthMarketplaceTraitDataWithHttpInfo(getEthMarketplaceTraitDataRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthMarketplaceTraitDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthMarketplaceTraitDataRequest** | [**GetEthMarketplaceTraitDataRequest**](GetEthMarketplaceTraitDataRequest.md) |  | [optional]  |

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

<a name="getethrarity"></a>
# **GetEthRarity**
> void GetEthRarity (GetEthRarityRequest getEthRarityRequest = null)

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
    public class GetEthRarityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthRarityRequest = new GetEthRarityRequest(); // GetEthRarityRequest |  (optional) 

            try
            {
                // Token Rarity by Collection
                apiInstance.GetEthRarity(getEthRarityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthRarity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthRarityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Token Rarity by Collection
    apiInstance.GetEthRarityWithHttpInfo(getEthRarityRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthRarityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthRarityRequest** | [**GetEthRarityRequest**](GetEthRarityRequest.md) |  | [optional]  |

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

<a name="getethtokenappraisal"></a>
# **GetEthTokenAppraisal**
> void GetEthTokenAppraisal (GetEthTokenAppraisalRequest getEthTokenAppraisalRequest = null)

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
    public class GetEthTokenAppraisalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthTokenAppraisalRequest = new GetEthTokenAppraisalRequest(); // GetEthTokenAppraisalRequest |  (optional) 

            try
            {
                // Liquidation & Appraisal Estimate by Token
                apiInstance.GetEthTokenAppraisal(getEthTokenAppraisalRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthTokenAppraisal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthTokenAppraisalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Liquidation & Appraisal Estimate by Token
    apiInstance.GetEthTokenAppraisalWithHttpInfo(getEthTokenAppraisalRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthTokenAppraisalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthTokenAppraisalRequest** | [**GetEthTokenAppraisalRequest**](GetEthTokenAppraisalRequest.md) |  | [optional]  |

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

<a name="getethtokenforecasts"></a>
# **GetEthTokenForecasts**
> void GetEthTokenForecasts (GetEthTokenForecastsRequest getEthTokenForecastsRequest = null)

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
    public class GetEthTokenForecastsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthTokenForecastsRequest = new GetEthTokenForecastsRequest(); // GetEthTokenForecastsRequest |  (optional) 

            try
            {
                // Price Forecast by Token
                apiInstance.GetEthTokenForecasts(getEthTokenForecastsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthTokenForecasts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthTokenForecastsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Forecast by Token
    apiInstance.GetEthTokenForecastsWithHttpInfo(getEthTokenForecastsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthTokenForecastsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthTokenForecastsRequest** | [**GetEthTokenForecastsRequest**](GetEthTokenForecastsRequest.md) |  | [optional]  |

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

<a name="getethtokensummary"></a>
# **GetEthTokenSummary**
> void GetEthTokenSummary (GetEthTokenSummaryRequest getEthTokenSummaryRequest = null)

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
    public class GetEthTokenSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthTokenSummaryRequest = new GetEthTokenSummaryRequest(); // GetEthTokenSummaryRequest |  (optional) 

            try
            {
                // Summary Statistics by Token
                apiInstance.GetEthTokenSummary(getEthTokenSummaryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthTokenSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthTokenSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summary Statistics by Token
    apiInstance.GetEthTokenSummaryWithHttpInfo(getEthTokenSummaryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthTokenSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthTokenSummaryRequest** | [**GetEthTokenSummaryRequest**](GetEthTokenSummaryRequest.md) |  | [optional]  |

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

<a name="getethtokentransactions"></a>
# **GetEthTokenTransactions**
> void GetEthTokenTransactions (GetEthTokenTransactionsRequest getEthTokenTransactionsRequest = null)

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
    public class GetEthTokenTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthTokenTransactionsRequest = new GetEthTokenTransactionsRequest(); // GetEthTokenTransactionsRequest |  (optional) 

            try
            {
                // Transactions by Token
                apiInstance.GetEthTokenTransactions(getEthTokenTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthTokenTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthTokenTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transactions by Token
    apiInstance.GetEthTokenTransactionsWithHttpInfo(getEthTokenTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthTokenTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthTokenTransactionsRequest** | [**GetEthTokenTransactionsRequest**](GetEthTokenTransactionsRequest.md) |  | [optional]  |

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

<a name="getethtokens"></a>
# **GetEthTokens**
> void GetEthTokens (GetEthTokensRequest getEthTokensRequest = null)

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
    public class GetEthTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthTokensRequest = new GetEthTokensRequest(); // GetEthTokensRequest |  (optional) 

            try
            {
                // Tokens by Collection
                apiInstance.GetEthTokens(getEthTokensRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tokens by Collection
    apiInstance.GetEthTokensWithHttpInfo(getEthTokensRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthTokensRequest** | [**GetEthTokensRequest**](GetEthTokensRequest.md) |  | [optional]  |

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

<a name="getethwalletlabels"></a>
# **GetEthWalletLabels**
> void GetEthWalletLabels (GetEthWalletLabelsRequest getEthWalletLabelsRequest = null)

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
    public class GetEthWalletLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthWalletLabelsRequest = new GetEthWalletLabelsRequest(); // GetEthWalletLabelsRequest |  (optional) 

            try
            {
                // Wallet Activity Labels
                apiInstance.GetEthWalletLabels(getEthWalletLabelsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthWalletLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthWalletLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wallet Activity Labels
    apiInstance.GetEthWalletLabelsWithHttpInfo(getEthWalletLabelsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthWalletLabelsWithHttpInfo: " + e.Message);
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

<a name="getethwalletnfts"></a>
# **GetEthWalletNFTs**
> void GetEthWalletNFTs (GetEthWalletNFTsRequest getEthWalletNFTsRequest = null)

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
    public class GetEthWalletNFTsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthWalletNFTsRequest = new GetEthWalletNFTsRequest(); // GetEthWalletNFTsRequest |  (optional) 

            try
            {
                // Tokens Owned by Wallet
                apiInstance.GetEthWalletNFTs(getEthWalletNFTsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthWalletNFTs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthWalletNFTsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tokens Owned by Wallet
    apiInstance.GetEthWalletNFTsWithHttpInfo(getEthWalletNFTsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthWalletNFTsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthWalletNFTsRequest** | [**GetEthWalletNFTsRequest**](GetEthWalletNFTsRequest.md) |  | [optional]  |

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

<a name="getethwallettransactions"></a>
# **GetEthWalletTransactions**
> void GetEthWalletTransactions (GetEthWalletTransactionsRequest getEthWalletTransactionsRequest = null)

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
    public class GetEthWalletTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthWalletTransactionsRequest = new GetEthWalletTransactionsRequest(); // GetEthWalletTransactionsRequest |  (optional) 

            try
            {
                // Historical Token Transactions by Wallet
                apiInstance.GetEthWalletTransactions(getEthWalletTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthWalletTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthWalletTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Token Transactions by Wallet
    apiInstance.GetEthWalletTransactionsWithHttpInfo(getEthWalletTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthWalletTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthWalletTransactionsRequest** | [**GetEthWalletTransactionsRequest**](GetEthWalletTransactionsRequest.md) |  | [optional]  |

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

<a name="getethwashtrade"></a>
# **GetEthWashTrade**
> void GetEthWashTrade (GetEthWashTradeRequest getEthWashTradeRequest = null)

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
    public class GetEthWashTradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthWashTradeRequest = new GetEthWashTradeRequest(); // GetEthWashTradeRequest |  (optional) 

            try
            {
                // Wash Trades by Transaction
                apiInstance.GetEthWashTrade(getEthWashTradeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthWashTrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthWashTradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wash Trades by Transaction
    apiInstance.GetEthWashTradeWithHttpInfo(getEthWashTradeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthWashTradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthWashTradeRequest** | [**GetEthWashTradeRequest**](GetEthWashTradeRequest.md) |  | [optional]  |

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

<a name="getethwashtransactions"></a>
# **GetEthWashTransactions**
> void GetEthWashTransactions (GetEthWashTransactionsRequest getEthWashTransactionsRequest = null)

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
    public class GetEthWashTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthWashTransactionsRequest = new GetEthWashTransactionsRequest(); // GetEthWashTransactionsRequest |  (optional) 

            try
            {
                // Wash Trades by Collection
                apiInstance.GetEthWashTransactions(getEthWashTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthWashTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEthWashTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wash Trades by Collection
    apiInstance.GetEthWashTransactionsWithHttpInfo(getEthWashTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EthereumApi.GetEthWashTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEthWashTransactionsRequest** | [**GetEthWashTransactionsRequest**](GetEthWashTransactionsRequest.md) |  | [optional]  |

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

