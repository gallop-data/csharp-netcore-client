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
    /// GetSolNFTAccountRequest
    /// </summary>
    [DataContract(Name = "getSolNFTAccount_request")]
    public partial class GetSolNFTAccountRequest : IEquatable<GetSolNFTAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolNFTAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSolNFTAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolNFTAccountRequest" /> class.
        /// </summary>
        /// <param name="mintAddress">The Solana token mint address. (required).</param>
        public GetSolNFTAccountRequest(string mintAddress = default(string))
        {
            // to ensure "mintAddress" is required (not null)
            if (mintAddress == null)
            {
                throw new ArgumentNullException("mintAddress is a required property for GetSolNFTAccountRequest and cannot be null");
            }
            this.MintAddress = mintAddress;
        }

        /// <summary>
        /// The Solana token mint address.
        /// </summary>
        /// <value>The Solana token mint address.</value>
        /// <example>&quot;G6oNTZRyrU2tN1YnWREmFaLwEcMA7QDoCscxon4Xrkbp&quot;</example>
        [DataMember(Name = "mint_address", IsRequired = true, EmitDefaultValue = true)]
        public string MintAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSolNFTAccountRequest {\n");
            sb.Append("  MintAddress: ").Append(MintAddress).Append("\n");
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
            return this.Equals(input as GetSolNFTAccountRequest);
        }

        /// <summary>
        /// Returns true if GetSolNFTAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSolNFTAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSolNFTAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MintAddress == input.MintAddress ||
                    (this.MintAddress != null &&
                    this.MintAddress.Equals(input.MintAddress))
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
