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
    /// Class of permission item
    /// </summary>
    [DataContract]
    public partial class PermissionItemDTO :  IEquatable<PermissionItemDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionItemDTO" /> class.
        /// </summary>
        /// <param name="permission">Identifier.</param>
        /// <param name="allow">Allow.</param>
        /// <param name="deny">Deny.</param>
        public PermissionItemDTO(int? permission = default(int?), bool? allow = default(bool?), bool? deny = default(bool?))
        {
            this.Permission = permission;
            this.Allow = allow;
            this.Deny = deny;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public int? Permission { get; set; }

        /// <summary>
        /// Allow
        /// </summary>
        /// <value>Allow</value>
        [DataMember(Name="allow", EmitDefaultValue=false)]
        public bool? Allow { get; set; }

        /// <summary>
        /// Deny
        /// </summary>
        /// <value>Deny</value>
        [DataMember(Name="deny", EmitDefaultValue=false)]
        public bool? Deny { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionItemDTO {\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Allow: ").Append(Allow).Append("\n");
            sb.Append("  Deny: ").Append(Deny).Append("\n");
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
            return this.Equals(input as PermissionItemDTO);
        }

        /// <summary>
        /// Returns true if PermissionItemDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionItemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionItemDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Allow == input.Allow ||
                    (this.Allow != null &&
                    this.Allow.Equals(input.Allow))
                ) && 
                (
                    this.Deny == input.Deny ||
                    (this.Deny != null &&
                    this.Deny.Equals(input.Deny))
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
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Allow != null)
                    hashCode = hashCode * 59 + this.Allow.GetHashCode();
                if (this.Deny != null)
                    hashCode = hashCode * 59 + this.Deny.GetHashCode();
                return hashCode;
            }
        }
    }

}
