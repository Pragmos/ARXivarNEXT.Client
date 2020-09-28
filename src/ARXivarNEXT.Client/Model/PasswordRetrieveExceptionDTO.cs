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
    /// PasswordRetrieveExceptionDTO
    /// </summary>
    [DataContract]
    public partial class PasswordRetrieveExceptionDTO :  IEquatable<PasswordRetrieveExceptionDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordRetrieveExceptionDTO" /> class.
        /// </summary>
        /// <param name="userMessage">userMessage.</param>
        /// <param name="exceptionCode">Possible values:  0: Generic  1: EmailNotUnique  2: EmailNotConfigured .</param>
        public PasswordRetrieveExceptionDTO(string userMessage = default(string), int? exceptionCode = default(int?))
        {
            this.UserMessage = userMessage;
            this.ExceptionCode = exceptionCode;
        }
        
        /// <summary>
        /// Gets or Sets UserMessage
        /// </summary>
        [DataMember(Name="userMessage", EmitDefaultValue=false)]
        public string UserMessage { get; set; }

        /// <summary>
        /// Possible values:  0: Generic  1: EmailNotUnique  2: EmailNotConfigured 
        /// </summary>
        /// <value>Possible values:  0: Generic  1: EmailNotUnique  2: EmailNotConfigured </value>
        [DataMember(Name="exceptionCode", EmitDefaultValue=false)]
        public int? ExceptionCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordRetrieveExceptionDTO {\n");
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            sb.Append("  ExceptionCode: ").Append(ExceptionCode).Append("\n");
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
            return this.Equals(input as PasswordRetrieveExceptionDTO);
        }

        /// <summary>
        /// Returns true if PasswordRetrieveExceptionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordRetrieveExceptionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordRetrieveExceptionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserMessage == input.UserMessage ||
                    (this.UserMessage != null &&
                    this.UserMessage.Equals(input.UserMessage))
                ) && 
                (
                    this.ExceptionCode == input.ExceptionCode ||
                    (this.ExceptionCode != null &&
                    this.ExceptionCode.Equals(input.ExceptionCode))
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
                if (this.UserMessage != null)
                    hashCode = hashCode * 59 + this.UserMessage.GetHashCode();
                if (this.ExceptionCode != null)
                    hashCode = hashCode * 59 + this.ExceptionCode.GetHashCode();
                return hashCode;
            }
        }
    }

}