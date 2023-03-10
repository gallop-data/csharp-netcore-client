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
    /// GetPolCollectionOwnersRequest
    /// </summary>
    [DataContract(Name = "getPolCollectionOwners_request")]
    public partial class GetPolCollectionOwnersRequest : IEquatable<GetPolCollectionOwnersRequest>, IValidatableObject
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
        /// <example>100</example>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public PageSizeEnum? PageSize { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolCollectionOwnersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPolCollectionOwnersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolCollectionOwnersRequest" /> class.
        /// </summary>
        /// <param name="collectionAddress">The contract address of the collection. (required).</param>
        /// <param name="page">The pagination cursor..</param>
        /// <param name="pageSize">The number of records returned per page..</param>
        public GetPolCollectionOwnersRequest(string collectionAddress = default(string), int page = default(int), PageSizeEnum? pageSize = default(PageSizeEnum?))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for GetPolCollectionOwnersRequest and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// The contract address of the collection.
        /// </summary>
        /// <value>The contract address of the collection.</value>
        /// <example>&quot;0x78306a498516d75a76beeacea04fe772d20fe41b&quot;</example>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// The pagination cursor.
        /// </summary>
        /// <value>The pagination cursor.</value>
        /// <example>1</example>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPolCollectionOwnersRequest {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
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
            return this.Equals(input as GetPolCollectionOwnersRequest);
        }

        /// <summary>
        /// Returns true if GetPolCollectionOwnersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPolCollectionOwnersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPolCollectionOwnersRequest input)
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
                if (this.CollectionAddress != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionAddress.GetHashCode();
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
