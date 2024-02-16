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
    /// MfaDisableAuthenticatorRequestDTO
    /// </summary>
    [DataContract]
    public partial class MfaDisableAuthenticatorRequestDTO :  IEquatable<MfaDisableAuthenticatorRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfaDisableAuthenticatorRequestDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MfaDisableAuthenticatorRequestDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MfaDisableAuthenticatorRequestDTO" /> class.
        /// </summary>
        /// <param name="mfaToken">mfaToken (required).</param>
        public MfaDisableAuthenticatorRequestDTO(string mfaToken = default(string))
        {
            // to ensure "mfaToken" is required (not null)
            if (mfaToken == null)
            {
                throw new InvalidDataException("mfaToken is a required property for MfaDisableAuthenticatorRequestDTO and cannot be null");
            }
            else
            {
                this.MfaToken = mfaToken;
            }
        }
        
        /// <summary>
        /// Gets or Sets MfaToken
        /// </summary>
        [DataMember(Name="mfaToken", EmitDefaultValue=false)]
        public string MfaToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MfaDisableAuthenticatorRequestDTO {\n");
            sb.Append("  MfaToken: ").Append(MfaToken).Append("\n");
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
            return this.Equals(input as MfaDisableAuthenticatorRequestDTO);
        }

        /// <summary>
        /// Returns true if MfaDisableAuthenticatorRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MfaDisableAuthenticatorRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MfaDisableAuthenticatorRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MfaToken == input.MfaToken ||
                    (this.MfaToken != null &&
                    this.MfaToken.Equals(input.MfaToken))
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
                if (this.MfaToken != null)
                    hashCode = hashCode * 59 + this.MfaToken.GetHashCode();
                return hashCode;
            }
        }
    }

}
