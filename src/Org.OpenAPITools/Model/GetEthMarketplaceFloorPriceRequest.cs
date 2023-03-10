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
    /// GetEthMarketplaceFloorPriceRequest
    /// </summary>
    [DataContract(Name = "getEthMarketplaceFloorPrice_request")]
    public partial class GetEthMarketplaceFloorPriceRequest : IEquatable<GetEthMarketplaceFloorPriceRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="GetEthMarketplaceFloorPriceRequest" /> class.
        /// </summary>
        /// <param name="page">The pagination cursor..</param>
        /// <param name="pageSize">The number of records returned per page..</param>
        /// <param name="collectionAddress">Array of collection addresses.</param>
        public GetEthMarketplaceFloorPriceRequest(int page = default(int), PageSizeEnum? pageSize = default(PageSizeEnum?), List<string> collectionAddress = default(List<string>))
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.CollectionAddress = collectionAddress;
        }

        /// <summary>
        /// The pagination cursor.
        /// </summary>
        /// <value>The pagination cursor.</value>
        /// <example>1</example>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Array of collection addresses
        /// </summary>
        /// <value>Array of collection addresses</value>
        [DataMember(Name = "collection_address", EmitDefaultValue = false)]
        public List<string> CollectionAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEthMarketplaceFloorPriceRequest {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
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
            return this.Equals(input as GetEthMarketplaceFloorPriceRequest);
        }

        /// <summary>
        /// Returns true if GetEthMarketplaceFloorPriceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEthMarketplaceFloorPriceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEthMarketplaceFloorPriceRequest input)
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
                    this.CollectionAddress == input.CollectionAddress ||
                    this.CollectionAddress != null &&
                    input.CollectionAddress != null &&
                    this.CollectionAddress.SequenceEqual(input.CollectionAddress)
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
                if (this.CollectionAddress != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionAddress.GetHashCode();
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
