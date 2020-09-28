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
    /// CertificatePolicyInfoDTO
    /// </summary>
    [DataContract]
    public partial class CertificatePolicyInfoDTO :  IEquatable<CertificatePolicyInfoDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatePolicyInfoDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="descriptionId">descriptionId.</param>
        /// <param name="childList">childList.</param>
        public CertificatePolicyInfoDTO(string id = default(string), string descriptionId = default(string), List<CertificatePolicyChildInfoDTO> childList = default(List<CertificatePolicyChildInfoDTO>))
        {
            this.Id = id;
            this.DescriptionId = descriptionId;
            this.ChildList = childList;
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
        /// Gets or Sets ChildList
        /// </summary>
        [DataMember(Name="childList", EmitDefaultValue=false)]
        public List<CertificatePolicyChildInfoDTO> ChildList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificatePolicyInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DescriptionId: ").Append(DescriptionId).Append("\n");
            sb.Append("  ChildList: ").Append(ChildList).Append("\n");
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
            return this.Equals(input as CertificatePolicyInfoDTO);
        }

        /// <summary>
        /// Returns true if CertificatePolicyInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificatePolicyInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatePolicyInfoDTO input)
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
                    this.ChildList == input.ChildList ||
                    this.ChildList != null &&
                    this.ChildList.SequenceEqual(input.ChildList)
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
                if (this.ChildList != null)
                    hashCode = hashCode * 59 + this.ChildList.GetHashCode();
                return hashCode;
            }
        }
    }

}
