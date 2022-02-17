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
    /// IxFeDocumentDetailDTO
    /// </summary>
    [DataContract]
    public partial class IxFeDocumentDetailDTO :  IEquatable<IxFeDocumentDetailDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeDocumentDetailDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="ixServiceId">ixServiceId.</param>
        /// <param name="status">Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: IxServiceTakeCharge  5: TemplateCompleted  6: TemplateError  7: ValidationCompleted  8: ValidationError  9: Discarded  10: ConservationCompleted  11: ConservationError  12: historicizingCompleted  13: historicizingError  14: DiscardedNotManaged  15: ResendCompleted  16: ResendError  17: SignCompleted  18: SignError  19: TransmissionCompleted  20: TransmissionError  21: DeliveryReceiptNotification  22: DeliveryMissedNotification  23: DiscardedNotification  24: ResultNotification  25: ExpirationTermsNotification  26: SendAttestationNotification  27: PositiveResultNotification  28: NegativeResultNotification  29: PositiveResultWaiting  30: NegativeResultWaiting  31: DiscardedNotification_B2B  32: DeliveryReceiptNotification_B2B  33: DeliveryMissedNotification_B2B  34: SdiDeliveredNotification  35: ConservationSentNotification .</param>
        /// <param name="message">message.</param>
        /// <param name="creationDate">creationDate.</param>
        public IxFeDocumentDetailDTO(int? id = default(int?), int? ixServiceId = default(int?), int? status = default(int?), string message = default(string), DateTime? creationDate = default(DateTime?))
        {
            this.Id = id;
            this.IxServiceId = ixServiceId;
            this.Status = status;
            this.Message = message;
            this.CreationDate = creationDate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets IxServiceId
        /// </summary>
        [DataMember(Name="ixServiceId", EmitDefaultValue=false)]
        public int? IxServiceId { get; set; }

        /// <summary>
        /// Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: IxServiceTakeCharge  5: TemplateCompleted  6: TemplateError  7: ValidationCompleted  8: ValidationError  9: Discarded  10: ConservationCompleted  11: ConservationError  12: historicizingCompleted  13: historicizingError  14: DiscardedNotManaged  15: ResendCompleted  16: ResendError  17: SignCompleted  18: SignError  19: TransmissionCompleted  20: TransmissionError  21: DeliveryReceiptNotification  22: DeliveryMissedNotification  23: DiscardedNotification  24: ResultNotification  25: ExpirationTermsNotification  26: SendAttestationNotification  27: PositiveResultNotification  28: NegativeResultNotification  29: PositiveResultWaiting  30: NegativeResultWaiting  31: DiscardedNotification_B2B  32: DeliveryReceiptNotification_B2B  33: DeliveryMissedNotification_B2B  34: SdiDeliveredNotification  35: ConservationSentNotification 
        /// </summary>
        /// <value>Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: IxServiceTakeCharge  5: TemplateCompleted  6: TemplateError  7: ValidationCompleted  8: ValidationError  9: Discarded  10: ConservationCompleted  11: ConservationError  12: historicizingCompleted  13: historicizingError  14: DiscardedNotManaged  15: ResendCompleted  16: ResendError  17: SignCompleted  18: SignError  19: TransmissionCompleted  20: TransmissionError  21: DeliveryReceiptNotification  22: DeliveryMissedNotification  23: DiscardedNotification  24: ResultNotification  25: ExpirationTermsNotification  26: SendAttestationNotification  27: PositiveResultNotification  28: NegativeResultNotification  29: PositiveResultWaiting  30: NegativeResultWaiting  31: DiscardedNotification_B2B  32: DeliveryReceiptNotification_B2B  33: DeliveryMissedNotification_B2B  34: SdiDeliveredNotification  35: ConservationSentNotification </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeDocumentDetailDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IxServiceId: ").Append(IxServiceId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
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
            return this.Equals(input as IxFeDocumentDetailDTO);
        }

        /// <summary>
        /// Returns true if IxFeDocumentDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeDocumentDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeDocumentDetailDTO input)
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
                    this.IxServiceId == input.IxServiceId ||
                    (this.IxServiceId != null &&
                    this.IxServiceId.Equals(input.IxServiceId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
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
                if (this.IxServiceId != null)
                    hashCode = hashCode * 59 + this.IxServiceId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
