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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// GetEthCollectionForecastsRequest
    /// </summary>
    [DataContract(Name = "getEthCollectionForecasts_request")]
    public partial class GetEthCollectionForecastsRequest : IEquatable<GetEthCollectionForecastsRequest>, IValidatableObject
    {
        /// <summary>
        /// Type of statistical forecasting model to be calculated as a 3-char string, e.g. &#x60;arc&#x60; for ARCH
        /// </summary>
        /// <value>Type of statistical forecasting model to be calculated as a 3-char string, e.g. &#x60;arc&#x60; for ARCH</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VoltypeEnum
        {
            /// <summary>
            /// Enum Arc for value: arc
            /// </summary>
            [EnumMember(Value = "arc")]
            Arc = 1,

            /// <summary>
            /// Enum Gar for value: gar
            /// </summary>
            [EnumMember(Value = "gar")]
            Gar = 2,

            /// <summary>
            /// Enum Har for value: har
            /// </summary>
            [EnumMember(Value = "har")]
            Har = 3

        }


        /// <summary>
        /// Type of statistical forecasting model to be calculated as a 3-char string, e.g. &#x60;arc&#x60; for ARCH
        /// </summary>
        /// <value>Type of statistical forecasting model to be calculated as a 3-char string, e.g. &#x60;arc&#x60; for ARCH</value>
        [DataMember(Name = "voltype", EmitDefaultValue = false)]
        public VoltypeEnum? Voltype { get; set; }
        /// <summary>
        /// The distribution assumed to calculate parametric risk for.
        /// </summary>
        /// <value>The distribution assumed to calculate parametric risk for.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DistEnum
        {
            /// <summary>
            /// Enum Norm for value: norm
            /// </summary>
            [EnumMember(Value = "norm")]
            Norm = 1,

            /// <summary>
            /// Enum T for value: t
            /// </summary>
            [EnumMember(Value = "t")]
            T = 2

        }


        /// <summary>
        /// The distribution assumed to calculate parametric risk for.
        /// </summary>
        /// <value>The distribution assumed to calculate parametric risk for.</value>
        [DataMember(Name = "dist", EmitDefaultValue = false)]
        public DistEnum? Dist { get; set; }
        /// <summary>
        /// The currency to report results in
        /// </summary>
        /// <value>The currency to report results in</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReptCurrEnum
        {
            /// <summary>
            /// Enum Eth for value: eth
            /// </summary>
            [EnumMember(Value = "eth")]
            Eth = 1,

            /// <summary>
            /// Enum Usd for value: usd
            /// </summary>
            [EnumMember(Value = "usd")]
            Usd = 2

        }


        /// <summary>
        /// The currency to report results in
        /// </summary>
        /// <value>The currency to report results in</value>
        [DataMember(Name = "rept_curr", EmitDefaultValue = false)]
        public ReptCurrEnum? ReptCurr { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEthCollectionForecastsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEthCollectionForecastsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEthCollectionForecastsRequest" /> class.
        /// </summary>
        /// <param name="collectionAddress">The contract address of the token collection. (required).</param>
        /// <param name="percentiles">The collection percentile(s).</param>
        /// <param name="voltype">Type of statistical forecasting model to be calculated as a 3-char string, e.g. &#x60;arc&#x60; for ARCH.</param>
        /// <param name="horizon">The forecast horizon (i.e. the number of periods to forecast out).</param>
        /// <param name="frequency">The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc..</param>
        /// <param name="dist">The distribution assumed to calculate parametric risk for..</param>
        /// <param name="startDate">The start date to pull data for calculations.</param>
        /// <param name="endDate">The end date to pull data for calculations.</param>
        /// <param name="returnPriceForecasts">Set to true, returns confidencve intervals at alpha significance for price on top of forecasts for returns and volatilities.</param>
        /// <param name="alpha">The significance level, e.g. 0.05 for 95% confidence.</param>
        /// <param name="reptCurr">The currency to report results in.</param>
        /// <param name="excludeWash">Exclude suspected wash transactions?.</param>
        /// <param name="archParams">archParams.</param>
        public GetEthCollectionForecastsRequest(string collectionAddress = default(string), List<int> percentiles = default(List<int>), VoltypeEnum? voltype = default(VoltypeEnum?), int horizon = default(int), string frequency = default(string), DistEnum? dist = default(DistEnum?), string startDate = default(string), string endDate = default(string), bool returnPriceForecasts = default(bool), decimal alpha = default(decimal), ReptCurrEnum? reptCurr = default(ReptCurrEnum?), bool excludeWash = default(bool), GetEthCollectionForecastsRequestArchParams archParams = default(GetEthCollectionForecastsRequestArchParams))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for GetEthCollectionForecastsRequest and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            this.Percentiles = percentiles;
            this.Voltype = voltype;
            this.Horizon = horizon;
            this.Frequency = frequency;
            this.Dist = dist;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ReturnPriceForecasts = returnPriceForecasts;
            this.Alpha = alpha;
            this.ReptCurr = reptCurr;
            this.ExcludeWash = excludeWash;
            this.ArchParams = archParams;
        }

        /// <summary>
        /// The contract address of the token collection.
        /// </summary>
        /// <value>The contract address of the token collection.</value>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// The collection percentile(s)
        /// </summary>
        /// <value>The collection percentile(s)</value>
        [DataMember(Name = "percentiles", EmitDefaultValue = false)]
        public List<int> Percentiles { get; set; }

        /// <summary>
        /// The forecast horizon (i.e. the number of periods to forecast out)
        /// </summary>
        /// <value>The forecast horizon (i.e. the number of periods to forecast out)</value>
        [DataMember(Name = "horizon", EmitDefaultValue = false)]
        public int Horizon { get; set; }

        /// <summary>
        /// The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc.
        /// </summary>
        /// <value>The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc.</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The start date to pull data for calculations
        /// </summary>
        /// <value>The start date to pull data for calculations</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date to pull data for calculations
        /// </summary>
        /// <value>The end date to pull data for calculations</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Set to true, returns confidencve intervals at alpha significance for price on top of forecasts for returns and volatilities
        /// </summary>
        /// <value>Set to true, returns confidencve intervals at alpha significance for price on top of forecasts for returns and volatilities</value>
        [DataMember(Name = "return_price_forecasts", EmitDefaultValue = true)]
        public bool ReturnPriceForecasts { get; set; }

        /// <summary>
        /// The significance level, e.g. 0.05 for 95% confidence
        /// </summary>
        /// <value>The significance level, e.g. 0.05 for 95% confidence</value>
        [DataMember(Name = "alpha", EmitDefaultValue = false)]
        public decimal Alpha { get; set; }

        /// <summary>
        /// Exclude suspected wash transactions?
        /// </summary>
        /// <value>Exclude suspected wash transactions?</value>
        [DataMember(Name = "exclude_wash", EmitDefaultValue = true)]
        public bool ExcludeWash { get; set; }

        /// <summary>
        /// Gets or Sets ArchParams
        /// </summary>
        [DataMember(Name = "arch_params", EmitDefaultValue = false)]
        public GetEthCollectionForecastsRequestArchParams ArchParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEthCollectionForecastsRequest {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  Percentiles: ").Append(Percentiles).Append("\n");
            sb.Append("  Voltype: ").Append(Voltype).Append("\n");
            sb.Append("  Horizon: ").Append(Horizon).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Dist: ").Append(Dist).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ReturnPriceForecasts: ").Append(ReturnPriceForecasts).Append("\n");
            sb.Append("  Alpha: ").Append(Alpha).Append("\n");
            sb.Append("  ReptCurr: ").Append(ReptCurr).Append("\n");
            sb.Append("  ExcludeWash: ").Append(ExcludeWash).Append("\n");
            sb.Append("  ArchParams: ").Append(ArchParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetEthCollectionForecastsRequest);
        }

        /// <summary>
        /// Returns true if GetEthCollectionForecastsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEthCollectionForecastsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEthCollectionForecastsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CollectionAddress == input.CollectionAddress ||
                    (this.CollectionAddress != null &&
                    this.CollectionAddress.Equals(input.CollectionAddress))
                ) && 
                (
                    this.Percentiles == input.Percentiles ||
                    this.Percentiles != null &&
                    input.Percentiles != null &&
                    this.Percentiles.SequenceEqual(input.Percentiles)
                ) && 
                (
                    this.Voltype == input.Voltype ||
                    this.Voltype.Equals(input.Voltype)
                ) && 
                (
                    this.Horizon == input.Horizon ||
                    this.Horizon.Equals(input.Horizon)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Dist == input.Dist ||
                    this.Dist.Equals(input.Dist)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ReturnPriceForecasts == input.ReturnPriceForecasts ||
                    this.ReturnPriceForecasts.Equals(input.ReturnPriceForecasts)
                ) && 
                (
                    this.Alpha == input.Alpha ||
                    this.Alpha.Equals(input.Alpha)
                ) && 
                (
                    this.ReptCurr == input.ReptCurr ||
                    this.ReptCurr.Equals(input.ReptCurr)
                ) && 
                (
                    this.ExcludeWash == input.ExcludeWash ||
                    this.ExcludeWash.Equals(input.ExcludeWash)
                ) && 
                (
                    this.ArchParams == input.ArchParams ||
                    (this.ArchParams != null &&
                    this.ArchParams.Equals(input.ArchParams))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CollectionAddress != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionAddress.GetHashCode();
                }
                if (this.Percentiles != null)
                {
                    hashCode = (hashCode * 59) + this.Percentiles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Voltype.GetHashCode();
                hashCode = (hashCode * 59) + this.Horizon.GetHashCode();
                if (this.Frequency != null)
                {
                    hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Dist.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReturnPriceForecasts.GetHashCode();
                hashCode = (hashCode * 59) + this.Alpha.GetHashCode();
                hashCode = (hashCode * 59) + this.ReptCurr.GetHashCode();
                hashCode = (hashCode * 59) + this.ExcludeWash.GetHashCode();
                if (this.ArchParams != null)
                {
                    hashCode = (hashCode * 59) + this.ArchParams.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
