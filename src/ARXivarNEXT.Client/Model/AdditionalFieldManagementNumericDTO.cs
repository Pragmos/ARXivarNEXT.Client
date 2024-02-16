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
    /// Class for additional field of type Numeric
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldManagementNumericDTO :  IEquatable<AdditionalFieldManagementNumericDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementNumericDTO" /> class.
        /// </summary>
        /// <param name="decimals">Decimals number.</param>
        /// <param name="autocomplete">Autocomplete.</param>
        /// <param name="autocompleteCharacter">Autocomplete character.</param>
        /// <param name="autocompleteAlign">Possible values:  0: Left  1: Right  -1: None .</param>
        /// <param name="locked">Si definisce se il campo è bloccato per l&#39;inserimento di un valore.</param>
        /// <param name="transcoding">Enable field transcoding.</param>
        /// <param name="tableName">Transcoding: Table name.</param>
        /// <param name="codeFieldName">Transcoding: Field name for code.</param>
        /// <param name="descriptionFieldName">Transcoding: Field name for description.</param>
        /// <param name="validationType">Possible values:  0: None  1: Regex  2: Formula .</param>
        /// <param name="validationString">Validation string (formula/regex).</param>
        /// <param name="showThousandsSeparator">showThousandsSeparator.</param>
        public AdditionalFieldManagementNumericDTO(int? decimals = default(int?), bool? autocomplete = default(bool?), string autocompleteCharacter = default(string), int? autocompleteAlign = default(int?), bool? locked = default(bool?), bool? transcoding = default(bool?), string tableName = default(string), string codeFieldName = default(string), string descriptionFieldName = default(string), int? validationType = default(int?), string validationString = default(string), bool? showThousandsSeparator = default(bool?))
        {
            this.Decimals = decimals;
            this.Autocomplete = autocomplete;
            this.AutocompleteCharacter = autocompleteCharacter;
            this.AutocompleteAlign = autocompleteAlign;
            this.Locked = locked;
            this.Transcoding = transcoding;
            this.TableName = tableName;
            this.CodeFieldName = codeFieldName;
            this.DescriptionFieldName = descriptionFieldName;
            this.ValidationType = validationType;
            this.ValidationString = validationString;
            this.ShowThousandsSeparator = showThousandsSeparator;
        }
        
        /// <summary>
        /// Decimals number
        /// </summary>
        /// <value>Decimals number</value>
        [DataMember(Name="decimals", EmitDefaultValue=false)]
        public int? Decimals { get; set; }

        /// <summary>
        /// Autocomplete
        /// </summary>
        /// <value>Autocomplete</value>
        [DataMember(Name="autocomplete", EmitDefaultValue=false)]
        public bool? Autocomplete { get; set; }

        /// <summary>
        /// Autocomplete character
        /// </summary>
        /// <value>Autocomplete character</value>
        [DataMember(Name="autocompleteCharacter", EmitDefaultValue=false)]
        public string AutocompleteCharacter { get; set; }

        /// <summary>
        /// Possible values:  0: Left  1: Right  -1: None 
        /// </summary>
        /// <value>Possible values:  0: Left  1: Right  -1: None </value>
        [DataMember(Name="autocompleteAlign", EmitDefaultValue=false)]
        public int? AutocompleteAlign { get; set; }

        /// <summary>
        /// Si definisce se il campo è bloccato per l&#39;inserimento di un valore
        /// </summary>
        /// <value>Si definisce se il campo è bloccato per l&#39;inserimento di un valore</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Enable field transcoding
        /// </summary>
        /// <value>Enable field transcoding</value>
        [DataMember(Name="transcoding", EmitDefaultValue=false)]
        public bool? Transcoding { get; set; }

        /// <summary>
        /// Transcoding: Table name
        /// </summary>
        /// <value>Transcoding: Table name</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Transcoding: Field name for code
        /// </summary>
        /// <value>Transcoding: Field name for code</value>
        [DataMember(Name="codeFieldName", EmitDefaultValue=false)]
        public string CodeFieldName { get; set; }

        /// <summary>
        /// Transcoding: Field name for description
        /// </summary>
        /// <value>Transcoding: Field name for description</value>
        [DataMember(Name="descriptionFieldName", EmitDefaultValue=false)]
        public string DescriptionFieldName { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: Regex  2: Formula 
        /// </summary>
        /// <value>Possible values:  0: None  1: Regex  2: Formula </value>
        [DataMember(Name="validationType", EmitDefaultValue=false)]
        public int? ValidationType { get; set; }

        /// <summary>
        /// Validation string (formula/regex)
        /// </summary>
        /// <value>Validation string (formula/regex)</value>
        [DataMember(Name="validationString", EmitDefaultValue=false)]
        public string ValidationString { get; set; }

        /// <summary>
        /// Gets or Sets ShowThousandsSeparator
        /// </summary>
        [DataMember(Name="showThousandsSeparator", EmitDefaultValue=false)]
        public bool? ShowThousandsSeparator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldManagementNumericDTO {\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Autocomplete: ").Append(Autocomplete).Append("\n");
            sb.Append("  AutocompleteCharacter: ").Append(AutocompleteCharacter).Append("\n");
            sb.Append("  AutocompleteAlign: ").Append(AutocompleteAlign).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Transcoding: ").Append(Transcoding).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  CodeFieldName: ").Append(CodeFieldName).Append("\n");
            sb.Append("  DescriptionFieldName: ").Append(DescriptionFieldName).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
            sb.Append("  ValidationString: ").Append(ValidationString).Append("\n");
            sb.Append("  ShowThousandsSeparator: ").Append(ShowThousandsSeparator).Append("\n");
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
            return this.Equals(input as AdditionalFieldManagementNumericDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldManagementNumericDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldManagementNumericDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldManagementNumericDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Decimals == input.Decimals ||
                    (this.Decimals != null &&
                    this.Decimals.Equals(input.Decimals))
                ) && 
                (
                    this.Autocomplete == input.Autocomplete ||
                    (this.Autocomplete != null &&
                    this.Autocomplete.Equals(input.Autocomplete))
                ) && 
                (
                    this.AutocompleteCharacter == input.AutocompleteCharacter ||
                    (this.AutocompleteCharacter != null &&
                    this.AutocompleteCharacter.Equals(input.AutocompleteCharacter))
                ) && 
                (
                    this.AutocompleteAlign == input.AutocompleteAlign ||
                    (this.AutocompleteAlign != null &&
                    this.AutocompleteAlign.Equals(input.AutocompleteAlign))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Transcoding == input.Transcoding ||
                    (this.Transcoding != null &&
                    this.Transcoding.Equals(input.Transcoding))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.CodeFieldName == input.CodeFieldName ||
                    (this.CodeFieldName != null &&
                    this.CodeFieldName.Equals(input.CodeFieldName))
                ) && 
                (
                    this.DescriptionFieldName == input.DescriptionFieldName ||
                    (this.DescriptionFieldName != null &&
                    this.DescriptionFieldName.Equals(input.DescriptionFieldName))
                ) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
                ) && 
                (
                    this.ValidationString == input.ValidationString ||
                    (this.ValidationString != null &&
                    this.ValidationString.Equals(input.ValidationString))
                ) && 
                (
                    this.ShowThousandsSeparator == input.ShowThousandsSeparator ||
                    (this.ShowThousandsSeparator != null &&
                    this.ShowThousandsSeparator.Equals(input.ShowThousandsSeparator))
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
                if (this.Decimals != null)
                    hashCode = hashCode * 59 + this.Decimals.GetHashCode();
                if (this.Autocomplete != null)
                    hashCode = hashCode * 59 + this.Autocomplete.GetHashCode();
                if (this.AutocompleteCharacter != null)
                    hashCode = hashCode * 59 + this.AutocompleteCharacter.GetHashCode();
                if (this.AutocompleteAlign != null)
                    hashCode = hashCode * 59 + this.AutocompleteAlign.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Transcoding != null)
                    hashCode = hashCode * 59 + this.Transcoding.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.CodeFieldName != null)
                    hashCode = hashCode * 59 + this.CodeFieldName.GetHashCode();
                if (this.DescriptionFieldName != null)
                    hashCode = hashCode * 59 + this.DescriptionFieldName.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
                if (this.ValidationString != null)
                    hashCode = hashCode * 59 + this.ValidationString.GetHashCode();
                if (this.ShowThousandsSeparator != null)
                    hashCode = hashCode * 59 + this.ShowThousandsSeparator.GetHashCode();
                return hashCode;
            }
        }
    }

}
