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
    /// WorkflowEventAbstractConfiguration
    /// </summary>
    [DataContract]
    public partial class WorkflowEventAbstractConfiguration :  IEquatable<WorkflowEventAbstractConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEventAbstractConfiguration" /> class.
        /// </summary>
        /// <param name="className">className.</param>
        /// <param name="filters">filters.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="defaultValues">defaultValues.</param>
        /// <param name="variableAssociations">variableAssociations.</param>
        public WorkflowEventAbstractConfiguration(string className = default(string), List<EventFilterDTO> filters = default(List<EventFilterDTO>), int? eventType = default(int?), List<EventDefaultValueDTO> defaultValues = default(List<EventDefaultValueDTO>), List<EventVariableAssDTO> variableAssociations = default(List<EventVariableAssDTO>))
        {
            this.ClassName = className;
            this.Filters = filters;
            this.EventType = eventType;
            this.DefaultValues = defaultValues;
            this.VariableAssociations = variableAssociations;
        }
        
        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<EventFilterDTO> Filters { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public int? EventType { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name="defaultValues", EmitDefaultValue=false)]
        public List<EventDefaultValueDTO> DefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets VariableAssociations
        /// </summary>
        [DataMember(Name="variableAssociations", EmitDefaultValue=false)]
        public List<EventVariableAssDTO> VariableAssociations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowEventAbstractConfiguration {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
            sb.Append("  VariableAssociations: ").Append(VariableAssociations).Append("\n");
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
            return this.Equals(input as WorkflowEventAbstractConfiguration);
        }

        /// <summary>
        /// Returns true if WorkflowEventAbstractConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowEventAbstractConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowEventAbstractConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.DefaultValues == input.DefaultValues ||
                    this.DefaultValues != null &&
                    this.DefaultValues.SequenceEqual(input.DefaultValues)
                ) && 
                (
                    this.VariableAssociations == input.VariableAssociations ||
                    this.VariableAssociations != null &&
                    this.VariableAssociations.SequenceEqual(input.VariableAssociations)
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.DefaultValues != null)
                    hashCode = hashCode * 59 + this.DefaultValues.GetHashCode();
                if (this.VariableAssociations != null)
                    hashCode = hashCode * 59 + this.VariableAssociations.GetHashCode();
                return hashCode;
            }
        }
    }

}
