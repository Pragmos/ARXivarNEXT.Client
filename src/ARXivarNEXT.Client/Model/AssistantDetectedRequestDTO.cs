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
    /// AssistantDetectedRequestDTO
    /// </summary>
    [DataContract]
    public partial class AssistantDetectedRequestDTO :  IEquatable<AssistantDetectedRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantDetectedRequestDTO" /> class.
        /// </summary>
        /// <param name="connectionId">connectionId.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="version">version.</param>
        public AssistantDetectedRequestDTO(string connectionId = default(string), List<string> capabilities = default(List<string>), string version = default(string))
        {
            this.ConnectionId = connectionId;
            this.Capabilities = capabilities;
            this.Version = version;
        }
        
        /// <summary>
        /// Gets or Sets ConnectionId
        /// </summary>
        [DataMember(Name="connectionId", EmitDefaultValue=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistantDetectedRequestDTO {\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as AssistantDetectedRequestDTO);
        }

        /// <summary>
        /// Returns true if AssistantDetectedRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AssistantDetectedRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssistantDetectedRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectionId == input.ConnectionId ||
                    (this.ConnectionId != null &&
                    this.ConnectionId.Equals(input.ConnectionId))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ConnectionId != null)
                    hashCode = hashCode * 59 + this.ConnectionId.GetHashCode();
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
