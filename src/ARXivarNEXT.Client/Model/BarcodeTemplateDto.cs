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
    /// Class of barcode template
    /// </summary>
    [DataContract]
    public partial class BarcodeTemplateDto :  IEquatable<BarcodeTemplateDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeTemplateDto" /> class.
        /// </summary>
        /// <param name="barcodeTemplate">Barcode Template Name.</param>
        /// <param name="printerFamily">Possible values:  0: ZEBRA_EPL2  1: ZEBRA_ZPL2  2: TOSHIBA_BSV4  3: EPSON_ESC_POS  4: GRAPHIC .</param>
        /// <param name="dmTipidocumentoId">Document Type Identifier.</param>
        public BarcodeTemplateDto(string barcodeTemplate = default(string), int? printerFamily = default(int?), int? dmTipidocumentoId = default(int?))
        {
            this.BarcodeTemplate = barcodeTemplate;
            this.PrinterFamily = printerFamily;
            this.DmTipidocumentoId = dmTipidocumentoId;
        }
        
        /// <summary>
        /// Barcode Template Name
        /// </summary>
        /// <value>Barcode Template Name</value>
        [DataMember(Name="barcodeTemplate", EmitDefaultValue=false)]
        public string BarcodeTemplate { get; set; }

        /// <summary>
        /// Possible values:  0: ZEBRA_EPL2  1: ZEBRA_ZPL2  2: TOSHIBA_BSV4  3: EPSON_ESC_POS  4: GRAPHIC 
        /// </summary>
        /// <value>Possible values:  0: ZEBRA_EPL2  1: ZEBRA_ZPL2  2: TOSHIBA_BSV4  3: EPSON_ESC_POS  4: GRAPHIC </value>
        [DataMember(Name="printerFamily", EmitDefaultValue=false)]
        public int? PrinterFamily { get; set; }

        /// <summary>
        /// Document Type Identifier
        /// </summary>
        /// <value>Document Type Identifier</value>
        [DataMember(Name="dmTipidocumentoId", EmitDefaultValue=false)]
        public int? DmTipidocumentoId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeTemplateDto {\n");
            sb.Append("  BarcodeTemplate: ").Append(BarcodeTemplate).Append("\n");
            sb.Append("  PrinterFamily: ").Append(PrinterFamily).Append("\n");
            sb.Append("  DmTipidocumentoId: ").Append(DmTipidocumentoId).Append("\n");
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
            return this.Equals(input as BarcodeTemplateDto);
        }

        /// <summary>
        /// Returns true if BarcodeTemplateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeTemplateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeTemplateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BarcodeTemplate == input.BarcodeTemplate ||
                    (this.BarcodeTemplate != null &&
                    this.BarcodeTemplate.Equals(input.BarcodeTemplate))
                ) && 
                (
                    this.PrinterFamily == input.PrinterFamily ||
                    (this.PrinterFamily != null &&
                    this.PrinterFamily.Equals(input.PrinterFamily))
                ) && 
                (
                    this.DmTipidocumentoId == input.DmTipidocumentoId ||
                    (this.DmTipidocumentoId != null &&
                    this.DmTipidocumentoId.Equals(input.DmTipidocumentoId))
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
                if (this.BarcodeTemplate != null)
                    hashCode = hashCode * 59 + this.BarcodeTemplate.GetHashCode();
                if (this.PrinterFamily != null)
                    hashCode = hashCode * 59 + this.PrinterFamily.GetHashCode();
                if (this.DmTipidocumentoId != null)
                    hashCode = hashCode * 59 + this.DmTipidocumentoId.GetHashCode();
                return hashCode;
            }
        }
    }

}
