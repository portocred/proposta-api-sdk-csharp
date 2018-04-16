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
    /// Enumeration dos tipos de cliente.
    /// </summary>
    /// <value>Enumeration dos tipos de cliente.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TipoCliente
    {
        
        /// <summary>
        /// Enum CLIENTEPRINCIPAL for value: CLIENTE_PRINCIPAL
        /// </summary>
        [EnumMember(Value = "CLIENTE_PRINCIPAL")]
        CLIENTEPRINCIPAL = 1,
        
        /// <summary>
        /// Enum AVALISTA1 for value: AVALISTA_1
        /// </summary>
        [EnumMember(Value = "AVALISTA_1")]
        AVALISTA1 = 2,
        
        /// <summary>
        /// Enum AVALISTA2 for value: AVALISTA_2
        /// </summary>
        [EnumMember(Value = "AVALISTA_2")]
        AVALISTA2 = 3
    }

}
