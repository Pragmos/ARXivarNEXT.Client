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
    /// BarcodeServiceRuleDTO
    /// </summary>
    [DataContract]
    public partial class BarcodeServiceRuleDTO :  IEquatable<BarcodeServiceRuleDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeServiceRuleDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BarcodeServiceRuleDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeServiceRuleDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="barcodePath">barcodePath.</param>
        /// <param name="enableProfilation">enableProfilation.</param>
        /// <param name="userProfilation">userProfilation.</param>
        /// <param name="multiPageSplit">Possible values:  0: SplitFirstPage  1: SplitLastPage  2: AllPages  3: AllPagesDiscardEmpty  -1: SystemDefault  (required).</param>
        /// <param name="scanOptions">scanOptions (required).</param>
        /// <param name="format">format.</param>
        public BarcodeServiceRuleDTO(int? id = default(int?), bool? enabled = default(bool?), string barcodePath = default(string), bool? enableProfilation = default(bool?), UserSimpleDTO userProfilation = default(UserSimpleDTO), int? multiPageSplit = default(int?), BarcodeScanOptionsDTO scanOptions = default(BarcodeScanOptionsDTO), List<BarcodeFormatDTO> format = default(List<BarcodeFormatDTO>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BarcodeServiceRuleDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "multiPageSplit" is required (not null)
            if (multiPageSplit == null)
            {
                throw new InvalidDataException("multiPageSplit is a required property for BarcodeServiceRuleDTO and cannot be null");
            }
            else
            {
                this.MultiPageSplit = multiPageSplit;
            }
            // to ensure "scanOptions" is required (not null)
            if (scanOptions == null)
            {
                throw new InvalidDataException("scanOptions is a required property for BarcodeServiceRuleDTO and cannot be null");
            }
            else
            {
                this.ScanOptions = scanOptions;
            }
            this.Enabled = enabled;
            this.BarcodePath = barcodePath;
            this.EnableProfilation = enableProfilation;
            this.UserProfilation = userProfilation;
            this.Format = format;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets BarcodePath
        /// </summary>
        [DataMember(Name="barcodePath", EmitDefaultValue=false)]
        public string BarcodePath { get; set; }

        /// <summary>
        /// Gets or Sets EnableProfilation
        /// </summary>
        [DataMember(Name="enableProfilation", EmitDefaultValue=false)]
        public bool? EnableProfilation { get; set; }

        /// <summary>
        /// Gets or Sets UserProfilation
        /// </summary>
        [DataMember(Name="userProfilation", EmitDefaultValue=false)]
        public UserSimpleDTO UserProfilation { get; set; }

        /// <summary>
        /// Possible values:  0: SplitFirstPage  1: SplitLastPage  2: AllPages  3: AllPagesDiscardEmpty  -1: SystemDefault 
        /// </summary>
        /// <value>Possible values:  0: SplitFirstPage  1: SplitLastPage  2: AllPages  3: AllPagesDiscardEmpty  -1: SystemDefault </value>
        [DataMember(Name="multiPageSplit", EmitDefaultValue=false)]
        public int? MultiPageSplit { get; set; }

        /// <summary>
        /// Gets or Sets ScanOptions
        /// </summary>
        [DataMember(Name="scanOptions", EmitDefaultValue=false)]
        public BarcodeScanOptionsDTO ScanOptions { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public List<BarcodeFormatDTO> Format { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeServiceRuleDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  BarcodePath: ").Append(BarcodePath).Append("\n");
            sb.Append("  EnableProfilation: ").Append(EnableProfilation).Append("\n");
            sb.Append("  UserProfilation: ").Append(UserProfilation).Append("\n");
            sb.Append("  MultiPageSplit: ").Append(MultiPageSplit).Append("\n");
            sb.Append("  ScanOptions: ").Append(ScanOptions).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(input as BarcodeServiceRuleDTO);
        }

        /// <summary>
        /// Returns true if BarcodeServiceRuleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeServiceRuleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeServiceRuleDTO input)
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
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.BarcodePath == input.BarcodePath ||
                    (this.BarcodePath != null &&
                    this.BarcodePath.Equals(input.BarcodePath))
                ) && 
                (
                    this.EnableProfilation == input.EnableProfilation ||
                    (this.EnableProfilation != null &&
                    this.EnableProfilation.Equals(input.EnableProfilation))
                ) && 
                (
                    this.UserProfilation == input.UserProfilation ||
                    (this.UserProfilation != null &&
                    this.UserProfilation.Equals(input.UserProfilation))
                ) && 
                (
                    this.MultiPageSplit == input.MultiPageSplit ||
                    (this.MultiPageSplit != null &&
                    this.MultiPageSplit.Equals(input.MultiPageSplit))
                ) && 
                (
                    this.ScanOptions == input.ScanOptions ||
                    (this.ScanOptions != null &&
                    this.ScanOptions.Equals(input.ScanOptions))
                ) && 
                (
                    this.Format == input.Format ||
                    this.Format != null &&
                    this.Format.SequenceEqual(input.Format)
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.BarcodePath != null)
                    hashCode = hashCode * 59 + this.BarcodePath.GetHashCode();
                if (this.EnableProfilation != null)
                    hashCode = hashCode * 59 + this.EnableProfilation.GetHashCode();
                if (this.UserProfilation != null)
                    hashCode = hashCode * 59 + this.UserProfilation.GetHashCode();
                if (this.MultiPageSplit != null)
                    hashCode = hashCode * 59 + this.MultiPageSplit.GetHashCode();
                if (this.ScanOptions != null)
                    hashCode = hashCode * 59 + this.ScanOptions.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                return hashCode;
            }
        }
    }

}
