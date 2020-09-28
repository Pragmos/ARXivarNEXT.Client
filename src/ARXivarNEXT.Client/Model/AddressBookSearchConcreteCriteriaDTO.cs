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
    /// This class contain the search and select part for addressbook search functions
    /// </summary>
    [DataContract]
    public partial class AddressBookSearchConcreteCriteriaDTO :  IEquatable<AddressBookSearchConcreteCriteriaDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookSearchConcreteCriteriaDTO" /> class.
        /// </summary>
        /// <param name="searchDto">Addressbook search.</param>
        /// <param name="selectDto">Addressbook select.</param>
        public AddressBookSearchConcreteCriteriaDTO(AddressBookSearchConcreteDTO searchDto = default(AddressBookSearchConcreteDTO), SelectDTO selectDto = default(SelectDTO))
        {
            this.SearchDto = searchDto;
            this.SelectDto = selectDto;
        }
        
        /// <summary>
        /// Addressbook search
        /// </summary>
        /// <value>Addressbook search</value>
        [DataMember(Name="searchDto", EmitDefaultValue=false)]
        public AddressBookSearchConcreteDTO SearchDto { get; set; }

        /// <summary>
        /// Addressbook select
        /// </summary>
        /// <value>Addressbook select</value>
        [DataMember(Name="selectDto", EmitDefaultValue=false)]
        public SelectDTO SelectDto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressBookSearchConcreteCriteriaDTO {\n");
            sb.Append("  SearchDto: ").Append(SearchDto).Append("\n");
            sb.Append("  SelectDto: ").Append(SelectDto).Append("\n");
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
            return this.Equals(input as AddressBookSearchConcreteCriteriaDTO);
        }

        /// <summary>
        /// Returns true if AddressBookSearchConcreteCriteriaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressBookSearchConcreteCriteriaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressBookSearchConcreteCriteriaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchDto == input.SearchDto ||
                    (this.SearchDto != null &&
                    this.SearchDto.Equals(input.SearchDto))
                ) && 
                (
                    this.SelectDto == input.SelectDto ||
                    (this.SelectDto != null &&
                    this.SelectDto.Equals(input.SelectDto))
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
                if (this.SearchDto != null)
                    hashCode = hashCode * 59 + this.SearchDto.GetHashCode();
                if (this.SelectDto != null)
                    hashCode = hashCode * 59 + this.SelectDto.GetHashCode();
                return hashCode;
            }
        }
    }

}
