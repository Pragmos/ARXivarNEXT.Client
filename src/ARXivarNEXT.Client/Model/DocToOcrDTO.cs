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
    /// Class of optical character recognition (OCR) on a document profile.
    /// </summary>
    [DataContract]
    public partial class DocToOcrDTO :  IEquatable<DocToOcrDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocToOcrDTO" /> class.
        /// </summary>
        /// <param name="docnumber">Document Identifier.</param>
        /// <param name="status">Possible values:  1: Pending  2: Failed  3: Scheduled  4: Pending_Rev  5: Failed_Rev  6: Scheduled_Rev .</param>
        /// <param name="revision">Revision of document.</param>
        /// <param name="ocrDate">Schedule Date.</param>
        /// <param name="user">User Identifier.</param>
        /// <param name="guid">Identifier.</param>
        /// <param name="numAttemps">Number of Attempts.</param>
        /// <param name="errorMessage">Error Message.</param>
        public DocToOcrDTO(int? docnumber = default(int?), int? status = default(int?), int? revision = default(int?), DateTime? ocrDate = default(DateTime?), int? user = default(int?), string guid = default(string), int? numAttemps = default(int?), string errorMessage = default(string))
        {
            this.Docnumber = docnumber;
            this.Status = status;
            this.Revision = revision;
            this.OcrDate = ocrDate;
            this.User = user;
            this.Guid = guid;
            this.NumAttemps = numAttemps;
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Possible values:  1: Pending  2: Failed  3: Scheduled  4: Pending_Rev  5: Failed_Rev  6: Scheduled_Rev 
        /// </summary>
        /// <value>Possible values:  1: Pending  2: Failed  3: Scheduled  4: Pending_Rev  5: Failed_Rev  6: Scheduled_Rev </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Revision of document
        /// </summary>
        /// <value>Revision of document</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Schedule Date
        /// </summary>
        /// <value>Schedule Date</value>
        [DataMember(Name="ocrDate", EmitDefaultValue=false)]
        public DateTime? OcrDate { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Number of Attempts
        /// </summary>
        /// <value>Number of Attempts</value>
        [DataMember(Name="numAttemps", EmitDefaultValue=false)]
        public int? NumAttemps { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        /// <value>Error Message</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocToOcrDTO {\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  OcrDate: ").Append(OcrDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  NumAttemps: ").Append(NumAttemps).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as DocToOcrDTO);
        }

        /// <summary>
        /// Returns true if DocToOcrDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocToOcrDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocToOcrDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.OcrDate == input.OcrDate ||
                    (this.OcrDate != null &&
                    this.OcrDate.Equals(input.OcrDate))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.NumAttemps == input.NumAttemps ||
                    (this.NumAttemps != null &&
                    this.NumAttemps.Equals(input.NumAttemps))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.OcrDate != null)
                    hashCode = hashCode * 59 + this.OcrDate.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.NumAttemps != null)
                    hashCode = hashCode * 59 + this.NumAttemps.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }

}
