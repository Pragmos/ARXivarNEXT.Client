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
    /// Class of rule in folder for profiling
    /// </summary>
    [DataContract]
    public partial class FolderArchiveModeRule :  IEquatable<FolderArchiveModeRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderArchiveModeRule" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="itemId">Item Identifier.</param>
        /// <param name="itemName">Item Name.</param>
        /// <param name="userId">User Identifier.</param>
        /// <param name="userCompleteName">User Name.</param>
        /// <param name="compositionRule">Rule.</param>
        public FolderArchiveModeRule(int? id = default(int?), string itemId = default(string), string itemName = default(string), int? userId = default(int?), string userCompleteName = default(string), FolderCompositionRule compositionRule = default(FolderCompositionRule))
        {
            this.Id = id;
            this.ItemId = itemId;
            this.ItemName = itemName;
            this.UserId = userId;
            this.UserCompleteName = userCompleteName;
            this.CompositionRule = compositionRule;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Item Identifier
        /// </summary>
        /// <value>Item Identifier</value>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        /// <value>Item Name</value>
        [DataMember(Name="itemName", EmitDefaultValue=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <value>User Name</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Rule
        /// </summary>
        /// <value>Rule</value>
        [DataMember(Name="compositionRule", EmitDefaultValue=false)]
        public FolderCompositionRule CompositionRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderArchiveModeRule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  CompositionRule: ").Append(CompositionRule).Append("\n");
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
            return this.Equals(input as FolderArchiveModeRule);
        }

        /// <summary>
        /// Returns true if FolderArchiveModeRule instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderArchiveModeRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderArchiveModeRule input)
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
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.CompositionRule == input.CompositionRule ||
                    (this.CompositionRule != null &&
                    this.CompositionRule.Equals(input.CompositionRule))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ItemName != null)
                    hashCode = hashCode * 59 + this.ItemName.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.CompositionRule != null)
                    hashCode = hashCode * 59 + this.CompositionRule.GetHashCode();
                return hashCode;
            }
        }
    }

}
