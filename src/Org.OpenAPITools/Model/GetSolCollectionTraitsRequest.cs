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
    /// GetSolCollectionTraitsRequest
    /// </summary>
    [DataContract(Name = "getSolCollectionTraits_request")]
    public partial class GetSolCollectionTraitsRequest : IEquatable<GetSolCollectionTraitsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolCollectionTraitsRequest" /> class.
        /// </summary>
        /// <param name="collectionTag">The tag of the collection..</param>
        public GetSolCollectionTraitsRequest(string collectionTag = default(string))
        {
            this.CollectionTag = collectionTag;
        }

        /// <summary>
        /// The tag of the collection.
        /// </summary>
        /// <value>The tag of the collection.</value>
        /// <example>&quot;solanamonkerejectsget&quot;</example>
        [DataMember(Name = "collection_tag", EmitDefaultValue = false)]
        public string CollectionTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSolCollectionTraitsRequest {\n");
            sb.Append("  CollectionTag: ").Append(CollectionTag).Append("\n");
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
            return this.Equals(input as GetSolCollectionTraitsRequest);
        }

        /// <summary>
        /// Returns true if GetSolCollectionTraitsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSolCollectionTraitsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSolCollectionTraitsRequest input)
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
