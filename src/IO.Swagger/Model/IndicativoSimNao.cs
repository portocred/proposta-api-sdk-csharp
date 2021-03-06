/* 
 * Gestão de Propostas
 *
 * API de Gestão de Propostas.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Enumeration de indicativo de Sim ou Não.
    /// </summary>
    /// <value>Enumeration de indicativo de Sim ou Não.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum IndicativoSimNao
    {

        /// <summary>
        /// Enum SIM for value: SIM
        /// </summary>
        [EnumMember(Value = "SIM")]
         SIM = 1,

        /// <summary>
        /// Enum NAO for value: NAO
        /// </summary>
        [EnumMember(Value = "NAO")]
        NAO = 2
    }

}
