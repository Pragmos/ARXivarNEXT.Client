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
using JsonSubTypes;
using SwaggerDateConverter = ARXivarNEXT.Client.Client.SwaggerDateConverter;

namespace ARXivarNEXT.Client.Model
{
    /// <summary>
    /// Class of the additional field filter properties
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "className")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchIntDto), "FieldBaseForSearchIntDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchDoubleDto), "FieldBaseForSearchDoubleDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchConservazioneDto), "FieldBaseForSearchConservazioneDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchContactDto), "FieldBaseForSearchContactDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchDocumentTypeDto), "FieldBaseForSearchDocumentTypeDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchStampDto), "FieldBaseForSearchStampDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchBoolDto), "FieldBaseForSearchBoolDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchListDto), "FieldBaseForSearchListDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchStringDto), "FieldBaseForSearchStringDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchDateTimeDto), "FieldBaseForSearchDateTimeDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchAooDto), "FieldBaseForSearchAooDto")]
    [JsonSubtypes.KnownSubType(typeof(FieldBaseForSearchProtocolloDto), "FieldBaseForSearchProtocolloDto")]
    public partial class FieldBaseForSearchDTO :  IEquatable<FieldBaseForSearchDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldBaseForSearchDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchDTO" /> class.
        /// </summary>
        /// <param name="groupId">Group Identifier.</param>
        /// <param name="fieldType">Possible values:  0: Standard  1: Group  2: Additional .</param>
        /// <param name="additionalFieldType">Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea .</param>
        /// <param name="defaultOperator">Default Operator.</param>
        /// <param name="tableName">Table name.</param>
        /// <param name="binderFieldId">Binder Identifier.</param>
        /// <param name="multiple">Multiple values.</param>
        /// <param name="name">Name.</param>
        /// <param name="externalId">External identifier.</param>
        /// <param name="description">Label.</param>
        /// <param name="order">Order.</param>
        /// <param name="dataSource">DataSource identifier.</param>
        /// <param name="required">Required.</param>
        /// <param name="formula">Formula.</param>
        /// <param name="className">Name of class (required).</param>
        /// <param name="locked">Locked in read-only.</param>
        /// <param name="comboGruppiId">Data Group Identifier.</param>
        /// <param name="dependencyFields">List of dependent fields.</param>
        /// <param name="associations">Associated fields.</param>
        /// <param name="isAdditional">Field type additional.</param>
        /// <param name="visible">Visible.</param>
        /// <param name="predefinedProfileFormula">Formula in the context of predefined profile.</param>
        public FieldBaseForSearchDTO(int? groupId = default(int?), int? fieldType = default(int?), int? additionalFieldType = default(int?), int? defaultOperator = default(int?), string tableName = default(string), int? binderFieldId = default(int?), string multiple = default(string), string name = default(string), string externalId = default(string), string description = default(string), int? order = default(int?), string dataSource = default(string), bool? required = default(bool?), string formula = default(string), string className = default(string), bool? locked = default(bool?), string comboGruppiId = default(string), List<DependencyFieldItem> dependencyFields = default(List<DependencyFieldItem>), Dictionary<string, string> associations = default(Dictionary<string, string>), bool? isAdditional = default(bool?), bool? visible = default(bool?), string predefinedProfileFormula = default(string))
        {
            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new InvalidDataException("className is a required property for FieldBaseForSearchDTO and cannot be null");
            }
            else
            {
                this.ClassName = className;
            }
            this.GroupId = groupId;
            this.FieldType = fieldType;
            this.AdditionalFieldType = additionalFieldType;
            this.DefaultOperator = defaultOperator;
            this.TableName = tableName;
            this.BinderFieldId = binderFieldId;
            this.Multiple = multiple;
            this.Name = name;
            this.ExternalId = externalId;
            this.Description = description;
            this.Order = order;
            this.DataSource = dataSource;
            this.Required = required;
            this.Formula = formula;
            this.Locked = locked;
            this.ComboGruppiId = comboGruppiId;
            this.DependencyFields = dependencyFields;
            this.Associations = associations;
            this.IsAdditional = isAdditional;
            this.Visible = visible;
            this.PredefinedProfileFormula = predefinedProfileFormula;
        }
        
        /// <summary>
        /// Group Identifier
        /// </summary>
        /// <value>Group Identifier</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// Possible values:  0: Standard  1: Group  2: Additional 
        /// </summary>
        /// <value>Possible values:  0: Standard  1: Group  2: Additional </value>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public int? FieldType { get; set; }

        /// <summary>
        /// Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea 
        /// </summary>
        /// <value>Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea </value>
        [DataMember(Name="additionalFieldType", EmitDefaultValue=false)]
        public int? AdditionalFieldType { get; set; }

        /// <summary>
        /// Default Operator
        /// </summary>
        /// <value>Default Operator</value>
        [DataMember(Name="defaultOperator", EmitDefaultValue=false)]
        public int? DefaultOperator { get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        /// <value>Table name</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Binder Identifier
        /// </summary>
        /// <value>Binder Identifier</value>
        [DataMember(Name="binderFieldId", EmitDefaultValue=false)]
        public int? BinderFieldId { get; set; }

        /// <summary>
        /// Multiple values
        /// </summary>
        /// <value>Multiple values</value>
        [DataMember(Name="multiple", EmitDefaultValue=false)]
        public string Multiple { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// External identifier
        /// </summary>
        /// <value>External identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// DataSource identifier
        /// </summary>
        /// <value>DataSource identifier</value>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        /// <value>Required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Formula
        /// </summary>
        /// <value>Formula</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }

        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Locked in read-only
        /// </summary>
        /// <value>Locked in read-only</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Data Group Identifier
        /// </summary>
        /// <value>Data Group Identifier</value>
        [DataMember(Name="comboGruppiId", EmitDefaultValue=false)]
        public string ComboGruppiId { get; set; }

        /// <summary>
        /// List of dependent fields
        /// </summary>
        /// <value>List of dependent fields</value>
        [DataMember(Name="dependencyFields", EmitDefaultValue=false)]
        public List<DependencyFieldItem> DependencyFields { get; set; }

        /// <summary>
        /// Associated fields
        /// </summary>
        /// <value>Associated fields</value>
        [DataMember(Name="associations", EmitDefaultValue=false)]
        public Dictionary<string, string> Associations { get; set; }

        /// <summary>
        /// Field type additional
        /// </summary>
        /// <value>Field type additional</value>
        [DataMember(Name="isAdditional", EmitDefaultValue=false)]
        public bool? IsAdditional { get; set; }

        /// <summary>
        /// Visible
        /// </summary>
        /// <value>Visible</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Formula in the context of predefined profile
        /// </summary>
        /// <value>Formula in the context of predefined profile</value>
        [DataMember(Name="predefinedProfileFormula", EmitDefaultValue=false)]
        public string PredefinedProfileFormula { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseForSearchDTO {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  AdditionalFieldType: ").Append(AdditionalFieldType).Append("\n");
            sb.Append("  DefaultOperator: ").Append(DefaultOperator).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  BinderFieldId: ").Append(BinderFieldId).Append("\n");
            sb.Append("  Multiple: ").Append(Multiple).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  ComboGruppiId: ").Append(ComboGruppiId).Append("\n");
            sb.Append("  DependencyFields: ").Append(DependencyFields).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  IsAdditional: ").Append(IsAdditional).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  PredefinedProfileFormula: ").Append(PredefinedProfileFormula).Append("\n");
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
            return this.Equals(input as FieldBaseForSearchDTO);
        }

        /// <summary>
        /// Returns true if FieldBaseForSearchDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldBaseForSearchDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseForSearchDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.AdditionalFieldType == input.AdditionalFieldType ||
                    (this.AdditionalFieldType != null &&
                    this.AdditionalFieldType.Equals(input.AdditionalFieldType))
                ) && 
                (
                    this.DefaultOperator == input.DefaultOperator ||
                    (this.DefaultOperator != null &&
                    this.DefaultOperator.Equals(input.DefaultOperator))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.BinderFieldId == input.BinderFieldId ||
                    (this.BinderFieldId != null &&
                    this.BinderFieldId.Equals(input.BinderFieldId))
                ) && 
                (
                    this.Multiple == input.Multiple ||
                    (this.Multiple != null &&
                    this.Multiple.Equals(input.Multiple))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.ComboGruppiId == input.ComboGruppiId ||
                    (this.ComboGruppiId != null &&
                    this.ComboGruppiId.Equals(input.ComboGruppiId))
                ) && 
                (
                    this.DependencyFields == input.DependencyFields ||
                    this.DependencyFields != null &&
                    this.DependencyFields.SequenceEqual(input.DependencyFields)
                ) && 
                (
                    this.Associations == input.Associations ||
                    this.Associations != null &&
                    this.Associations.SequenceEqual(input.Associations)
                ) && 
                (
                    this.IsAdditional == input.IsAdditional ||
                    (this.IsAdditional != null &&
                    this.IsAdditional.Equals(input.IsAdditional))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
                ) && 
                (
                    this.PredefinedProfileFormula == input.PredefinedProfileFormula ||
                    (this.PredefinedProfileFormula != null &&
                    this.PredefinedProfileFormula.Equals(input.PredefinedProfileFormula))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.AdditionalFieldType != null)
                    hashCode = hashCode * 59 + this.AdditionalFieldType.GetHashCode();
                if (this.DefaultOperator != null)
                    hashCode = hashCode * 59 + this.DefaultOperator.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.BinderFieldId != null)
                    hashCode = hashCode * 59 + this.BinderFieldId.GetHashCode();
                if (this.Multiple != null)
                    hashCode = hashCode * 59 + this.Multiple.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.ComboGruppiId != null)
                    hashCode = hashCode * 59 + this.ComboGruppiId.GetHashCode();
                if (this.DependencyFields != null)
                    hashCode = hashCode * 59 + this.DependencyFields.GetHashCode();
                if (this.Associations != null)
                    hashCode = hashCode * 59 + this.Associations.GetHashCode();
                if (this.IsAdditional != null)
                    hashCode = hashCode * 59 + this.IsAdditional.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.PredefinedProfileFormula != null)
                    hashCode = hashCode * 59 + this.PredefinedProfileFormula.GetHashCode();
                return hashCode;
            }
        }
    }

}
