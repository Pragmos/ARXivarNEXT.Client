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
    /// RelationInsertItemDTO
    /// </summary>
    [DataContract]
    public partial class RelationInsertItemDTO :  IEquatable<RelationInsertItemDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationInsertItemDTO" /> class.
        /// </summary>
        /// <param name="docNumber">Document Identifier.</param>
        /// <param name="relationType">Possible values:  0: Date  1: Father  2: Child .</param>
        public RelationInsertItemDTO(int? docNumber = default(int?), int? relationType = default(int?))
        {
            this.DocNumber = docNumber;
            this.RelationType = relationType;
        }
        
        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Possible values:  0: Date  1: Father  2: Child 
        /// </summary>
        /// <value>Possible values:  0: Date  1: Father  2: Child </value>
        [DataMember(Name="relationType", EmitDefaultValue=false)]
        public int? RelationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationInsertItemDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  RelationType: ").Append(RelationType).Append("\n");
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
            return this.Equals(input as RelationInsertItemDTO);
        }

        /// <summary>
        /// Returns true if RelationInsertItemDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationInsertItemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationInsertItemDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.RelationType == input.RelationType ||
                    (this.RelationType != null &&
                    this.RelationType.Equals(input.RelationType))
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
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.RelationType != null)
                    hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                return hashCode;
            }
        }
    }

}
