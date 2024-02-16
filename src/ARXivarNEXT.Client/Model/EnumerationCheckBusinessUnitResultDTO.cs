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
    /// Result of the enumeration check for a Business Unit
    /// </summary>
    [DataContract]
    public partial class EnumerationCheckBusinessUnitResultDTO :  IEquatable<EnumerationCheckBusinessUnitResultDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationCheckBusinessUnitResultDTO" /> class.
        /// </summary>
        /// <param name="businessUnit">Business Unit.</param>
        /// <param name="documentTypesCheckResult">Result of the enumeration check for each Document Types.</param>
        public EnumerationCheckBusinessUnitResultDTO(BusinessUnitDTO businessUnit = default(BusinessUnitDTO), List<EnumerationCheckDocumentTypeResultDTO> documentTypesCheckResult = default(List<EnumerationCheckDocumentTypeResultDTO>))
        {
            this.BusinessUnit = businessUnit;
            this.DocumentTypesCheckResult = documentTypesCheckResult;
        }
        
        /// <summary>
        /// Business Unit
        /// </summary>
        /// <value>Business Unit</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public BusinessUnitDTO BusinessUnit { get; set; }

        /// <summary>
        /// Result of the enumeration check for each Document Types
        /// </summary>
        /// <value>Result of the enumeration check for each Document Types</value>
        [DataMember(Name="documentTypesCheckResult", EmitDefaultValue=false)]
        public List<EnumerationCheckDocumentTypeResultDTO> DocumentTypesCheckResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumerationCheckBusinessUnitResultDTO {\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  DocumentTypesCheckResult: ").Append(DocumentTypesCheckResult).Append("\n");
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
            return this.Equals(input as EnumerationCheckBusinessUnitResultDTO);
        }

        /// <summary>
        /// Returns true if EnumerationCheckBusinessUnitResultDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumerationCheckBusinessUnitResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumerationCheckBusinessUnitResultDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessUnit == input.BusinessUnit ||
                    (this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(input.BusinessUnit))
                ) && 
                (
                    this.DocumentTypesCheckResult == input.DocumentTypesCheckResult ||
                    this.DocumentTypesCheckResult != null &&
                    this.DocumentTypesCheckResult.SequenceEqual(input.DocumentTypesCheckResult)
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
                if (this.BusinessUnit != null)
                    hashCode = hashCode * 59 + this.BusinessUnit.GetHashCode();
                if (this.DocumentTypesCheckResult != null)
                    hashCode = hashCode * 59 + this.DocumentTypesCheckResult.GetHashCode();
                return hashCode;
            }
        }
    }

}
