# Org.OpenAPITools - the C# library for the Gallop API

Data and insights APIs, webooks, and dashboards enabling businesses to launch tokenized products in seconds.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.gallop.run/v1";
            // Configure API key authorization: api_key
            config.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new EthereumApi(config);
            var getEthCollectionFloorPriceOHLCRequest = new GetEthCollectionFloorPriceOHLCRequest(); // GetEthCollectionFloorPriceOHLCRequest |  (optional) 

            try
            {
                // Intraday Marketplace Floor Price by Collection
                apiInstance.GetEthCollectionFloorPriceOHLC(getEthCollectionFloorPriceOHLCRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EthereumApi.GetEthCollectionFloorPriceOHLC: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.prod.gallop.run/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*EthereumApi* | [**GetEthCollectionFloorPriceOHLC**](docs/EthereumApi.md#getethcollectionfloorpriceohlc) | **POST** /analytics/eth/getCollectionFloorPriceOHLC | Intraday Marketplace Floor Price by Collection
*EthereumApi* | [**GetEthCollectionForecasts**](docs/EthereumApi.md#getethcollectionforecasts) | **POST** /insights/eth/getCollectionForecasts | Price Forecast by Collection
*EthereumApi* | [**GetEthCollectionListingsOHLC**](docs/EthereumApi.md#getethcollectionlistingsohlc) | **POST** /analytics/eth/getCollectionListingsOHLC | Collection Price Listings Candlesticks
*EthereumApi* | [**GetEthCollectionOwners**](docs/EthereumApi.md#getethcollectionowners) | **POST** /data/eth/getCollectionOwners | Wallet Owners by Collection
*EthereumApi* | [**GetEthCollectionPriceDiff**](docs/EthereumApi.md#getethcollectionpricediff) | **POST** /analytics/eth/getCollectionPriceDiff | Price Differentiation by Trait
*EthereumApi* | [**GetEthCollectionSalesOHLC**](docs/EthereumApi.md#getethcollectionsalesohlc) | **POST** /analytics/eth/getCollectionSalesOHLC | Collection Sales Price Candlesticks
*EthereumApi* | [**GetEthCollectionSummary**](docs/EthereumApi.md#getethcollectionsummary) | **POST** /analytics/eth/getCollectionSummary | Summary Statistics by Collection
*EthereumApi* | [**GetEthCollectionTransactions**](docs/EthereumApi.md#getethcollectiontransactions) | **POST** /data/eth/getCollectionTransactions | Transactions by Collection
*EthereumApi* | [**GetEthCollections**](docs/EthereumApi.md#getethcollections) | **POST** /data/eth/getCollections | Aggregated Collections Supported by Gallop
*EthereumApi* | [**GetEthCustomCollectionRisk**](docs/EthereumApi.md#getethcustomcollectionrisk) | **POST** /insights/eth/getCustomCollectionRisk | Custom Volatility & Risk Metrics by Collection
*EthereumApi* | [**GetEthCustomTokenRisk**](docs/EthereumApi.md#getethcustomtokenrisk) | **POST** /insights/eth/getCustomTokenRisk | Custom Volatility & Risk Metrics by Token
*EthereumApi* | [**GetEthDefaultCollectionRisk**](docs/EthereumApi.md#getethdefaultcollectionrisk) | **POST** /insights/eth/getDefaultCollectionRisk | Default Volatility & Risk Metrics by Collection
*EthereumApi* | [**GetEthDefaultTokenRisk**](docs/EthereumApi.md#getethdefaulttokenrisk) | **POST** /insights/eth/getDefaultTokenRisk | Default Volatility & Risk Metrics by Token
*EthereumApi* | [**GetEthHistoricalEvents**](docs/EthereumApi.md#getethhistoricalevents) | **POST** /data/eth/getHistoricalEvents | Marketplace Activity by Collection
*EthereumApi* | [**GetEthHistoricalTransactions**](docs/EthereumApi.md#getethhistoricaltransactions) | **POST** /data/eth/getHistoricalTransactions | Historical Transactions by Collection
*EthereumApi* | [**GetEthLeaderBoard**](docs/EthereumApi.md#getethleaderboard) | **POST** /analytics/eth/getLeaderBoard | Ethereum Leaderboard by Collection
*EthereumApi* | [**GetEthMarketplaceData**](docs/EthereumApi.md#getethmarketplacedata) | **POST** /data/eth/getMarketplaceData | Collection Summary by Marketplace
*EthereumApi* | [**GetEthMarketplaceFloorPrice**](docs/EthereumApi.md#getethmarketplacefloorprice) | **POST** /data/eth/getMarketplaceFloorPrice | Marketplace Floor Price by Collection
*EthereumApi* | [**GetEthMarketplaceTraitData**](docs/EthereumApi.md#getethmarketplacetraitdata) | **POST** /data/eth/getMarketplaceTraitData | Collection Listings by Trait & Marketplace
*EthereumApi* | [**GetEthRarity**](docs/EthereumApi.md#getethrarity) | **POST** /analytics/eth/getRarity | Token Rarity by Collection
*EthereumApi* | [**GetEthTokenAppraisal**](docs/EthereumApi.md#getethtokenappraisal) | **POST** /insights/eth/getTokenAppraisal | Liquidation & Appraisal Estimate by Token
*EthereumApi* | [**GetEthTokenForecasts**](docs/EthereumApi.md#getethtokenforecasts) | **POST** /insights/eth/getTokenForecasts | Price Forecast by Token
*EthereumApi* | [**GetEthTokenSummary**](docs/EthereumApi.md#getethtokensummary) | **POST** /analytics/eth/getTokenSummary | Summary Statistics by Token
*EthereumApi* | [**GetEthTokenTransactions**](docs/EthereumApi.md#getethtokentransactions) | **POST** /data/eth/getTokenTransactions | Transactions by Token
*EthereumApi* | [**GetEthTokens**](docs/EthereumApi.md#getethtokens) | **POST** /data/eth/getTokens | Tokens by Collection
*EthereumApi* | [**GetEthWalletLabels**](docs/EthereumApi.md#getethwalletlabels) | **POST** /insights/eth/getWalletLabels | Wallet Activity Labels
*EthereumApi* | [**GetEthWalletNFTs**](docs/EthereumApi.md#getethwalletnfts) | **POST** /data/eth/getWalletNFTs | Tokens Owned by Wallet
*EthereumApi* | [**GetEthWalletTransactions**](docs/EthereumApi.md#getethwallettransactions) | **POST** /data/eth/getWalletTransactions | Historical Token Transactions by Wallet
*EthereumApi* | [**GetEthWashTrade**](docs/EthereumApi.md#getethwashtrade) | **POST** /analytics/eth/getWashTrade | Wash Trades by Transaction
*EthereumApi* | [**GetEthWashTransactions**](docs/EthereumApi.md#getethwashtransactions) | **POST** /analytics/eth/getWashTransactions | Wash Trades by Collection
*PolygonApi* | [**GetPolCollectionForecasts**](docs/PolygonApi.md#getpolcollectionforecasts) | **POST** /insights/pol/getCollectionForecasts | Price Forecast by Collection
*PolygonApi* | [**GetPolCollectionOwners**](docs/PolygonApi.md#getpolcollectionowners) | **POST** /data/pol/getCollectionOwners | Wallet Owners by Collection
*PolygonApi* | [**GetPolCollectionPriceDiff**](docs/PolygonApi.md#getpolcollectionpricediff) | **POST** /analytics/pol/getCollectionPriceDiff | Price Differentiation by Trait
*PolygonApi* | [**GetPolCollectionSalesOHLC**](docs/PolygonApi.md#getpolcollectionsalesohlc) | **POST** /analytics/pol/getCollectionSalesOHLC | Collection Sales Price Candlesticks
*PolygonApi* | [**GetPolCollectionSummary**](docs/PolygonApi.md#getpolcollectionsummary) | **POST** /analytics/pol/getCollectionSummary | Summary Statistics by Collection
*PolygonApi* | [**GetPolCollectionTraits**](docs/PolygonApi.md#getpolcollectiontraits) | **POST** /data/pol/getCollectionTraits | Traits by Collection
*PolygonApi* | [**GetPolCollectionTransactions**](docs/PolygonApi.md#getpolcollectiontransactions) | **POST** /data/pol/getCollectionTransactions | Transactions by Collection
*PolygonApi* | [**GetPolCollections**](docs/PolygonApi.md#getpolcollections) | **POST** /data/pol/getCollections | Aggregated Collections Supported by Gallop
*PolygonApi* | [**GetPolCustomCollectionRisk**](docs/PolygonApi.md#getpolcustomcollectionrisk) | **POST** /insights/pol/getCustomCollectionRisk | Custom Volatility & Risk Metrics by Collection
*PolygonApi* | [**GetPolCustomTokenRisk**](docs/PolygonApi.md#getpolcustomtokenrisk) | **POST** /insights/pol/getCustomTokenRisk | Custom Volatility & Risk Metrics by Token
*PolygonApi* | [**GetPolDefaultCollectionRisk**](docs/PolygonApi.md#getpoldefaultcollectionrisk) | **POST** /insights/pol/getDefaultCollectionRisk | Default Volatility & Risk Metrics by Collection
*PolygonApi* | [**GetPolDefaultTokenRisk**](docs/PolygonApi.md#getpoldefaulttokenrisk) | **POST** /insights/pol/getDefaultTokenRisk | Default Volatility & Risk Metrics by Token
*PolygonApi* | [**GetPolHistoricalTransactions**](docs/PolygonApi.md#getpolhistoricaltransactions) | **POST** /data/pol/getHistoricalTransactions | Historical Transactions by Collection
*PolygonApi* | [**GetPolLeaderBoard**](docs/PolygonApi.md#getpolleaderboard) | **POST** /analytics/pol/getLeaderBoard | Polygon Leaderboard by Collection
*PolygonApi* | [**GetPolMarketplaceData**](docs/PolygonApi.md#getpolmarketplacedata) | **POST** /data/pol/getMarketplaceData | Collection Summary by Marketplace
*PolygonApi* | [**GetPolMarketplaceFloorPrice**](docs/PolygonApi.md#getpolmarketplacefloorprice) | **POST** /data/pol/getMarketplaceFloorPrice | Marketplace Floor Price by Collection
*PolygonApi* | [**GetPolRarity**](docs/PolygonApi.md#getpolrarity) | **POST** /analytics/pol/getRarity | Token Rarity by Collection
*PolygonApi* | [**GetPolTokenAppraisal**](docs/PolygonApi.md#getpoltokenappraisal) | **POST** /insights/pol/getTokenAppraisal | Liquidation & Appraisal Estimate by Token
*PolygonApi* | [**GetPolTokenForecasts**](docs/PolygonApi.md#getpoltokenforecasts) | **POST** /insights/pol/getTokenForecasts | Price Forecast by Token
*PolygonApi* | [**GetPolTokenSummary**](docs/PolygonApi.md#getpoltokensummary) | **POST** /analytics/pol/getTokenSummary | Summary Statistics by Token
*PolygonApi* | [**GetPolTokenTransactions**](docs/PolygonApi.md#getpoltokentransactions) | **POST** /data/pol/getTokenTransactions | Transactions by Token
*PolygonApi* | [**GetPolTokens**](docs/PolygonApi.md#getpoltokens) | **POST** /data/pol/getTokens | Tokens by Collection
*PolygonApi* | [**GetPolWalletLabels**](docs/PolygonApi.md#getpolwalletlabels) | **POST** /insights/pol/getWalletLabels | Wallet Activity Labels
*PolygonApi* | [**GetPolWalletNFTs**](docs/PolygonApi.md#getpolwalletnfts) | **POST** /data/pol/getWalletNFTs | Tokens Owned by Wallet
*PolygonApi* | [**GetPolWalletTransactions**](docs/PolygonApi.md#getpolwallettransactions) | **POST** /data/pol/getWalletTransactions | Historical Token Transactions by Wallet
*PolygonApi* | [**GetPolWashTrade**](docs/PolygonApi.md#getpolwashtrade) | **POST** /analytics/pol/getWashTrade | Wash Trades by Transaction
*PolygonApi* | [**GetPolWashTransactions**](docs/PolygonApi.md#getpolwashtransactions) | **POST** /analytics/pol/getWashTransactions | Wash Trades by Collection
*SolanaApi* | [**GetSolAccountNFTs**](docs/SolanaApi.md#getsolaccountnfts) | **POST** /data/sol/getAccountNFTs | Tokens Owned by Wallet
*SolanaApi* | [**GetSolCollectionForecasts**](docs/SolanaApi.md#getsolcollectionforecasts) | **POST** /insights/sol/getCollectionForecasts | Price Forecast by Collection
*SolanaApi* | [**GetSolCollectionPriceDiff**](docs/SolanaApi.md#getsolcollectionpricediff) | **POST** /analytics/sol/getCollectionPriceDiff | Price Differentiation by Trait
*SolanaApi* | [**GetSolCollectionSalesOHLC**](docs/SolanaApi.md#getsolcollectionsalesohlc) | **POST** /analytics/sol/getCollectionSalesOHLC | Collection Sales Price Candlesticks
*SolanaApi* | [**GetSolCollectionSummary**](docs/SolanaApi.md#getsolcollectionsummary) | **POST** /analytics/sol/getCollectionSummary | Summary Statistics by Collection
*SolanaApi* | [**GetSolCollectionTraits**](docs/SolanaApi.md#getsolcollectiontraits) | **POST** /data/sol/getCollectionTraits | Traits by Collection
*SolanaApi* | [**GetSolCollectionTransactions**](docs/SolanaApi.md#getsolcollectiontransactions) | **POST** /data/sol/getCollectionTransactions | Transactions by Collections
*SolanaApi* | [**GetSolCollections**](docs/SolanaApi.md#getsolcollections) | **POST** /data/sol/getCollections | Aggregated Collections Supported by Gallop
*SolanaApi* | [**GetSolCustomCollectionRisk**](docs/SolanaApi.md#getsolcustomcollectionrisk) | **POST** /insights/sol/getCustomCollectionRisk | Custom Volatility & Risk Metrics by Collection
*SolanaApi* | [**GetSolCustomTokenRisk**](docs/SolanaApi.md#getsolcustomtokenrisk) | **POST** /insights/sol/getCustomTokenRisk | Custom Volatility & Risk Metrics by Token
*SolanaApi* | [**GetSolDefaultCollectionRisk**](docs/SolanaApi.md#getsoldefaultcollectionrisk) | **POST** /insights/sol/getDefaultCollectionRisk | Default Volatility & Risk Metrics by Collection
*SolanaApi* | [**GetSolDefaultTokenRisk**](docs/SolanaApi.md#getsoldefaulttokenrisk) | **POST** /insights/sol/getDefaultTokenRisk | Default Volatility & Risk Metrics by Token
*SolanaApi* | [**GetSolHistoricalTransactions**](docs/SolanaApi.md#getsolhistoricaltransactions) | **POST** /data/sol/getHistoricalTransactions | Historical Transactions by Collection
*SolanaApi* | [**GetSolMarketplaceData**](docs/SolanaApi.md#getsolmarketplacedata) | **POST** /data/sol/getMarketplaceData | Collection Summary by Marketplace
*SolanaApi* | [**GetSolMarketplaceFloorPrice**](docs/SolanaApi.md#getsolmarketplacefloorprice) | **POST** /data/sol/getMarketplaceFloorPrice | Marketplace Floor Price by Collection
*SolanaApi* | [**GetSolMarketplaceTraitData**](docs/SolanaApi.md#getsolmarketplacetraitdata) | **POST** /data/sol/getMarketplaceTraitData | Collection Listings by Trait & Marketplace
*SolanaApi* | [**GetSolNFTAccount**](docs/SolanaApi.md#getsolnftaccount) | **POST** /data/sol/getNFTAccount | Wallet Owners by Token
*SolanaApi* | [**GetSolRarity**](docs/SolanaApi.md#getsolrarity) | **POST** /analytics/sol/getRarity | Token Rarity by Collection
*SolanaApi* | [**GetSolTokenAppraisal**](docs/SolanaApi.md#getsoltokenappraisal) | **POST** /insights/sol/getTokenAppraisal | Liquidation & Appraisal Estimate by Token
*SolanaApi* | [**GetSolTokenForecasts**](docs/SolanaApi.md#getsoltokenforecasts) | **POST** /insights/sol/getTokenForecasts | Price Forecast by Token
*SolanaApi* | [**GetSolTokenSummary**](docs/SolanaApi.md#getsoltokensummary) | **POST** /analytics/sol/getTokenSummary | Summary Statistics by Token
*SolanaApi* | [**GetSolTokenTransactions**](docs/SolanaApi.md#getsoltokentransactions) | **POST** /data/sol/getTokenTransactions | Transactions by Token
*SolanaApi* | [**GetSolTokens**](docs/SolanaApi.md#getsoltokens) | **POST** /data/sol/getTokens | Tokens by Collection
*SolanaApi* | [**GetSolWashTrade**](docs/SolanaApi.md#getsolwashtrade) | **POST** /analytics/sol/getWashTrade | Wash Trades by Transaction
*SolanaApi* | [**GetSolWashTransactions**](docs/SolanaApi.md#getsolwashtransactions) | **POST** /analytics/sol/getWashTransactions | Wash Trades by Collection
*StarknetApi* | [**GetSknMarketplaceData**](docs/StarknetApi.md#getsknmarketplacedata) | **POST** /data/skn/getMarketplaceData | Gallop Marketplace Data
*StarknetApi* | [**GetSknMarketplaceFloorPrice**](docs/StarknetApi.md#getsknmarketplacefloorprice) | **POST** /data/skn/getMarketplaceFloorPrice | Marketplace Floor Price by Collection


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.GetEthCollectionFloorPriceOHLCRequest](docs/GetEthCollectionFloorPriceOHLCRequest.md)
 - [Model.GetEthCollectionForecastsRequest](docs/GetEthCollectionForecastsRequest.md)
 - [Model.GetEthCollectionForecastsRequestArchParams](docs/GetEthCollectionForecastsRequestArchParams.md)
 - [Model.GetEthCollectionListingsOHLCRequest](docs/GetEthCollectionListingsOHLCRequest.md)
 - [Model.GetEthCollectionOwnersRequest](docs/GetEthCollectionOwnersRequest.md)
 - [Model.GetEthCollectionPriceDiffRequest](docs/GetEthCollectionPriceDiffRequest.md)
 - [Model.GetEthCollectionSalesOHLCRequest](docs/GetEthCollectionSalesOHLCRequest.md)
 - [Model.GetEthCollectionSummaryRequest](docs/GetEthCollectionSummaryRequest.md)
 - [Model.GetEthCollectionTransactionsRequest](docs/GetEthCollectionTransactionsRequest.md)
 - [Model.GetEthCollectionsRequest](docs/GetEthCollectionsRequest.md)
 - [Model.GetEthCustomCollectionRiskRequest](docs/GetEthCustomCollectionRiskRequest.md)
 - [Model.GetEthCustomCollectionRiskRequestArcParams](docs/GetEthCustomCollectionRiskRequestArcParams.md)
 - [Model.GetEthCustomCollectionRiskRequestGarParams](docs/GetEthCustomCollectionRiskRequestGarParams.md)
 - [Model.GetEthCustomCollectionRiskRequestHarParams](docs/GetEthCustomCollectionRiskRequestHarParams.md)
 - [Model.GetEthCustomTokenRiskRequest](docs/GetEthCustomTokenRiskRequest.md)
 - [Model.GetEthDefaultCollectionRiskRequest](docs/GetEthDefaultCollectionRiskRequest.md)
 - [Model.GetEthDefaultTokenRiskRequest](docs/GetEthDefaultTokenRiskRequest.md)
 - [Model.GetEthHistoricalEventsRequest](docs/GetEthHistoricalEventsRequest.md)
 - [Model.GetEthHistoricalTransactionsRequest](docs/GetEthHistoricalTransactionsRequest.md)
 - [Model.GetEthLeaderBoardRequest](docs/GetEthLeaderBoardRequest.md)
 - [Model.GetEthMarketplaceDataRequest](docs/GetEthMarketplaceDataRequest.md)
 - [Model.GetEthMarketplaceFloorPriceRequest](docs/GetEthMarketplaceFloorPriceRequest.md)
 - [Model.GetEthMarketplaceTraitDataRequest](docs/GetEthMarketplaceTraitDataRequest.md)
 - [Model.GetEthRarityRequest](docs/GetEthRarityRequest.md)
 - [Model.GetEthTokenAppraisalRequest](docs/GetEthTokenAppraisalRequest.md)
 - [Model.GetEthTokenForecastsRequest](docs/GetEthTokenForecastsRequest.md)
 - [Model.GetEthTokenSummaryRequest](docs/GetEthTokenSummaryRequest.md)
 - [Model.GetEthTokenTransactionsRequest](docs/GetEthTokenTransactionsRequest.md)
 - [Model.GetEthTokensRequest](docs/GetEthTokensRequest.md)
 - [Model.GetEthWalletLabelsRequest](docs/GetEthWalletLabelsRequest.md)
 - [Model.GetEthWalletNFTsRequest](docs/GetEthWalletNFTsRequest.md)
 - [Model.GetEthWalletTransactionsRequest](docs/GetEthWalletTransactionsRequest.md)
 - [Model.GetEthWashTradeRequest](docs/GetEthWashTradeRequest.md)
 - [Model.GetEthWashTransactionsRequest](docs/GetEthWashTransactionsRequest.md)
 - [Model.GetPolCollectionForecastsRequest](docs/GetPolCollectionForecastsRequest.md)
 - [Model.GetPolCollectionOwnersRequest](docs/GetPolCollectionOwnersRequest.md)
 - [Model.GetPolCollectionPriceDiffRequest](docs/GetPolCollectionPriceDiffRequest.md)
 - [Model.GetPolCollectionSalesOHLCRequest](docs/GetPolCollectionSalesOHLCRequest.md)
 - [Model.GetPolCollectionSummaryRequest](docs/GetPolCollectionSummaryRequest.md)
 - [Model.GetPolCollectionTraitsRequest](docs/GetPolCollectionTraitsRequest.md)
 - [Model.GetPolCollectionTransactionsRequest](docs/GetPolCollectionTransactionsRequest.md)
 - [Model.GetPolCollectionsRequest](docs/GetPolCollectionsRequest.md)
 - [Model.GetPolCustomCollectionRiskRequest](docs/GetPolCustomCollectionRiskRequest.md)
 - [Model.GetPolCustomTokenRiskRequest](docs/GetPolCustomTokenRiskRequest.md)
 - [Model.GetPolDefaultCollectionRiskRequest](docs/GetPolDefaultCollectionRiskRequest.md)
 - [Model.GetPolDefaultTokenRiskRequest](docs/GetPolDefaultTokenRiskRequest.md)
 - [Model.GetPolHistoricalTransactionsRequest](docs/GetPolHistoricalTransactionsRequest.md)
 - [Model.GetPolMarketplaceDataRequest](docs/GetPolMarketplaceDataRequest.md)
 - [Model.GetPolMarketplaceFloorPriceRequest](docs/GetPolMarketplaceFloorPriceRequest.md)
 - [Model.GetPolRarityRequest](docs/GetPolRarityRequest.md)
 - [Model.GetPolTokenAppraisalRequest](docs/GetPolTokenAppraisalRequest.md)
 - [Model.GetPolTokenForecastsRequest](docs/GetPolTokenForecastsRequest.md)
 - [Model.GetPolTokenSummaryRequest](docs/GetPolTokenSummaryRequest.md)
 - [Model.GetPolTokenTransactionsRequest](docs/GetPolTokenTransactionsRequest.md)
 - [Model.GetPolTokensRequest](docs/GetPolTokensRequest.md)
 - [Model.GetPolWalletNFTsRequest](docs/GetPolWalletNFTsRequest.md)
 - [Model.GetPolWalletTransactionsRequest](docs/GetPolWalletTransactionsRequest.md)
 - [Model.GetPolWashTradeRequest](docs/GetPolWashTradeRequest.md)
 - [Model.GetPolWashTransactionsRequest](docs/GetPolWashTransactionsRequest.md)
 - [Model.GetSknMarketplaceDataRequest](docs/GetSknMarketplaceDataRequest.md)
 - [Model.GetSknMarketplaceFloorPriceRequest](docs/GetSknMarketplaceFloorPriceRequest.md)
 - [Model.GetSolAccountNFTsRequest](docs/GetSolAccountNFTsRequest.md)
 - [Model.GetSolCollectionForecastsRequest](docs/GetSolCollectionForecastsRequest.md)
 - [Model.GetSolCollectionForecastsRequestArchParams](docs/GetSolCollectionForecastsRequestArchParams.md)
 - [Model.GetSolCollectionPriceDiffRequest](docs/GetSolCollectionPriceDiffRequest.md)
 - [Model.GetSolCollectionSalesOHLCRequest](docs/GetSolCollectionSalesOHLCRequest.md)
 - [Model.GetSolCollectionSummaryRequest](docs/GetSolCollectionSummaryRequest.md)
 - [Model.GetSolCollectionTraitsRequest](docs/GetSolCollectionTraitsRequest.md)
 - [Model.GetSolCollectionTransactionsRequest](docs/GetSolCollectionTransactionsRequest.md)
 - [Model.GetSolCollectionsRequest](docs/GetSolCollectionsRequest.md)
 - [Model.GetSolCustomCollectionRiskRequest](docs/GetSolCustomCollectionRiskRequest.md)
 - [Model.GetSolCustomTokenRiskRequest](docs/GetSolCustomTokenRiskRequest.md)
 - [Model.GetSolDefaultCollectionRiskRequest](docs/GetSolDefaultCollectionRiskRequest.md)
 - [Model.GetSolDefaultTokenRiskRequest](docs/GetSolDefaultTokenRiskRequest.md)
 - [Model.GetSolHistoricalTransactionsRequest](docs/GetSolHistoricalTransactionsRequest.md)
 - [Model.GetSolMarketplaceDataRequest](docs/GetSolMarketplaceDataRequest.md)
 - [Model.GetSolMarketplaceFloorPriceRequest](docs/GetSolMarketplaceFloorPriceRequest.md)
 - [Model.GetSolMarketplaceTraitDataRequest](docs/GetSolMarketplaceTraitDataRequest.md)
 - [Model.GetSolNFTAccountRequest](docs/GetSolNFTAccountRequest.md)
 - [Model.GetSolRarityRequest](docs/GetSolRarityRequest.md)
 - [Model.GetSolTokenAppraisalRequest](docs/GetSolTokenAppraisalRequest.md)
 - [Model.GetSolTokenForecastsRequest](docs/GetSolTokenForecastsRequest.md)
 - [Model.GetSolTokenForecastsRequestArchParams](docs/GetSolTokenForecastsRequestArchParams.md)
 - [Model.GetSolTokenSummaryRequest](docs/GetSolTokenSummaryRequest.md)
 - [Model.GetSolTokenTransactionsRequest](docs/GetSolTokenTransactionsRequest.md)
 - [Model.GetSolTokensRequest](docs/GetSolTokensRequest.md)
 - [Model.GetSolWashTradeRequest](docs/GetSolWashTradeRequest.md)
 - [Model.GetSolWashTransactionsRequest](docs/GetSolWashTransactionsRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

