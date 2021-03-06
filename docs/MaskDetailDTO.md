# ARXivarNEXT.Client.Model.MaskDetailDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Detail Identifier | [optional] 
**MaskId** | **string** | Mask Identifier | [optional] 
**FieldName** | **string** | Name of the field. | [optional] 
**Label** | **string** | Label | [optional] 
**Order** | **int?** | Mask detail order | [optional] 
**ReadOnly** | **bool?** | Read Only | [optional] 
**Required** | **bool?** | Required | [optional] 
**DetailKind** | **int?** | Possible values:  0: NonImpostato  1: From  2: To  3: Cc  4: Aoo  5: DocumentType  6: DataDoc  7: Numero  8: Oggetto  9: Origine  10: Stato  11: Pratiche  12: Scadenza  13: Importante  14: AbilitaWeb  15: AvviaWorkFlow  16: InviaPerFax  17: InviaPerMail  18: AllegaATaskAttivo  19: InserisciInAssociazione  20: InserisciInFascicolo  21: InserisciInRelazioneManuale  22: GestisciRevisioni  23: Note  24: Allegati  25: Aggiuntivo  26: File  27: Scanner  28: Barcode  29: SicurezzaSingoloDocumento  30: ExternalId  31: AllegaMemo  32: Senders  33: AvviaCollaboration  34: ScansioneImmediata  35: NegaCommuta  36: From_Cap  37: From_Cell  38: From_Codfis  39: From_Codice  40: From_Contatti  41: From_Email  42: From_Fax  43: From_Faxnome  44: From_Indirizzo  45: From_Localita  46: From_Mail  47: From_Mansione  48: From_Nazione  49: From_Partiva  50: From_Provincia  51: From_Reparto  52: From_Riferimento  53: From_Tel  54: From_Telnome  55: From_Ufficio  56: From_Valore  57: From_Abitazione  58: To_Cap  59: To_Cell  60: To_Codfis  61: To_Codice  62: To_Contatti  63: To_Email  64: To_Fax  65: To_Faxnome  66: To_Indirizzo  67: To_Localita  68: To_Mail  69: To_Mansione  70: To_Nazione  71: To_Partiva  72: To_Provincia  73: To_Reparto  74: To_Riferimento  75: To_Tel  76: To_Telnome  77: To_Ufficio  78: To_Valore  79: To_Abitazione  80: Cc_Cap  81: Cc_Cell  82: Cc_Codfis  83: Cc_Codice  84: Cc_Contatti  85: Cc_Email  86: Cc_Fax  87: Cc_Faxnome  88: Cc_Indirizzo  89: Cc_Localita  90: Cc_Mail  91: Cc_Mansione  92: Cc_Nazione  93: Cc_Partiva  94: Cc_Provincia  95: Cc_Reparto  96: Cc_Riferimento  97: Cc_Tel  98: Cc_Telnome  99: Cc_Ufficio  100: Cc_Valore  101: Cc_Abitazione  102: Senders_Cap  103: Senders_Cell  104: Senders_Codfis  105: Senders_Codice  106: Senders_Contatti  107: Senders_Email  108: Senders_Fax  109: Senders_Faxnome  110: Senders_Indirizzo  111: Senders_Localita  112: Senders_Mail  113: Senders_Mansione  114: Senders_Nazione  115: Senders_Partiva  116: Senders_Provincia  117: Senders_Reparto  118: Senders_Riferimento  119: Senders_Tel  120: Senders_Telnome  121: Senders_Ufficio  122: Senders_Valore  123: Senders_Abitazione  124: From_Priorita  125: To_Priorita  126: Cc_Priorita  127: Senders_Priorita  128: Instruction  | [optional] 
**VisibilityCondition** | **string** | The visibility condition formula for this mask field | [optional] 
**AddressBookDefaultFilter** | **int?** | The preferred address book for search contacts for this field | [optional] 
**EnabledAddressBook** | **List&lt;int?&gt;** | Possible addressbook for selection for this field | [optional] 
**Translations** | [**List&lt;MaskDetailTranslationDTO&gt;**](MaskDetailTranslationDTO.md) | Translations for the field label | [optional] 
**Columns** | **int?** | Number of display columns for the field | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

