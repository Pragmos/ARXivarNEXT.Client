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
    /// Class of request for remove some profiles to a binder
    /// </summary>
    [DataContract]
    public partial class BinderProfilesRemoveRequest :  IEquatable<BinderProfilesRemoveRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderProfilesRemoveRequest" /> class.
        /// </summary>
        /// <param name="profilesIds">Profiles to remove.</param>
        /// <param name="binderId">Binder Identifier.</param>
        public BinderProfilesRemoveRequest(List<int?> profilesIds = default(List<int?>), int? binderId = default(int?))
        {
            this.ProfilesIds = profilesIds;
            this.BinderId = binderId;
        }
        
        /// <summary>
        /// Profiles to remove
        /// </summary>
        /// <value>Profiles to remove</value>
        [DataMember(Name="profilesIds", EmitDefaultValue=false)]
        public List<int?> ProfilesIds { get; set; }

        /// <summary>
        /// Binder Identifier
        /// </summary>
        /// <value>Binder Identifier</value>
        [DataMember(Name="binderId", EmitDefaultValue=false)]
        public int? BinderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderProfilesRemoveRequest {\n");
            sb.Append("  ProfilesIds: ").Append(ProfilesIds).Append("\n");
            sb.Append("  BinderId: ").Append(BinderId).Append("\n");
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
            return this.Equals(input as BinderProfilesRemoveRequest);
        }

        /// <summary>
        /// Returns true if BinderProfilesRemoveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BinderProfilesRemoveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderProfilesRemoveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfilesIds == input.ProfilesIds ||
                    this.ProfilesIds != null &&
                    this.ProfilesIds.SequenceEqual(input.ProfilesIds)
                ) && 
                (
                    this.BinderId == input.BinderId ||
                    (this.BinderId != null &&
                    this.BinderId.Equals(input.BinderId))
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
                if (this.ProfilesIds != null)
                    hashCode = hashCode * 59 + this.ProfilesIds.GetHashCode();
                if (this.BinderId != null)
                    hashCode = hashCode * 59 + this.BinderId.GetHashCode();
                return hashCode;
            }
        }
    }

}
