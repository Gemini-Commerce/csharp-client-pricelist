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
    /// PricelistGetPriceListByCodeResponse
    /// </summary>
    [DataContract(Name = "pricelistGetPriceListByCodeResponse")]
    public partial class PricelistGetPriceListByCodeResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public PricelistCurrency? Currency { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PricelistPriceListType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PricelistGetPriceListByCodeResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="grn">grn.</param>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="currency">currency.</param>
        /// <param name="vatIncluded">vatIncluded.</param>
        /// <param name="deliveredDutyPaid">deliveredDutyPaid.</param>
        /// <param name="segments">segments.</param>
        /// <param name="markets">markets.</param>
        /// <param name="channels">channels.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="type">type.</param>
        /// <param name="isSystem">isSystem.</param>
        public PricelistGetPriceListByCodeResponse(string id = default(string), string grn = default(string), string code = default(string), string name = default(string), string description = default(string), bool isActive = default(bool), bool isDefault = default(bool), PricelistCurrency? currency = default(PricelistCurrency?), bool vatIncluded = default(bool), bool deliveredDutyPaid = default(bool), List<string> segments = default(List<string>), List<string> markets = default(List<string>), List<string> channels = default(List<string>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), PricelistPriceListType? type = default(PricelistPriceListType?), bool isSystem = default(bool))
        {
            this.Id = id;
            this.Grn = grn;
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.IsActive = isActive;
            this.IsDefault = isDefault;
            this.Currency = currency;
            this.VatIncluded = vatIncluded;
            this.DeliveredDutyPaid = deliveredDutyPaid;
            this.Segments = segments;
            this.Markets = markets;
            this.Channels = channels;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Type = type;
            this.IsSystem = isSystem;
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
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets VatIncluded
        /// </summary>
        [DataMember(Name = "vatIncluded", EmitDefaultValue = true)]
        public bool VatIncluded { get; set; }

        /// <summary>
        /// Gets or Sets DeliveredDutyPaid
        /// </summary>
        [DataMember(Name = "deliveredDutyPaid", EmitDefaultValue = true)]
        public bool DeliveredDutyPaid { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name = "segments", EmitDefaultValue = false)]
        public List<string> Segments { get; set; }

        /// <summary>
        /// Gets or Sets Markets
        /// </summary>
        [DataMember(Name = "markets", EmitDefaultValue = false)]
        public List<string> Markets { get; set; }

        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name = "channels", EmitDefaultValue = false)]
        public List<string> Channels { get; set; }

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
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name = "isSystem", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

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
            sb.Append("class PricelistGetPriceListByCodeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Grn: ").Append(Grn).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  VatIncluded: ").Append(VatIncluded).Append("\n");
            sb.Append("  DeliveredDutyPaid: ").Append(DeliveredDutyPaid).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Markets: ").Append(Markets).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
