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
    /// Class of user used to profiling
    /// </summary>
    [DataContract]
    public partial class UserProfileDTO :  IEquatable<UserProfileDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="externalId">External Identifier.</param>
        /// <param name="description">Description.</param>
        /// <param name="docNumber">Document Identifier.</param>
        /// <param name="type">Possible values:  0: To  1: From  2: Cc  3: Senders .</param>
        /// <param name="contactId">Contact Identifier.</param>
        /// <param name="fax">Fax.</param>
        /// <param name="address">Address.</param>
        /// <param name="postalCode">Postal Code.</param>
        /// <param name="contact">Description.</param>
        /// <param name="job">Job.</param>
        /// <param name="locality">Locality.</param>
        /// <param name="province">Province.</param>
        /// <param name="phone">Phone number.</param>
        /// <param name="mobilePhone">Mobile number.</param>
        /// <param name="telName">Contact Phone number.</param>
        /// <param name="faxName">Contact Fax.</param>
        /// <param name="house">Contact House.</param>
        /// <param name="department">Contact Department.</param>
        /// <param name="reference">Reference.</param>
        /// <param name="office">Office.</param>
        /// <param name="vat">Vat.</param>
        /// <param name="mail">Contact Email.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="code">Code.</param>
        /// <param name="email">Email.</param>
        /// <param name="fiscalCode">Fiscal Code.</param>
        /// <param name="nation">Nation.</param>
        /// <param name="addressBookId">Address Book Identifier.</param>
        /// <param name="society">Society.</param>
        public UserProfileDTO(int? id = default(int?), string externalId = default(string), string description = default(string), string docNumber = default(string), int? type = default(int?), int? contactId = default(int?), string fax = default(string), string address = default(string), string postalCode = default(string), string contact = default(string), string job = default(string), string locality = default(string), string province = default(string), string phone = default(string), string mobilePhone = default(string), string telName = default(string), string faxName = default(string), string house = default(string), string department = default(string), string reference = default(string), string office = default(string), string vat = default(string), string mail = default(string), string priority = default(string), string code = default(string), string email = default(string), string fiscalCode = default(string), string nation = default(string), int? addressBookId = default(int?), string society = default(string))
        {
            this.Id = id;
            this.ExternalId = externalId;
            this.Description = description;
            this.DocNumber = docNumber;
            this.Type = type;
            this.ContactId = contactId;
            this.Fax = fax;
            this.Address = address;
            this.PostalCode = postalCode;
            this.Contact = contact;
            this.Job = job;
            this.Locality = locality;
            this.Province = province;
            this.Phone = phone;
            this.MobilePhone = mobilePhone;
            this.TelName = telName;
            this.FaxName = faxName;
            this.House = house;
            this.Department = department;
            this.Reference = reference;
            this.Office = office;
            this.Vat = vat;
            this.Mail = mail;
            this.Priority = priority;
            this.Code = code;
            this.Email = email;
            this.FiscalCode = fiscalCode;
            this.Nation = nation;
            this.AddressBookId = addressBookId;
            this.Society = society;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// External Identifier
        /// </summary>
        /// <value>External Identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public string DocNumber { get; set; }

        /// <summary>
        /// Possible values:  0: To  1: From  2: Cc  3: Senders 
        /// </summary>
        /// <value>Possible values:  0: To  1: From  2: Cc  3: Senders </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Contact Identifier
        /// </summary>
        /// <value>Contact Identifier</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public int? ContactId { get; set; }

        /// <summary>
        /// Fax
        /// </summary>
        /// <value>Fax</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        /// <value>Address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        /// <value>Postal Code</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Job
        /// </summary>
        /// <value>Job</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public string Job { get; set; }

        /// <summary>
        /// Locality
        /// </summary>
        /// <value>Locality</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Province
        /// </summary>
        /// <value>Province</value>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public string Province { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Mobile number
        /// </summary>
        /// <value>Mobile number</value>
        [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Contact Phone number
        /// </summary>
        /// <value>Contact Phone number</value>
        [DataMember(Name="telName", EmitDefaultValue=false)]
        public string TelName { get; set; }

        /// <summary>
        /// Contact Fax
        /// </summary>
        /// <value>Contact Fax</value>
        [DataMember(Name="faxName", EmitDefaultValue=false)]
        public string FaxName { get; set; }

        /// <summary>
        /// Contact House
        /// </summary>
        /// <value>Contact House</value>
        [DataMember(Name="house", EmitDefaultValue=false)]
        public string House { get; set; }

        /// <summary>
        /// Contact Department
        /// </summary>
        /// <value>Contact Department</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Reference
        /// </summary>
        /// <value>Reference</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Office
        /// </summary>
        /// <value>Office</value>
        [DataMember(Name="office", EmitDefaultValue=false)]
        public string Office { get; set; }

        /// <summary>
        /// Vat
        /// </summary>
        /// <value>Vat</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public string Vat { get; set; }

        /// <summary>
        /// Contact Email
        /// </summary>
        /// <value>Contact Email</value>
        [DataMember(Name="mail", EmitDefaultValue=false)]
        public string Mail { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        /// <value>Priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        /// <value>Code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Fiscal Code
        /// </summary>
        /// <value>Fiscal Code</value>
        [DataMember(Name="fiscalCode", EmitDefaultValue=false)]
        public string FiscalCode { get; set; }

        /// <summary>
        /// Nation
        /// </summary>
        /// <value>Nation</value>
        [DataMember(Name="nation", EmitDefaultValue=false)]
        public string Nation { get; set; }

        /// <summary>
        /// Address Book Identifier
        /// </summary>
        /// <value>Address Book Identifier</value>
        [DataMember(Name="addressBookId", EmitDefaultValue=false)]
        public int? AddressBookId { get; set; }

        /// <summary>
        /// Society
        /// </summary>
        /// <value>Society</value>
        [DataMember(Name="society", EmitDefaultValue=false)]
        public string Society { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  TelName: ").Append(TelName).Append("\n");
            sb.Append("  FaxName: ").Append(FaxName).Append("\n");
            sb.Append("  House: ").Append(House).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FiscalCode: ").Append(FiscalCode).Append("\n");
            sb.Append("  Nation: ").Append(Nation).Append("\n");
            sb.Append("  AddressBookId: ").Append(AddressBookId).Append("\n");
            sb.Append("  Society: ").Append(Society).Append("\n");
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
            return this.Equals(input as UserProfileDTO);
        }

        /// <summary>
        /// Returns true if UserProfileDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfileDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileDTO input)
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
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.MobilePhone == input.MobilePhone ||
                    (this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone))
                ) && 
                (
                    this.TelName == input.TelName ||
                    (this.TelName != null &&
                    this.TelName.Equals(input.TelName))
                ) && 
                (
                    this.FaxName == input.FaxName ||
                    (this.FaxName != null &&
                    this.FaxName.Equals(input.FaxName))
                ) && 
                (
                    this.House == input.House ||
                    (this.House != null &&
                    this.House.Equals(input.House))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
                ) && 
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
                ) && 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FiscalCode == input.FiscalCode ||
                    (this.FiscalCode != null &&
                    this.FiscalCode.Equals(input.FiscalCode))
                ) && 
                (
                    this.Nation == input.Nation ||
                    (this.Nation != null &&
                    this.Nation.Equals(input.Nation))
                ) && 
                (
                    this.AddressBookId == input.AddressBookId ||
                    (this.AddressBookId != null &&
                    this.AddressBookId.Equals(input.AddressBookId))
                ) && 
                (
                    this.Society == input.Society ||
                    (this.Society != null &&
                    this.Society.Equals(input.Society))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.MobilePhone != null)
                    hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.TelName != null)
                    hashCode = hashCode * 59 + this.TelName.GetHashCode();
                if (this.FaxName != null)
                    hashCode = hashCode * 59 + this.FaxName.GetHashCode();
                if (this.House != null)
                    hashCode = hashCode * 59 + this.House.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
                if (this.Vat != null)
                    hashCode = hashCode * 59 + this.Vat.GetHashCode();
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FiscalCode != null)
                    hashCode = hashCode * 59 + this.FiscalCode.GetHashCode();
                if (this.Nation != null)
                    hashCode = hashCode * 59 + this.Nation.GetHashCode();
                if (this.AddressBookId != null)
                    hashCode = hashCode * 59 + this.AddressBookId.GetHashCode();
                if (this.Society != null)
                    hashCode = hashCode * 59 + this.Society.GetHashCode();
                return hashCode;
            }
        }
    }

}
