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
    /// DesktopItemDTO
    /// </summary>
    [DataContract]
    public partial class DesktopItemDTO :  IEquatable<DesktopItemDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopItemDTO" /> class.
        /// </summary>
        /// <param name="desktopItemType">Possible values:  0: View  1: Profile  2: Folder  3: Model  4: QuickSearch  5: Mask .</param>
        /// <param name="desktopItemId">Unique id of the item.</param>
        public DesktopItemDTO(int? desktopItemType = default(int?), string desktopItemId = default(string))
        {
            this.DesktopItemType = desktopItemType;
            this.DesktopItemId = desktopItemId;
        }
        
        /// <summary>
        /// Possible values:  0: View  1: Profile  2: Folder  3: Model  4: QuickSearch  5: Mask 
        /// </summary>
        /// <value>Possible values:  0: View  1: Profile  2: Folder  3: Model  4: QuickSearch  5: Mask </value>
        [DataMember(Name="desktopItemType", EmitDefaultValue=false)]
        public int? DesktopItemType { get; set; }

        /// <summary>
        /// Unique id of the item
        /// </summary>
        /// <value>Unique id of the item</value>
        [DataMember(Name="desktopItemId", EmitDefaultValue=false)]
        public string DesktopItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopItemDTO {\n");
            sb.Append("  DesktopItemType: ").Append(DesktopItemType).Append("\n");
            sb.Append("  DesktopItemId: ").Append(DesktopItemId).Append("\n");
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
            return this.Equals(input as DesktopItemDTO);
        }

        /// <summary>
        /// Returns true if DesktopItemDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DesktopItemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopItemDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DesktopItemType == input.DesktopItemType ||
                    (this.DesktopItemType != null &&
                    this.DesktopItemType.Equals(input.DesktopItemType))
                ) && 
                (
                    this.DesktopItemId == input.DesktopItemId ||
                    (this.DesktopItemId != null &&
                    this.DesktopItemId.Equals(input.DesktopItemId))
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
                if (this.DesktopItemType != null)
                    hashCode = hashCode * 59 + this.DesktopItemType.GetHashCode();
                if (this.DesktopItemId != null)
                    hashCode = hashCode * 59 + this.DesktopItemId.GetHashCode();
                return hashCode;
            }
        }
    }

}
