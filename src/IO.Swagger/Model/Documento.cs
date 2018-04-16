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
    /// Entidade representando um documento de um cliente.
    /// </summary>
    [DataContract]
    public partial class Documento :  IEquatable<Documento>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Documento" /> class.
        /// </summary>
        /// <param name="Numero">Número do documento..</param>
        /// <param name="CodigoTipoDocumento">Código do Tipo do documento..</param>
        /// <param name="CodigoOrgaoEmissor">Código do órgão emissor do documento..</param>
        /// <param name="DataEmissao">Data da emissão do documento..</param>
        /// <param name="Uf">Unidade federativa do documento..</param>
        public Documento(string Numero = default(string), string CodigoTipoDocumento = default(string), string CodigoOrgaoEmissor = default(string), DateTime? DataEmissao = default(DateTime?), string Uf = default(string))
        {
            this.Numero = Numero;
            this.CodigoTipoDocumento = CodigoTipoDocumento;
            this.CodigoOrgaoEmissor = CodigoOrgaoEmissor;
            this.DataEmissao = DataEmissao;
            this.Uf = Uf;
        }
        
        /// <summary>
        /// Número do documento.
        /// </summary>
        /// <value>Número do documento.</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public string Numero { get; set; }

        /// <summary>
        /// Código do Tipo do documento.
        /// </summary>
        /// <value>Código do Tipo do documento.</value>
        [DataMember(Name="codigoTipoDocumento", EmitDefaultValue=false)]
        public string CodigoTipoDocumento { get; set; }

        /// <summary>
        /// Código do órgão emissor do documento.
        /// </summary>
        /// <value>Código do órgão emissor do documento.</value>
        [DataMember(Name="codigoOrgaoEmissor", EmitDefaultValue=false)]
        public string CodigoOrgaoEmissor { get; set; }

        /// <summary>
        /// Data da emissão do documento.
        /// </summary>
        /// <value>Data da emissão do documento.</value>
        [DataMember(Name="dataEmissao", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DataEmissao { get; set; }

        /// <summary>
        /// Unidade federativa do documento.
        /// </summary>
        /// <value>Unidade federativa do documento.</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Documento {\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  CodigoTipoDocumento: ").Append(CodigoTipoDocumento).Append("\n");
            sb.Append("  CodigoOrgaoEmissor: ").Append(CodigoOrgaoEmissor).Append("\n");
            sb.Append("  DataEmissao: ").Append(DataEmissao).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Documento);
        }

        /// <summary>
        /// Returns true if Documento instances are equal
        /// </summary>
        /// <param name="input">Instance of Documento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Documento input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Numero == input.Numero ||
                    (this.Numero != null &&
                    this.Numero.Equals(input.Numero))
                ) && 
                (
                    this.CodigoTipoDocumento == input.CodigoTipoDocumento ||
                    (this.CodigoTipoDocumento != null &&
                    this.CodigoTipoDocumento.Equals(input.CodigoTipoDocumento))
                ) && 
                (
                    this.CodigoOrgaoEmissor == input.CodigoOrgaoEmissor ||
                    (this.CodigoOrgaoEmissor != null &&
                    this.CodigoOrgaoEmissor.Equals(input.CodigoOrgaoEmissor))
                ) && 
                (
                    this.DataEmissao == input.DataEmissao ||
                    (this.DataEmissao != null &&
                    this.DataEmissao.Equals(input.DataEmissao))
                ) && 
                (
                    this.Uf == input.Uf ||
                    (this.Uf != null &&
                    this.Uf.Equals(input.Uf))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Numero != null)
                    hashCode = hashCode * 59 + this.Numero.GetHashCode();
                if (this.CodigoTipoDocumento != null)
                    hashCode = hashCode * 59 + this.CodigoTipoDocumento.GetHashCode();
                if (this.CodigoOrgaoEmissor != null)
                    hashCode = hashCode * 59 + this.CodigoOrgaoEmissor.GetHashCode();
                if (this.DataEmissao != null)
                    hashCode = hashCode * 59 + this.DataEmissao.GetHashCode();
                if (this.Uf != null)
                    hashCode = hashCode * 59 + this.Uf.GetHashCode();
                return hashCode;
            }
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
