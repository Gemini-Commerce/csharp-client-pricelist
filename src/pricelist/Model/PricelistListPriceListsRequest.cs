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
    /// PricelistListPriceListsRequest
    /// </summary>
    [DataContract(Name = "pricelistListPriceListsRequest")]
    public partial class PricelistListPriceListsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricelistListPriceListsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageToken">pageToken.</param>
        /// <param name="searchQuery">searchQuery.</param>
        /// <param name="filterMask">filterMask.</param>
        /// <param name="filter">filter.</param>
        public PricelistListPriceListsRequest(string tenantId = default(string), long pageSize = default(long), string pageToken = default(string), string searchQuery = default(string), string filterMask = default(string), ListPriceListsRequestFilter filter = default(ListPriceListsRequestFilter))
        {
            this.TenantId = tenantId;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.SearchQuery = searchQuery;
            this.FilterMask = filterMask;
            this.Filter = filter;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageToken
        /// </summary>
        [DataMember(Name = "pageToken", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// Gets or Sets SearchQuery
        /// </summary>
        [DataMember(Name = "searchQuery", EmitDefaultValue = false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Gets or Sets FilterMask
        /// </summary>
        [DataMember(Name = "filterMask", EmitDefaultValue = false)]
        public string FilterMask { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public ListPriceListsRequestFilter Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PricelistListPriceListsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  FilterMask: ").Append(FilterMask).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
