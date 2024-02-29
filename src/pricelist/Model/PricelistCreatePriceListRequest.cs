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
    /// PricelistCreatePriceListRequest
    /// </summary>
    [DataContract(Name = "pricelistCreatePriceListRequest")]
    public partial class PricelistCreatePriceListRequest : IValidatableObject
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
        /// Initializes a new instance of the <see cref="PricelistCreatePriceListRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
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
        /// <param name="type">type.</param>
        /// <param name="isSystem">isSystem.</param>
        public PricelistCreatePriceListRequest(string tenantId = default(string), string code = default(string), string name = default(string), string description = default(string), bool isActive = default(bool), bool isDefault = default(bool), PricelistCurrency? currency = default(PricelistCurrency?), bool vatIncluded = default(bool), bool deliveredDutyPaid = default(bool), List<string> segments = default(List<string>), List<string> markets = default(List<string>), List<string> channels = default(List<string>), PricelistPriceListType? type = default(PricelistPriceListType?), bool isSystem = default(bool))
        {
            this.TenantId = tenantId;
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
            this.Type = type;
            this.IsSystem = isSystem;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

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
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name = "isSystem", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricelistCreatePriceListRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
