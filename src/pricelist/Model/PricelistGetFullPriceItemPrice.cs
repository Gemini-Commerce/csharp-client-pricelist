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
    /// PricelistGetFullPriceItemPrice
    /// </summary>
    [DataContract(Name = "pricelistGetFullPriceItemPrice")]
    public partial class PricelistGetFullPriceItemPrice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricelistGetFullPriceItemPrice" /> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="startAt">startAt.</param>
        /// <param name="endAt">endAt.</param>
        /// <param name="order">order.</param>
        /// <param name="basePrice">basePrice.</param>
        public PricelistGetFullPriceItemPrice(PricelistMoney price = default(PricelistMoney), bool isEnabled = default(bool), DateTime startAt = default(DateTime), DateTime endAt = default(DateTime), long order = default(long), PricelistMoney basePrice = default(PricelistMoney))
        {
            this.Price = price;
            this.IsEnabled = isEnabled;
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Order = order;
            this.BasePrice = basePrice;
        }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public PricelistMoney Price { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets StartAt
        /// </summary>
        [DataMember(Name = "startAt", EmitDefaultValue = false)]
        public DateTime StartAt { get; set; }

        /// <summary>
        /// Gets or Sets EndAt
        /// </summary>
        [DataMember(Name = "endAt", EmitDefaultValue = false)]
        public DateTime EndAt { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public long Order { get; set; }

        /// <summary>
        /// Gets or Sets BasePrice
        /// </summary>
        [DataMember(Name = "basePrice", EmitDefaultValue = false)]
        public PricelistMoney BasePrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricelistGetFullPriceItemPrice {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  BasePrice: ").Append(BasePrice).Append("\n");
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
