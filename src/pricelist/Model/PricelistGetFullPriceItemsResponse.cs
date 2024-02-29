/*
 * pricelist/service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
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
    /// PricelistGetFullPriceItemsResponse
    /// </summary>
    [DataContract(Name = "pricelistGetFullPriceItemsResponse")]
    public partial class PricelistGetFullPriceItemsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricelistGetFullPriceItemsResponse" /> class.
        /// </summary>
        /// <param name="priceItems">priceItems.</param>
        public PricelistGetFullPriceItemsResponse(List<PricelistGetFullPriceItem> priceItems = default(List<PricelistGetFullPriceItem>))
        {
            this.PriceItems = priceItems;
        }

        /// <summary>
        /// Gets or Sets PriceItems
        /// </summary>
        [DataMember(Name = "priceItems", EmitDefaultValue = false)]
        public List<PricelistGetFullPriceItem> PriceItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricelistGetFullPriceItemsResponse {\n");
            sb.Append("  PriceItems: ").Append(PriceItems).Append("\n");
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
