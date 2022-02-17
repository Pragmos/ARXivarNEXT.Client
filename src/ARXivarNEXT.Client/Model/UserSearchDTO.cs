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
    /// Class of user search fields
    /// </summary>
    [DataContract]
    public partial class UserSearchDTO :  IEquatable<UserSearchDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchDTO" /> class.
        /// </summary>
        /// <param name="stringFields">List of fields of type &#39;String&#39;.</param>
        /// <param name="intFields">List of fields of type &#39;Integer&#39;.</param>
        public UserSearchDTO(List<FieldBaseForSearchStringDto> stringFields = default(List<FieldBaseForSearchStringDto>), List<FieldBaseForSearchIntDto> intFields = default(List<FieldBaseForSearchIntDto>))
        {
            this.StringFields = stringFields;
            this.IntFields = intFields;
        }
        
        /// <summary>
        /// List of fields of type &#39;String&#39;
        /// </summary>
        /// <value>List of fields of type &#39;String&#39;</value>
        [DataMember(Name="stringFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchStringDto> StringFields { get; set; }

        /// <summary>
        /// List of fields of type &#39;Integer&#39;
        /// </summary>
        /// <value>List of fields of type &#39;Integer&#39;</value>
        [DataMember(Name="intFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchIntDto> IntFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearchDTO {\n");
            sb.Append("  StringFields: ").Append(StringFields).Append("\n");
            sb.Append("  IntFields: ").Append(IntFields).Append("\n");
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
            return this.Equals(input as UserSearchDTO);
        }

        /// <summary>
        /// Returns true if UserSearchDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSearchDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StringFields == input.StringFields ||
                    this.StringFields != null &&
                    this.StringFields.SequenceEqual(input.StringFields)
                ) && 
                (
                    this.IntFields == input.IntFields ||
                    this.IntFields != null &&
                    this.IntFields.SequenceEqual(input.IntFields)
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
                if (this.StringFields != null)
                    hashCode = hashCode * 59 + this.StringFields.GetHashCode();
                if (this.IntFields != null)
                    hashCode = hashCode * 59 + this.IntFields.GetHashCode();
                return hashCode;
            }
        }
    }

}