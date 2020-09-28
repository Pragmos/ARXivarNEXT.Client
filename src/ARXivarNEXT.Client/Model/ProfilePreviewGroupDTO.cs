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
    /// Class of preview group for documents
    /// </summary>
    [DataContract]
    public partial class ProfilePreviewGroupDTO :  IEquatable<ProfilePreviewGroupDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePreviewGroupDTO" /> class.
        /// </summary>
        /// <param name="labelGroup">Label of Group.</param>
        /// <param name="label">Label.</param>
        /// <param name="order">Order.</param>
        /// <param name="fields">List of Fields.</param>
        /// <param name="groupType">Possible values:  0: Standard  1: From  2: To  3: CC  4: Senders  5: Additionals  6: Notes  7: InternalAttachments  8: ExternalAttachments  9: Folders  10: Binders  11: Associations .</param>
        public ProfilePreviewGroupDTO(string labelGroup = default(string), string label = default(string), int? order = default(int?), List<FieldBaseDTO> fields = default(List<FieldBaseDTO>), int? groupType = default(int?))
        {
            this.LabelGroup = labelGroup;
            this.Label = label;
            this.Order = order;
            this.Fields = fields;
            this.GroupType = groupType;
        }
        
        /// <summary>
        /// Label of Group
        /// </summary>
        /// <value>Label of Group</value>
        [DataMember(Name="labelGroup", EmitDefaultValue=false)]
        public string LabelGroup { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// List of Fields
        /// </summary>
        /// <value>List of Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }

        /// <summary>
        /// Possible values:  0: Standard  1: From  2: To  3: CC  4: Senders  5: Additionals  6: Notes  7: InternalAttachments  8: ExternalAttachments  9: Folders  10: Binders  11: Associations 
        /// </summary>
        /// <value>Possible values:  0: Standard  1: From  2: To  3: CC  4: Senders  5: Additionals  6: Notes  7: InternalAttachments  8: ExternalAttachments  9: Folders  10: Binders  11: Associations </value>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public int? GroupType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfilePreviewGroupDTO {\n");
            sb.Append("  LabelGroup: ").Append(LabelGroup).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
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
            return this.Equals(input as ProfilePreviewGroupDTO);
        }

        /// <summary>
        /// Returns true if ProfilePreviewGroupDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfilePreviewGroupDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfilePreviewGroupDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelGroup == input.LabelGroup ||
                    (this.LabelGroup != null &&
                    this.LabelGroup.Equals(input.LabelGroup))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
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
                if (this.LabelGroup != null)
                    hashCode = hashCode * 59 + this.LabelGroup.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                return hashCode;
            }
        }
    }

}
