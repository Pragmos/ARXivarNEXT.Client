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
    /// Class of criteria to search in business unit
    /// </summary>
    [DataContract]
    public partial class BusinessUnitSearchCriteria :  IEquatable<BusinessUnitSearchCriteria>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessUnitSearchCriteria" /> class.
        /// </summary>
        /// <param name="mode">Possible values:  0: Search  1: Archive  2: ArchivePa .</param>
        /// <param name="orderBy">Order.</param>
        public BusinessUnitSearchCriteria(int? mode = default(int?), string orderBy = default(string))
        {
            this.Mode = mode;
            this.OrderBy = orderBy;
        }
        
        /// <summary>
        /// Possible values:  0: Search  1: Archive  2: ArchivePa 
        /// </summary>
        /// <value>Possible values:  0: Search  1: Archive  2: ArchivePa </value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessUnitSearchCriteria {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
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
            return this.Equals(input as BusinessUnitSearchCriteria);
        }

        /// <summary>
        /// Returns true if BusinessUnitSearchCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessUnitSearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessUnitSearchCriteria input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    (this.OrderBy != null &&
                    this.OrderBy.Equals(input.OrderBy))
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                return hashCode;
            }
        }
    }

}