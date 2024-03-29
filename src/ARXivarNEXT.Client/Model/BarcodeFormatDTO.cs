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
    /// BarcodeFormatDTO
    /// </summary>
    [DataContract]
    public partial class BarcodeFormatDTO :  IEquatable<BarcodeFormatDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeFormatDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BarcodeFormatDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeFormatDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="description">description.</param>
        /// <param name="enable">enable.</param>
        public BarcodeFormatDTO(string id = default(string), string description = default(string), bool? enable = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BarcodeFormatDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.Description = description;
            this.Enable = enable;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name="enable", EmitDefaultValue=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeFormatDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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
            return this.Equals(input as BarcodeFormatDTO);
        }

        /// <summary>
        /// Returns true if BarcodeFormatDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeFormatDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeFormatDTO input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                return hashCode;
            }
        }
    }

}
