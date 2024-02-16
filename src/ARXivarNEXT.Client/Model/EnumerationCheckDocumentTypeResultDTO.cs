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
    /// Result of the enumeration check for a Document Types
    /// </summary>
    [DataContract]
    public partial class EnumerationCheckDocumentTypeResultDTO :  IEquatable<EnumerationCheckDocumentTypeResultDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationCheckDocumentTypeResultDTO" /> class.
        /// </summary>
        /// <param name="enumerationCheckConfigured">If the business unit is configured for enumeration check for this document type, if not no result are provided.</param>
        /// <param name="success">If the enumeration check is successful.</param>
        /// <param name="documentType">Document type of the enumeration check.</param>
        /// <param name="enumerationCheckSplitFieldsResults">Result of the enumeration check for the split fields.</param>
        /// <param name="numDocChecked">Number of documents checked.</param>
        public EnumerationCheckDocumentTypeResultDTO(bool? enumerationCheckConfigured = default(bool?), bool? success = default(bool?), DocumentTypeCompleteDTO documentType = default(DocumentTypeCompleteDTO), List<EnumerationCheckSplitFieldsResultDTO> enumerationCheckSplitFieldsResults = default(List<EnumerationCheckSplitFieldsResultDTO>), int? numDocChecked = default(int?))
        {
            this.EnumerationCheckConfigured = enumerationCheckConfigured;
            this.Success = success;
            this.DocumentType = documentType;
            this.EnumerationCheckSplitFieldsResults = enumerationCheckSplitFieldsResults;
            this.NumDocChecked = numDocChecked;
        }
        
        /// <summary>
        /// If the business unit is configured for enumeration check for this document type, if not no result are provided
        /// </summary>
        /// <value>If the business unit is configured for enumeration check for this document type, if not no result are provided</value>
        [DataMember(Name="enumerationCheckConfigured", EmitDefaultValue=false)]
        public bool? EnumerationCheckConfigured { get; set; }

        /// <summary>
        /// If the enumeration check is successful
        /// </summary>
        /// <value>If the enumeration check is successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Document type of the enumeration check
        /// </summary>
        /// <value>Document type of the enumeration check</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeCompleteDTO DocumentType { get; set; }

        /// <summary>
        /// Result of the enumeration check for the split fields
        /// </summary>
        /// <value>Result of the enumeration check for the split fields</value>
        [DataMember(Name="enumerationCheckSplitFieldsResults", EmitDefaultValue=false)]
        public List<EnumerationCheckSplitFieldsResultDTO> EnumerationCheckSplitFieldsResults { get; set; }

        /// <summary>
        /// Number of documents checked
        /// </summary>
        /// <value>Number of documents checked</value>
        [DataMember(Name="numDocChecked", EmitDefaultValue=false)]
        public int? NumDocChecked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumerationCheckDocumentTypeResultDTO {\n");
            sb.Append("  EnumerationCheckConfigured: ").Append(EnumerationCheckConfigured).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  EnumerationCheckSplitFieldsResults: ").Append(EnumerationCheckSplitFieldsResults).Append("\n");
            sb.Append("  NumDocChecked: ").Append(NumDocChecked).Append("\n");
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
            return this.Equals(input as EnumerationCheckDocumentTypeResultDTO);
        }

        /// <summary>
        /// Returns true if EnumerationCheckDocumentTypeResultDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumerationCheckDocumentTypeResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumerationCheckDocumentTypeResultDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnumerationCheckConfigured == input.EnumerationCheckConfigured ||
                    (this.EnumerationCheckConfigured != null &&
                    this.EnumerationCheckConfigured.Equals(input.EnumerationCheckConfigured))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.EnumerationCheckSplitFieldsResults == input.EnumerationCheckSplitFieldsResults ||
                    this.EnumerationCheckSplitFieldsResults != null &&
                    this.EnumerationCheckSplitFieldsResults.SequenceEqual(input.EnumerationCheckSplitFieldsResults)
                ) && 
                (
                    this.NumDocChecked == input.NumDocChecked ||
                    (this.NumDocChecked != null &&
                    this.NumDocChecked.Equals(input.NumDocChecked))
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
                if (this.EnumerationCheckConfigured != null)
                    hashCode = hashCode * 59 + this.EnumerationCheckConfigured.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.EnumerationCheckSplitFieldsResults != null)
                    hashCode = hashCode * 59 + this.EnumerationCheckSplitFieldsResults.GetHashCode();
                if (this.NumDocChecked != null)
                    hashCode = hashCode * 59 + this.NumDocChecked.GetHashCode();
                return hashCode;
            }
        }
    }

}