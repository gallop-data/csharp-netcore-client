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
    /// GetEthCollectionSalesOHLCRequest
    /// </summary>
    [DataContract(Name = "getEthCollectionSalesOHLC_request")]
    public partial class GetEthCollectionSalesOHLCRequest : IEquatable<GetEthCollectionSalesOHLCRequest>, IValidatableObject
    {
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
        /// <example>&quot;eth&quot;</example>
        [DataMember(Name = "rept_curr", EmitDefaultValue = false)]
        public ReptCurrEnum? ReptCurr { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEthCollectionSalesOHLCRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEthCollectionSalesOHLCRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEthCollectionSalesOHLCRequest" /> class.
        /// </summary>
        /// <param name="collectionAddress">The Ethereum contract address to identify the collection. (required).</param>
        /// <param name="frequency">The interval at which to return OHLC, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc..</param>
        /// <param name="groupBy">An attribute of the NFT to group results by..</param>
        /// <param name="volume">If &#39;true&#39;, response dicts contain OHLCV.</param>
        /// <param name="nTrades">If &#39;true&#39;, append number of trades to OHLC(V).</param>
        /// <param name="reptCurr">The currency to report results in.</param>
        /// <param name="startDate">The start date to pull data for calculations.</param>
        /// <param name="endDate">The end date to pull data for calculations.</param>
        /// <param name="excludeWash">Exclude suspected wash transactions?.</param>
        public GetEthCollectionSalesOHLCRequest(string collectionAddress = default(string), string frequency = default(string), string groupBy = default(string), bool volume = default(bool), bool nTrades = default(bool), ReptCurrEnum? reptCurr = default(ReptCurrEnum?), string startDate = default(string), string endDate = default(string), bool excludeWash = default(bool))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for GetEthCollectionSalesOHLCRequest and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            this.Frequency = frequency;
            this.GroupBy = groupBy;
            this.Volume = volume;
            this.NTrades = nTrades;
            this.ReptCurr = reptCurr;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ExcludeWash = excludeWash;
        }

        /// <summary>
        /// The Ethereum contract address to identify the collection.
        /// </summary>
        /// <value>The Ethereum contract address to identify the collection.</value>
        /// <example>&quot;0x7bd29408f11d2bfc23c34f18275bbf23bb716bc7&quot;</example>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// The interval at which to return OHLC, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc.
        /// </summary>
        /// <value>The interval at which to return OHLC, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc.</value>
        /// <example>&quot;1D&quot;</example>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public string Frequency { get; set; }

        /// <summary>
        /// An attribute of the NFT to group results by.
        /// </summary>
        /// <value>An attribute of the NFT to group results by.</value>
        /// <example>&quot;Hat&quot;</example>
        [DataMember(Name = "group_by", EmitDefaultValue = false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// If &#39;true&#39;, response dicts contain OHLCV
        /// </summary>
        /// <value>If &#39;true&#39;, response dicts contain OHLCV</value>
        /// <example>false</example>
        [DataMember(Name = "volume", EmitDefaultValue = true)]
        public bool Volume { get; set; }

        /// <summary>
        /// If &#39;true&#39;, append number of trades to OHLC(V)
        /// </summary>
        /// <value>If &#39;true&#39;, append number of trades to OHLC(V)</value>
        /// <example>false</example>
        [DataMember(Name = "n_trades", EmitDefaultValue = true)]
        public bool NTrades { get; set; }

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
        /// <example>&quot;2022-03-04&quot;</example>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Exclude suspected wash transactions?
        /// </summary>
        /// <value>Exclude suspected wash transactions?</value>
        /// <example>true</example>
        [DataMember(Name = "exclude_wash", EmitDefaultValue = true)]
        public bool ExcludeWash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEthCollectionSalesOHLCRequest {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  NTrades: ").Append(NTrades).Append("\n");
            sb.Append("  ReptCurr: ").Append(ReptCurr).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExcludeWash: ").Append(ExcludeWash).Append("\n");
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
            return this.Equals(input as GetEthCollectionSalesOHLCRequest);
        }

        /// <summary>
        /// Returns true if GetEthCollectionSalesOHLCRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEthCollectionSalesOHLCRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEthCollectionSalesOHLCRequest input)
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
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    (this.GroupBy != null &&
                    this.GroupBy.Equals(input.GroupBy))
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
                ) && 
                (
                    this.NTrades == input.NTrades ||
                    this.NTrades.Equals(input.NTrades)
                ) && 
                (
                    this.ReptCurr == input.ReptCurr ||
                    this.ReptCurr.Equals(input.ReptCurr)
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
                    this.ExcludeWash == input.ExcludeWash ||
                    this.ExcludeWash.Equals(input.ExcludeWash)
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
                if (this.Frequency != null)
                {
                    hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                }
                if (this.GroupBy != null)
                {
                    hashCode = (hashCode * 59) + this.GroupBy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                hashCode = (hashCode * 59) + this.NTrades.GetHashCode();
                hashCode = (hashCode * 59) + this.ReptCurr.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExcludeWash.GetHashCode();
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
