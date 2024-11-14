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
    /// PricelistGetFullPriceItem
    /// </summary>
    [DataContract(Name = "pricelistGetFullPriceItem")]
    public partial class PricelistGetFullPriceItem : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public PricelistCurrency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PricelistGetFullPriceItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="grn">grn.</param>
        /// <param name="itemGrn">itemGrn.</param>
        /// <param name="basePrice">basePrice.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="currency">currency.</param>
        /// <param name="prices">prices.</param>
        /// <param name="hasTierPrices">hasTierPrices.</param>
        public PricelistGetFullPriceItem(string id = default(string), string grn = default(string), string itemGrn = default(string), PricelistMoney basePrice = default(PricelistMoney), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), PricelistCurrency? currency = default(PricelistCurrency?), List<PricelistGetFullPriceItemPrice> prices = default(List<PricelistGetFullPriceItemPrice>), bool hasTierPrices = default(bool))
        {
            this.Id = id;
            this.Grn = grn;
            this.ItemGrn = itemGrn;
            this.BasePrice = basePrice;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Currency = currency;
            this.Prices = prices;
            this.HasTierPrices = hasTierPrices;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Grn
        /// </summary>
        [DataMember(Name = "grn", EmitDefaultValue = false)]
        public string Grn { get; set; }

        /// <summary>
        /// Gets or Sets ItemGrn
        /// </summary>
        [DataMember(Name = "itemGrn", EmitDefaultValue = false)]
        public string ItemGrn { get; set; }

        /// <summary>
        /// Gets or Sets BasePrice
        /// </summary>
        [DataMember(Name = "basePrice", EmitDefaultValue = false)]
        public PricelistMoney BasePrice { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Prices
        /// </summary>
        [DataMember(Name = "prices", EmitDefaultValue = false)]
        public List<PricelistGetFullPriceItemPrice> Prices { get; set; }

        /// <summary>
        /// Gets or Sets HasTierPrices
        /// </summary>
        [DataMember(Name = "hasTierPrices", EmitDefaultValue = true)]
        public bool HasTierPrices { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricelistGetFullPriceItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Grn: ").Append(Grn).Append("\n");
            sb.Append("  ItemGrn: ").Append(ItemGrn).Append("\n");
            sb.Append("  BasePrice: ").Append(BasePrice).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  HasTierPrices: ").Append(HasTierPrices).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
