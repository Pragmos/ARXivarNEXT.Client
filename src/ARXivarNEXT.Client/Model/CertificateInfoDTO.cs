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
    /// CertificateInfoDTO
    /// </summary>
    [DataContract]
    public partial class CertificateInfoDTO :  IEquatable<CertificateInfoDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateInfoDTO" /> class.
        /// </summary>
        /// <param name="signAlgorithm">signAlgorithm.</param>
        /// <param name="keyBitLength">keyBitLength.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="thumbprintAlgorithm">thumbprintAlgorithm.</param>
        /// <param name="thumbprint">thumbprint.</param>
        /// <param name="trustLevel">trustLevel.</param>
        /// <param name="keyUsageList">keyUsageList.</param>
        /// <param name="extendedKeyUsageList">extendedKeyUsageList.</param>
        /// <param name="validNotBeforeUtc">validNotBeforeUtc.</param>
        /// <param name="validNotAfterUtc">validNotAfterUtc.</param>
        /// <param name="subjectKeyIdentifier">subjectKeyIdentifier.</param>
        /// <param name="subjectAlternativeName">subjectAlternativeName.</param>
        /// <param name="subjectUniqueId">subjectUniqueId.</param>
        /// <param name="subjectInfoList">subjectInfoList.</param>
        /// <param name="version">version.</param>
        /// <param name="issuerUniqueId">issuerUniqueId.</param>
        /// <param name="issuerAlternativeName">issuerAlternativeName.</param>
        /// <param name="issuerInfoList">issuerInfoList.</param>
        /// <param name="authorityInfoAccessOcsp">authorityInfoAccessOcsp.</param>
        /// <param name="crlDistributionPoints">crlDistributionPoints.</param>
        /// <param name="validationMessageList">validationMessageList.</param>
        /// <param name="certificatePolicies">certificatePolicies.</param>
        /// <param name="qcStatementList">qcStatementList.</param>
        /// <param name="isTrusted">isTrusted.</param>
        /// <param name="trustValidationMessageList">trustValidationMessageList.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="certificateB64">certificateB64.</param>
        /// <param name="verifyCondition">verifyCondition.</param>
        public CertificateInfoDTO(IdValuePairDTO signAlgorithm = default(IdValuePairDTO), int? keyBitLength = default(int?), string serialNumber = default(string), IdValuePairDTO thumbprintAlgorithm = default(IdValuePairDTO), string thumbprint = default(string), string trustLevel = default(string), List<int?> keyUsageList = default(List<int?>), List<IdValuePairDTO> extendedKeyUsageList = default(List<IdValuePairDTO>), DateTime? validNotBeforeUtc = default(DateTime?), DateTime? validNotAfterUtc = default(DateTime?), string subjectKeyIdentifier = default(string), string subjectAlternativeName = default(string), string subjectUniqueId = default(string), List<IdValuePairDTO> subjectInfoList = default(List<IdValuePairDTO>), int? version = default(int?), string issuerUniqueId = default(string), string issuerAlternativeName = default(string), List<IdValuePairDTO> issuerInfoList = default(List<IdValuePairDTO>), List<string> authorityInfoAccessOcsp = default(List<string>), List<string> crlDistributionPoints = default(List<string>), List<ValidationMessageDTO> validationMessageList = default(List<ValidationMessageDTO>), List<CertificatePolicyInfoDTO> certificatePolicies = default(List<CertificatePolicyInfoDTO>), List<SignatureAttributeDTO> qcStatementList = default(List<SignatureAttributeDTO>), bool? isTrusted = default(bool?), List<ValidationMessageDTO> trustValidationMessageList = default(List<ValidationMessageDTO>), bool? isValid = default(bool?), string certificateB64 = default(string), VerifyConditionDTO verifyCondition = default(VerifyConditionDTO))
        {
            this.SignAlgorithm = signAlgorithm;
            this.KeyBitLength = keyBitLength;
            this.SerialNumber = serialNumber;
            this.ThumbprintAlgorithm = thumbprintAlgorithm;
            this.Thumbprint = thumbprint;
            this.TrustLevel = trustLevel;
            this.KeyUsageList = keyUsageList;
            this.ExtendedKeyUsageList = extendedKeyUsageList;
            this.ValidNotBeforeUtc = validNotBeforeUtc;
            this.ValidNotAfterUtc = validNotAfterUtc;
            this.SubjectKeyIdentifier = subjectKeyIdentifier;
            this.SubjectAlternativeName = subjectAlternativeName;
            this.SubjectUniqueId = subjectUniqueId;
            this.SubjectInfoList = subjectInfoList;
            this.Version = version;
            this.IssuerUniqueId = issuerUniqueId;
            this.IssuerAlternativeName = issuerAlternativeName;
            this.IssuerInfoList = issuerInfoList;
            this.AuthorityInfoAccessOcsp = authorityInfoAccessOcsp;
            this.CrlDistributionPoints = crlDistributionPoints;
            this.ValidationMessageList = validationMessageList;
            this.CertificatePolicies = certificatePolicies;
            this.QcStatementList = qcStatementList;
            this.IsTrusted = isTrusted;
            this.TrustValidationMessageList = trustValidationMessageList;
            this.IsValid = isValid;
            this.CertificateB64 = certificateB64;
            this.VerifyCondition = verifyCondition;
        }
        
        /// <summary>
        /// Gets or Sets SignAlgorithm
        /// </summary>
        [DataMember(Name="signAlgorithm", EmitDefaultValue=false)]
        public IdValuePairDTO SignAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets KeyBitLength
        /// </summary>
        [DataMember(Name="keyBitLength", EmitDefaultValue=false)]
        public int? KeyBitLength { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets ThumbprintAlgorithm
        /// </summary>
        [DataMember(Name="thumbprintAlgorithm", EmitDefaultValue=false)]
        public IdValuePairDTO ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets Thumbprint
        /// </summary>
        [DataMember(Name="thumbprint", EmitDefaultValue=false)]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or Sets TrustLevel
        /// </summary>
        [DataMember(Name="trustLevel", EmitDefaultValue=false)]
        public string TrustLevel { get; set; }

        /// <summary>
        /// Gets or Sets KeyUsageList
        /// </summary>
        [DataMember(Name="keyUsageList", EmitDefaultValue=false)]
        public List<int?> KeyUsageList { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedKeyUsageList
        /// </summary>
        [DataMember(Name="extendedKeyUsageList", EmitDefaultValue=false)]
        public List<IdValuePairDTO> ExtendedKeyUsageList { get; set; }

        /// <summary>
        /// Gets or Sets ValidNotBeforeUtc
        /// </summary>
        [DataMember(Name="validNotBeforeUtc", EmitDefaultValue=false)]
        public DateTime? ValidNotBeforeUtc { get; set; }

        /// <summary>
        /// Gets or Sets ValidNotAfterUtc
        /// </summary>
        [DataMember(Name="validNotAfterUtc", EmitDefaultValue=false)]
        public DateTime? ValidNotAfterUtc { get; set; }

        /// <summary>
        /// Gets or Sets SubjectKeyIdentifier
        /// </summary>
        [DataMember(Name="subjectKeyIdentifier", EmitDefaultValue=false)]
        public string SubjectKeyIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SubjectAlternativeName
        /// </summary>
        [DataMember(Name="subjectAlternativeName", EmitDefaultValue=false)]
        public string SubjectAlternativeName { get; set; }

        /// <summary>
        /// Gets or Sets SubjectUniqueId
        /// </summary>
        [DataMember(Name="subjectUniqueId", EmitDefaultValue=false)]
        public string SubjectUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets SubjectInfoList
        /// </summary>
        [DataMember(Name="subjectInfoList", EmitDefaultValue=false)]
        public List<IdValuePairDTO> SubjectInfoList { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Gets or Sets IssuerUniqueId
        /// </summary>
        [DataMember(Name="issuerUniqueId", EmitDefaultValue=false)]
        public string IssuerUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerAlternativeName
        /// </summary>
        [DataMember(Name="issuerAlternativeName", EmitDefaultValue=false)]
        public string IssuerAlternativeName { get; set; }

        /// <summary>
        /// Gets or Sets IssuerInfoList
        /// </summary>
        [DataMember(Name="issuerInfoList", EmitDefaultValue=false)]
        public List<IdValuePairDTO> IssuerInfoList { get; set; }

        /// <summary>
        /// Gets or Sets AuthorityInfoAccessOcsp
        /// </summary>
        [DataMember(Name="authorityInfoAccessOcsp", EmitDefaultValue=false)]
        public List<string> AuthorityInfoAccessOcsp { get; set; }

        /// <summary>
        /// Gets or Sets CrlDistributionPoints
        /// </summary>
        [DataMember(Name="crlDistributionPoints", EmitDefaultValue=false)]
        public List<string> CrlDistributionPoints { get; set; }

        /// <summary>
        /// Gets or Sets ValidationMessageList
        /// </summary>
        [DataMember(Name="validationMessageList", EmitDefaultValue=false)]
        public List<ValidationMessageDTO> ValidationMessageList { get; set; }

        /// <summary>
        /// Gets or Sets CertificatePolicies
        /// </summary>
        [DataMember(Name="certificatePolicies", EmitDefaultValue=false)]
        public List<CertificatePolicyInfoDTO> CertificatePolicies { get; set; }

        /// <summary>
        /// Gets or Sets QcStatementList
        /// </summary>
        [DataMember(Name="qcStatementList", EmitDefaultValue=false)]
        public List<SignatureAttributeDTO> QcStatementList { get; set; }

        /// <summary>
        /// Gets or Sets IsTrusted
        /// </summary>
        [DataMember(Name="isTrusted", EmitDefaultValue=false)]
        public bool? IsTrusted { get; set; }

        /// <summary>
        /// Gets or Sets TrustValidationMessageList
        /// </summary>
        [DataMember(Name="trustValidationMessageList", EmitDefaultValue=false)]
        public List<ValidationMessageDTO> TrustValidationMessageList { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="isValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets or Sets CertificateB64
        /// </summary>
        [DataMember(Name="certificateB64", EmitDefaultValue=false)]
        public string CertificateB64 { get; set; }

        /// <summary>
        /// Gets or Sets VerifyCondition
        /// </summary>
        [DataMember(Name="verifyCondition", EmitDefaultValue=false)]
        public VerifyConditionDTO VerifyCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateInfoDTO {\n");
            sb.Append("  SignAlgorithm: ").Append(SignAlgorithm).Append("\n");
            sb.Append("  KeyBitLength: ").Append(KeyBitLength).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  ThumbprintAlgorithm: ").Append(ThumbprintAlgorithm).Append("\n");
            sb.Append("  Thumbprint: ").Append(Thumbprint).Append("\n");
            sb.Append("  TrustLevel: ").Append(TrustLevel).Append("\n");
            sb.Append("  KeyUsageList: ").Append(KeyUsageList).Append("\n");
            sb.Append("  ExtendedKeyUsageList: ").Append(ExtendedKeyUsageList).Append("\n");
            sb.Append("  ValidNotBeforeUtc: ").Append(ValidNotBeforeUtc).Append("\n");
            sb.Append("  ValidNotAfterUtc: ").Append(ValidNotAfterUtc).Append("\n");
            sb.Append("  SubjectKeyIdentifier: ").Append(SubjectKeyIdentifier).Append("\n");
            sb.Append("  SubjectAlternativeName: ").Append(SubjectAlternativeName).Append("\n");
            sb.Append("  SubjectUniqueId: ").Append(SubjectUniqueId).Append("\n");
            sb.Append("  SubjectInfoList: ").Append(SubjectInfoList).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  IssuerUniqueId: ").Append(IssuerUniqueId).Append("\n");
            sb.Append("  IssuerAlternativeName: ").Append(IssuerAlternativeName).Append("\n");
            sb.Append("  IssuerInfoList: ").Append(IssuerInfoList).Append("\n");
            sb.Append("  AuthorityInfoAccessOcsp: ").Append(AuthorityInfoAccessOcsp).Append("\n");
            sb.Append("  CrlDistributionPoints: ").Append(CrlDistributionPoints).Append("\n");
            sb.Append("  ValidationMessageList: ").Append(ValidationMessageList).Append("\n");
            sb.Append("  CertificatePolicies: ").Append(CertificatePolicies).Append("\n");
            sb.Append("  QcStatementList: ").Append(QcStatementList).Append("\n");
            sb.Append("  IsTrusted: ").Append(IsTrusted).Append("\n");
            sb.Append("  TrustValidationMessageList: ").Append(TrustValidationMessageList).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  CertificateB64: ").Append(CertificateB64).Append("\n");
            sb.Append("  VerifyCondition: ").Append(VerifyCondition).Append("\n");
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
            return this.Equals(input as CertificateInfoDTO);
        }

        /// <summary>
        /// Returns true if CertificateInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignAlgorithm == input.SignAlgorithm ||
                    (this.SignAlgorithm != null &&
                    this.SignAlgorithm.Equals(input.SignAlgorithm))
                ) && 
                (
                    this.KeyBitLength == input.KeyBitLength ||
                    (this.KeyBitLength != null &&
                    this.KeyBitLength.Equals(input.KeyBitLength))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.ThumbprintAlgorithm == input.ThumbprintAlgorithm ||
                    (this.ThumbprintAlgorithm != null &&
                    this.ThumbprintAlgorithm.Equals(input.ThumbprintAlgorithm))
                ) && 
                (
                    this.Thumbprint == input.Thumbprint ||
                    (this.Thumbprint != null &&
                    this.Thumbprint.Equals(input.Thumbprint))
                ) && 
                (
                    this.TrustLevel == input.TrustLevel ||
                    (this.TrustLevel != null &&
                    this.TrustLevel.Equals(input.TrustLevel))
                ) && 
                (
                    this.KeyUsageList == input.KeyUsageList ||
                    this.KeyUsageList != null &&
                    this.KeyUsageList.SequenceEqual(input.KeyUsageList)
                ) && 
                (
                    this.ExtendedKeyUsageList == input.ExtendedKeyUsageList ||
                    this.ExtendedKeyUsageList != null &&
                    this.ExtendedKeyUsageList.SequenceEqual(input.ExtendedKeyUsageList)
                ) && 
                (
                    this.ValidNotBeforeUtc == input.ValidNotBeforeUtc ||
                    (this.ValidNotBeforeUtc != null &&
                    this.ValidNotBeforeUtc.Equals(input.ValidNotBeforeUtc))
                ) && 
                (
                    this.ValidNotAfterUtc == input.ValidNotAfterUtc ||
                    (this.ValidNotAfterUtc != null &&
                    this.ValidNotAfterUtc.Equals(input.ValidNotAfterUtc))
                ) && 
                (
                    this.SubjectKeyIdentifier == input.SubjectKeyIdentifier ||
                    (this.SubjectKeyIdentifier != null &&
                    this.SubjectKeyIdentifier.Equals(input.SubjectKeyIdentifier))
                ) && 
                (
                    this.SubjectAlternativeName == input.SubjectAlternativeName ||
                    (this.SubjectAlternativeName != null &&
                    this.SubjectAlternativeName.Equals(input.SubjectAlternativeName))
                ) && 
                (
                    this.SubjectUniqueId == input.SubjectUniqueId ||
                    (this.SubjectUniqueId != null &&
                    this.SubjectUniqueId.Equals(input.SubjectUniqueId))
                ) && 
                (
                    this.SubjectInfoList == input.SubjectInfoList ||
                    this.SubjectInfoList != null &&
                    this.SubjectInfoList.SequenceEqual(input.SubjectInfoList)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.IssuerUniqueId == input.IssuerUniqueId ||
                    (this.IssuerUniqueId != null &&
                    this.IssuerUniqueId.Equals(input.IssuerUniqueId))
                ) && 
                (
                    this.IssuerAlternativeName == input.IssuerAlternativeName ||
                    (this.IssuerAlternativeName != null &&
                    this.IssuerAlternativeName.Equals(input.IssuerAlternativeName))
                ) && 
                (
                    this.IssuerInfoList == input.IssuerInfoList ||
                    this.IssuerInfoList != null &&
                    this.IssuerInfoList.SequenceEqual(input.IssuerInfoList)
                ) && 
                (
                    this.AuthorityInfoAccessOcsp == input.AuthorityInfoAccessOcsp ||
                    this.AuthorityInfoAccessOcsp != null &&
                    this.AuthorityInfoAccessOcsp.SequenceEqual(input.AuthorityInfoAccessOcsp)
                ) && 
                (
                    this.CrlDistributionPoints == input.CrlDistributionPoints ||
                    this.CrlDistributionPoints != null &&
                    this.CrlDistributionPoints.SequenceEqual(input.CrlDistributionPoints)
                ) && 
                (
                    this.ValidationMessageList == input.ValidationMessageList ||
                    this.ValidationMessageList != null &&
                    this.ValidationMessageList.SequenceEqual(input.ValidationMessageList)
                ) && 
                (
                    this.CertificatePolicies == input.CertificatePolicies ||
                    this.CertificatePolicies != null &&
                    this.CertificatePolicies.SequenceEqual(input.CertificatePolicies)
                ) && 
                (
                    this.QcStatementList == input.QcStatementList ||
                    this.QcStatementList != null &&
                    this.QcStatementList.SequenceEqual(input.QcStatementList)
                ) && 
                (
                    this.IsTrusted == input.IsTrusted ||
                    (this.IsTrusted != null &&
                    this.IsTrusted.Equals(input.IsTrusted))
                ) && 
                (
                    this.TrustValidationMessageList == input.TrustValidationMessageList ||
                    this.TrustValidationMessageList != null &&
                    this.TrustValidationMessageList.SequenceEqual(input.TrustValidationMessageList)
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
                ) && 
                (
                    this.CertificateB64 == input.CertificateB64 ||
                    (this.CertificateB64 != null &&
                    this.CertificateB64.Equals(input.CertificateB64))
                ) && 
                (
                    this.VerifyCondition == input.VerifyCondition ||
                    (this.VerifyCondition != null &&
                    this.VerifyCondition.Equals(input.VerifyCondition))
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
                if (this.SignAlgorithm != null)
                    hashCode = hashCode * 59 + this.SignAlgorithm.GetHashCode();
                if (this.KeyBitLength != null)
                    hashCode = hashCode * 59 + this.KeyBitLength.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.ThumbprintAlgorithm != null)
                    hashCode = hashCode * 59 + this.ThumbprintAlgorithm.GetHashCode();
                if (this.Thumbprint != null)
                    hashCode = hashCode * 59 + this.Thumbprint.GetHashCode();
                if (this.TrustLevel != null)
                    hashCode = hashCode * 59 + this.TrustLevel.GetHashCode();
                if (this.KeyUsageList != null)
                    hashCode = hashCode * 59 + this.KeyUsageList.GetHashCode();
                if (this.ExtendedKeyUsageList != null)
                    hashCode = hashCode * 59 + this.ExtendedKeyUsageList.GetHashCode();
                if (this.ValidNotBeforeUtc != null)
                    hashCode = hashCode * 59 + this.ValidNotBeforeUtc.GetHashCode();
                if (this.ValidNotAfterUtc != null)
                    hashCode = hashCode * 59 + this.ValidNotAfterUtc.GetHashCode();
                if (this.SubjectKeyIdentifier != null)
                    hashCode = hashCode * 59 + this.SubjectKeyIdentifier.GetHashCode();
                if (this.SubjectAlternativeName != null)
                    hashCode = hashCode * 59 + this.SubjectAlternativeName.GetHashCode();
                if (this.SubjectUniqueId != null)
                    hashCode = hashCode * 59 + this.SubjectUniqueId.GetHashCode();
                if (this.SubjectInfoList != null)
                    hashCode = hashCode * 59 + this.SubjectInfoList.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.IssuerUniqueId != null)
                    hashCode = hashCode * 59 + this.IssuerUniqueId.GetHashCode();
                if (this.IssuerAlternativeName != null)
                    hashCode = hashCode * 59 + this.IssuerAlternativeName.GetHashCode();
                if (this.IssuerInfoList != null)
                    hashCode = hashCode * 59 + this.IssuerInfoList.GetHashCode();
                if (this.AuthorityInfoAccessOcsp != null)
                    hashCode = hashCode * 59 + this.AuthorityInfoAccessOcsp.GetHashCode();
                if (this.CrlDistributionPoints != null)
                    hashCode = hashCode * 59 + this.CrlDistributionPoints.GetHashCode();
                if (this.ValidationMessageList != null)
                    hashCode = hashCode * 59 + this.ValidationMessageList.GetHashCode();
                if (this.CertificatePolicies != null)
                    hashCode = hashCode * 59 + this.CertificatePolicies.GetHashCode();
                if (this.QcStatementList != null)
                    hashCode = hashCode * 59 + this.QcStatementList.GetHashCode();
                if (this.IsTrusted != null)
                    hashCode = hashCode * 59 + this.IsTrusted.GetHashCode();
                if (this.TrustValidationMessageList != null)
                    hashCode = hashCode * 59 + this.TrustValidationMessageList.GetHashCode();
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.CertificateB64 != null)
                    hashCode = hashCode * 59 + this.CertificateB64.GetHashCode();
                if (this.VerifyCondition != null)
                    hashCode = hashCode * 59 + this.VerifyCondition.GetHashCode();
                return hashCode;
            }
        }
    }

}
