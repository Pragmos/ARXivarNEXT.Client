/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ARXivarNEXT.Client.Client.SwaggerDateConverter;

namespace ARXivarNEXT.Client.Model
{
    /// <summary>
    /// FieldInt
    /// </summary>
    [DataContract]
    public partial class FieldInt :  IEquatable<FieldInt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldInt" /> class.
        /// </summary>
        /// <param name="valore2">valore2.</param>
        /// <param name="valore">valore.</param>
        /// <param name="operatore">Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso .</param>
        /// <param name="nome">nome.</param>
        /// <param name="nomeTabella">nomeTabella.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="multiple">multiple.</param>
        /// <param name="label">label.</param>
        public FieldInt(Object valore2 = default(Object), Object valore = default(Object), int? operatore = default(int?), string nome = default(string), string nomeTabella = default(string), string externalId = default(string), string multiple = default(string), string label = default(string))
        {
            this.Valore2 = valore2;
            this.Valore = valore;
            this.Operatore = operatore;
            this.Nome = nome;
            this.NomeTabella = nomeTabella;
            this.ExternalId = externalId;
            this.Multiple = multiple;
            this.Label = label;
        }
        
        /// <summary>
        /// Gets or Sets Valore2
        /// </summary>
        [DataMember(Name="valore2", EmitDefaultValue=false)]
        public Object Valore2 { get; set; }

        /// <summary>
        /// Gets or Sets Valore
        /// </summary>
        [DataMember(Name="valore", EmitDefaultValue=false)]
        public Object Valore { get; set; }

        /// <summary>
        /// Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso 
        /// </summary>
        /// <value>Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso </value>
        [DataMember(Name="operatore", EmitDefaultValue=false)]
        public int? Operatore { get; set; }

        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or Sets NomeTabella
        /// </summary>
        [DataMember(Name="nomeTabella", EmitDefaultValue=false)]
        public string NomeTabella { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Multiple
        /// </summary>
        [DataMember(Name="multiple", EmitDefaultValue=false)]
        public string Multiple { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldInt {\n");
            sb.Append("  Valore2: ").Append(Valore2).Append("\n");
            sb.Append("  Valore: ").Append(Valore).Append("\n");
            sb.Append("  Operatore: ").Append(Operatore).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeTabella: ").Append(NomeTabella).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Multiple: ").Append(Multiple).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as FieldInt);
        }

        /// <summary>
        /// Returns true if FieldInt instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldInt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldInt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Valore2 == input.Valore2 ||
                    (this.Valore2 != null &&
                    this.Valore2.Equals(input.Valore2))
                ) && 
                (
                    this.Valore == input.Valore ||
                    (this.Valore != null &&
                    this.Valore.Equals(input.Valore))
                ) && 
                (
                    this.Operatore == input.Operatore ||
                    (this.Operatore != null &&
                    this.Operatore.Equals(input.Operatore))
                ) && 
                (
                    this.Nome == input.Nome ||
                    (this.Nome != null &&
                    this.Nome.Equals(input.Nome))
                ) && 
                (
                    this.NomeTabella == input.NomeTabella ||
                    (this.NomeTabella != null &&
                    this.NomeTabella.Equals(input.NomeTabella))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Multiple == input.Multiple ||
                    (this.Multiple != null &&
                    this.Multiple.Equals(input.Multiple))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Valore2 != null)
                    hashCode = hashCode * 59 + this.Valore2.GetHashCode();
                if (this.Valore != null)
                    hashCode = hashCode * 59 + this.Valore.GetHashCode();
                if (this.Operatore != null)
                    hashCode = hashCode * 59 + this.Operatore.GetHashCode();
                if (this.Nome != null)
                    hashCode = hashCode * 59 + this.Nome.GetHashCode();
                if (this.NomeTabella != null)
                    hashCode = hashCode * 59 + this.NomeTabella.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Multiple != null)
                    hashCode = hashCode * 59 + this.Multiple.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }
    }

}
