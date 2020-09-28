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
    /// Class of profile desktop information
    /// </summary>
    [DataContract]
    public partial class ProfileForDesktopDTO :  IEquatable<ProfileForDesktopDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileForDesktopDTO" /> class.
        /// </summary>
        /// <param name="revision">Revision.</param>
        /// <param name="docNumber">Document Identifier.</param>
        /// <param name="number">Internal Protocol.</param>
        /// <param name="subject">Subject.</param>
        /// <param name="documentDate">Date of document.</param>
        /// <param name="to">Reciviers.</param>
        /// <param name="from">Sender.</param>
        /// <param name="fileName">File name associated with the profile.</param>
        public ProfileForDesktopDTO(int? revision = default(int?), int? docNumber = default(int?), string number = default(string), string subject = default(string), DateTime? documentDate = default(DateTime?), string to = default(string), string from = default(string), string fileName = default(string))
        {
            this.Revision = revision;
            this.DocNumber = docNumber;
            this.Number = number;
            this.Subject = subject;
            this.DocumentDate = documentDate;
            this.To = to;
            this.From = from;
            this.FileName = fileName;
        }
        
        /// <summary>
        /// Revision
        /// </summary>
        /// <value>Revision</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Internal Protocol
        /// </summary>
        /// <value>Internal Protocol</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        /// <value>Subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Date of document
        /// </summary>
        /// <value>Date of document</value>
        [DataMember(Name="documentDate", EmitDefaultValue=false)]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// Reciviers
        /// </summary>
        /// <value>Reciviers</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Sender
        /// </summary>
        /// <value>Sender</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// File name associated with the profile
        /// </summary>
        /// <value>File name associated with the profile</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileForDesktopDTO {\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return this.Equals(input as ProfileForDesktopDTO);
        }

        /// <summary>
        /// Returns true if ProfileForDesktopDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileForDesktopDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileForDesktopDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.DocumentDate == input.DocumentDate ||
                    (this.DocumentDate != null &&
                    this.DocumentDate.Equals(input.DocumentDate))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
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
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.DocumentDate != null)
                    hashCode = hashCode * 59 + this.DocumentDate.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                return hashCode;
            }
        }
    }

}
