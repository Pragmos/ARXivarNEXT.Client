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
    /// SqlQueryExecuteByExternalIdDTO
    /// </summary>
    [DataContract]
    public partial class SqlQueryExecuteByExternalIdDTO :  IEquatable<SqlQueryExecuteByExternalIdDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlQueryExecuteByExternalIdDTO" /> class.
        /// </summary>
        /// <param name="externalId">externalId.</param>
        /// <param name="values">values.</param>
        /// <param name="filters">filters.</param>
        public SqlQueryExecuteByExternalIdDTO(string externalId = default(string), List<KeyValueDTO> values = default(List<KeyValueDTO>), List<FieldBaseForSearchDTO> filters = default(List<FieldBaseForSearchDTO>))
        {
            this.ExternalId = externalId;
            this.Values = values;
            this.Filters = filters;
        }
        
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<KeyValueDTO> Values { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDTO> Filters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlQueryExecuteByExternalIdDTO {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(input as SqlQueryExecuteByExternalIdDTO);
        }

        /// <summary>
        /// Returns true if SqlQueryExecuteByExternalIdDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlQueryExecuteByExternalIdDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlQueryExecuteByExternalIdDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                return hashCode;
            }
        }
    }

}
