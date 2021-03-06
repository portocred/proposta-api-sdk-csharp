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
    /// Entidade representando um emprego.
    /// </summary>
    [DataContract]
    public partial class Emprego :  IEquatable<Emprego>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Emprego" /> class.
        /// </summary>
        /// <param name="NomeEmpresa">Nome da empresa..</param>
        /// <param name="CodigoClasseProfissional">Código da classe profissional..</param>
        /// <param name="CodigoAtividade">Código da atividade exercida..</param>
        /// <param name="DataAdmissao">Data da admissão. (aaaa-mm-dd)..</param>
        /// <param name="CodigoConveniada">Código da empresa conveniada. (para Consignado e Débito em Conta)..</param>
        /// <param name="OrgaoConveniada">Órgão da empresa conveniada. (para Consignado e Débito em Conta)..</param>
        /// <param name="NumeroBeneficio">Número do benefício..</param>
        /// <param name="EspecieBeneficio">Espécie do benefício..</param>
        /// <param name="MatriculaFucional">Matrícula funcional..</param>
        /// <param name="Renda">Valor da renda..</param>
        /// <param name="Cnpj">CNPJ da empresa..</param>
        /// <param name="Telefones">Telefones.</param>
        /// <param name="Endereco">Endereco.</param>
        public Emprego(string NomeEmpresa = default(string), string CodigoClasseProfissional = default(string), string CodigoAtividade = default(string), DateTime? DataAdmissao = default(DateTime?), string CodigoConveniada = default(string), string OrgaoConveniada = default(string), string NumeroBeneficio = default(string), string EspecieBeneficio = default(string), string MatriculaFucional = default(string), double? Renda = default(double?), string Cnpj = default(string), List<Telefone> Telefones = default(List<Telefone>), Endereco Endereco = default(Endereco))
        {
            this.NomeEmpresa = NomeEmpresa;
            this.CodigoClasseProfissional = CodigoClasseProfissional;
            this.CodigoAtividade = CodigoAtividade;
            this.DataAdmissao = DataAdmissao;
            this.CodigoConveniada = CodigoConveniada;
            this.OrgaoConveniada = OrgaoConveniada;
            this.NumeroBeneficio = NumeroBeneficio;
            this.EspecieBeneficio = EspecieBeneficio;
            this.MatriculaFucional = MatriculaFucional;
            this.Renda = Renda;
            this.Cnpj = Cnpj;
            this.Telefones = Telefones;
            this.Endereco = Endereco;
        }
        
        /// <summary>
        /// Nome da empresa.
        /// </summary>
        /// <value>Nome da empresa.</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }

        /// <summary>
        /// Código da classe profissional.
        /// </summary>
        /// <value>Código da classe profissional.</value>
        [DataMember(Name="codigoClasseProfissional", EmitDefaultValue=false)]
        public string CodigoClasseProfissional { get; set; }

        /// <summary>
        /// Código da atividade exercida.
        /// </summary>
        /// <value>Código da atividade exercida.</value>
        [DataMember(Name="codigoAtividade", EmitDefaultValue=false)]
        public string CodigoAtividade { get; set; }

        /// <summary>
        /// Data da admissão. (aaaa-mm-dd).
        /// </summary>
        /// <value>Data da admissão. (aaaa-mm-dd).</value>
        [DataMember(Name="dataAdmissao", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DataAdmissao { get; set; }

        /// <summary>
        /// Código da empresa conveniada. (para Consignado e Débito em Conta).
        /// </summary>
        /// <value>Código da empresa conveniada. (para Consignado e Débito em Conta).</value>
        [DataMember(Name="codigoConveniada", EmitDefaultValue=false)]
        public string CodigoConveniada { get; set; }

        /// <summary>
        /// Órgão da empresa conveniada. (para Consignado e Débito em Conta).
        /// </summary>
        /// <value>Órgão da empresa conveniada. (para Consignado e Débito em Conta).</value>
        [DataMember(Name="orgaoConveniada", EmitDefaultValue=false)]
        public string OrgaoConveniada { get; set; }

        /// <summary>
        /// Número do benefício.
        /// </summary>
        /// <value>Número do benefício.</value>
        [DataMember(Name="numeroBeneficio", EmitDefaultValue=false)]
        public string NumeroBeneficio { get; set; }

        /// <summary>
        /// Espécie do benefício.
        /// </summary>
        /// <value>Espécie do benefício.</value>
        [DataMember(Name="especieBeneficio", EmitDefaultValue=false)]
        public string EspecieBeneficio { get; set; }

        /// <summary>
        /// Matrícula funcional.
        /// </summary>
        /// <value>Matrícula funcional.</value>
        [DataMember(Name="matriculaFucional", EmitDefaultValue=false)]
        public string MatriculaFucional { get; set; }

        /// <summary>
        /// Valor da renda.
        /// </summary>
        /// <value>Valor da renda.</value>
        [DataMember(Name="renda", EmitDefaultValue=false)]
        public double? Renda { get; set; }

        /// <summary>
        /// CNPJ da empresa.
        /// </summary>
        /// <value>CNPJ da empresa.</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }

        /// <summary>
        /// Gets or Sets Telefones
        /// </summary>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<Telefone> Telefones { get; set; }

        /// <summary>
        /// Gets or Sets Endereco
        /// </summary>
        [DataMember(Name="endereco", EmitDefaultValue=false)]
        public Endereco Endereco { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Emprego {\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  CodigoClasseProfissional: ").Append(CodigoClasseProfissional).Append("\n");
            sb.Append("  CodigoAtividade: ").Append(CodigoAtividade).Append("\n");
            sb.Append("  DataAdmissao: ").Append(DataAdmissao).Append("\n");
            sb.Append("  CodigoConveniada: ").Append(CodigoConveniada).Append("\n");
            sb.Append("  OrgaoConveniada: ").Append(OrgaoConveniada).Append("\n");
            sb.Append("  NumeroBeneficio: ").Append(NumeroBeneficio).Append("\n");
            sb.Append("  EspecieBeneficio: ").Append(EspecieBeneficio).Append("\n");
            sb.Append("  MatriculaFucional: ").Append(MatriculaFucional).Append("\n");
            sb.Append("  Renda: ").Append(Renda).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Endereco: ").Append(Endereco).Append("\n");
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
            return this.Equals(input as Emprego);
        }

        /// <summary>
        /// Returns true if Emprego instances are equal
        /// </summary>
        /// <param name="input">Instance of Emprego to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Emprego input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NomeEmpresa == input.NomeEmpresa ||
                    (this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(input.NomeEmpresa))
                ) && 
                (
                    this.CodigoClasseProfissional == input.CodigoClasseProfissional ||
                    (this.CodigoClasseProfissional != null &&
                    this.CodigoClasseProfissional.Equals(input.CodigoClasseProfissional))
                ) && 
                (
                    this.CodigoAtividade == input.CodigoAtividade ||
                    (this.CodigoAtividade != null &&
                    this.CodigoAtividade.Equals(input.CodigoAtividade))
                ) && 
                (
                    this.DataAdmissao == input.DataAdmissao ||
                    (this.DataAdmissao != null &&
                    this.DataAdmissao.Equals(input.DataAdmissao))
                ) && 
                (
                    this.CodigoConveniada == input.CodigoConveniada ||
                    (this.CodigoConveniada != null &&
                    this.CodigoConveniada.Equals(input.CodigoConveniada))
                ) && 
                (
                    this.OrgaoConveniada == input.OrgaoConveniada ||
                    (this.OrgaoConveniada != null &&
                    this.OrgaoConveniada.Equals(input.OrgaoConveniada))
                ) && 
                (
                    this.NumeroBeneficio == input.NumeroBeneficio ||
                    (this.NumeroBeneficio != null &&
                    this.NumeroBeneficio.Equals(input.NumeroBeneficio))
                ) && 
                (
                    this.EspecieBeneficio == input.EspecieBeneficio ||
                    (this.EspecieBeneficio != null &&
                    this.EspecieBeneficio.Equals(input.EspecieBeneficio))
                ) && 
                (
                    this.MatriculaFucional == input.MatriculaFucional ||
                    (this.MatriculaFucional != null &&
                    this.MatriculaFucional.Equals(input.MatriculaFucional))
                ) && 
                (
                    this.Renda == input.Renda ||
                    (this.Renda != null &&
                    this.Renda.Equals(input.Renda))
                ) && 
                (
                    this.Cnpj == input.Cnpj ||
                    (this.Cnpj != null &&
                    this.Cnpj.Equals(input.Cnpj))
                ) && 
                (
                    this.Telefones == input.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(input.Telefones)
                ) && 
                (
                    this.Endereco == input.Endereco ||
                    (this.Endereco != null &&
                    this.Endereco.Equals(input.Endereco))
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
                if (this.NomeEmpresa != null)
                    hashCode = hashCode * 59 + this.NomeEmpresa.GetHashCode();
                if (this.CodigoClasseProfissional != null)
                    hashCode = hashCode * 59 + this.CodigoClasseProfissional.GetHashCode();
                if (this.CodigoAtividade != null)
                    hashCode = hashCode * 59 + this.CodigoAtividade.GetHashCode();
                if (this.DataAdmissao != null)
                    hashCode = hashCode * 59 + this.DataAdmissao.GetHashCode();
                if (this.CodigoConveniada != null)
                    hashCode = hashCode * 59 + this.CodigoConveniada.GetHashCode();
                if (this.OrgaoConveniada != null)
                    hashCode = hashCode * 59 + this.OrgaoConveniada.GetHashCode();
                if (this.NumeroBeneficio != null)
                    hashCode = hashCode * 59 + this.NumeroBeneficio.GetHashCode();
                if (this.EspecieBeneficio != null)
                    hashCode = hashCode * 59 + this.EspecieBeneficio.GetHashCode();
                if (this.MatriculaFucional != null)
                    hashCode = hashCode * 59 + this.MatriculaFucional.GetHashCode();
                if (this.Renda != null)
                    hashCode = hashCode * 59 + this.Renda.GetHashCode();
                if (this.Cnpj != null)
                    hashCode = hashCode * 59 + this.Cnpj.GetHashCode();
                if (this.Telefones != null)
                    hashCode = hashCode * 59 + this.Telefones.GetHashCode();
                if (this.Endereco != null)
                    hashCode = hashCode * 59 + this.Endereco.GetHashCode();
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
