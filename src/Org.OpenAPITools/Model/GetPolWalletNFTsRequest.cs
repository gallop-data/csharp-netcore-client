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
    /// GetPolWalletNFTsRequest
    /// </summary>
    [DataContract(Name = "getPolWalletNFTs_request")]
    public partial class GetPolWalletNFTsRequest : IEquatable<GetPolWalletNFTsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolWalletNFTsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPolWalletNFTsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolWalletNFTsRequest" /> class.
        /// </summary>
        /// <param name="walletAddress">The wallet address to search. (required).</param>
        public GetPolWalletNFTsRequest(string walletAddress = default(string))
        {
            // to ensure "walletAddress" is required (not null)
            if (walletAddress == null)
            {
                throw new ArgumentNullException("walletAddress is a required property for GetPolWalletNFTsRequest and cannot be null");
            }
            this.WalletAddress = walletAddress;
        }

        /// <summary>
        /// The wallet address to search.
        /// </summary>
        /// <value>The wallet address to search.</value>
        /// <example>&quot;0xab0cda4cc21207fd9433356afe9428b6fac8a8a5&quot;</example>
        [DataMember(Name = "wallet_address", IsRequired = true, EmitDefaultValue = true)]
        public string WalletAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPolWalletNFTsRequest {\n");
            sb.Append("  WalletAddress: ").Append(WalletAddress).Append("\n");
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
            return this.Equals(input as GetPolWalletNFTsRequest);
        }

        /// <summary>
        /// Returns true if GetPolWalletNFTsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPolWalletNFTsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPolWalletNFTsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WalletAddress == input.WalletAddress ||
                    (this.WalletAddress != null &&
                    this.WalletAddress.Equals(input.WalletAddress))
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
                if (this.WalletAddress != null)
                {
                    hashCode = (hashCode * 59) + this.WalletAddress.GetHashCode();
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
