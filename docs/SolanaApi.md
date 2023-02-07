# Org.OpenAPITools.Api.SolanaApi

All URIs are relative to *https://api.prod.gallop.run/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSolAccountNFTs**](SolanaApi.md#getsolaccountnfts) | **POST** /data/sol/getAccountNFTs | Tokens Owned by Wallet |
| [**GetSolCollectionForecasts**](SolanaApi.md#getsolcollectionforecasts) | **POST** /insights/sol/getCollectionForecasts | Price Forecast by Collection |
| [**GetSolCollectionPriceDiff**](SolanaApi.md#getsolcollectionpricediff) | **POST** /analytics/sol/getCollectionPriceDiff | Price Differentiation by Trait |
| [**GetSolCollectionSalesOHLC**](SolanaApi.md#getsolcollectionsalesohlc) | **POST** /analytics/sol/getCollectionSalesOHLC | Collection Sales Price Candlesticks |
| [**GetSolCollectionSummary**](SolanaApi.md#getsolcollectionsummary) | **POST** /analytics/sol/getCollectionSummary | Summary Statistics by Collection |
| [**GetSolCollectionTraits**](SolanaApi.md#getsolcollectiontraits) | **POST** /data/sol/getCollectionTraits | Traits by Collection |
| [**GetSolCollectionTransactions**](SolanaApi.md#getsolcollectiontransactions) | **POST** /data/sol/getCollectionTransactions | Transactions by Collections |
| [**GetSolCollections**](SolanaApi.md#getsolcollections) | **POST** /data/sol/getCollections | Aggregated Collections Supported by Gallop |
| [**GetSolCustomCollectionRisk**](SolanaApi.md#getsolcustomcollectionrisk) | **POST** /insights/sol/getCustomCollectionRisk | Custom Volatility &amp; Risk Metrics by Collection |
| [**GetSolCustomTokenRisk**](SolanaApi.md#getsolcustomtokenrisk) | **POST** /insights/sol/getCustomTokenRisk | Custom Volatility &amp; Risk Metrics by Token |
| [**GetSolDefaultCollectionRisk**](SolanaApi.md#getsoldefaultcollectionrisk) | **POST** /insights/sol/getDefaultCollectionRisk | Default Volatility &amp; Risk Metrics by Collection |
| [**GetSolDefaultTokenRisk**](SolanaApi.md#getsoldefaulttokenrisk) | **POST** /insights/sol/getDefaultTokenRisk | Default Volatility &amp; Risk Metrics by Token |
| [**GetSolHistoricalTransactions**](SolanaApi.md#getsolhistoricaltransactions) | **POST** /data/sol/getHistoricalTransactions | Historical Transactions by Collection |
| [**GetSolMarketplaceData**](SolanaApi.md#getsolmarketplacedata) | **POST** /data/sol/getMarketplaceData | Collection Summary by Marketplace |
| [**GetSolMarketplaceFloorPrice**](SolanaApi.md#getsolmarketplacefloorprice) | **POST** /data/sol/getMarketplaceFloorPrice | Marketplace Floor Price by Collection |
| [**GetSolMarketplaceTraitData**](SolanaApi.md#getsolmarketplacetraitdata) | **POST** /data/sol/getMarketplaceTraitData | Collection Listings by Trait &amp; Marketplace |
| [**GetSolNFTAccount**](SolanaApi.md#getsolnftaccount) | **POST** /data/sol/getNFTAccount | Wallet Owners by Token |
| [**GetSolRarity**](SolanaApi.md#getsolrarity) | **POST** /analytics/sol/getRarity | Token Rarity by Collection |
| [**GetSolTokenAppraisal**](SolanaApi.md#getsoltokenappraisal) | **POST** /insights/sol/getTokenAppraisal | Liquidation &amp; Appraisal Estimate by Token |
| [**GetSolTokenForecasts**](SolanaApi.md#getsoltokenforecasts) | **POST** /insights/sol/getTokenForecasts | Price Forecast by Token |
| [**GetSolTokenSummary**](SolanaApi.md#getsoltokensummary) | **POST** /analytics/sol/getTokenSummary | Summary Statistics by Token |
| [**GetSolTokenTransactions**](SolanaApi.md#getsoltokentransactions) | **POST** /data/sol/getTokenTransactions | Transactions by Token |
| [**GetSolTokens**](SolanaApi.md#getsoltokens) | **POST** /data/sol/getTokens | Tokens by Collection |
| [**GetSolWashTrade**](SolanaApi.md#getsolwashtrade) | **POST** /analytics/sol/getWashTrade | Wash Trades by Transaction |
| [**GetSolWashTransactions**](SolanaApi.md#getsolwashtransactions) | **POST** /analytics/sol/getWashTransactions | Wash Trades by Collection |

<a name="getsolaccountnfts"></a>
# **GetSolAccountNFTs**
> void GetSolAccountNFTs (GetSolAccountNFTsRequest getSolAccountNFTsRequest = null)

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
    public class GetSolAccountNFTsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolAccountNFTsRequest = new GetSolAccountNFTsRequest(); // GetSolAccountNFTsRequest |  (optional) 

            try
            {
                // Tokens Owned by Wallet
                apiInstance.GetSolAccountNFTs(getSolAccountNFTsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolAccountNFTs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolAccountNFTsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tokens Owned by Wallet
    apiInstance.GetSolAccountNFTsWithHttpInfo(getSolAccountNFTsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolAccountNFTsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolAccountNFTsRequest** | [**GetSolAccountNFTsRequest**](GetSolAccountNFTsRequest.md) |  | [optional]  |

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

<a name="getsolcollectionforecasts"></a>
# **GetSolCollectionForecasts**
> void GetSolCollectionForecasts (GetSolCollectionForecastsRequest getSolCollectionForecastsRequest = null)

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
    public class GetSolCollectionForecastsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCollectionForecastsRequest = new GetSolCollectionForecastsRequest(); // GetSolCollectionForecastsRequest |  (optional) 

            try
            {
                // Price Forecast by Collection
                apiInstance.GetSolCollectionForecasts(getSolCollectionForecastsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCollectionForecasts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCollectionForecastsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Forecast by Collection
    apiInstance.GetSolCollectionForecastsWithHttpInfo(getSolCollectionForecastsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCollectionForecastsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCollectionForecastsRequest** | [**GetSolCollectionForecastsRequest**](GetSolCollectionForecastsRequest.md) |  | [optional]  |

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

<a name="getsolcollectionpricediff"></a>
# **GetSolCollectionPriceDiff**
> void GetSolCollectionPriceDiff (GetSolCollectionPriceDiffRequest getSolCollectionPriceDiffRequest = null)

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
    public class GetSolCollectionPriceDiffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCollectionPriceDiffRequest = new GetSolCollectionPriceDiffRequest(); // GetSolCollectionPriceDiffRequest |  (optional) 

            try
            {
                // Price Differentiation by Trait
                apiInstance.GetSolCollectionPriceDiff(getSolCollectionPriceDiffRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCollectionPriceDiff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCollectionPriceDiffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Differentiation by Trait
    apiInstance.GetSolCollectionPriceDiffWithHttpInfo(getSolCollectionPriceDiffRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCollectionPriceDiffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCollectionPriceDiffRequest** | [**GetSolCollectionPriceDiffRequest**](GetSolCollectionPriceDiffRequest.md) |  | [optional]  |

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

<a name="getsolcollectionsalesohlc"></a>
# **GetSolCollectionSalesOHLC**
> void GetSolCollectionSalesOHLC (GetSolCollectionSalesOHLCRequest getSolCollectionSalesOHLCRequest = null)

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
    public class GetSolCollectionSalesOHLCExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCollectionSalesOHLCRequest = new GetSolCollectionSalesOHLCRequest(); // GetSolCollectionSalesOHLCRequest |  (optional) 

            try
            {
                // Collection Sales Price Candlesticks
                apiInstance.GetSolCollectionSalesOHLC(getSolCollectionSalesOHLCRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCollectionSalesOHLC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCollectionSalesOHLCWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Sales Price Candlesticks
    apiInstance.GetSolCollectionSalesOHLCWithHttpInfo(getSolCollectionSalesOHLCRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCollectionSalesOHLCWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCollectionSalesOHLCRequest** | [**GetSolCollectionSalesOHLCRequest**](GetSolCollectionSalesOHLCRequest.md) |  | [optional]  |

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

<a name="getsolcollectionsummary"></a>
# **GetSolCollectionSummary**
> void GetSolCollectionSummary (GetSolCollectionSummaryRequest getSolCollectionSummaryRequest = null)

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
    public class GetSolCollectionSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCollectionSummaryRequest = new GetSolCollectionSummaryRequest(); // GetSolCollectionSummaryRequest |  (optional) 

            try
            {
                // Summary Statistics by Collection
                apiInstance.GetSolCollectionSummary(getSolCollectionSummaryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCollectionSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCollectionSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summary Statistics by Collection
    apiInstance.GetSolCollectionSummaryWithHttpInfo(getSolCollectionSummaryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCollectionSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCollectionSummaryRequest** | [**GetSolCollectionSummaryRequest**](GetSolCollectionSummaryRequest.md) |  | [optional]  |

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

<a name="getsolcollectiontraits"></a>
# **GetSolCollectionTraits**
> void GetSolCollectionTraits (GetSolCollectionTraitsRequest getSolCollectionTraitsRequest = null)

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
    public class GetSolCollectionTraitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCollectionTraitsRequest = new GetSolCollectionTraitsRequest(); // GetSolCollectionTraitsRequest |  (optional) 

            try
            {
                // Traits by Collection
                apiInstance.GetSolCollectionTraits(getSolCollectionTraitsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCollectionTraits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCollectionTraitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Traits by Collection
    apiInstance.GetSolCollectionTraitsWithHttpInfo(getSolCollectionTraitsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCollectionTraitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCollectionTraitsRequest** | [**GetSolCollectionTraitsRequest**](GetSolCollectionTraitsRequest.md) |  | [optional]  |

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

<a name="getsolcollectiontransactions"></a>
# **GetSolCollectionTransactions**
> void GetSolCollectionTransactions (GetSolCollectionTransactionsRequest getSolCollectionTransactionsRequest = null)

Transactions by Collections

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
    public class GetSolCollectionTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCollectionTransactionsRequest = new GetSolCollectionTransactionsRequest(); // GetSolCollectionTransactionsRequest |  (optional) 

            try
            {
                // Transactions by Collections
                apiInstance.GetSolCollectionTransactions(getSolCollectionTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCollectionTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCollectionTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transactions by Collections
    apiInstance.GetSolCollectionTransactionsWithHttpInfo(getSolCollectionTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCollectionTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCollectionTransactionsRequest** | [**GetSolCollectionTransactionsRequest**](GetSolCollectionTransactionsRequest.md) |  | [optional]  |

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

<a name="getsolcollections"></a>
# **GetSolCollections**
> void GetSolCollections (GetSolCollectionsRequest getSolCollectionsRequest = null)

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
    public class GetSolCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCollectionsRequest = new GetSolCollectionsRequest(); // GetSolCollectionsRequest |  (optional) 

            try
            {
                // Aggregated Collections Supported by Gallop
                apiInstance.GetSolCollections(getSolCollectionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Aggregated Collections Supported by Gallop
    apiInstance.GetSolCollectionsWithHttpInfo(getSolCollectionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCollectionsRequest** | [**GetSolCollectionsRequest**](GetSolCollectionsRequest.md) |  | [optional]  |

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

<a name="getsolcustomcollectionrisk"></a>
# **GetSolCustomCollectionRisk**
> void GetSolCustomCollectionRisk (GetSolCustomCollectionRiskRequest getSolCustomCollectionRiskRequest = null)

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
    public class GetSolCustomCollectionRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCustomCollectionRiskRequest = new GetSolCustomCollectionRiskRequest(); // GetSolCustomCollectionRiskRequest |  (optional) 

            try
            {
                // Custom Volatility & Risk Metrics by Collection
                apiInstance.GetSolCustomCollectionRisk(getSolCustomCollectionRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCustomCollectionRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCustomCollectionRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom Volatility & Risk Metrics by Collection
    apiInstance.GetSolCustomCollectionRiskWithHttpInfo(getSolCustomCollectionRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCustomCollectionRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCustomCollectionRiskRequest** | [**GetSolCustomCollectionRiskRequest**](GetSolCustomCollectionRiskRequest.md) |  | [optional]  |

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

<a name="getsolcustomtokenrisk"></a>
# **GetSolCustomTokenRisk**
> void GetSolCustomTokenRisk (GetSolCustomTokenRiskRequest getSolCustomTokenRiskRequest = null)

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
    public class GetSolCustomTokenRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolCustomTokenRiskRequest = new GetSolCustomTokenRiskRequest(); // GetSolCustomTokenRiskRequest |  (optional) 

            try
            {
                // Custom Volatility & Risk Metrics by Token
                apiInstance.GetSolCustomTokenRisk(getSolCustomTokenRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolCustomTokenRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolCustomTokenRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom Volatility & Risk Metrics by Token
    apiInstance.GetSolCustomTokenRiskWithHttpInfo(getSolCustomTokenRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolCustomTokenRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolCustomTokenRiskRequest** | [**GetSolCustomTokenRiskRequest**](GetSolCustomTokenRiskRequest.md) |  | [optional]  |

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

<a name="getsoldefaultcollectionrisk"></a>
# **GetSolDefaultCollectionRisk**
> void GetSolDefaultCollectionRisk (GetSolDefaultCollectionRiskRequest getSolDefaultCollectionRiskRequest = null)

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
    public class GetSolDefaultCollectionRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolDefaultCollectionRiskRequest = new GetSolDefaultCollectionRiskRequest(); // GetSolDefaultCollectionRiskRequest |  (optional) 

            try
            {
                // Default Volatility & Risk Metrics by Collection
                apiInstance.GetSolDefaultCollectionRisk(getSolDefaultCollectionRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolDefaultCollectionRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolDefaultCollectionRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Default Volatility & Risk Metrics by Collection
    apiInstance.GetSolDefaultCollectionRiskWithHttpInfo(getSolDefaultCollectionRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolDefaultCollectionRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolDefaultCollectionRiskRequest** | [**GetSolDefaultCollectionRiskRequest**](GetSolDefaultCollectionRiskRequest.md) |  | [optional]  |

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

<a name="getsoldefaulttokenrisk"></a>
# **GetSolDefaultTokenRisk**
> void GetSolDefaultTokenRisk (GetSolDefaultTokenRiskRequest getSolDefaultTokenRiskRequest = null)

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
    public class GetSolDefaultTokenRiskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolDefaultTokenRiskRequest = new GetSolDefaultTokenRiskRequest(); // GetSolDefaultTokenRiskRequest |  (optional) 

            try
            {
                // Default Volatility & Risk Metrics by Token
                apiInstance.GetSolDefaultTokenRisk(getSolDefaultTokenRiskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolDefaultTokenRisk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolDefaultTokenRiskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Default Volatility & Risk Metrics by Token
    apiInstance.GetSolDefaultTokenRiskWithHttpInfo(getSolDefaultTokenRiskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolDefaultTokenRiskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolDefaultTokenRiskRequest** | [**GetSolDefaultTokenRiskRequest**](GetSolDefaultTokenRiskRequest.md) |  | [optional]  |

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

<a name="getsolhistoricaltransactions"></a>
# **GetSolHistoricalTransactions**
> void GetSolHistoricalTransactions (GetSolHistoricalTransactionsRequest getSolHistoricalTransactionsRequest = null)

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
    public class GetSolHistoricalTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolHistoricalTransactionsRequest = new GetSolHistoricalTransactionsRequest(); // GetSolHistoricalTransactionsRequest |  (optional) 

            try
            {
                // Historical Transactions by Collection
                apiInstance.GetSolHistoricalTransactions(getSolHistoricalTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolHistoricalTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolHistoricalTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Transactions by Collection
    apiInstance.GetSolHistoricalTransactionsWithHttpInfo(getSolHistoricalTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolHistoricalTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolHistoricalTransactionsRequest** | [**GetSolHistoricalTransactionsRequest**](GetSolHistoricalTransactionsRequest.md) |  | [optional]  |

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

<a name="getsolmarketplacedata"></a>
# **GetSolMarketplaceData**
> void GetSolMarketplaceData (GetSolMarketplaceDataRequest getSolMarketplaceDataRequest = null)

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
    public class GetSolMarketplaceDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolMarketplaceDataRequest = new GetSolMarketplaceDataRequest(); // GetSolMarketplaceDataRequest |  (optional) 

            try
            {
                // Collection Summary by Marketplace
                apiInstance.GetSolMarketplaceData(getSolMarketplaceDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolMarketplaceData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolMarketplaceDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Summary by Marketplace
    apiInstance.GetSolMarketplaceDataWithHttpInfo(getSolMarketplaceDataRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolMarketplaceDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolMarketplaceDataRequest** | [**GetSolMarketplaceDataRequest**](GetSolMarketplaceDataRequest.md) |  | [optional]  |

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

<a name="getsolmarketplacefloorprice"></a>
# **GetSolMarketplaceFloorPrice**
> void GetSolMarketplaceFloorPrice (GetSolMarketplaceFloorPriceRequest getSolMarketplaceFloorPriceRequest = null)

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
    public class GetSolMarketplaceFloorPriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolMarketplaceFloorPriceRequest = new GetSolMarketplaceFloorPriceRequest(); // GetSolMarketplaceFloorPriceRequest |  (optional) 

            try
            {
                // Marketplace Floor Price by Collection
                apiInstance.GetSolMarketplaceFloorPrice(getSolMarketplaceFloorPriceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolMarketplaceFloorPrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolMarketplaceFloorPriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marketplace Floor Price by Collection
    apiInstance.GetSolMarketplaceFloorPriceWithHttpInfo(getSolMarketplaceFloorPriceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolMarketplaceFloorPriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolMarketplaceFloorPriceRequest** | [**GetSolMarketplaceFloorPriceRequest**](GetSolMarketplaceFloorPriceRequest.md) |  | [optional]  |

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

<a name="getsolmarketplacetraitdata"></a>
# **GetSolMarketplaceTraitData**
> void GetSolMarketplaceTraitData (GetSolMarketplaceTraitDataRequest getSolMarketplaceTraitDataRequest = null)

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
    public class GetSolMarketplaceTraitDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolMarketplaceTraitDataRequest = new GetSolMarketplaceTraitDataRequest(); // GetSolMarketplaceTraitDataRequest |  (optional) 

            try
            {
                // Collection Listings by Trait & Marketplace
                apiInstance.GetSolMarketplaceTraitData(getSolMarketplaceTraitDataRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolMarketplaceTraitData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolMarketplaceTraitDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection Listings by Trait & Marketplace
    apiInstance.GetSolMarketplaceTraitDataWithHttpInfo(getSolMarketplaceTraitDataRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolMarketplaceTraitDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolMarketplaceTraitDataRequest** | [**GetSolMarketplaceTraitDataRequest**](GetSolMarketplaceTraitDataRequest.md) |  | [optional]  |

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

<a name="getsolnftaccount"></a>
# **GetSolNFTAccount**
> void GetSolNFTAccount (GetSolNFTAccountRequest getSolNFTAccountRequest = null)

Wallet Owners by Token

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
    public class GetSolNFTAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolNFTAccountRequest = new GetSolNFTAccountRequest(); // GetSolNFTAccountRequest |  (optional) 

            try
            {
                // Wallet Owners by Token
                apiInstance.GetSolNFTAccount(getSolNFTAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolNFTAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolNFTAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wallet Owners by Token
    apiInstance.GetSolNFTAccountWithHttpInfo(getSolNFTAccountRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolNFTAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolNFTAccountRequest** | [**GetSolNFTAccountRequest**](GetSolNFTAccountRequest.md) |  | [optional]  |

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

<a name="getsolrarity"></a>
# **GetSolRarity**
> void GetSolRarity (GetSolRarityRequest getSolRarityRequest = null)

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
    public class GetSolRarityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolRarityRequest = new GetSolRarityRequest(); // GetSolRarityRequest |  (optional) 

            try
            {
                // Token Rarity by Collection
                apiInstance.GetSolRarity(getSolRarityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolRarity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolRarityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Token Rarity by Collection
    apiInstance.GetSolRarityWithHttpInfo(getSolRarityRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolRarityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolRarityRequest** | [**GetSolRarityRequest**](GetSolRarityRequest.md) |  | [optional]  |

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

<a name="getsoltokenappraisal"></a>
# **GetSolTokenAppraisal**
> void GetSolTokenAppraisal (GetSolTokenAppraisalRequest getSolTokenAppraisalRequest = null)

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
    public class GetSolTokenAppraisalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolTokenAppraisalRequest = new GetSolTokenAppraisalRequest(); // GetSolTokenAppraisalRequest |  (optional) 

            try
            {
                // Liquidation & Appraisal Estimate by Token
                apiInstance.GetSolTokenAppraisal(getSolTokenAppraisalRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolTokenAppraisal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolTokenAppraisalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Liquidation & Appraisal Estimate by Token
    apiInstance.GetSolTokenAppraisalWithHttpInfo(getSolTokenAppraisalRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolTokenAppraisalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolTokenAppraisalRequest** | [**GetSolTokenAppraisalRequest**](GetSolTokenAppraisalRequest.md) |  | [optional]  |

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
| **200** | An object containing appraisal and liquidation value estimates for a (set of) given mint address(es). |  -  |
| **400** | Bad request |  -  |
| **403** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsoltokenforecasts"></a>
# **GetSolTokenForecasts**
> void GetSolTokenForecasts (GetSolTokenForecastsRequest getSolTokenForecastsRequest = null)

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
    public class GetSolTokenForecastsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolTokenForecastsRequest = new GetSolTokenForecastsRequest(); // GetSolTokenForecastsRequest |  (optional) 

            try
            {
                // Price Forecast by Token
                apiInstance.GetSolTokenForecasts(getSolTokenForecastsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolTokenForecasts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolTokenForecastsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price Forecast by Token
    apiInstance.GetSolTokenForecastsWithHttpInfo(getSolTokenForecastsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolTokenForecastsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolTokenForecastsRequest** | [**GetSolTokenForecastsRequest**](GetSolTokenForecastsRequest.md) |  | [optional]  |

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

<a name="getsoltokensummary"></a>
# **GetSolTokenSummary**
> void GetSolTokenSummary (GetSolTokenSummaryRequest getSolTokenSummaryRequest = null)

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
    public class GetSolTokenSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolTokenSummaryRequest = new GetSolTokenSummaryRequest(); // GetSolTokenSummaryRequest |  (optional) 

            try
            {
                // Summary Statistics by Token
                apiInstance.GetSolTokenSummary(getSolTokenSummaryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolTokenSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolTokenSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summary Statistics by Token
    apiInstance.GetSolTokenSummaryWithHttpInfo(getSolTokenSummaryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolTokenSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolTokenSummaryRequest** | [**GetSolTokenSummaryRequest**](GetSolTokenSummaryRequest.md) |  | [optional]  |

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

<a name="getsoltokentransactions"></a>
# **GetSolTokenTransactions**
> void GetSolTokenTransactions (GetSolTokenTransactionsRequest getSolTokenTransactionsRequest = null)

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
    public class GetSolTokenTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolTokenTransactionsRequest = new GetSolTokenTransactionsRequest(); // GetSolTokenTransactionsRequest |  (optional) 

            try
            {
                // Transactions by Token
                apiInstance.GetSolTokenTransactions(getSolTokenTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolTokenTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolTokenTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transactions by Token
    apiInstance.GetSolTokenTransactionsWithHttpInfo(getSolTokenTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolTokenTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolTokenTransactionsRequest** | [**GetSolTokenTransactionsRequest**](GetSolTokenTransactionsRequest.md) |  | [optional]  |

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

<a name="getsoltokens"></a>
# **GetSolTokens**
> void GetSolTokens (GetSolTokensRequest getSolTokensRequest = null)

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
    public class GetSolTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolTokensRequest = new GetSolTokensRequest(); // GetSolTokensRequest |  (optional) 

            try
            {
                // Tokens by Collection
                apiInstance.GetSolTokens(getSolTokensRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tokens by Collection
    apiInstance.GetSolTokensWithHttpInfo(getSolTokensRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolTokensRequest** | [**GetSolTokensRequest**](GetSolTokensRequest.md) |  | [optional]  |

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

<a name="getsolwashtrade"></a>
# **GetSolWashTrade**
> void GetSolWashTrade (GetSolWashTradeRequest getSolWashTradeRequest = null)

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
    public class GetSolWashTradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolWashTradeRequest = new GetSolWashTradeRequest(); // GetSolWashTradeRequest |  (optional) 

            try
            {
                // Wash Trades by Transaction
                apiInstance.GetSolWashTrade(getSolWashTradeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolWashTrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolWashTradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wash Trades by Transaction
    apiInstance.GetSolWashTradeWithHttpInfo(getSolWashTradeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolWashTradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolWashTradeRequest** | [**GetSolWashTradeRequest**](GetSolWashTradeRequest.md) |  | [optional]  |

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

<a name="getsolwashtransactions"></a>
# **GetSolWashTransactions**
> void GetSolWashTransactions (GetSolWashTransactionsRequest getSolWashTransactionsRequest = null)

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
    public class GetSolWashTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SolanaApi(config);
            var getSolWashTransactionsRequest = new GetSolWashTransactionsRequest(); // GetSolWashTransactionsRequest |  (optional) 

            try
            {
                // Wash Trades by Collection
                apiInstance.GetSolWashTransactions(getSolWashTransactionsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolanaApi.GetSolWashTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSolWashTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wash Trades by Collection
    apiInstance.GetSolWashTransactionsWithHttpInfo(getSolWashTransactionsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolanaApi.GetSolWashTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSolWashTransactionsRequest** | [**GetSolWashTransactionsRequest**](GetSolWashTransactionsRequest.md) |  | [optional]  |

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

