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
    /// Workflow chain master summary
    /// </summary>
    [DataContract]
    public partial class WorkFlowChainMasterSummaryDTO :  IEquatable<WorkFlowChainMasterSummaryDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkFlowChainMasterSummaryDTO" /> class.
        /// </summary>
        /// <param name="chainMaster">Workflow chain master.</param>
        /// <param name="correlationCount">Number of correlated chain.</param>
        public WorkFlowChainMasterSummaryDTO(WorkFlowChainMasterDTO chainMaster = default(WorkFlowChainMasterDTO), int? correlationCount = default(int?))
        {
            this.ChainMaster = chainMaster;
            this.CorrelationCount = correlationCount;
        }
        
        /// <summary>
        /// Workflow chain master
        /// </summary>
        /// <value>Workflow chain master</value>
        [DataMember(Name="chainMaster", EmitDefaultValue=false)]
        public WorkFlowChainMasterDTO ChainMaster { get; set; }

        /// <summary>
        /// Number of correlated chain
        /// </summary>
        /// <value>Number of correlated chain</value>
        [DataMember(Name="correlationCount", EmitDefaultValue=false)]
        public int? CorrelationCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkFlowChainMasterSummaryDTO {\n");
            sb.Append("  ChainMaster: ").Append(ChainMaster).Append("\n");
            sb.Append("  CorrelationCount: ").Append(CorrelationCount).Append("\n");
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
            return this.Equals(input as WorkFlowChainMasterSummaryDTO);
        }

        /// <summary>
        /// Returns true if WorkFlowChainMasterSummaryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkFlowChainMasterSummaryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkFlowChainMasterSummaryDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChainMaster == input.ChainMaster ||
                    (this.ChainMaster != null &&
                    this.ChainMaster.Equals(input.ChainMaster))
                ) && 
                (
                    this.CorrelationCount == input.CorrelationCount ||
                    (this.CorrelationCount != null &&
                    this.CorrelationCount.Equals(input.CorrelationCount))
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
                if (this.ChainMaster != null)
                    hashCode = hashCode * 59 + this.ChainMaster.GetHashCode();
                if (this.CorrelationCount != null)
                    hashCode = hashCode * 59 + this.CorrelationCount.GetHashCode();
                return hashCode;
            }
        }
    }

}
