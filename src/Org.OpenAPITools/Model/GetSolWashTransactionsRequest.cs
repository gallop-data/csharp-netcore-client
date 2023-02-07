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
    /// GetSolWashTransactionsRequest
    /// </summary>
    [DataContract(Name = "getSolWashTransactions_request")]
    public partial class GetSolWashTransactionsRequest : IEquatable<GetSolWashTransactionsRequest>, IValidatableObject
    {
        /// <summary>
        /// The number of records returned per page.
        /// </summary>
        /// <value>The number of records returned per page.</value>
        public enum PageSizeEnum
        {
            /// <summary>
            /// Enum NUMBER_50 for value: 50
            /// </summary>
            NUMBER_50 = 50,

            /// <summary>
            /// Enum NUMBER_100 for value: 100
            /// </summary>
            NUMBER_100 = 100,

            /// <summary>
            /// Enum NUMBER_500 for value: 500
            /// </summary>
            NUMBER_500 = 500,

            /// <summary>
            /// Enum NUMBER_1000 for value: 1000
            /// </summary>
            NUMBER_1000 = 1000

        }


        /// <summary>
        /// The number of records returned per page.
        /// </summary>
        /// <value>The number of records returned per page.</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public PageSizeEnum? PageSize { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolWashTransactionsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSolWashTransactionsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolWashTransactionsRequest" /> class.
        /// </summary>
        /// <param name="collectionTag">The Gallop slug for the collection. Please see sol/getCollections endpoint. (required).</param>
        /// <param name="mintAddress">An optional list of token addresses..</param>
        /// <param name="page">The pagination cursor..</param>
        /// <param name="pageSize">The number of records returned per page..</param>
        public GetSolWashTransactionsRequest(string collectionTag = default(string), List<string> mintAddress = default(List<string>), int page = default(int), PageSizeEnum? pageSize = default(PageSizeEnum?))
        {
            // to ensure "collectionTag" is required (not null)
            if (collectionTag == null)
            {
                throw new ArgumentNullException("collectionTag is a required property for GetSolWashTransactionsRequest and cannot be null");
            }
            this.CollectionTag = collectionTag;
            this.MintAddress = mintAddress;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// The Gallop slug for the collection. Please see sol/getCollections endpoint.
        /// </summary>
        /// <value>The Gallop slug for the collection. Please see sol/getCollections endpoint.</value>
        [DataMember(Name = "collection_tag", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionTag { get; set; }

        /// <summary>
        /// An optional list of token addresses.
        /// </summary>
        /// <value>An optional list of token addresses.</value>
        [DataMember(Name = "mint_address", EmitDefaultValue = false)]
        public List<string> MintAddress { get; set; }

        /// <summary>
        /// The pagination cursor.
        /// </summary>
        /// <value>The pagination cursor.</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSolWashTransactionsRequest {\n");
            sb.Append("  CollectionTag: ").Append(CollectionTag).Append("\n");
            sb.Append("  MintAddress: ").Append(MintAddress).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as GetSolWashTransactionsRequest);
        }

        /// <summary>
        /// Returns true if GetSolWashTransactionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSolWashTransactionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSolWashTransactionsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CollectionTag == input.CollectionTag ||
                    (this.CollectionTag != null &&
                    this.CollectionTag.Equals(input.CollectionTag))
                ) && 
                (
                    this.MintAddress == input.MintAddress ||
                    this.MintAddress != null &&
                    input.MintAddress != null &&
                    this.MintAddress.SequenceEqual(input.MintAddress)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.CollectionTag != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionTag.GetHashCode();
                }
                if (this.MintAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MintAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
