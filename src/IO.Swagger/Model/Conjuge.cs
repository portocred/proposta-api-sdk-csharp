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
    /// Entidade representando um conjuge do cliente da proposta.
    /// </summary>
    [DataContract]
    public partial class Conjuge :  IEquatable<Conjuge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conjuge" /> class.
        /// </summary>
        /// <param name="Cpf">Cpf do conjuge..</param>
        /// <param name="DataNascimento">Data de nascimento do conjuge..</param>
        /// <param name="Nome">Nome do conjuge..</param>
        /// <param name="Emprego">Emprego.</param>
        public Conjuge(string Cpf = default(string), DateTime? DataNascimento = default(DateTime?), string Nome = default(string), Emprego Emprego = default(Emprego))
        {
            this.Cpf = Cpf;
            this.DataNascimento = DataNascimento;
            this.Nome = Nome;
            this.Emprego = Emprego;
        }
        
        /// <summary>
        /// Cpf do conjuge.
        /// </summary>
        /// <value>Cpf do conjuge.</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }

        /// <summary>
        /// Data de nascimento do conjuge.
        /// </summary>
        /// <value>Data de nascimento do conjuge.</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// Nome do conjuge.
        /// </summary>
        /// <value>Nome do conjuge.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or Sets Emprego
        /// </summary>
        [DataMember(Name="emprego", EmitDefaultValue=false)]
        public Emprego Emprego { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conjuge {\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Emprego: ").Append(Emprego).Append("\n");
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
            return this.Equals(input as Conjuge);
        }

        /// <summary>
        /// Returns true if Conjuge instances are equal
        /// </summary>
        /// <param name="input">Instance of Conjuge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conjuge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cpf == input.Cpf ||
                    (this.Cpf != null &&
                    this.Cpf.Equals(input.Cpf))
                ) && 
                (
                    this.DataNascimento == input.DataNascimento ||
                    (this.DataNascimento != null &&
                    this.DataNascimento.Equals(input.DataNascimento))
                ) && 
                (
                    this.Nome == input.Nome ||
                    (this.Nome != null &&
                    this.Nome.Equals(input.Nome))
                ) && 
                (
                    this.Emprego == input.Emprego ||
                    (this.Emprego != null &&
                    this.Emprego.Equals(input.Emprego))
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
                if (this.Cpf != null)
                    hashCode = hashCode * 59 + this.Cpf.GetHashCode();
                if (this.DataNascimento != null)
                    hashCode = hashCode * 59 + this.DataNascimento.GetHashCode();
                if (this.Nome != null)
                    hashCode = hashCode * 59 + this.Nome.GetHashCode();
                if (this.Emprego != null)
                    hashCode = hashCode * 59 + this.Emprego.GetHashCode();
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
