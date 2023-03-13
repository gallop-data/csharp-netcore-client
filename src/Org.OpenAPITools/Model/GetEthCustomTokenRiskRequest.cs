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
    /// GetEthCustomTokenRiskRequest
    /// </summary>
    [DataContract(Name = "getEthCustomTokenRisk_request")]
    public partial class GetEthCustomTokenRiskRequest : IEquatable<GetEthCustomTokenRiskRequest>, IValidatableObject
    {
        /// <summary>
        /// Return distribution assumed.
        /// </summary>
        /// <value>Return distribution assumed.</value>
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
        /// Return distribution assumed.
        /// </summary>
        /// <value>Return distribution assumed.</value>
        /// <example>&quot;norm&quot;</example>
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
        /// <example>&quot;sol&quot;</example>
        [DataMember(Name = "rept_curr", EmitDefaultValue = false)]
        public ReptCurrEnum? ReptCurr { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEthCustomTokenRiskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEthCustomTokenRiskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEthCustomTokenRiskRequest" /> class.
        /// </summary>
        /// <param name="collectionAddress">The contract address of the token collection. (required).</param>
        /// <param name="tokenId">The id(s) for the token(s). (required).</param>
        /// <param name="holdingPeriod">The holding period to evaluate risk for, e.g. &#x60;12M&#x60; (required).</param>
        /// <param name="dist">Return distribution assumed..</param>
        /// <param name="startDate">The start date to pull data for calculations.</param>
        /// <param name="endDate">The end date to pull data for calculations.</param>
        /// <param name="riskFreeRate">The rate of return for an asset deemed risk free in the contemplated holding period.</param>
        /// <param name="winsOutliers">Whether to winsorize time series outliers prior to calculating risk.</param>
        /// <param name="frequency">The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc..</param>
        /// <param name="reptCurr">The currency to report results in.</param>
        /// <param name="excludeWash">Exclude suspected wash transactions?.</param>
        /// <param name="drawdown">If true, report drawdown volatility (based on negative returns only)..</param>
        /// <param name="arcParams">arcParams.</param>
        /// <param name="garParams">garParams.</param>
        /// <param name="harParams">harParams.</param>
        public GetEthCustomTokenRiskRequest(string collectionAddress = default(string), List<string> tokenId = default(List<string>), string holdingPeriod = default(string), DistEnum? dist = default(DistEnum?), string startDate = default(string), string endDate = default(string), decimal riskFreeRate = default(decimal), bool winsOutliers = default(bool), string frequency = default(string), ReptCurrEnum? reptCurr = default(ReptCurrEnum?), bool excludeWash = default(bool), bool drawdown = default(bool), GetEthCustomCollectionRiskRequestArcParams arcParams = default(GetEthCustomCollectionRiskRequestArcParams), GetEthCustomCollectionRiskRequestGarParams garParams = default(GetEthCustomCollectionRiskRequestGarParams), GetEthCustomCollectionRiskRequestHarParams harParams = default(GetEthCustomCollectionRiskRequestHarParams))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for GetEthCustomTokenRiskRequest and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for GetEthCustomTokenRiskRequest and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "holdingPeriod" is required (not null)
            if (holdingPeriod == null)
            {
                throw new ArgumentNullException("holdingPeriod is a required property for GetEthCustomTokenRiskRequest and cannot be null");
            }
            this.HoldingPeriod = holdingPeriod;
            this.Dist = dist;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.RiskFreeRate = riskFreeRate;
            this.WinsOutliers = winsOutliers;
            this.Frequency = frequency;
            this.ReptCurr = reptCurr;
            this.ExcludeWash = excludeWash;
            this.Drawdown = drawdown;
            this.ArcParams = arcParams;
            this.GarParams = garParams;
            this.HarParams = harParams;
        }

        /// <summary>
        /// The contract address of the token collection.
        /// </summary>
        /// <value>The contract address of the token collection.</value>
        /// <example>&quot;0x3f5fb35468e9834a43dca1c160c69eaae78b6360&quot;</example>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// The id(s) for the token(s).
        /// </summary>
        /// <value>The id(s) for the token(s).</value>
        [DataMember(Name = "token_id", IsRequired = true, EmitDefaultValue = true)]
        public List<string> TokenId { get; set; }

        /// <summary>
        /// The holding period to evaluate risk for, e.g. &#x60;12M&#x60;
        /// </summary>
        /// <value>The holding period to evaluate risk for, e.g. &#x60;12M&#x60;</value>
        /// <example>&quot;6M&quot;</example>
        [DataMember(Name = "holding_period", IsRequired = true, EmitDefaultValue = true)]
        public string HoldingPeriod { get; set; }

        /// <summary>
        /// The start date to pull data for calculations
        /// </summary>
        /// <value>The start date to pull data for calculations</value>
        /// <example>&quot;2021-08-01&quot;</example>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date to pull data for calculations
        /// </summary>
        /// <value>The end date to pull data for calculations</value>
        /// <example>&quot;2022-02-04&quot;</example>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The rate of return for an asset deemed risk free in the contemplated holding period
        /// </summary>
        /// <value>The rate of return for an asset deemed risk free in the contemplated holding period</value>
        /// <example>0.001</example>
        [DataMember(Name = "risk_free_rate", EmitDefaultValue = false)]
        public decimal RiskFreeRate { get; set; }

        /// <summary>
        /// Whether to winsorize time series outliers prior to calculating risk
        /// </summary>
        /// <value>Whether to winsorize time series outliers prior to calculating risk</value>
        /// <example>true</example>
        [DataMember(Name = "wins_outliers", EmitDefaultValue = true)]
        public bool WinsOutliers { get; set; }

        /// <summary>
        /// The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc.
        /// </summary>
        /// <value>The interval at which to calculate returns to base the forecasts upon, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc.</value>
        /// <example>&quot;1D&quot;</example>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public string Frequency { get; set; }

        /// <summary>
        /// Exclude suspected wash transactions?
        /// </summary>
        /// <value>Exclude suspected wash transactions?</value>
        /// <example>true</example>
        [DataMember(Name = "exclude_wash", EmitDefaultValue = true)]
        public bool ExcludeWash { get; set; }

        /// <summary>
        /// If true, report drawdown volatility (based on negative returns only).
        /// </summary>
        /// <value>If true, report drawdown volatility (based on negative returns only).</value>
        /// <example>false</example>
        [DataMember(Name = "drawdown", EmitDefaultValue = true)]
        public bool Drawdown { get; set; }

        /// <summary>
        /// Gets or Sets ArcParams
        /// </summary>
        [DataMember(Name = "arc_params", EmitDefaultValue = false)]
        public GetEthCustomCollectionRiskRequestArcParams ArcParams { get; set; }

        /// <summary>
        /// Gets or Sets GarParams
        /// </summary>
        [DataMember(Name = "gar_params", EmitDefaultValue = false)]
        public GetEthCustomCollectionRiskRequestGarParams GarParams { get; set; }

        /// <summary>
        /// Gets or Sets HarParams
        /// </summary>
        [DataMember(Name = "har_params", EmitDefaultValue = false)]
        public GetEthCustomCollectionRiskRequestHarParams HarParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEthCustomTokenRiskRequest {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  HoldingPeriod: ").Append(HoldingPeriod).Append("\n");
            sb.Append("  Dist: ").Append(Dist).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  RiskFreeRate: ").Append(RiskFreeRate).Append("\n");
            sb.Append("  WinsOutliers: ").Append(WinsOutliers).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  ReptCurr: ").Append(ReptCurr).Append("\n");
            sb.Append("  ExcludeWash: ").Append(ExcludeWash).Append("\n");
            sb.Append("  Drawdown: ").Append(Drawdown).Append("\n");
            sb.Append("  ArcParams: ").Append(ArcParams).Append("\n");
            sb.Append("  GarParams: ").Append(GarParams).Append("\n");
            sb.Append("  HarParams: ").Append(HarParams).Append("\n");
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
            return this.Equals(input as GetEthCustomTokenRiskRequest);
        }

        /// <summary>
        /// Returns true if GetEthCustomTokenRiskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEthCustomTokenRiskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEthCustomTokenRiskRequest input)
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
                    this.TokenId == input.TokenId ||
                    this.TokenId != null &&
                    input.TokenId != null &&
                    this.TokenId.SequenceEqual(input.TokenId)
                ) && 
                (
                    this.HoldingPeriod == input.HoldingPeriod ||
                    (this.HoldingPeriod != null &&
                    this.HoldingPeriod.Equals(input.HoldingPeriod))
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
                    this.RiskFreeRate == input.RiskFreeRate ||
                    this.RiskFreeRate.Equals(input.RiskFreeRate)
                ) && 
                (
                    this.WinsOutliers == input.WinsOutliers ||
                    this.WinsOutliers.Equals(input.WinsOutliers)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
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
                    this.Drawdown == input.Drawdown ||
                    this.Drawdown.Equals(input.Drawdown)
                ) && 
                (
                    this.ArcParams == input.ArcParams ||
                    (this.ArcParams != null &&
                    this.ArcParams.Equals(input.ArcParams))
                ) && 
                (
                    this.GarParams == input.GarParams ||
                    (this.GarParams != null &&
                    this.GarParams.Equals(input.GarParams))
                ) && 
                (
                    this.HarParams == input.HarParams ||
                    (this.HarParams != null &&
                    this.HarParams.Equals(input.HarParams))
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
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.HoldingPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.HoldingPeriod.GetHashCode();
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
                hashCode = (hashCode * 59) + this.RiskFreeRate.GetHashCode();
                hashCode = (hashCode * 59) + this.WinsOutliers.GetHashCode();
                if (this.Frequency != null)
                {
                    hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReptCurr.GetHashCode();
                hashCode = (hashCode * 59) + this.ExcludeWash.GetHashCode();
                hashCode = (hashCode * 59) + this.Drawdown.GetHashCode();
                if (this.ArcParams != null)
                {
                    hashCode = (hashCode * 59) + this.ArcParams.GetHashCode();
                }
                if (this.GarParams != null)
                {
                    hashCode = (hashCode * 59) + this.GarParams.GetHashCode();
                }
                if (this.HarParams != null)
                {
                    hashCode = (hashCode * 59) + this.HarParams.GetHashCode();
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
