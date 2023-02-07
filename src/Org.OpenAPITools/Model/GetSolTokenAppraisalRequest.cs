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
    /// GetSolTokenAppraisalRequest
    /// </summary>
    [DataContract(Name = "getSolTokenAppraisal_request")]
    public partial class GetSolTokenAppraisalRequest : IEquatable<GetSolTokenAppraisalRequest>, IValidatableObject
    {
        /// <summary>
        /// The currency to report results in
        /// </summary>
        /// <value>The currency to report results in</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReptCurrEnum
        {
            /// <summary>
            /// Enum Sol for value: sol
            /// </summary>
            [EnumMember(Value = "sol")]
            Sol = 1,

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
        /// Initializes a new instance of the <see cref="GetSolTokenAppraisalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSolTokenAppraisalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolTokenAppraisalRequest" /> class.
        /// </summary>
        /// <param name="mintAddress">List of mint addresses of tokens to appraise (required).</param>
        /// <param name="reptCurr">The currency to report results in.</param>
        /// <param name="frequency">The interval at which to calculate intermediate results and forecasts..</param>
        /// <param name="horizon">The forecast horizon (i.e. the number of periods to forecast out). Defaults to zero which only returns nowcasts..</param>
        /// <param name="alpha">The significance level for the liquidation estimate, e.g. 0.05 for 95% confidence.</param>
        /// <param name="excludeWash">Exclude suspected wash transactions?.</param>
        public GetSolTokenAppraisalRequest(List<string> mintAddress = default(List<string>), ReptCurrEnum? reptCurr = default(ReptCurrEnum?), string frequency = default(string), int horizon = default(int), decimal alpha = default(decimal), bool excludeWash = default(bool))
        {
            // to ensure "mintAddress" is required (not null)
            if (mintAddress == null)
            {
                throw new ArgumentNullException("mintAddress is a required property for GetSolTokenAppraisalRequest and cannot be null");
            }
            this.MintAddress = mintAddress;
            this.ReptCurr = reptCurr;
            this.Frequency = frequency;
            this.Horizon = horizon;
            this.Alpha = alpha;
            this.ExcludeWash = excludeWash;
        }

        /// <summary>
        /// List of mint addresses of tokens to appraise
        /// </summary>
        /// <value>List of mint addresses of tokens to appraise</value>
        [DataMember(Name = "mint_address", IsRequired = true, EmitDefaultValue = true)]
        public List<string> MintAddress { get; set; }

        /// <summary>
        /// The interval at which to calculate intermediate results and forecasts.
        /// </summary>
        /// <value>The interval at which to calculate intermediate results and forecasts.</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The forecast horizon (i.e. the number of periods to forecast out). Defaults to zero which only returns nowcasts.
        /// </summary>
        /// <value>The forecast horizon (i.e. the number of periods to forecast out). Defaults to zero which only returns nowcasts.</value>
        [DataMember(Name = "horizon", EmitDefaultValue = false)]
        public int Horizon { get; set; }

        /// <summary>
        /// The significance level for the liquidation estimate, e.g. 0.05 for 95% confidence
        /// </summary>
        /// <value>The significance level for the liquidation estimate, e.g. 0.05 for 95% confidence</value>
        [DataMember(Name = "alpha", EmitDefaultValue = false)]
        public decimal Alpha { get; set; }

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
            sb.Append("class GetSolTokenAppraisalRequest {\n");
            sb.Append("  MintAddress: ").Append(MintAddress).Append("\n");
            sb.Append("  ReptCurr: ").Append(ReptCurr).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Horizon: ").Append(Horizon).Append("\n");
            sb.Append("  Alpha: ").Append(Alpha).Append("\n");
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
            return this.Equals(input as GetSolTokenAppraisalRequest);
        }

        /// <summary>
        /// Returns true if GetSolTokenAppraisalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSolTokenAppraisalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSolTokenAppraisalRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MintAddress == input.MintAddress ||
                    this.MintAddress != null &&
                    input.MintAddress != null &&
                    this.MintAddress.SequenceEqual(input.MintAddress)
                ) && 
                (
                    this.ReptCurr == input.ReptCurr ||
                    this.ReptCurr.Equals(input.ReptCurr)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Horizon == input.Horizon ||
                    this.Horizon.Equals(input.Horizon)
                ) && 
                (
                    this.Alpha == input.Alpha ||
                    this.Alpha.Equals(input.Alpha)
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
                if (this.MintAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MintAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReptCurr.GetHashCode();
                if (this.Frequency != null)
                {
                    hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Horizon.GetHashCode();
                hashCode = (hashCode * 59) + this.Alpha.GetHashCode();
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
