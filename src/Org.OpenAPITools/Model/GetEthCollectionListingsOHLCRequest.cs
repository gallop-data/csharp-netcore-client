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
    /// GetEthCollectionListingsOHLCRequest
    /// </summary>
    [DataContract(Name = "getEthCollectionListingsOHLC_request")]
    public partial class GetEthCollectionListingsOHLCRequest : IEquatable<GetEthCollectionListingsOHLCRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="GetEthCollectionListingsOHLCRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEthCollectionListingsOHLCRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEthCollectionListingsOHLCRequest" /> class.
        /// </summary>
        /// <param name="collectionAddress">The Ethereum contract address to identify the collection. (required).</param>
        /// <param name="floorOnly">If &#x60;true&#x60;, report only historical floor prices. Otherwise, report OHFC candlesticks, number of active listings, number of unique owners and the average age of open listings..</param>
        /// <param name="frequency">The interval at which to return Floor prices / OHLF, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc. Must be &gt;&#x3D; &#x60;6H&#x60;.</param>
        /// <param name="reptCurr">The currency to report results in.</param>
        /// <param name="reportStartDate">The ISO 8601 start date/datetime to return results for.</param>
        /// <param name="reportEndDate">The ISO 8601 end date/datetime to return results for.</param>
        public GetEthCollectionListingsOHLCRequest(string collectionAddress = default(string), bool floorOnly = default(bool), string frequency = default(string), ReptCurrEnum? reptCurr = default(ReptCurrEnum?), string reportStartDate = default(string), string reportEndDate = default(string))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for GetEthCollectionListingsOHLCRequest and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            this.FloorOnly = floorOnly;
            this.Frequency = frequency;
            this.ReptCurr = reptCurr;
            this.ReportStartDate = reportStartDate;
            this.ReportEndDate = reportEndDate;
        }

        /// <summary>
        /// The Ethereum contract address to identify the collection.
        /// </summary>
        /// <value>The Ethereum contract address to identify the collection.</value>
        /// <example>&quot;0x7bd29408f11d2bfc23c34f18275bbf23bb716bc7&quot;</example>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// If &#x60;true&#x60;, report only historical floor prices. Otherwise, report OHFC candlesticks, number of active listings, number of unique owners and the average age of open listings.
        /// </summary>
        /// <value>If &#x60;true&#x60;, report only historical floor prices. Otherwise, report OHFC candlesticks, number of active listings, number of unique owners and the average age of open listings.</value>
        /// <example>true</example>
        [DataMember(Name = "floor_only", EmitDefaultValue = true)]
        public bool FloorOnly { get; set; }

        /// <summary>
        /// The interval at which to return Floor prices / OHLF, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc. Must be &gt;&#x3D; &#x60;6H&#x60;
        /// </summary>
        /// <value>The interval at which to return Floor prices / OHLF, e.g. &#x60;1D&#x60; for daily, &#x60;1M&#x60; for monthly etc. Must be &gt;&#x3D; &#x60;6H&#x60;</value>
        /// <example>&quot;1D&quot;</example>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The ISO 8601 start date/datetime to return results for
        /// </summary>
        /// <value>The ISO 8601 start date/datetime to return results for</value>
        /// <example>&quot;2023-01-01&quot;</example>
        [DataMember(Name = "report_start_date", EmitDefaultValue = false)]
        public string ReportStartDate { get; set; }

        /// <summary>
        /// The ISO 8601 end date/datetime to return results for
        /// </summary>
        /// <value>The ISO 8601 end date/datetime to return results for</value>
        /// <example>&quot;2023-01-04&quot;</example>
        [DataMember(Name = "report_end_date", EmitDefaultValue = false)]
        public string ReportEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEthCollectionListingsOHLCRequest {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  FloorOnly: ").Append(FloorOnly).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  ReptCurr: ").Append(ReptCurr).Append("\n");
            sb.Append("  ReportStartDate: ").Append(ReportStartDate).Append("\n");
            sb.Append("  ReportEndDate: ").Append(ReportEndDate).Append("\n");
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
            return this.Equals(input as GetEthCollectionListingsOHLCRequest);
        }

        /// <summary>
        /// Returns true if GetEthCollectionListingsOHLCRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEthCollectionListingsOHLCRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEthCollectionListingsOHLCRequest input)
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
                    this.FloorOnly == input.FloorOnly ||
                    this.FloorOnly.Equals(input.FloorOnly)
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
                    this.ReportStartDate == input.ReportStartDate ||
                    (this.ReportStartDate != null &&
                    this.ReportStartDate.Equals(input.ReportStartDate))
                ) && 
                (
                    this.ReportEndDate == input.ReportEndDate ||
                    (this.ReportEndDate != null &&
                    this.ReportEndDate.Equals(input.ReportEndDate))
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
                hashCode = (hashCode * 59) + this.FloorOnly.GetHashCode();
                if (this.Frequency != null)
                {
                    hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReptCurr.GetHashCode();
                if (this.ReportStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReportStartDate.GetHashCode();
                }
                if (this.ReportEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReportEndDate.GetHashCode();
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
