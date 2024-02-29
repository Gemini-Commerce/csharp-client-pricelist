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
    /// Defines pricelistPriceListType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricelistPriceListType
    {
        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Enum BASE for value: BASE
        /// </summary>
        [EnumMember(Value = "BASE")]
        BASE,

        /// <summary>
        /// Enum CATALOGPROMOTION for value: CATALOG_PROMOTION
        /// </summary>
        [EnumMember(Value = "CATALOG_PROMOTION")]
        CATALOGPROMOTION
    }

}