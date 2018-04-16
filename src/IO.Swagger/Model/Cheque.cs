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
    /// Entidade representando o cheque usado na proposta.
    /// </summary>
    [DataContract]
    public partial class Cheque :  IEquatable<Cheque>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cheque" /> class.
        /// </summary>
        /// <param name="Cmc7">CMC7 do cheque..</param>
        /// <param name="Parcela">Parcela do cheque..</param>
        /// <param name="Vencimento">Vencimento do cheque..</param>
        public Cheque(string Cmc7 = default(string), string Parcela = default(string), string Vencimento = default(string))
        {
            this.Cmc7 = Cmc7;
            this.Parcela = Parcela;
            this.Vencimento = Vencimento;
        }
        
        /// <summary>
        /// CMC7 do cheque.
        /// </summary>
        /// <value>CMC7 do cheque.</value>
        [DataMember(Name="cmc7", EmitDefaultValue=false)]
        public string Cmc7 { get; set; }

        /// <summary>
        /// Parcela do cheque.
        /// </summary>
        /// <value>Parcela do cheque.</value>
        [DataMember(Name="parcela", EmitDefaultValue=false)]
        public string Parcela { get; set; }

        /// <summary>
        /// Vencimento do cheque.
        /// </summary>
        /// <value>Vencimento do cheque.</value>
        [DataMember(Name="vencimento", EmitDefaultValue=false)]
        public string Vencimento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cheque {\n");
            sb.Append("  Cmc7: ").Append(Cmc7).Append("\n");
            sb.Append("  Parcela: ").Append(Parcela).Append("\n");
            sb.Append("  Vencimento: ").Append(Vencimento).Append("\n");
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
            return this.Equals(input as Cheque);
        }

        /// <summary>
        /// Returns true if Cheque instances are equal
        /// </summary>
        /// <param name="input">Instance of Cheque to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cheque input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cmc7 == input.Cmc7 ||
                    (this.Cmc7 != null &&
                    this.Cmc7.Equals(input.Cmc7))
                ) && 
                (
                    this.Parcela == input.Parcela ||
                    (this.Parcela != null &&
                    this.Parcela.Equals(input.Parcela))
                ) && 
                (
                    this.Vencimento == input.Vencimento ||
                    (this.Vencimento != null &&
                    this.Vencimento.Equals(input.Vencimento))
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
                if (this.Cmc7 != null)
                    hashCode = hashCode * 59 + this.Cmc7.GetHashCode();
                if (this.Parcela != null)
                    hashCode = hashCode * 59 + this.Parcela.GetHashCode();
                if (this.Vencimento != null)
                    hashCode = hashCode * 59 + this.Vencimento.GetHashCode();
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
