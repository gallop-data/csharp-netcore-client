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
    /// GetPolTokenSummaryRequest
    /// </summary>
    [DataContract(Name = "getPolTokenSummary_request")]
    public partial class GetPolTokenSummaryRequest : IEquatable<GetPolTokenSummaryRequest>, IValidatableObject
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
            Usd = 2,

            /// <summary>
            /// Enum Matic for value: matic
            /// </summary>
            [EnumMember(Value = "matic")]
            Matic = 3

        }


        /// <summary>
        /// The currency to report results in
        /// </summary>
        /// <value>The currency to report results in</value>
        [DataMember(Name = "rept_curr", EmitDefaultValue = false)]
        public ReptCurrEnum? ReptCurr { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolTokenSummaryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPolTokenSummaryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolTokenSummaryRequest" /> class.
        /// </summary>
        /// <param name="collectionAddress">The contract address of the token collection. (required).</param>
        /// <param name="tokenId">The id for the token. (required).</param>
        /// <param name="startDate">The start date to pull data for calculations.</param>
        /// <param name="endDate">The end date to pull data for calculations.</param>
        /// <param name="reptCurr">The currency to report results in.</param>
        /// <param name="excludeWash">Exclude suspected wash transactions?.</param>
        public GetPolTokenSummaryRequest(string collectionAddress = default(string), List<string> tokenId = default(List<string>), string startDate = default(string), string endDate = default(string), ReptCurrEnum? reptCurr = default(ReptCurrEnum?), bool excludeWash = default(bool))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for GetPolTokenSummaryRequest and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for GetPolTokenSummaryRequest and cannot be null");
            }
            this.TokenId = tokenId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ReptCurr = reptCurr;
            this.ExcludeWash = excludeWash;
        }

        /// <summary>
        /// The contract address of the token collection.
        /// </summary>
        /// <value>The contract address of the token collection.</value>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// The id for the token.
        /// </summary>
        /// <value>The id for the token.</value>
        [DataMember(Name = "token_id", IsRequired = true, EmitDefaultValue = true)]
        public List<string> TokenId { get; set; }

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
        /// Exclude suspected wash transactions?
        /// </summary>
        /// <value>Exclude suspected wash transactions?</value>
        [DataMember(Name = "exclude_wash", EmitDefaultValue = true)]
        public bool ExcludeWash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPolTokenSummaryRequest {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ReptCurr: ").Append(ReptCurr).Append("\n");
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
            return this.Equals(input as GetPolTokenSummaryRequest);
        }

        /// <summary>
        /// Returns true if GetPolTokenSummaryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPolTokenSummaryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPolTokenSummaryRequest input)
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
                    this.ReptCurr == input.ReptCurr ||
                    this.ReptCurr.Equals(input.ReptCurr)
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
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReptCurr.GetHashCode();
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
