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
    /// Command operation for TaskWork
    /// </summary>
    [DataContract]
    public partial class TaskWorkCommandDTO :  IEquatable<TaskWorkCommandDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkCommandDTO" /> class.
        /// </summary>
        /// <param name="id">Command Id..</param>
        /// <param name="processId">Process Id..</param>
        /// <param name="taskWorkId">TaskWork Id..</param>
        /// <param name="command">Command to execute..</param>
        /// <param name="isRequired">Required..</param>
        /// <param name="isAsync">Asyncronous execution..</param>
        /// <param name="description">Command description..</param>
        /// <param name="side">Possible values:  0: Client  1: Server  2: OpenUrl .</param>
        /// <param name="isExecuted">Executed.</param>
        public TaskWorkCommandDTO(int? id = default(int?), int? processId = default(int?), int? taskWorkId = default(int?), string command = default(string), bool? isRequired = default(bool?), bool? isAsync = default(bool?), string description = default(string), int? side = default(int?), bool? isExecuted = default(bool?))
        {
            this.Id = id;
            this.ProcessId = processId;
            this.TaskWorkId = taskWorkId;
            this.Command = command;
            this.IsRequired = isRequired;
            this.IsAsync = isAsync;
            this.Description = description;
            this.Side = side;
            this.IsExecuted = isExecuted;
        }
        
        /// <summary>
        /// Command Id.
        /// </summary>
        /// <value>Command Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Process Id.
        /// </summary>
        /// <value>Process Id.</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// TaskWork Id.
        /// </summary>
        /// <value>TaskWork Id.</value>
        [DataMember(Name="taskWorkId", EmitDefaultValue=false)]
        public int? TaskWorkId { get; set; }

        /// <summary>
        /// Command to execute.
        /// </summary>
        /// <value>Command to execute.</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public string Command { get; set; }

        /// <summary>
        /// Required.
        /// </summary>
        /// <value>Required.</value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Asyncronous execution.
        /// </summary>
        /// <value>Asyncronous execution.</value>
        [DataMember(Name="isAsync", EmitDefaultValue=false)]
        public bool? IsAsync { get; set; }

        /// <summary>
        /// Command description.
        /// </summary>
        /// <value>Command description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Possible values:  0: Client  1: Server  2: OpenUrl 
        /// </summary>
        /// <value>Possible values:  0: Client  1: Server  2: OpenUrl </value>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public int? Side { get; set; }

        /// <summary>
        /// Executed
        /// </summary>
        /// <value>Executed</value>
        [DataMember(Name="isExecuted", EmitDefaultValue=false)]
        public bool? IsExecuted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkCommandDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  TaskWorkId: ").Append(TaskWorkId).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  IsAsync: ").Append(IsAsync).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  IsExecuted: ").Append(IsExecuted).Append("\n");
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
            return this.Equals(input as TaskWorkCommandDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkCommandDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkCommandDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkCommandDTO input)
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
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.TaskWorkId == input.TaskWorkId ||
                    (this.TaskWorkId != null &&
                    this.TaskWorkId.Equals(input.TaskWorkId))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) && 
                (
                    this.IsAsync == input.IsAsync ||
                    (this.IsAsync != null &&
                    this.IsAsync.Equals(input.IsAsync))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.IsExecuted == input.IsExecuted ||
                    (this.IsExecuted != null &&
                    this.IsExecuted.Equals(input.IsExecuted))
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
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.TaskWorkId != null)
                    hashCode = hashCode * 59 + this.TaskWorkId.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.IsAsync != null)
                    hashCode = hashCode * 59 + this.IsAsync.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.IsExecuted != null)
                    hashCode = hashCode * 59 + this.IsExecuted.GetHashCode();
                return hashCode;
            }
        }
    }

}
