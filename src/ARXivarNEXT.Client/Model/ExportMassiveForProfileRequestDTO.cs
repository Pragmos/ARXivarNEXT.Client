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
    /// ExportMassiveForProfileRequestDTO
    /// </summary>
    [DataContract]
    public partial class ExportMassiveForProfileRequestDTO :  IEquatable<ExportMassiveForProfileRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportMassiveForProfileRequestDTO" /> class.
        /// </summary>
        /// <param name="profiles">profiles.</param>
        /// <param name="forView">forView.</param>
        public ExportMassiveForProfileRequestDTO(List<int?> profiles = default(List<int?>), bool? forView = default(bool?))
        {
            this.Profiles = profiles;
            this.ForView = forView;
        }
        
        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public List<int?> Profiles { get; set; }

        /// <summary>
        /// Gets or Sets ForView
        /// </summary>
        [DataMember(Name="forView", EmitDefaultValue=false)]
        public bool? ForView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportMassiveForProfileRequestDTO {\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  ForView: ").Append(ForView).Append("\n");
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
            return this.Equals(input as ExportMassiveForProfileRequestDTO);
        }

        /// <summary>
        /// Returns true if ExportMassiveForProfileRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportMassiveForProfileRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportMassiveForProfileRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
                ) && 
                (
                    this.ForView == input.ForView ||
                    (this.ForView != null &&
                    this.ForView.Equals(input.ForView))
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
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.ForView != null)
                    hashCode = hashCode * 59 + this.ForView.GetHashCode();
                return hashCode;
            }
        }
    }

}
