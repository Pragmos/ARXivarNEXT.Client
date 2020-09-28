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
    /// Class of taskwork closed
    /// </summary>
    [DataContract]
    public partial class TaskWorkCloseRequest :  IEquatable<TaskWorkCloseRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkCloseRequest" /> class.
        /// </summary>
        /// <param name="taskWorkIds">List of Taskwork identifier.</param>
        /// <param name="exitCode">Exit Code.</param>
        /// <param name="password">Password.</param>
        /// <param name="note">Note.</param>
        public TaskWorkCloseRequest(List<int?> taskWorkIds = default(List<int?>), string exitCode = default(string), string password = default(string), string note = default(string))
        {
            this.TaskWorkIds = taskWorkIds;
            this.ExitCode = exitCode;
            this.Password = password;
            this.Note = note;
        }
        
        /// <summary>
        /// List of Taskwork identifier
        /// </summary>
        /// <value>List of Taskwork identifier</value>
        [DataMember(Name="taskWorkIds", EmitDefaultValue=false)]
        public List<int?> TaskWorkIds { get; set; }

        /// <summary>
        /// Exit Code
        /// </summary>
        /// <value>Exit Code</value>
        [DataMember(Name="exitCode", EmitDefaultValue=false)]
        public string ExitCode { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        /// <value>Note</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkCloseRequest {\n");
            sb.Append("  TaskWorkIds: ").Append(TaskWorkIds).Append("\n");
            sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(input as TaskWorkCloseRequest);
        }

        /// <summary>
        /// Returns true if TaskWorkCloseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkCloseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkCloseRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskWorkIds == input.TaskWorkIds ||
                    this.TaskWorkIds != null &&
                    this.TaskWorkIds.SequenceEqual(input.TaskWorkIds)
                ) && 
                (
                    this.ExitCode == input.ExitCode ||
                    (this.ExitCode != null &&
                    this.ExitCode.Equals(input.ExitCode))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                if (this.TaskWorkIds != null)
                    hashCode = hashCode * 59 + this.TaskWorkIds.GetHashCode();
                if (this.ExitCode != null)
                    hashCode = hashCode * 59 + this.ExitCode.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                return hashCode;
            }
        }
    }

}
