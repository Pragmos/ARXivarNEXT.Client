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
    /// PostelDefaultSenderInfoDTO
    /// </summary>
    [DataContract]
    public partial class PostelDefaultSenderInfoDTO :  IEquatable<PostelDefaultSenderInfoDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostelDefaultSenderInfoDTO" /> class.
        /// </summary>
        /// <param name="useDefaultUser">useDefaultUser.</param>
        /// <param name="country">country.</param>
        /// <param name="province">province.</param>
        /// <param name="city">city.</param>
        /// <param name="zipCode">zipCode.</param>
        /// <param name="address">address.</param>
        /// <param name="name">name.</param>
        public PostelDefaultSenderInfoDTO(bool? useDefaultUser = default(bool?), string country = default(string), string province = default(string), string city = default(string), string zipCode = default(string), string address = default(string), string name = default(string))
        {
            this.UseDefaultUser = useDefaultUser;
            this.Country = country;
            this.Province = province;
            this.City = city;
            this.ZipCode = zipCode;
            this.Address = address;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets UseDefaultUser
        /// </summary>
        [DataMember(Name="useDefaultUser", EmitDefaultValue=false)]
        public bool? UseDefaultUser { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="zipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostelDefaultSenderInfoDTO {\n");
            sb.Append("  UseDefaultUser: ").Append(UseDefaultUser).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as PostelDefaultSenderInfoDTO);
        }

        /// <summary>
        /// Returns true if PostelDefaultSenderInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PostelDefaultSenderInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostelDefaultSenderInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseDefaultUser == input.UseDefaultUser ||
                    (this.UseDefaultUser != null &&
                    this.UseDefaultUser.Equals(input.UseDefaultUser))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.UseDefaultUser != null)
                    hashCode = hashCode * 59 + this.UseDefaultUser.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
