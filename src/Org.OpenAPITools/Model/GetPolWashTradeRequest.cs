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
    /// GetPolWashTradeRequest
    /// </summary>
    [DataContract(Name = "getPolWashTrade_request")]
    public partial class GetPolWashTradeRequest : IEquatable<GetPolWashTradeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolWashTradeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPolWashTradeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolWashTradeRequest" /> class.
        /// </summary>
        /// <param name="transactionHash">The transaction hash to valildate. (required).</param>
        public GetPolWashTradeRequest(string transactionHash = default(string))
        {
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for GetPolWashTradeRequest and cannot be null");
            }
            this.TransactionHash = transactionHash;
        }

        /// <summary>
        /// The transaction hash to valildate.
        /// </summary>
        /// <value>The transaction hash to valildate.</value>
        /// <example>&quot;0x40692e18987ef5237cb0f9f0eaf8898e044a140b94d1cfc2a66dc9eb39033c1a&quot;</example>
        [DataMember(Name = "transaction_hash", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPolWashTradeRequest {\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
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
            return this.Equals(input as GetPolWashTradeRequest);
        }

        /// <summary>
        /// Returns true if GetPolWashTradeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPolWashTradeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPolWashTradeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
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
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
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
