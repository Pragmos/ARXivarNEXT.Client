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
    /// Class of task layout
    /// </summary>
    [DataContract]
    public partial class TaskLayoutDetailDTO :  IEquatable<TaskLayoutDetailDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLayoutDetailDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="elementId">Item Identifier.</param>
        /// <param name="x">X Position.</param>
        /// <param name="y">Y Position.</param>
        /// <param name="w">Width.</param>
        /// <param name="h">Heigth.</param>
        /// <param name="instanceId">Instance Identifier.</param>
        /// <param name="taskLayoutId">Task Layout Identifier.</param>
        public TaskLayoutDetailDTO(int? id = default(int?), string elementId = default(string), int? x = default(int?), int? y = default(int?), int? w = default(int?), int? h = default(int?), string instanceId = default(string), int? taskLayoutId = default(int?))
        {
            this.Id = id;
            this.ElementId = elementId;
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            this.InstanceId = instanceId;
            this.TaskLayoutId = taskLayoutId;
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
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// X Position
        /// </summary>
        /// <value>X Position</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Y Position
        /// </summary>
        /// <value>Y Position</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        /// <value>Width</value>
        [DataMember(Name="w", EmitDefaultValue=false)]
        public int? W { get; set; }

        /// <summary>
        /// Heigth
        /// </summary>
        /// <value>Heigth</value>
        [DataMember(Name="h", EmitDefaultValue=false)]
        public int? H { get; set; }

        /// <summary>
        /// Instance Identifier
        /// </summary>
        /// <value>Instance Identifier</value>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Task Layout Identifier
        /// </summary>
        /// <value>Task Layout Identifier</value>
        [DataMember(Name="taskLayoutId", EmitDefaultValue=false)]
        public int? TaskLayoutId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskLayoutDetailDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  W: ").Append(W).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  TaskLayoutId: ").Append(TaskLayoutId).Append("\n");
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
            return this.Equals(input as TaskLayoutDetailDTO);
        }

        /// <summary>
        /// Returns true if TaskLayoutDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskLayoutDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskLayoutDetailDTO input)
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
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.W == input.W ||
                    (this.W != null &&
                    this.W.Equals(input.W))
                ) && 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.TaskLayoutId == input.TaskLayoutId ||
                    (this.TaskLayoutId != null &&
                    this.TaskLayoutId.Equals(input.TaskLayoutId))
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
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.W != null)
                    hashCode = hashCode * 59 + this.W.GetHashCode();
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.TaskLayoutId != null)
                    hashCode = hashCode * 59 + this.TaskLayoutId.GetHashCode();
                return hashCode;
            }
        }
    }

}
