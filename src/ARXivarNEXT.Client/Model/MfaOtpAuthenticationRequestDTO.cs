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
    /// MfaOtpAuthenticationRequestDTO
    /// </summary>
    [DataContract]
    public partial class MfaOtpAuthenticationRequestDTO :  IEquatable<MfaOtpAuthenticationRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfaOtpAuthenticationRequestDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MfaOtpAuthenticationRequestDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MfaOtpAuthenticationRequestDTO" /> class.
        /// </summary>
        /// <param name="clientId">clientId (required).</param>
        /// <param name="clientSecret">clientSecret (required).</param>
        /// <param name="mfaToken">mfaToken (required).</param>
        /// <param name="otp">otp (required).</param>
        public MfaOtpAuthenticationRequestDTO(string clientId = default(string), string clientSecret = default(string), string mfaToken = default(string), string otp = default(string))
        {
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new InvalidDataException("clientId is a required property for MfaOtpAuthenticationRequestDTO and cannot be null");
            }
            else
            {
                this.ClientId = clientId;
            }
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new InvalidDataException("clientSecret is a required property for MfaOtpAuthenticationRequestDTO and cannot be null");
            }
            else
            {
                this.ClientSecret = clientSecret;
            }
            // to ensure "mfaToken" is required (not null)
            if (mfaToken == null)
            {
                throw new InvalidDataException("mfaToken is a required property for MfaOtpAuthenticationRequestDTO and cannot be null");
            }
            else
            {
                this.MfaToken = mfaToken;
            }
            // to ensure "otp" is required (not null)
            if (otp == null)
            {
                throw new InvalidDataException("otp is a required property for MfaOtpAuthenticationRequestDTO and cannot be null");
            }
            else
            {
                this.Otp = otp;
            }
        }
        
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets MfaToken
        /// </summary>
        [DataMember(Name="mfaToken", EmitDefaultValue=false)]
        public string MfaToken { get; set; }

        /// <summary>
        /// Gets or Sets Otp
        /// </summary>
        [DataMember(Name="otp", EmitDefaultValue=false)]
        public string Otp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MfaOtpAuthenticationRequestDTO {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  MfaToken: ").Append(MfaToken).Append("\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
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
            return this.Equals(input as MfaOtpAuthenticationRequestDTO);
        }

        /// <summary>
        /// Returns true if MfaOtpAuthenticationRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MfaOtpAuthenticationRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MfaOtpAuthenticationRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.MfaToken == input.MfaToken ||
                    (this.MfaToken != null &&
                    this.MfaToken.Equals(input.MfaToken))
                ) && 
                (
                    this.Otp == input.Otp ||
                    (this.Otp != null &&
                    this.Otp.Equals(input.Otp))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.MfaToken != null)
                    hashCode = hashCode * 59 + this.MfaToken.GetHashCode();
                if (this.Otp != null)
                    hashCode = hashCode * 59 + this.Otp.GetHashCode();
                return hashCode;
            }
        }
    }

}