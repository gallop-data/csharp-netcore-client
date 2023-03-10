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
    /// JSON containing options for the ARCH family model
    /// </summary>
    [DataContract(Name = "getSolCollectionForecasts_request_arch_params")]
    public partial class GetSolCollectionForecastsRequestArchParams : IEquatable<GetSolCollectionForecastsRequestArchParams>, IValidatableObject
    {
        /// <summary>
        /// Return distribution assumed
        /// </summary>
        /// <value>Return distribution assumed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DistEnum
        {
            /// <summary>
            /// Enum Norm for value: norm
            /// </summary>
            [EnumMember(Value = "norm")]
            Norm = 1,

            /// <summary>
            /// Enum T for value: t
            /// </summary>
            [EnumMember(Value = "t")]
            T = 2

        }


        /// <summary>
        /// Return distribution assumed
        /// </summary>
        /// <value>Return distribution assumed</value>
        [DataMember(Name = "dist", EmitDefaultValue = false)]
        public DistEnum? Dist { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolCollectionForecastsRequestArchParams" /> class.
        /// </summary>
        /// <param name="mean">Estimator for the location model of the time series, e.g: &#x60;Zero&#x60;, &#x60;Constant&#x60;, &#x60;ARX&#x60;, ... . .</param>
        /// <param name="lags">Number of time time period lags considered. Note that the time period is set by the &#x60;frequency&#x60; parameter, so a value of 2 will assume 2-day lags if &#x60;frequency&#x3D;&#x3D;&#39;1D&#39;&#x60;..</param>
        /// <param name="vol">Estimator used for the volatility process of the time series, e.g: &#x60;Constant&#x60;, &#x60;ARCH&#x60;, &#x60;GARCH&#x60;, ... .</param>
        /// <param name="p">Order of the symmetric innovation(s)..</param>
        /// <param name="dist">Return distribution assumed.</param>
        public GetSolCollectionForecastsRequestArchParams(string mean = default(string), int lags = default(int), string vol = default(string), int p = default(int), DistEnum? dist = default(DistEnum?))
        {
            this.Mean = mean;
            this.Lags = lags;
            this.Vol = vol;
            this.P = p;
            this.Dist = dist;
        }

        /// <summary>
        /// Estimator for the location model of the time series, e.g: &#x60;Zero&#x60;, &#x60;Constant&#x60;, &#x60;ARX&#x60;, ... . 
        /// </summary>
        /// <value>Estimator for the location model of the time series, e.g: &#x60;Zero&#x60;, &#x60;Constant&#x60;, &#x60;ARX&#x60;, ... . </value>
        [DataMember(Name = "mean", EmitDefaultValue = false)]
        public string Mean { get; set; }

        /// <summary>
        /// Number of time time period lags considered. Note that the time period is set by the &#x60;frequency&#x60; parameter, so a value of 2 will assume 2-day lags if &#x60;frequency&#x3D;&#x3D;&#39;1D&#39;&#x60;.
        /// </summary>
        /// <value>Number of time time period lags considered. Note that the time period is set by the &#x60;frequency&#x60; parameter, so a value of 2 will assume 2-day lags if &#x60;frequency&#x3D;&#x3D;&#39;1D&#39;&#x60;.</value>
        [DataMember(Name = "lags", EmitDefaultValue = false)]
        public int Lags { get; set; }

        /// <summary>
        /// Estimator used for the volatility process of the time series, e.g: &#x60;Constant&#x60;, &#x60;ARCH&#x60;, &#x60;GARCH&#x60;, ... 
        /// </summary>
        /// <value>Estimator used for the volatility process of the time series, e.g: &#x60;Constant&#x60;, &#x60;ARCH&#x60;, &#x60;GARCH&#x60;, ... </value>
        [DataMember(Name = "vol", EmitDefaultValue = false)]
        public string Vol { get; set; }

        /// <summary>
        /// Order of the symmetric innovation(s).
        /// </summary>
        /// <value>Order of the symmetric innovation(s).</value>
        [DataMember(Name = "p", EmitDefaultValue = false)]
        public int P { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSolCollectionForecastsRequestArchParams {\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Lags: ").Append(Lags).Append("\n");
            sb.Append("  Vol: ").Append(Vol).Append("\n");
            sb.Append("  P: ").Append(P).Append("\n");
            sb.Append("  Dist: ").Append(Dist).Append("\n");
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
            return this.Equals(input as GetSolCollectionForecastsRequestArchParams);
        }

        /// <summary>
        /// Returns true if GetSolCollectionForecastsRequestArchParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSolCollectionForecastsRequestArchParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSolCollectionForecastsRequestArchParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mean == input.Mean ||
                    (this.Mean != null &&
                    this.Mean.Equals(input.Mean))
                ) && 
                (
                    this.Lags == input.Lags ||
                    this.Lags.Equals(input.Lags)
                ) && 
                (
                    this.Vol == input.Vol ||
                    (this.Vol != null &&
                    this.Vol.Equals(input.Vol))
                ) && 
                (
                    this.P == input.P ||
                    this.P.Equals(input.P)
                ) && 
                (
                    this.Dist == input.Dist ||
                    this.Dist.Equals(input.Dist)
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
                if (this.Mean != null)
                {
                    hashCode = (hashCode * 59) + this.Mean.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Lags.GetHashCode();
                if (this.Vol != null)
                {
                    hashCode = (hashCode * 59) + this.Vol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.P.GetHashCode();
                hashCode = (hashCode * 59) + this.Dist.GetHashCode();
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
