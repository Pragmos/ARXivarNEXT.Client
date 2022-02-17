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
    /// Class for mail account settings
    /// </summary>
    [DataContract]
    public partial class MailAccountDTO :  IEquatable<MailAccountDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MailAccountDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountDTO" /> class.
        /// </summary>
        /// <param name="id">Account Identifier.</param>
        /// <param name="userId">User identifier.</param>
        /// <param name="alias">Alias (required).</param>
        /// <param name="mail">Mail (required).</param>
        /// <param name="isDefault">Boolean indicating  whether the account is the default account.</param>
        /// <param name="enabled">Boolean indicating  whether the account is active.</param>
        /// <param name="isSystemAccount">Boolean indicating if the account is the system account.</param>
        /// <param name="sendSettings">Setting for sending mail (SMTP).</param>
        /// <param name="receiveSettings">Setting for sending mail (POP3 or IMAP).</param>
        public MailAccountDTO(int? id = default(int?), int? userId = default(int?), string alias = default(string), string mail = default(string), bool? isDefault = default(bool?), bool? enabled = default(bool?), bool? isSystemAccount = default(bool?), MailAccountSendSettingsDTO sendSettings = default(MailAccountSendSettingsDTO), MailAccountReceiveSettingsDTO receiveSettings = default(MailAccountReceiveSettingsDTO))
        {
            // to ensure "alias" is required (not null)
            if (alias == null)
            {
                throw new InvalidDataException("alias is a required property for MailAccountDTO and cannot be null");
            }
            else
            {
                this.Alias = alias;
            }
            // to ensure "mail" is required (not null)
            if (mail == null)
            {
                throw new InvalidDataException("mail is a required property for MailAccountDTO and cannot be null");
            }
            else
            {
                this.Mail = mail;
            }
            this.Id = id;
            this.UserId = userId;
            this.IsDefault = isDefault;
            this.Enabled = enabled;
            this.IsSystemAccount = isSystemAccount;
            this.SendSettings = sendSettings;
            this.ReceiveSettings = receiveSettings;
        }
        
        /// <summary>
        /// Account Identifier
        /// </summary>
        /// <value>Account Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        /// <value>User identifier</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Alias
        /// </summary>
        /// <value>Alias</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Mail
        /// </summary>
        /// <value>Mail</value>
        [DataMember(Name="mail", EmitDefaultValue=false)]
        public string Mail { get; set; }

        /// <summary>
        /// Boolean indicating  whether the account is the default account
        /// </summary>
        /// <value>Boolean indicating  whether the account is the default account</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Boolean indicating  whether the account is active
        /// </summary>
        /// <value>Boolean indicating  whether the account is active</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Boolean indicating if the account is the system account
        /// </summary>
        /// <value>Boolean indicating if the account is the system account</value>
        [DataMember(Name="isSystemAccount", EmitDefaultValue=false)]
        public bool? IsSystemAccount { get; set; }

        /// <summary>
        /// Setting for sending mail (SMTP)
        /// </summary>
        /// <value>Setting for sending mail (SMTP)</value>
        [DataMember(Name="sendSettings", EmitDefaultValue=false)]
        public MailAccountSendSettingsDTO SendSettings { get; set; }

        /// <summary>
        /// Setting for sending mail (POP3 or IMAP)
        /// </summary>
        /// <value>Setting for sending mail (POP3 or IMAP)</value>
        [DataMember(Name="receiveSettings", EmitDefaultValue=false)]
        public MailAccountReceiveSettingsDTO ReceiveSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IsSystemAccount: ").Append(IsSystemAccount).Append("\n");
            sb.Append("  SendSettings: ").Append(SendSettings).Append("\n");
            sb.Append("  ReceiveSettings: ").Append(ReceiveSettings).Append("\n");
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
            return this.Equals(input as MailAccountDTO);
        }

        /// <summary>
        /// Returns true if MailAccountDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountDTO input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.IsSystemAccount == input.IsSystemAccount ||
                    (this.IsSystemAccount != null &&
                    this.IsSystemAccount.Equals(input.IsSystemAccount))
                ) && 
                (
                    this.SendSettings == input.SendSettings ||
                    (this.SendSettings != null &&
                    this.SendSettings.Equals(input.SendSettings))
                ) && 
                (
                    this.ReceiveSettings == input.ReceiveSettings ||
                    (this.ReceiveSettings != null &&
                    this.ReceiveSettings.Equals(input.ReceiveSettings))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.IsSystemAccount != null)
                    hashCode = hashCode * 59 + this.IsSystemAccount.GetHashCode();
                if (this.SendSettings != null)
                    hashCode = hashCode * 59 + this.SendSettings.GetHashCode();
                if (this.ReceiveSettings != null)
                    hashCode = hashCode * 59 + this.ReceiveSettings.GetHashCode();
                return hashCode;
            }
        }
    }

}
