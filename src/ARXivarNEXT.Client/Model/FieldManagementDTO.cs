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
    /// Class of field item for management
    /// </summary>
    [DataContract]
    public partial class FieldManagementDTO :  IEquatable<FieldManagementDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldManagementDTO" /> class.
        /// </summary>
        /// <param name="documentType">Document type for additional field.</param>
        /// <param name="dataType">Possible values:  0: Integer  1: String  2: DateTime  3: Double  4: Boolean  5: DmDatiProfilo .</param>
        /// <param name="name">Name.</param>
        /// <param name="description">Label.</param>
        /// <param name="table">Possible values:  0: Empty  1: DM_PROFILE  2: DM_PROFILE_MULTIVALUES  3: DM_DATIPROFILO  4: DM_DATI_ENTE  5: _Function_ .</param>
        /// <param name="type">Possible values:  0: Standard  1: Additional  2: Contacts  3: PA  4: BodyData  5: Function .</param>
        public FieldManagementDTO(DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), int? dataType = default(int?), string name = default(string), string description = default(string), int? table = default(int?), int? type = default(int?))
        {
            this.DocumentType = documentType;
            this.DataType = dataType;
            this.Name = name;
            this.Description = description;
            this.Table = table;
            this.Type = type;
        }
        
        /// <summary>
        /// Document type for additional field
        /// </summary>
        /// <value>Document type for additional field</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// Possible values:  0: Integer  1: String  2: DateTime  3: Double  4: Boolean  5: DmDatiProfilo 
        /// </summary>
        /// <value>Possible values:  0: Integer  1: String  2: DateTime  3: Double  4: Boolean  5: DmDatiProfilo </value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public int? DataType { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Possible values:  0: Empty  1: DM_PROFILE  2: DM_PROFILE_MULTIVALUES  3: DM_DATIPROFILO  4: DM_DATI_ENTE  5: _Function_ 
        /// </summary>
        /// <value>Possible values:  0: Empty  1: DM_PROFILE  2: DM_PROFILE_MULTIVALUES  3: DM_DATIPROFILO  4: DM_DATI_ENTE  5: _Function_ </value>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public int? Table { get; set; }

        /// <summary>
        /// Possible values:  0: Standard  1: Additional  2: Contacts  3: PA  4: BodyData  5: Function 
        /// </summary>
        /// <value>Possible values:  0: Standard  1: Additional  2: Contacts  3: PA  4: BodyData  5: Function </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldManagementDTO {\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as FieldManagementDTO);
        }

        /// <summary>
        /// Returns true if FieldManagementDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldManagementDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldManagementDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}
