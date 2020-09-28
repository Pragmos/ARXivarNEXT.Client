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
    /// TaskWorkInstructionGroupDTO
    /// </summary>
    [DataContract]
    public partial class TaskWorkInstructionGroupDTO :  IEquatable<TaskWorkInstructionGroupDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkInstructionGroupDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="order">order.</param>
        /// <param name="description">description.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="showInDocumentation">showInDocumentation.</param>
        /// <param name="items">items.</param>
        public TaskWorkInstructionGroupDTO(string id = default(string), int? order = default(int?), string description = default(string), bool? deleted = default(bool?), bool? showInDocumentation = default(bool?), List<TaskWorkInstructionItemDTO> items = default(List<TaskWorkInstructionItemDTO>))
        {
            this.Id = id;
            this.Order = order;
            this.Description = description;
            this.Deleted = deleted;
            this.ShowInDocumentation = showInDocumentation;
            this.Items = items;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or Sets ShowInDocumentation
        /// </summary>
        [DataMember(Name="showInDocumentation", EmitDefaultValue=false)]
        public bool? ShowInDocumentation { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<TaskWorkInstructionItemDTO> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkInstructionGroupDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  ShowInDocumentation: ").Append(ShowInDocumentation).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as TaskWorkInstructionGroupDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkInstructionGroupDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkInstructionGroupDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkInstructionGroupDTO input)
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
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.ShowInDocumentation == input.ShowInDocumentation ||
                    (this.ShowInDocumentation != null &&
                    this.ShowInDocumentation.Equals(input.ShowInDocumentation))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.ShowInDocumentation != null)
                    hashCode = hashCode * 59 + this.ShowInDocumentation.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }

}
