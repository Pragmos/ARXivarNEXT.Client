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
    /// Class for search in addressbook
    /// </summary>
    [DataContract]
    public partial class AddressBookSearchConcreteDTO :  IEquatable<AddressBookSearchConcreteDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookSearchConcreteDTO" /> class.
        /// </summary>
        /// <param name="dateTimeFields">List of fields of type &#39;Datetime&#39;.</param>
        /// <param name="stringFields">List of fields of type &#39;String&#39;.</param>
        /// <param name="intFields">List of fields of type &#39;Integer&#39;.</param>
        /// <param name="boolFields">List of fields of type &#39;Boolean&#39;.</param>
        /// <param name="doubleFields">List of fields of type &#39;Decimal&#39;.</param>
        /// <param name="stringListFields">List of fields of type &#39;List&#39;.</param>
        /// <param name="maxItems">maxItems.</param>
        public AddressBookSearchConcreteDTO(List<FieldBaseForSearchDateTimeDto> dateTimeFields = default(List<FieldBaseForSearchDateTimeDto>), List<FieldBaseForSearchStringDto> stringFields = default(List<FieldBaseForSearchStringDto>), List<FieldBaseForSearchIntDto> intFields = default(List<FieldBaseForSearchIntDto>), List<FieldBaseForSearchBoolDto> boolFields = default(List<FieldBaseForSearchBoolDto>), List<FieldBaseForSearchDoubleDto> doubleFields = default(List<FieldBaseForSearchDoubleDto>), List<FieldBaseForSearchListDto> stringListFields = default(List<FieldBaseForSearchListDto>), int? maxItems = default(int?))
        {
            this.DateTimeFields = dateTimeFields;
            this.StringFields = stringFields;
            this.IntFields = intFields;
            this.BoolFields = boolFields;
            this.DoubleFields = doubleFields;
            this.StringListFields = stringListFields;
            this.MaxItems = maxItems;
        }
        
        /// <summary>
        /// List of fields of type &#39;Datetime&#39;
        /// </summary>
        /// <value>List of fields of type &#39;Datetime&#39;</value>
        [DataMember(Name="dateTimeFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDateTimeDto> DateTimeFields { get; set; }

        /// <summary>
        /// List of fields of type &#39;String&#39;
        /// </summary>
        /// <value>List of fields of type &#39;String&#39;</value>
        [DataMember(Name="stringFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchStringDto> StringFields { get; set; }

        /// <summary>
        /// List of fields of type &#39;Integer&#39;
        /// </summary>
        /// <value>List of fields of type &#39;Integer&#39;</value>
        [DataMember(Name="intFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchIntDto> IntFields { get; set; }

        /// <summary>
        /// List of fields of type &#39;Boolean&#39;
        /// </summary>
        /// <value>List of fields of type &#39;Boolean&#39;</value>
        [DataMember(Name="boolFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchBoolDto> BoolFields { get; set; }

        /// <summary>
        /// List of fields of type &#39;Decimal&#39;
        /// </summary>
        /// <value>List of fields of type &#39;Decimal&#39;</value>
        [DataMember(Name="doubleFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDoubleDto> DoubleFields { get; set; }

        /// <summary>
        /// List of fields of type &#39;List&#39;
        /// </summary>
        /// <value>List of fields of type &#39;List&#39;</value>
        [DataMember(Name="stringListFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchListDto> StringListFields { get; set; }

        /// <summary>
        /// Gets or Sets MaxItems
        /// </summary>
        [DataMember(Name="maxItems", EmitDefaultValue=false)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressBookSearchConcreteDTO {\n");
            sb.Append("  DateTimeFields: ").Append(DateTimeFields).Append("\n");
            sb.Append("  StringFields: ").Append(StringFields).Append("\n");
            sb.Append("  IntFields: ").Append(IntFields).Append("\n");
            sb.Append("  BoolFields: ").Append(BoolFields).Append("\n");
            sb.Append("  DoubleFields: ").Append(DoubleFields).Append("\n");
            sb.Append("  StringListFields: ").Append(StringListFields).Append("\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
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
            return this.Equals(input as AddressBookSearchConcreteDTO);
        }

        /// <summary>
        /// Returns true if AddressBookSearchConcreteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressBookSearchConcreteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressBookSearchConcreteDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateTimeFields == input.DateTimeFields ||
                    this.DateTimeFields != null &&
                    this.DateTimeFields.SequenceEqual(input.DateTimeFields)
                ) && 
                (
                    this.StringFields == input.StringFields ||
                    this.StringFields != null &&
                    this.StringFields.SequenceEqual(input.StringFields)
                ) && 
                (
                    this.IntFields == input.IntFields ||
                    this.IntFields != null &&
                    this.IntFields.SequenceEqual(input.IntFields)
                ) && 
                (
                    this.BoolFields == input.BoolFields ||
                    this.BoolFields != null &&
                    this.BoolFields.SequenceEqual(input.BoolFields)
                ) && 
                (
                    this.DoubleFields == input.DoubleFields ||
                    this.DoubleFields != null &&
                    this.DoubleFields.SequenceEqual(input.DoubleFields)
                ) && 
                (
                    this.StringListFields == input.StringListFields ||
                    this.StringListFields != null &&
                    this.StringListFields.SequenceEqual(input.StringListFields)
                ) && 
                (
                    this.MaxItems == input.MaxItems ||
                    (this.MaxItems != null &&
                    this.MaxItems.Equals(input.MaxItems))
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
                if (this.DateTimeFields != null)
                    hashCode = hashCode * 59 + this.DateTimeFields.GetHashCode();
                if (this.StringFields != null)
                    hashCode = hashCode * 59 + this.StringFields.GetHashCode();
                if (this.IntFields != null)
                    hashCode = hashCode * 59 + this.IntFields.GetHashCode();
                if (this.BoolFields != null)
                    hashCode = hashCode * 59 + this.BoolFields.GetHashCode();
                if (this.DoubleFields != null)
                    hashCode = hashCode * 59 + this.DoubleFields.GetHashCode();
                if (this.StringListFields != null)
                    hashCode = hashCode * 59 + this.StringListFields.GetHashCode();
                if (this.MaxItems != null)
                    hashCode = hashCode * 59 + this.MaxItems.GetHashCode();
                return hashCode;
            }
        }
    }

}