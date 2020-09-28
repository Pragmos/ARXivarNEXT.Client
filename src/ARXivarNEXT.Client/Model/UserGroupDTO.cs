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
    /// UserGroupDTO
    /// </summary>
    [DataContract]
    public partial class UserGroupDTO :  IEquatable<UserGroupDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupDTO" /> class.
        /// </summary>
        /// <param name="id">Group ID..</param>
        /// <param name="description">Group description..</param>
        /// <param name="completeName">Complete Name.</param>
        /// <param name="businessUnitCode">BusinessUnit code.</param>
        /// <param name="state">Possible values:  0: NonAttivo  1: Attivo  2: Nascosto .</param>
        public UserGroupDTO(int? id = default(int?), string description = default(string), string completeName = default(string), string businessUnitCode = default(string), int? state = default(int?))
        {
            this.Id = id;
            this.Description = description;
            this.CompleteName = completeName;
            this.BusinessUnitCode = businessUnitCode;
            this.State = state;
        }
        
        /// <summary>
        /// Group ID.
        /// </summary>
        /// <value>Group ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Group description.
        /// </summary>
        /// <value>Group description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Complete Name
        /// </summary>
        /// <value>Complete Name</value>
        [DataMember(Name="completeName", EmitDefaultValue=false)]
        public string CompleteName { get; set; }

        /// <summary>
        /// BusinessUnit code
        /// </summary>
        /// <value>BusinessUnit code</value>
        [DataMember(Name="businessUnitCode", EmitDefaultValue=false)]
        public string BusinessUnitCode { get; set; }

        /// <summary>
        /// Possible values:  0: NonAttivo  1: Attivo  2: Nascosto 
        /// </summary>
        /// <value>Possible values:  0: NonAttivo  1: Attivo  2: Nascosto </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserGroupDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CompleteName: ").Append(CompleteName).Append("\n");
            sb.Append("  BusinessUnitCode: ").Append(BusinessUnitCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as UserGroupDTO);
        }

        /// <summary>
        /// Returns true if UserGroupDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserGroupDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserGroupDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CompleteName == input.CompleteName ||
                    (this.CompleteName != null &&
                    this.CompleteName.Equals(input.CompleteName))
                ) && 
                (
                    this.BusinessUnitCode == input.BusinessUnitCode ||
                    (this.BusinessUnitCode != null &&
                    this.BusinessUnitCode.Equals(input.BusinessUnitCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CompleteName != null)
                    hashCode = hashCode * 59 + this.CompleteName.GetHashCode();
                if (this.BusinessUnitCode != null)
                    hashCode = hashCode * 59 + this.BusinessUnitCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }

}
