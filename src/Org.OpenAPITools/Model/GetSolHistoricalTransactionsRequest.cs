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
    /// GetSolHistoricalTransactionsRequest
    /// </summary>
    [DataContract(Name = "getSolHistoricalTransactions_request")]
    public partial class GetSolHistoricalTransactionsRequest : IEquatable<GetSolHistoricalTransactionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolHistoricalTransactionsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSolHistoricalTransactionsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolHistoricalTransactionsRequest" /> class.
        /// </summary>
        /// <param name="collectionTag">The Gallop slug for the collection. Please see sol/getCollections endpoint. (required).</param>
        /// <param name="page">The pagination cursor..</param>
        public GetSolHistoricalTransactionsRequest(string collectionTag = default(string), int page = default(int))
        {
            // to ensure "collectionTag" is required (not null)
            if (collectionTag == null)
            {
                throw new ArgumentNullException("collectionTag is a required property for GetSolHistoricalTransactionsRequest and cannot be null");
            }
            this.CollectionTag = collectionTag;
            this.Page = page;
        }

        /// <summary>
        /// The Gallop slug for the collection. Please see sol/getCollections endpoint.
        /// </summary>
        /// <value>The Gallop slug for the collection. Please see sol/getCollections endpoint.</value>
        [DataMember(Name = "collection_tag", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionTag { get; set; }

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
            sb.Append("class GetSolHistoricalTransactionsRequest {\n");
            sb.Append("  CollectionTag: ").Append(CollectionTag).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return this.Equals(input as GetSolHistoricalTransactionsRequest);
        }

        /// <summary>
        /// Returns true if GetSolHistoricalTransactionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSolHistoricalTransactionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSolHistoricalTransactionsRequest input)
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
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
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
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
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
