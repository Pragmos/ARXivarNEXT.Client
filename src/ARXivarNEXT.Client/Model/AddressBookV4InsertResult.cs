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
    /// Result of an Address book insert action
    /// </summary>
    [DataContract]
    public partial class AddressBookV4InsertResult :  IEquatable<AddressBookV4InsertResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookV4InsertResult" /> class.
        /// </summary>
        /// <param name="success">If the insert is successful.</param>
        /// <param name="addressBook">The inserted Address book if successful.</param>
        /// <param name="errorMessage">Error message if not successful.</param>
        /// <param name="exception">Exception details is not successful.</param>
        public AddressBookV4InsertResult(bool? success = default(bool?), AddressBookV4DTO addressBook = default(AddressBookV4DTO), string errorMessage = default(string), ArxivarSuiteException exception = default(ArxivarSuiteException))
        {
            this.Success = success;
            this.AddressBook = addressBook;
            this.ErrorMessage = errorMessage;
            this.Exception = exception;
        }
        
        /// <summary>
        /// If the insert is successful
        /// </summary>
        /// <value>If the insert is successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The inserted Address book if successful
        /// </summary>
        /// <value>The inserted Address book if successful</value>
        [DataMember(Name="addressBook", EmitDefaultValue=false)]
        public AddressBookV4DTO AddressBook { get; set; }

        /// <summary>
        /// Error message if not successful
        /// </summary>
        /// <value>Error message if not successful</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Exception details is not successful
        /// </summary>
        /// <value>Exception details is not successful</value>
        [DataMember(Name="exception", EmitDefaultValue=false)]
        public ArxivarSuiteException Exception { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressBookV4InsertResult {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  AddressBook: ").Append(AddressBook).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
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
            return this.Equals(input as AddressBookV4InsertResult);
        }

        /// <summary>
        /// Returns true if AddressBookV4InsertResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressBookV4InsertResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressBookV4InsertResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.AddressBook == input.AddressBook ||
                    (this.AddressBook != null &&
                    this.AddressBook.Equals(input.AddressBook))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Exception == input.Exception ||
                    (this.Exception != null &&
                    this.Exception.Equals(input.Exception))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.AddressBook != null)
                    hashCode = hashCode * 59 + this.AddressBook.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Exception != null)
                    hashCode = hashCode * 59 + this.Exception.GetHashCode();
                return hashCode;
            }
        }
    }

}
