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
    /// Objeto de resposta da proposta.
    /// </summary>
    [DataContract]
    public partial class PropostaResponse :  IEquatable<PropostaResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropostaResponse" /> class.
        /// </summary>
        /// <param name="Numero">Número da proposta..</param>
        /// <param name="Data">Data da proposta..</param>
        /// <param name="CodigoLoja">Código da loja da proposta..</param>
        /// <param name="CodigoLojista">Código do lojista da proposta..</param>
        /// <param name="CodigoProduto">Código do produto da proposta..</param>
        /// <param name="Valor">Valor da proposta..</param>
        /// <param name="Tipo">Tipo da proposta..</param>
        /// <param name="Situacao">Situação da proposta..</param>
        public PropostaResponse(string Numero = default(string), DateTime? Data = default(DateTime?), string CodigoLoja = default(string), string CodigoLojista = default(string), string CodigoProduto = default(string), double? Valor = default(double?), string Tipo = default(string), string Situacao = default(string))
        {
            this.Numero = Numero;
            this.Data = Data;
            this.CodigoLoja = CodigoLoja;
            this.CodigoLojista = CodigoLojista;
            this.CodigoProduto = CodigoProduto;
            this.Valor = Valor;
            this.Tipo = Tipo;
            this.Situacao = Situacao;
        }
        
        /// <summary>
        /// Número da proposta.
        /// </summary>
        /// <value>Número da proposta.</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public string Numero { get; set; }

        /// <summary>
        /// Data da proposta.
        /// </summary>
        /// <value>Data da proposta.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Data { get; set; }

        /// <summary>
        /// Código da loja da proposta.
        /// </summary>
        /// <value>Código da loja da proposta.</value>
        [DataMember(Name="codigoLoja", EmitDefaultValue=false)]
        public string CodigoLoja { get; set; }

        /// <summary>
        /// Código do lojista da proposta.
        /// </summary>
        /// <value>Código do lojista da proposta.</value>
        [DataMember(Name="codigoLojista", EmitDefaultValue=false)]
        public string CodigoLojista { get; set; }

        /// <summary>
        /// Código do produto da proposta.
        /// </summary>
        /// <value>Código do produto da proposta.</value>
        [DataMember(Name="codigoProduto", EmitDefaultValue=false)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Valor da proposta.
        /// </summary>
        /// <value>Valor da proposta.</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }

        /// <summary>
        /// Tipo da proposta.
        /// </summary>
        /// <value>Tipo da proposta.</value>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }

        /// <summary>
        /// Situação da proposta.
        /// </summary>
        /// <value>Situação da proposta.</value>
        [DataMember(Name="situacao", EmitDefaultValue=false)]
        public string Situacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropostaResponse {\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  CodigoLoja: ").Append(CodigoLoja).Append("\n");
            sb.Append("  CodigoLojista: ").Append(CodigoLojista).Append("\n");
            sb.Append("  CodigoProduto: ").Append(CodigoProduto).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Situacao: ").Append(Situacao).Append("\n");
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
            return this.Equals(input as PropostaResponse);
        }

        /// <summary>
        /// Returns true if PropostaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PropostaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropostaResponse input)
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
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.CodigoLoja == input.CodigoLoja ||
                    (this.CodigoLoja != null &&
                    this.CodigoLoja.Equals(input.CodigoLoja))
                ) && 
                (
                    this.CodigoLojista == input.CodigoLojista ||
                    (this.CodigoLojista != null &&
                    this.CodigoLojista.Equals(input.CodigoLojista))
                ) && 
                (
                    this.CodigoProduto == input.CodigoProduto ||
                    (this.CodigoProduto != null &&
                    this.CodigoProduto.Equals(input.CodigoProduto))
                ) && 
                (
                    this.Valor == input.Valor ||
                    (this.Valor != null &&
                    this.Valor.Equals(input.Valor))
                ) && 
                (
                    this.Tipo == input.Tipo ||
                    (this.Tipo != null &&
                    this.Tipo.Equals(input.Tipo))
                ) && 
                (
                    this.Situacao == input.Situacao ||
                    (this.Situacao != null &&
                    this.Situacao.Equals(input.Situacao))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.CodigoLoja != null)
                    hashCode = hashCode * 59 + this.CodigoLoja.GetHashCode();
                if (this.CodigoLojista != null)
                    hashCode = hashCode * 59 + this.CodigoLojista.GetHashCode();
                if (this.CodigoProduto != null)
                    hashCode = hashCode * 59 + this.CodigoProduto.GetHashCode();
                if (this.Valor != null)
                    hashCode = hashCode * 59 + this.Valor.GetHashCode();
                if (this.Tipo != null)
                    hashCode = hashCode * 59 + this.Tipo.GetHashCode();
                if (this.Situacao != null)
                    hashCode = hashCode * 59 + this.Situacao.GetHashCode();
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