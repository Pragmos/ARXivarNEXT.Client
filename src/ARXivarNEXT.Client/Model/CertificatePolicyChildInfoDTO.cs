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
    /// CertificatePolicyChildInfoDTO
    /// </summary>
    [DataContract]
    public partial class CertificatePolicyChildInfoDTO :  IEquatable<CertificatePolicyChildInfoDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatePolicyChildInfoDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="descriptionId">descriptionId.</param>
        /// <param name="value">value.</param>
        public CertificatePolicyChildInfoDTO(string id = default(string), string descriptionId = default(string), string value = default(string))
        {
            this.Id = id;
            this.DescriptionId = descriptionId;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionId
        /// </summary>
        [DataMember(Name="descriptionId", EmitDefaultValue=false)]
        public string DescriptionId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificatePolicyChildInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DescriptionId: ").Append(DescriptionId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as CertificatePolicyChildInfoDTO);
        }

        /// <summary>
        /// Returns true if CertificatePolicyChildInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificatePolicyChildInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatePolicyChildInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DescriptionId == input.DescriptionId ||
                    (this.DescriptionId != null &&
                    this.DescriptionId.Equals(input.DescriptionId))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DescriptionId != null)
                    hashCode = hashCode * 59 + this.DescriptionId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }

}