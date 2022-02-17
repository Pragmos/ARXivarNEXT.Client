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
    /// Class of the documents writing settings
    /// </summary>
    [DataContract]
    public partial class DocumentsWritingSettingsDTO :  IEquatable<DocumentsWritingSettingsDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsWritingSettingsDTO" /> class.
        /// </summary>
        /// <param name="blacklistFileExtensions">List of file extensions that can&#39;t be accepted.</param>
        /// <param name="whitelistFileExtensions">List of file extensions that can be accepted.</param>
        /// <param name="minFileSize">Minimum writable document size.</param>
        /// <param name="maxFileSize">Maximum writable document size.</param>
        public DocumentsWritingSettingsDTO(List<string> blacklistFileExtensions = default(List<string>), List<string> whitelistFileExtensions = default(List<string>), long? minFileSize = default(long?), long? maxFileSize = default(long?))
        {
            this.BlacklistFileExtensions = blacklistFileExtensions;
            this.WhitelistFileExtensions = whitelistFileExtensions;
            this.MinFileSize = minFileSize;
            this.MaxFileSize = maxFileSize;
        }
        
        /// <summary>
        /// List of file extensions that can&#39;t be accepted
        /// </summary>
        /// <value>List of file extensions that can&#39;t be accepted</value>
        [DataMember(Name="blacklistFileExtensions", EmitDefaultValue=false)]
        public List<string> BlacklistFileExtensions { get; set; }

        /// <summary>
        /// List of file extensions that can be accepted
        /// </summary>
        /// <value>List of file extensions that can be accepted</value>
        [DataMember(Name="whitelistFileExtensions", EmitDefaultValue=false)]
        public List<string> WhitelistFileExtensions { get; set; }

        /// <summary>
        /// Minimum writable document size
        /// </summary>
        /// <value>Minimum writable document size</value>
        [DataMember(Name="minFileSize", EmitDefaultValue=false)]
        public long? MinFileSize { get; set; }

        /// <summary>
        /// Maximum writable document size
        /// </summary>
        /// <value>Maximum writable document size</value>
        [DataMember(Name="maxFileSize", EmitDefaultValue=false)]
        public long? MaxFileSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentsWritingSettingsDTO {\n");
            sb.Append("  BlacklistFileExtensions: ").Append(BlacklistFileExtensions).Append("\n");
            sb.Append("  WhitelistFileExtensions: ").Append(WhitelistFileExtensions).Append("\n");
            sb.Append("  MinFileSize: ").Append(MinFileSize).Append("\n");
            sb.Append("  MaxFileSize: ").Append(MaxFileSize).Append("\n");
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
            return this.Equals(input as DocumentsWritingSettingsDTO);
        }

        /// <summary>
        /// Returns true if DocumentsWritingSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentsWritingSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentsWritingSettingsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlacklistFileExtensions == input.BlacklistFileExtensions ||
                    this.BlacklistFileExtensions != null &&
                    this.BlacklistFileExtensions.SequenceEqual(input.BlacklistFileExtensions)
                ) && 
                (
                    this.WhitelistFileExtensions == input.WhitelistFileExtensions ||
                    this.WhitelistFileExtensions != null &&
                    this.WhitelistFileExtensions.SequenceEqual(input.WhitelistFileExtensions)
                ) && 
                (
                    this.MinFileSize == input.MinFileSize ||
                    (this.MinFileSize != null &&
                    this.MinFileSize.Equals(input.MinFileSize))
                ) && 
                (
                    this.MaxFileSize == input.MaxFileSize ||
                    (this.MaxFileSize != null &&
                    this.MaxFileSize.Equals(input.MaxFileSize))
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
                if (this.BlacklistFileExtensions != null)
                    hashCode = hashCode * 59 + this.BlacklistFileExtensions.GetHashCode();
                if (this.WhitelistFileExtensions != null)
                    hashCode = hashCode * 59 + this.WhitelistFileExtensions.GetHashCode();
                if (this.MinFileSize != null)
                    hashCode = hashCode * 59 + this.MinFileSize.GetHashCode();
                if (this.MaxFileSize != null)
                    hashCode = hashCode * 59 + this.MaxFileSize.GetHashCode();
                return hashCode;
            }
        }
    }

}
