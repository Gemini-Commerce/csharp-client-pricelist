/*
 * PriceList Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
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
using OpenAPIDateConverter = pricelist.Client.OpenAPIDateConverter;

namespace pricelist.Model
{
    /// <summary>
    /// PricelistPriceListTypeFilter
    /// </summary>
    [DataContract(Name = "pricelistPriceListTypeFilter")]
    public partial class PricelistPriceListTypeFilter : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public PricelistFilterCondition? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PricelistPriceListTypeFilter" /> class.
        /// </summary>
        /// <param name="pricelistTypes">pricelistTypes.</param>
        /// <param name="condition">condition.</param>
        public PricelistPriceListTypeFilter(List<PricelistPriceListType> pricelistTypes = default(List<PricelistPriceListType>), PricelistFilterCondition? condition = default(PricelistFilterCondition?))
        {
            this.PricelistTypes = pricelistTypes;
            this.Condition = condition;
        }

        /// <summary>
        /// Gets or Sets PricelistTypes
        /// </summary>
        [DataMember(Name = "pricelistTypes", EmitDefaultValue = false)]
        public List<PricelistPriceListType> PricelistTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricelistPriceListTypeFilter {\n");
            sb.Append("  PricelistTypes: ").Append(PricelistTypes).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
