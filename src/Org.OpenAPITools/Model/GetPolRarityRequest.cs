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
    /// GetPolRarityRequest
    /// </summary>
    [DataContract(Name = "getPolRarity_request")]
    public partial class GetPolRarityRequest : IEquatable<GetPolRarityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolRarityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPolRarityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolRarityRequest" /> class.
        /// </summary>
        /// <param name="collectionAddress">The Polygon contract address to identify the collection. (required).</param>
        /// <param name="weights">Dict containing trait keys and weight values..</param>
        /// <param name="tokenId">An array of token ids..</param>
        public GetPolRarityRequest(string collectionAddress = default(string), Object weights = default(Object), List<string> tokenId = default(List<string>))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for GetPolRarityRequest and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            this.Weights = weights;
            this.TokenId = tokenId;
        }

        /// <summary>
        /// The Polygon contract address to identify the collection.
        /// </summary>
        /// <value>The Polygon contract address to identify the collection.</value>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// Dict containing trait keys and weight values.
        /// </summary>
        /// <value>Dict containing trait keys and weight values.</value>
        [DataMember(Name = "weights", EmitDefaultValue = false)]
        public Object Weights { get; set; }

        /// <summary>
        /// An array of token ids.
        /// </summary>
        /// <value>An array of token ids.</value>
        [DataMember(Name = "token_id", EmitDefaultValue = false)]
        public List<string> TokenId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPolRarityRequest {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  Weights: ").Append(Weights).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
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
            return this.Equals(input as GetPolRarityRequest);
        }

        /// <summary>
        /// Returns true if GetPolRarityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPolRarityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPolRarityRequest input)
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
                    this.Weights == input.Weights ||
                    (this.Weights != null &&
                    this.Weights.Equals(input.Weights))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    this.TokenId != null &&
                    input.TokenId != null &&
                    this.TokenId.SequenceEqual(input.TokenId)
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
                if (this.Weights != null)
                {
                    hashCode = (hashCode * 59) + this.Weights.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
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
