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
    /// Class of the adress book item category
    /// </summary>
    [DataContract]
    public partial class AddressBookCategoryDTO :  IEquatable<AddressBookCategoryDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookCategoryDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="addressBook">Name.</param>
        /// <param name="type">Possible values:  0: Public  1: Private .</param>
        /// <param name="_default">Set as default category.</param>
        public AddressBookCategoryDTO(int? id = default(int?), string addressBook = default(string), int? type = default(int?), bool? _default = default(bool?))
        {
            this.Id = id;
            this.AddressBook = addressBook;
            this.Type = type;
            this.Default = _default;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="addressBook", EmitDefaultValue=false)]
        public string AddressBook { get; set; }

        /// <summary>
        /// Possible values:  0: Public  1: Private 
        /// </summary>
        /// <value>Possible values:  0: Public  1: Private </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Set as default category
        /// </summary>
        /// <value>Set as default category</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressBookCategoryDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AddressBook: ").Append(AddressBook).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(input as AddressBookCategoryDTO);
        }

        /// <summary>
        /// Returns true if AddressBookCategoryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressBookCategoryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressBookCategoryDTO input)
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
                    this.AddressBook == input.AddressBook ||
                    (this.AddressBook != null &&
                    this.AddressBook.Equals(input.AddressBook))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
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
                if (this.AddressBook != null)
                    hashCode = hashCode * 59 + this.AddressBook.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                return hashCode;
            }
        }
    }

}
