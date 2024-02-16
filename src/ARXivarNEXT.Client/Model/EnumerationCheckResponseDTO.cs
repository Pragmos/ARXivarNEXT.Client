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
    /// Result of the enumeration check
    /// </summary>
    [DataContract]
    public partial class EnumerationCheckResponseDTO :  IEquatable<EnumerationCheckResponseDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationCheckResponseDTO" /> class.
        /// </summary>
        /// <param name="numDocChecked">The number of documents checked.</param>
        /// <param name="numDocInVolumeTemp">The number of documents in temporary volume.</param>
        /// <param name="success">If the enumeration check is successful.</param>
        /// <param name="businessUnitsCheckResult">Result of the enumeration check for each Business Unit.</param>
        public EnumerationCheckResponseDTO(int? numDocChecked = default(int?), int? numDocInVolumeTemp = default(int?), bool? success = default(bool?), List<EnumerationCheckBusinessUnitResultDTO> businessUnitsCheckResult = default(List<EnumerationCheckBusinessUnitResultDTO>))
        {
            this.NumDocChecked = numDocChecked;
            this.NumDocInVolumeTemp = numDocInVolumeTemp;
            this.Success = success;
            this.BusinessUnitsCheckResult = businessUnitsCheckResult;
        }
        
        /// <summary>
        /// The number of documents checked
        /// </summary>
        /// <value>The number of documents checked</value>
        [DataMember(Name="numDocChecked", EmitDefaultValue=false)]
        public int? NumDocChecked { get; set; }

        /// <summary>
        /// The number of documents in temporary volume
        /// </summary>
        /// <value>The number of documents in temporary volume</value>
        [DataMember(Name="numDocInVolumeTemp", EmitDefaultValue=false)]
        public int? NumDocInVolumeTemp { get; set; }

        /// <summary>
        /// If the enumeration check is successful
        /// </summary>
        /// <value>If the enumeration check is successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Result of the enumeration check for each Business Unit
        /// </summary>
        /// <value>Result of the enumeration check for each Business Unit</value>
        [DataMember(Name="businessUnitsCheckResult", EmitDefaultValue=false)]
        public List<EnumerationCheckBusinessUnitResultDTO> BusinessUnitsCheckResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumerationCheckResponseDTO {\n");
            sb.Append("  NumDocChecked: ").Append(NumDocChecked).Append("\n");
            sb.Append("  NumDocInVolumeTemp: ").Append(NumDocInVolumeTemp).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  BusinessUnitsCheckResult: ").Append(BusinessUnitsCheckResult).Append("\n");
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
            return this.Equals(input as EnumerationCheckResponseDTO);
        }

        /// <summary>
        /// Returns true if EnumerationCheckResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumerationCheckResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumerationCheckResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumDocChecked == input.NumDocChecked ||
                    (this.NumDocChecked != null &&
                    this.NumDocChecked.Equals(input.NumDocChecked))
                ) && 
                (
                    this.NumDocInVolumeTemp == input.NumDocInVolumeTemp ||
                    (this.NumDocInVolumeTemp != null &&
                    this.NumDocInVolumeTemp.Equals(input.NumDocInVolumeTemp))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.BusinessUnitsCheckResult == input.BusinessUnitsCheckResult ||
                    this.BusinessUnitsCheckResult != null &&
                    this.BusinessUnitsCheckResult.SequenceEqual(input.BusinessUnitsCheckResult)
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
                if (this.NumDocChecked != null)
                    hashCode = hashCode * 59 + this.NumDocChecked.GetHashCode();
                if (this.NumDocInVolumeTemp != null)
                    hashCode = hashCode * 59 + this.NumDocInVolumeTemp.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.BusinessUnitsCheckResult != null)
                    hashCode = hashCode * 59 + this.BusinessUnitsCheckResult.GetHashCode();
                return hashCode;
            }
        }
    }

}
