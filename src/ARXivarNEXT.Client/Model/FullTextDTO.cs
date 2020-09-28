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
    /// Class of Full Text Item
    /// </summary>
    [DataContract]
    public partial class FullTextDTO :  IEquatable<FullTextDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullTextDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="docnumber">Document Identifier.</param>
        /// <param name="revision">Revision Number.</param>
        /// <param name="text">Text recognition by the OCR operation.</param>
        public FullTextDTO(int? id = default(int?), int? docnumber = default(int?), int? revision = default(int?), string text = default(string))
        {
            this.Id = id;
            this.Docnumber = docnumber;
            this.Revision = revision;
            this.Text = text;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Revision Number
        /// </summary>
        /// <value>Revision Number</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Text recognition by the OCR operation
        /// </summary>
        /// <value>Text recognition by the OCR operation</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullTextDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as FullTextDTO);
        }

        /// <summary>
        /// Returns true if FullTextDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FullTextDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullTextDTO input)
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
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                return hashCode;
            }
        }
    }

}
