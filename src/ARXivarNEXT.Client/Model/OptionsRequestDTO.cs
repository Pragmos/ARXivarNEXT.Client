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
    /// Class of options information
    /// </summary>
    [DataContract]
    public partial class OptionsRequestDTO :  IEquatable<OptionsRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsRequestDTO" /> class.
        /// </summary>
        /// <param name="argument">Argument.</param>
        /// <param name="value">Value.</param>
        public OptionsRequestDTO(string argument = default(string), string value = default(string))
        {
            this.Argument = argument;
            this.Value = value;
        }
        
        /// <summary>
        /// Argument
        /// </summary>
        /// <value>Argument</value>
        [DataMember(Name="argument", EmitDefaultValue=false)]
        public string Argument { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsRequestDTO {\n");
            sb.Append("  Argument: ").Append(Argument).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as OptionsRequestDTO);
        }

        /// <summary>
        /// Returns true if OptionsRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Argument == input.Argument ||
                    (this.Argument != null &&
                    this.Argument.Equals(input.Argument))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Argument != null)
                    hashCode = hashCode * 59 + this.Argument.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }

}
