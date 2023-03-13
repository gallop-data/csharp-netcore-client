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
    /// GetPolCollectionsRequest
    /// </summary>
    [DataContract(Name = "getPolCollections_request")]
    public partial class GetPolCollectionsRequest : IEquatable<GetPolCollectionsRequest>, IValidatableObject
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
        /// The value to sort by. Defaults to created_at
        /// </summary>
        /// <value>The value to sort by. Defaults to created_at</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortByEnum
        {
            /// <summary>
            /// Enum CreatedAt for value: created_at
            /// </summary>
            [EnumMember(Value = "created_at")]
            CreatedAt = 1,

            /// <summary>
            /// Enum CollectionName for value: collection_name
            /// </summary>
            [EnumMember(Value = "collection_name")]
            CollectionName = 2

        }


        /// <summary>
        /// The value to sort by. Defaults to created_at
        /// </summary>
        /// <value>The value to sort by. Defaults to created_at</value>
        /// <example>&quot;created_at&quot;</example>
        [DataMember(Name = "sort_by", EmitDefaultValue = false)]
        public SortByEnum? SortBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolCollectionsRequest" /> class.
        /// </summary>
        /// <param name="page">The pagination cursor..</param>
        /// <param name="pageSize">The number of records returned per page..</param>
        /// <param name="collectionName">The name of the collection searched..</param>
        /// <param name="traded">Only return collections that have traded..</param>
        /// <param name="createdAfter">Only return collections recorded after this day [YYYY-MM-DD].</param>
        /// <param name="sortBy">The value to sort by. Defaults to created_at.</param>
        public GetPolCollectionsRequest(int page = default(int), PageSizeEnum? pageSize = default(PageSizeEnum?), string collectionName = default(string), bool traded = default(bool), string createdAfter = default(string), SortByEnum? sortBy = default(SortByEnum?))
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.CollectionName = collectionName;
            this.Traded = traded;
            this.CreatedAfter = createdAfter;
            this.SortBy = sortBy;
        }

        /// <summary>
        /// The pagination cursor.
        /// </summary>
        /// <value>The pagination cursor.</value>
        /// <example>1</example>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// The name of the collection searched.
        /// </summary>
        /// <value>The name of the collection searched.</value>
        /// <example>&quot;punks&quot;</example>
        [DataMember(Name = "collection_name", EmitDefaultValue = false)]
        public string CollectionName { get; set; }

        /// <summary>
        /// Only return collections that have traded.
        /// </summary>
        /// <value>Only return collections that have traded.</value>
        /// <example>true</example>
        [DataMember(Name = "traded", EmitDefaultValue = true)]
        public bool Traded { get; set; }

        /// <summary>
        /// Only return collections recorded after this day [YYYY-MM-DD]
        /// </summary>
        /// <value>Only return collections recorded after this day [YYYY-MM-DD]</value>
        /// <example>&quot;2023-01-15&quot;</example>
        [DataMember(Name = "created_after", EmitDefaultValue = false)]
        public string CreatedAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPolCollectionsRequest {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  CollectionName: ").Append(CollectionName).Append("\n");
            sb.Append("  Traded: ").Append(Traded).Append("\n");
            sb.Append("  CreatedAfter: ").Append(CreatedAfter).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
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
            return this.Equals(input as GetPolCollectionsRequest);
        }

        /// <summary>
        /// Returns true if GetPolCollectionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPolCollectionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPolCollectionsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.CollectionName == input.CollectionName ||
                    (this.CollectionName != null &&
                    this.CollectionName.Equals(input.CollectionName))
                ) && 
                (
                    this.Traded == input.Traded ||
                    this.Traded.Equals(input.Traded)
                ) && 
                (
                    this.CreatedAfter == input.CreatedAfter ||
                    (this.CreatedAfter != null &&
                    this.CreatedAfter.Equals(input.CreatedAfter))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    this.SortBy.Equals(input.SortBy)
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
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.CollectionName != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Traded.GetHashCode();
                if (this.CreatedAfter != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAfter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortBy.GetHashCode();
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
