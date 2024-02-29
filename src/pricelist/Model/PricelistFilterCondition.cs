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
    /// Defines pricelistFilterCondition
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricelistFilterCondition
    {
        /// <summary>
        /// Enum IN for value: IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN = 1,

        /// <summary>
        /// Enum NOTIN for value: NOT_IN
        /// </summary>
        [EnumMember(Value = "NOT_IN")]
        NOTIN = 2
    }

}
