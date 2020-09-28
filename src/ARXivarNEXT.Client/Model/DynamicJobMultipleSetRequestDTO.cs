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
    /// Dynamic job operation multiple set request
    /// </summary>
    [DataContract]
    public partial class DynamicJobMultipleSetRequestDTO :  IEquatable<DynamicJobMultipleSetRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicJobMultipleSetRequestDTO" /> class.
        /// </summary>
        /// <param name="dynamicJobUserId">User id of dynamic job.</param>
        /// <param name="taskWorkIds">TaskWork id to set.</param>
        /// <param name="users">Values for dynamic job.</param>
        public DynamicJobMultipleSetRequestDTO(int? dynamicJobUserId = default(int?), List<int?> taskWorkIds = default(List<int?>), List<UserCompleteDTO> users = default(List<UserCompleteDTO>))
        {
            this.DynamicJobUserId = dynamicJobUserId;
            this.TaskWorkIds = taskWorkIds;
            this.Users = users;
        }
        
        /// <summary>
        /// User id of dynamic job
        /// </summary>
        /// <value>User id of dynamic job</value>
        [DataMember(Name="dynamicJobUserId", EmitDefaultValue=false)]
        public int? DynamicJobUserId { get; set; }

        /// <summary>
        /// TaskWork id to set
        /// </summary>
        /// <value>TaskWork id to set</value>
        [DataMember(Name="taskWorkIds", EmitDefaultValue=false)]
        public List<int?> TaskWorkIds { get; set; }

        /// <summary>
        /// Values for dynamic job
        /// </summary>
        /// <value>Values for dynamic job</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserCompleteDTO> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicJobMultipleSetRequestDTO {\n");
            sb.Append("  DynamicJobUserId: ").Append(DynamicJobUserId).Append("\n");
            sb.Append("  TaskWorkIds: ").Append(TaskWorkIds).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as DynamicJobMultipleSetRequestDTO);
        }

        /// <summary>
        /// Returns true if DynamicJobMultipleSetRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicJobMultipleSetRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicJobMultipleSetRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DynamicJobUserId == input.DynamicJobUserId ||
                    (this.DynamicJobUserId != null &&
                    this.DynamicJobUserId.Equals(input.DynamicJobUserId))
                ) && 
                (
                    this.TaskWorkIds == input.TaskWorkIds ||
                    this.TaskWorkIds != null &&
                    this.TaskWorkIds.SequenceEqual(input.TaskWorkIds)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.DynamicJobUserId != null)
                    hashCode = hashCode * 59 + this.DynamicJobUserId.GetHashCode();
                if (this.TaskWorkIds != null)
                    hashCode = hashCode * 59 + this.TaskWorkIds.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }

}
