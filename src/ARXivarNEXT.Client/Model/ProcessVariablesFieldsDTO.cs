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
    /// Class of fields of process variable
    /// </summary>
    [DataContract]
    public partial class ProcessVariablesFieldsDTO :  IEquatable<ProcessVariablesFieldsDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessVariablesFieldsDTO" /> class.
        /// </summary>
        /// <param name="booleanVariables">List of variables in boolean format.</param>
        /// <param name="stringVariables">List of variables in string format.</param>
        /// <param name="comboVariables">List of variables in list format.</param>
        /// <param name="dateTimeVariables">List of variables in datetime format.</param>
        /// <param name="doubleVariables">List of variables in decimal format.</param>
        /// <param name="tableVariables">List of variables in table format.</param>
        public ProcessVariablesFieldsDTO(List<AdditionalFieldBooleanDTO> booleanVariables = default(List<AdditionalFieldBooleanDTO>), List<AdditionalFieldStringDTO> stringVariables = default(List<AdditionalFieldStringDTO>), List<AdditionalFieldComboDTO> comboVariables = default(List<AdditionalFieldComboDTO>), List<AdditionalFieldDateTimeDTO> dateTimeVariables = default(List<AdditionalFieldDateTimeDTO>), List<AdditionalFieldDoubleDTO> doubleVariables = default(List<AdditionalFieldDoubleDTO>), List<AdditionalFieldTableDTO> tableVariables = default(List<AdditionalFieldTableDTO>))
        {
            this.BooleanVariables = booleanVariables;
            this.StringVariables = stringVariables;
            this.ComboVariables = comboVariables;
            this.DateTimeVariables = dateTimeVariables;
            this.DoubleVariables = doubleVariables;
            this.TableVariables = tableVariables;
        }
        
        /// <summary>
        /// List of variables in boolean format
        /// </summary>
        /// <value>List of variables in boolean format</value>
        [DataMember(Name="booleanVariables", EmitDefaultValue=false)]
        public List<AdditionalFieldBooleanDTO> BooleanVariables { get; set; }

        /// <summary>
        /// List of variables in string format
        /// </summary>
        /// <value>List of variables in string format</value>
        [DataMember(Name="stringVariables", EmitDefaultValue=false)]
        public List<AdditionalFieldStringDTO> StringVariables { get; set; }

        /// <summary>
        /// List of variables in list format
        /// </summary>
        /// <value>List of variables in list format</value>
        [DataMember(Name="comboVariables", EmitDefaultValue=false)]
        public List<AdditionalFieldComboDTO> ComboVariables { get; set; }

        /// <summary>
        /// List of variables in datetime format
        /// </summary>
        /// <value>List of variables in datetime format</value>
        [DataMember(Name="dateTimeVariables", EmitDefaultValue=false)]
        public List<AdditionalFieldDateTimeDTO> DateTimeVariables { get; set; }

        /// <summary>
        /// List of variables in decimal format
        /// </summary>
        /// <value>List of variables in decimal format</value>
        [DataMember(Name="doubleVariables", EmitDefaultValue=false)]
        public List<AdditionalFieldDoubleDTO> DoubleVariables { get; set; }

        /// <summary>
        /// List of variables in table format
        /// </summary>
        /// <value>List of variables in table format</value>
        [DataMember(Name="tableVariables", EmitDefaultValue=false)]
        public List<AdditionalFieldTableDTO> TableVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessVariablesFieldsDTO {\n");
            sb.Append("  BooleanVariables: ").Append(BooleanVariables).Append("\n");
            sb.Append("  StringVariables: ").Append(StringVariables).Append("\n");
            sb.Append("  ComboVariables: ").Append(ComboVariables).Append("\n");
            sb.Append("  DateTimeVariables: ").Append(DateTimeVariables).Append("\n");
            sb.Append("  DoubleVariables: ").Append(DoubleVariables).Append("\n");
            sb.Append("  TableVariables: ").Append(TableVariables).Append("\n");
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
            return this.Equals(input as ProcessVariablesFieldsDTO);
        }

        /// <summary>
        /// Returns true if ProcessVariablesFieldsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessVariablesFieldsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessVariablesFieldsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BooleanVariables == input.BooleanVariables ||
                    this.BooleanVariables != null &&
                    this.BooleanVariables.SequenceEqual(input.BooleanVariables)
                ) && 
                (
                    this.StringVariables == input.StringVariables ||
                    this.StringVariables != null &&
                    this.StringVariables.SequenceEqual(input.StringVariables)
                ) && 
                (
                    this.ComboVariables == input.ComboVariables ||
                    this.ComboVariables != null &&
                    this.ComboVariables.SequenceEqual(input.ComboVariables)
                ) && 
                (
                    this.DateTimeVariables == input.DateTimeVariables ||
                    this.DateTimeVariables != null &&
                    this.DateTimeVariables.SequenceEqual(input.DateTimeVariables)
                ) && 
                (
                    this.DoubleVariables == input.DoubleVariables ||
                    this.DoubleVariables != null &&
                    this.DoubleVariables.SequenceEqual(input.DoubleVariables)
                ) && 
                (
                    this.TableVariables == input.TableVariables ||
                    this.TableVariables != null &&
                    this.TableVariables.SequenceEqual(input.TableVariables)
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
                if (this.BooleanVariables != null)
                    hashCode = hashCode * 59 + this.BooleanVariables.GetHashCode();
                if (this.StringVariables != null)
                    hashCode = hashCode * 59 + this.StringVariables.GetHashCode();
                if (this.ComboVariables != null)
                    hashCode = hashCode * 59 + this.ComboVariables.GetHashCode();
                if (this.DateTimeVariables != null)
                    hashCode = hashCode * 59 + this.DateTimeVariables.GetHashCode();
                if (this.DoubleVariables != null)
                    hashCode = hashCode * 59 + this.DoubleVariables.GetHashCode();
                if (this.TableVariables != null)
                    hashCode = hashCode * 59 + this.TableVariables.GetHashCode();
                return hashCode;
            }
        }
    }

}
