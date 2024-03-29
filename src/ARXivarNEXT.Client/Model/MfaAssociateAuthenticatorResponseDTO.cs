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
    /// MfaAssociateAuthenticatorResponseDTO
    /// </summary>
    [DataContract]
    public partial class MfaAssociateAuthenticatorResponseDTO :  IEquatable<MfaAssociateAuthenticatorResponseDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfaAssociateAuthenticatorResponseDTO" /> class.
        /// </summary>
        /// <param name="authenticatorType">authenticatorType.</param>
        /// <param name="authenticatorId">authenticatorId.</param>
        /// <param name="bindingMethod">bindingMethod.</param>
        /// <param name="oobCode">oobCode.</param>
        /// <param name="oobChannel">oobChannel.</param>
        /// <param name="oobTarget">oobTarget.</param>
        /// <param name="secret">secret.</param>
        /// <param name="barcodeUri">barcodeUri.</param>
        public MfaAssociateAuthenticatorResponseDTO(string authenticatorType = default(string), string authenticatorId = default(string), string bindingMethod = default(string), string oobCode = default(string), string oobChannel = default(string), string oobTarget = default(string), string secret = default(string), string barcodeUri = default(string))
        {
            this.AuthenticatorType = authenticatorType;
            this.AuthenticatorId = authenticatorId;
            this.BindingMethod = bindingMethod;
            this.OobCode = oobCode;
            this.OobChannel = oobChannel;
            this.OobTarget = oobTarget;
            this.Secret = secret;
            this.BarcodeUri = barcodeUri;
        }
        
        /// <summary>
        /// Gets or Sets AuthenticatorType
        /// </summary>
        [DataMember(Name="authenticatorType", EmitDefaultValue=false)]
        public string AuthenticatorType { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticatorId
        /// </summary>
        [DataMember(Name="authenticatorId", EmitDefaultValue=false)]
        public string AuthenticatorId { get; set; }

        /// <summary>
        /// Gets or Sets BindingMethod
        /// </summary>
        [DataMember(Name="bindingMethod", EmitDefaultValue=false)]
        public string BindingMethod { get; set; }

        /// <summary>
        /// Gets or Sets OobCode
        /// </summary>
        [DataMember(Name="oobCode", EmitDefaultValue=false)]
        public string OobCode { get; set; }

        /// <summary>
        /// Gets or Sets OobChannel
        /// </summary>
        [DataMember(Name="oobChannel", EmitDefaultValue=false)]
        public string OobChannel { get; set; }

        /// <summary>
        /// Gets or Sets OobTarget
        /// </summary>
        [DataMember(Name="oobTarget", EmitDefaultValue=false)]
        public string OobTarget { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or Sets BarcodeUri
        /// </summary>
        [DataMember(Name="barcodeUri", EmitDefaultValue=false)]
        public string BarcodeUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MfaAssociateAuthenticatorResponseDTO {\n");
            sb.Append("  AuthenticatorType: ").Append(AuthenticatorType).Append("\n");
            sb.Append("  AuthenticatorId: ").Append(AuthenticatorId).Append("\n");
            sb.Append("  BindingMethod: ").Append(BindingMethod).Append("\n");
            sb.Append("  OobCode: ").Append(OobCode).Append("\n");
            sb.Append("  OobChannel: ").Append(OobChannel).Append("\n");
            sb.Append("  OobTarget: ").Append(OobTarget).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  BarcodeUri: ").Append(BarcodeUri).Append("\n");
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
            return this.Equals(input as MfaAssociateAuthenticatorResponseDTO);
        }

        /// <summary>
        /// Returns true if MfaAssociateAuthenticatorResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MfaAssociateAuthenticatorResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MfaAssociateAuthenticatorResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticatorType == input.AuthenticatorType ||
                    (this.AuthenticatorType != null &&
                    this.AuthenticatorType.Equals(input.AuthenticatorType))
                ) && 
                (
                    this.AuthenticatorId == input.AuthenticatorId ||
                    (this.AuthenticatorId != null &&
                    this.AuthenticatorId.Equals(input.AuthenticatorId))
                ) && 
                (
                    this.BindingMethod == input.BindingMethod ||
                    (this.BindingMethod != null &&
                    this.BindingMethod.Equals(input.BindingMethod))
                ) && 
                (
                    this.OobCode == input.OobCode ||
                    (this.OobCode != null &&
                    this.OobCode.Equals(input.OobCode))
                ) && 
                (
                    this.OobChannel == input.OobChannel ||
                    (this.OobChannel != null &&
                    this.OobChannel.Equals(input.OobChannel))
                ) && 
                (
                    this.OobTarget == input.OobTarget ||
                    (this.OobTarget != null &&
                    this.OobTarget.Equals(input.OobTarget))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.BarcodeUri == input.BarcodeUri ||
                    (this.BarcodeUri != null &&
                    this.BarcodeUri.Equals(input.BarcodeUri))
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
                if (this.AuthenticatorType != null)
                    hashCode = hashCode * 59 + this.AuthenticatorType.GetHashCode();
                if (this.AuthenticatorId != null)
                    hashCode = hashCode * 59 + this.AuthenticatorId.GetHashCode();
                if (this.BindingMethod != null)
                    hashCode = hashCode * 59 + this.BindingMethod.GetHashCode();
                if (this.OobCode != null)
                    hashCode = hashCode * 59 + this.OobCode.GetHashCode();
                if (this.OobChannel != null)
                    hashCode = hashCode * 59 + this.OobChannel.GetHashCode();
                if (this.OobTarget != null)
                    hashCode = hashCode * 59 + this.OobTarget.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.BarcodeUri != null)
                    hashCode = hashCode * 59 + this.BarcodeUri.GetHashCode();
                return hashCode;
            }
        }
    }

}
