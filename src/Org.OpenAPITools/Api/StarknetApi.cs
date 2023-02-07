/*
 * Gallop API
 *
 * Data and insights APIs, webooks, and dashboards enabling businesses to launch tokenized products in seconds.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@higallop.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStarknetApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gallop Marketplace Data
        /// </summary>
        /// <remarks>
        /// Lists marketplace data from contract address.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void GetSknMarketplaceData(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0);

        /// <summary>
        /// Gallop Marketplace Data
        /// </summary>
        /// <remarks>
        /// Lists marketplace data from contract address.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetSknMarketplaceDataWithHttpInfo(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0);
        /// <summary>
        /// Marketplace Floor Price by Collection
        /// </summary>
        /// <remarks>
        /// Returns current floor price for all collections by marketplace
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void GetSknMarketplaceFloorPrice(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0);

        /// <summary>
        /// Marketplace Floor Price by Collection
        /// </summary>
        /// <remarks>
        /// Returns current floor price for all collections by marketplace
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetSknMarketplaceFloorPriceWithHttpInfo(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStarknetApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Gallop Marketplace Data
        /// </summary>
        /// <remarks>
        /// Lists marketplace data from contract address.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetSknMarketplaceDataAsync(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gallop Marketplace Data
        /// </summary>
        /// <remarks>
        /// Lists marketplace data from contract address.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetSknMarketplaceDataWithHttpInfoAsync(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Marketplace Floor Price by Collection
        /// </summary>
        /// <remarks>
        /// Returns current floor price for all collections by marketplace
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetSknMarketplaceFloorPriceAsync(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Marketplace Floor Price by Collection
        /// </summary>
        /// <remarks>
        /// Returns current floor price for all collections by marketplace
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetSknMarketplaceFloorPriceWithHttpInfoAsync(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStarknetApi : IStarknetApiSync, IStarknetApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StarknetApi : IStarknetApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StarknetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StarknetApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarknetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StarknetApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarknetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StarknetApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarknetApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StarknetApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gallop Marketplace Data Lists marketplace data from contract address.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void GetSknMarketplaceData(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0)
        {
            GetSknMarketplaceDataWithHttpInfo(getSknMarketplaceDataRequest);
        }

        /// <summary>
        /// Gallop Marketplace Data Lists marketplace data from contract address.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> GetSknMarketplaceDataWithHttpInfo(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getSknMarketplaceDataRequest;

            localVarRequestOptions.Operation = "StarknetApi.GetSknMarketplaceData";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/data/skn/getMarketplaceData", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSknMarketplaceData", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gallop Marketplace Data Lists marketplace data from contract address.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetSknMarketplaceDataAsync(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await GetSknMarketplaceDataWithHttpInfoAsync(getSknMarketplaceDataRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gallop Marketplace Data Lists marketplace data from contract address.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceDataRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> GetSknMarketplaceDataWithHttpInfoAsync(GetSknMarketplaceDataRequest getSknMarketplaceDataRequest = default(GetSknMarketplaceDataRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getSknMarketplaceDataRequest;

            localVarRequestOptions.Operation = "StarknetApi.GetSknMarketplaceData";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/data/skn/getMarketplaceData", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSknMarketplaceData", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Marketplace Floor Price by Collection Returns current floor price for all collections by marketplace
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void GetSknMarketplaceFloorPrice(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0)
        {
            GetSknMarketplaceFloorPriceWithHttpInfo(getSknMarketplaceFloorPriceRequest);
        }

        /// <summary>
        /// Marketplace Floor Price by Collection Returns current floor price for all collections by marketplace
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> GetSknMarketplaceFloorPriceWithHttpInfo(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getSknMarketplaceFloorPriceRequest;

            localVarRequestOptions.Operation = "StarknetApi.GetSknMarketplaceFloorPrice";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/data/skn/getMarketplaceFloorPrice", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSknMarketplaceFloorPrice", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Marketplace Floor Price by Collection Returns current floor price for all collections by marketplace
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetSknMarketplaceFloorPriceAsync(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await GetSknMarketplaceFloorPriceWithHttpInfoAsync(getSknMarketplaceFloorPriceRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Marketplace Floor Price by Collection Returns current floor price for all collections by marketplace
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getSknMarketplaceFloorPriceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> GetSknMarketplaceFloorPriceWithHttpInfoAsync(GetSknMarketplaceFloorPriceRequest getSknMarketplaceFloorPriceRequest = default(GetSknMarketplaceFloorPriceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getSknMarketplaceFloorPriceRequest;

            localVarRequestOptions.Operation = "StarknetApi.GetSknMarketplaceFloorPrice";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/data/skn/getMarketplaceFloorPrice", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSknMarketplaceFloorPrice", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}