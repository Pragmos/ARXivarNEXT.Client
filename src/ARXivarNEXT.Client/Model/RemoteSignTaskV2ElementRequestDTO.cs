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
    /// Remote sign Taskwork Workflow V2
    /// </summary>
    [DataContract]
    public partial class RemoteSignTaskV2ElementRequestDTO :  IEquatable<RemoteSignTaskV2ElementRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteSignTaskV2ElementRequestDTO" /> class.
        /// </summary>
        /// <param name="taskId">Taskwork id.</param>
        /// <param name="operationId">Operation Id.</param>
        /// <param name="documentIdList">Document id list.</param>
        public RemoteSignTaskV2ElementRequestDTO(string taskId = default(string), string operationId = default(string), List<string> documentIdList = default(List<string>))
        {
            this.TaskId = taskId;
            this.OperationId = operationId;
            this.DocumentIdList = documentIdList;
        }
        
        /// <summary>
        /// Taskwork id
        /// </summary>
        /// <value>Taskwork id</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Operation Id
        /// </summary>
        /// <value>Operation Id</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// Document id list
        /// </summary>
        /// <value>Document id list</value>
        [DataMember(Name="documentIdList", EmitDefaultValue=false)]
        public List<string> DocumentIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteSignTaskV2ElementRequestDTO {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  DocumentIdList: ").Append(DocumentIdList).Append("\n");
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
            return this.Equals(input as RemoteSignTaskV2ElementRequestDTO);
        }

        /// <summary>
        /// Returns true if RemoteSignTaskV2ElementRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteSignTaskV2ElementRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteSignTaskV2ElementRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.DocumentIdList == input.DocumentIdList ||
                    this.DocumentIdList != null &&
                    this.DocumentIdList.SequenceEqual(input.DocumentIdList)
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                if (this.DocumentIdList != null)
                    hashCode = hashCode * 59 + this.DocumentIdList.GetHashCode();
                return hashCode;
            }
        }
    }

}
