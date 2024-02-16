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
    /// NpceSummaryDTO
    /// </summary>
    [DataContract]
    public partial class NpceSummaryDTO :  IEquatable<NpceSummaryDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpceSummaryDTO" /> class.
        /// </summary>
        /// <param name="totalToSend">totalToSend.</param>
        /// <param name="totalInProgress">totalInProgress.</param>
        /// <param name="totalToConfirm">totalToConfirm.</param>
        /// <param name="totalProcessingError">totalProcessingError.</param>
        /// <param name="totalSendingError">totalSendingError.</param>
        /// <param name="totalCanceled">totalCanceled.</param>
        /// <param name="totalInDelivery">totalInDelivery.</param>
        /// <param name="totalDeliveryError">totalDeliveryError.</param>
        public NpceSummaryDTO(int? totalToSend = default(int?), int? totalInProgress = default(int?), int? totalToConfirm = default(int?), int? totalProcessingError = default(int?), int? totalSendingError = default(int?), int? totalCanceled = default(int?), int? totalInDelivery = default(int?), int? totalDeliveryError = default(int?))
        {
            this.TotalToSend = totalToSend;
            this.TotalInProgress = totalInProgress;
            this.TotalToConfirm = totalToConfirm;
            this.TotalProcessingError = totalProcessingError;
            this.TotalSendingError = totalSendingError;
            this.TotalCanceled = totalCanceled;
            this.TotalInDelivery = totalInDelivery;
            this.TotalDeliveryError = totalDeliveryError;
        }
        
        /// <summary>
        /// Gets or Sets TotalToSend
        /// </summary>
        [DataMember(Name="totalToSend", EmitDefaultValue=false)]
        public int? TotalToSend { get; set; }

        /// <summary>
        /// Gets or Sets TotalInProgress
        /// </summary>
        [DataMember(Name="totalInProgress", EmitDefaultValue=false)]
        public int? TotalInProgress { get; set; }

        /// <summary>
        /// Gets or Sets TotalToConfirm
        /// </summary>
        [DataMember(Name="totalToConfirm", EmitDefaultValue=false)]
        public int? TotalToConfirm { get; set; }

        /// <summary>
        /// Gets or Sets TotalProcessingError
        /// </summary>
        [DataMember(Name="totalProcessingError", EmitDefaultValue=false)]
        public int? TotalProcessingError { get; set; }

        /// <summary>
        /// Gets or Sets TotalSendingError
        /// </summary>
        [DataMember(Name="totalSendingError", EmitDefaultValue=false)]
        public int? TotalSendingError { get; set; }

        /// <summary>
        /// Gets or Sets TotalCanceled
        /// </summary>
        [DataMember(Name="totalCanceled", EmitDefaultValue=false)]
        public int? TotalCanceled { get; set; }

        /// <summary>
        /// Gets or Sets TotalInDelivery
        /// </summary>
        [DataMember(Name="totalInDelivery", EmitDefaultValue=false)]
        public int? TotalInDelivery { get; set; }

        /// <summary>
        /// Gets or Sets TotalDeliveryError
        /// </summary>
        [DataMember(Name="totalDeliveryError", EmitDefaultValue=false)]
        public int? TotalDeliveryError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NpceSummaryDTO {\n");
            sb.Append("  TotalToSend: ").Append(TotalToSend).Append("\n");
            sb.Append("  TotalInProgress: ").Append(TotalInProgress).Append("\n");
            sb.Append("  TotalToConfirm: ").Append(TotalToConfirm).Append("\n");
            sb.Append("  TotalProcessingError: ").Append(TotalProcessingError).Append("\n");
            sb.Append("  TotalSendingError: ").Append(TotalSendingError).Append("\n");
            sb.Append("  TotalCanceled: ").Append(TotalCanceled).Append("\n");
            sb.Append("  TotalInDelivery: ").Append(TotalInDelivery).Append("\n");
            sb.Append("  TotalDeliveryError: ").Append(TotalDeliveryError).Append("\n");
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
            return this.Equals(input as NpceSummaryDTO);
        }

        /// <summary>
        /// Returns true if NpceSummaryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NpceSummaryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NpceSummaryDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalToSend == input.TotalToSend ||
                    (this.TotalToSend != null &&
                    this.TotalToSend.Equals(input.TotalToSend))
                ) && 
                (
                    this.TotalInProgress == input.TotalInProgress ||
                    (this.TotalInProgress != null &&
                    this.TotalInProgress.Equals(input.TotalInProgress))
                ) && 
                (
                    this.TotalToConfirm == input.TotalToConfirm ||
                    (this.TotalToConfirm != null &&
                    this.TotalToConfirm.Equals(input.TotalToConfirm))
                ) && 
                (
                    this.TotalProcessingError == input.TotalProcessingError ||
                    (this.TotalProcessingError != null &&
                    this.TotalProcessingError.Equals(input.TotalProcessingError))
                ) && 
                (
                    this.TotalSendingError == input.TotalSendingError ||
                    (this.TotalSendingError != null &&
                    this.TotalSendingError.Equals(input.TotalSendingError))
                ) && 
                (
                    this.TotalCanceled == input.TotalCanceled ||
                    (this.TotalCanceled != null &&
                    this.TotalCanceled.Equals(input.TotalCanceled))
                ) && 
                (
                    this.TotalInDelivery == input.TotalInDelivery ||
                    (this.TotalInDelivery != null &&
                    this.TotalInDelivery.Equals(input.TotalInDelivery))
                ) && 
                (
                    this.TotalDeliveryError == input.TotalDeliveryError ||
                    (this.TotalDeliveryError != null &&
                    this.TotalDeliveryError.Equals(input.TotalDeliveryError))
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
                if (this.TotalToSend != null)
                    hashCode = hashCode * 59 + this.TotalToSend.GetHashCode();
                if (this.TotalInProgress != null)
                    hashCode = hashCode * 59 + this.TotalInProgress.GetHashCode();
                if (this.TotalToConfirm != null)
                    hashCode = hashCode * 59 + this.TotalToConfirm.GetHashCode();
                if (this.TotalProcessingError != null)
                    hashCode = hashCode * 59 + this.TotalProcessingError.GetHashCode();
                if (this.TotalSendingError != null)
                    hashCode = hashCode * 59 + this.TotalSendingError.GetHashCode();
                if (this.TotalCanceled != null)
                    hashCode = hashCode * 59 + this.TotalCanceled.GetHashCode();
                if (this.TotalInDelivery != null)
                    hashCode = hashCode * 59 + this.TotalInDelivery.GetHashCode();
                if (this.TotalDeliveryError != null)
                    hashCode = hashCode * 59 + this.TotalDeliveryError.GetHashCode();
                return hashCode;
            }
        }
    }

}
