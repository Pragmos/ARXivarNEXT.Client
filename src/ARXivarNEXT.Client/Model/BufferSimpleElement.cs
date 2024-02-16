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
    /// BufferSimpleElement
    /// </summary>
    [DataContract]
    public partial class BufferSimpleElement :  IEquatable<BufferSimpleElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BufferSimpleElement" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="filename">filename.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="monitoredFolderId">monitoredFolderId.</param>
        /// <param name="monitoredFolderPath">monitoredFolderPath.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="bufferElementType">Possible values:  0: DmBuffer  1: NextArchive  2: MonitoredFolder  3: ProcessDocThumbnail  4: CloneProfile  5: ReportExecuted  6: Mail  7: ESign  8: Audit .</param>
        public BufferSimpleElement(string id = default(string), string filename = default(string), DateTime? creationDate = default(DateTime?), string monitoredFolderId = default(string), string monitoredFolderPath = default(string), long? fileSize = default(long?), int? bufferElementType = default(int?))
        {
            this.Id = id;
            this.Filename = filename;
            this.CreationDate = creationDate;
            this.MonitoredFolderId = monitoredFolderId;
            this.MonitoredFolderPath = monitoredFolderPath;
            this.FileSize = fileSize;
            this.BufferElementType = bufferElementType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets MonitoredFolderId
        /// </summary>
        [DataMember(Name="monitoredFolderId", EmitDefaultValue=false)]
        public string MonitoredFolderId { get; set; }

        /// <summary>
        /// Gets or Sets MonitoredFolderPath
        /// </summary>
        [DataMember(Name="monitoredFolderPath", EmitDefaultValue=false)]
        public string MonitoredFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name="fileSize", EmitDefaultValue=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// Possible values:  0: DmBuffer  1: NextArchive  2: MonitoredFolder  3: ProcessDocThumbnail  4: CloneProfile  5: ReportExecuted  6: Mail  7: ESign  8: Audit 
        /// </summary>
        /// <value>Possible values:  0: DmBuffer  1: NextArchive  2: MonitoredFolder  3: ProcessDocThumbnail  4: CloneProfile  5: ReportExecuted  6: Mail  7: ESign  8: Audit </value>
        [DataMember(Name="bufferElementType", EmitDefaultValue=false)]
        public int? BufferElementType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BufferSimpleElement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  MonitoredFolderId: ").Append(MonitoredFolderId).Append("\n");
            sb.Append("  MonitoredFolderPath: ").Append(MonitoredFolderPath).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  BufferElementType: ").Append(BufferElementType).Append("\n");
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
            return this.Equals(input as BufferSimpleElement);
        }

        /// <summary>
        /// Returns true if BufferSimpleElement instances are equal
        /// </summary>
        /// <param name="input">Instance of BufferSimpleElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BufferSimpleElement input)
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
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.MonitoredFolderId == input.MonitoredFolderId ||
                    (this.MonitoredFolderId != null &&
                    this.MonitoredFolderId.Equals(input.MonitoredFolderId))
                ) && 
                (
                    this.MonitoredFolderPath == input.MonitoredFolderPath ||
                    (this.MonitoredFolderPath != null &&
                    this.MonitoredFolderPath.Equals(input.MonitoredFolderPath))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.BufferElementType == input.BufferElementType ||
                    (this.BufferElementType != null &&
                    this.BufferElementType.Equals(input.BufferElementType))
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
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.MonitoredFolderId != null)
                    hashCode = hashCode * 59 + this.MonitoredFolderId.GetHashCode();
                if (this.MonitoredFolderPath != null)
                    hashCode = hashCode * 59 + this.MonitoredFolderPath.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.BufferElementType != null)
                    hashCode = hashCode * 59 + this.BufferElementType.GetHashCode();
                return hashCode;
            }
        }
    }

}
