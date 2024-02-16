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
    /// NpceOutPartyDTO
    /// </summary>
    [DataContract]
    public partial class NpceOutPartyDTO :  IEquatable<NpceOutPartyDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpceOutPartyDTO" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="address">address.</param>
        /// <param name="locality">locality.</param>
        /// <param name="cap">cap.</param>
        /// <param name="province">province.</param>
        /// <param name="country">country.</param>
        public NpceOutPartyDTO(string description = default(string), string address = default(string), string locality = default(string), string cap = default(string), string province = default(string), string country = default(string))
        {
            this.Description = description;
            this.Address = address;
            this.Locality = locality;
            this.Cap = cap;
            this.Province = province;
            this.Country = country;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or Sets Cap
        /// </summary>
        [DataMember(Name="cap", EmitDefaultValue=false)]
        public string Cap { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NpceOutPartyDTO {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Cap: ").Append(Cap).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as NpceOutPartyDTO);
        }

        /// <summary>
        /// Returns true if NpceOutPartyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NpceOutPartyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NpceOutPartyDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.Cap == input.Cap ||
                    (this.Cap != null &&
                    this.Cap.Equals(input.Cap))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.Cap != null)
                    hashCode = hashCode * 59 + this.Cap.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                return hashCode;
            }
        }
    }

}
