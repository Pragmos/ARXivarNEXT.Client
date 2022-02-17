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
    /// Class for Plugin advanced command request
    /// </summary>
    [DataContract]
    public partial class PluginAdvancedCommandRequestDTO :  IEquatable<PluginAdvancedCommandRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginAdvancedCommandRequestDTO" /> class.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="command">Command.</param>
        public PluginAdvancedCommandRequestDTO(string parameters = default(string), string command = default(string))
        {
            this.Parameters = parameters;
            this.Command = command;
        }
        
        /// <summary>
        /// Parameters
        /// </summary>
        /// <value>Parameters</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// Command
        /// </summary>
        /// <value>Command</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public string Command { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginAdvancedCommandRequestDTO {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
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
            return this.Equals(input as PluginAdvancedCommandRequestDTO);
        }

        /// <summary>
        /// Returns true if PluginAdvancedCommandRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginAdvancedCommandRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginAdvancedCommandRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
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
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                return hashCode;
            }
        }
    }

}
