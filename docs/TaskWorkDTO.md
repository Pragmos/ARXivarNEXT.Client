# ARXivarNEXT.Client.Model.TaskWorkDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Identifier | [optional] 
**ProcessId** | **int?** | Process Identifier | [optional] 
**WorkflowId** | **int?** | Workflow Identifier | [optional] 
**Notes** | **bool?** | Notes | [optional] 
**Attachments** | **bool?** | Attachments | [optional] 
**Docnumber** | **int?** | Principal Document Identifier | [optional] 
**Revision** | **int?** | Principal Document Revision Number | [optional] 
**StartDate** | **DateTime?** | Start Date | [optional] 
**TaskName** | **string** | Task Name | [optional] 
**TaskDescription** | **string** | Description | [optional] 
**User** | **int?** | Author Identifier | [optional] 
**EndDate** | **DateTime?** | End Date | [optional] 
**State** | **int?** | Possible values:  0: Ended  1: Active  2: NotActive  | [optional] 
**ExpireDate** | **DateTime?** | Expiration Date | [optional] 
**PrincipalProfileSecurity** | **int?** | Possible values:  0: Read  1: Write  2: FromSecurity  | [optional] 
**NodeId** | **int?** | Task Node Identifier | [optional] 
**UserEnumSelection** | **int?** | Possible values:  0: Standard  1: List  2: OrganizationChart  | [optional] 
**NewProfileInput** | **bool?** | Active the operation to insert a principal document | [optional] 
**ProfileEdit** | **bool?** | Active the operation to update a principal document | [optional] 
**FolderInsert** | **bool?** | Active the operation to insert in folder a principal document | [optional] 
**Priority** | **int?** | Possible values:  0: Standard  1: Medium  2: High  | [optional] 
**ModelId** | **int?** | Model Identifier for operation to insert a principal document | [optional] 
**TaskType** | **int?** | Possible values:  0: Standard  1: Connection  2: Process  3: Pause  5: Task5  6: Documentation  7: Chrono  | [optional] 
**ExecutionMode** | **int?** | Execution Mode | [optional] 
**MailNotification** | **bool?** | Smtp for mail notification | [optional] 
**AutomaticTaskFeedDate** | **DateTime?** | Date of Automatic Feed | [optional] 
**PasswordRequired** | **bool?** | Password request for the conclusion of the task | [optional] 
**NewMemo** | **bool?** | Creating a new memo | [optional] 
**Readed** | **bool?** | The task was read | [optional] 
**AsyncCommand** | **bool?** | Execution mode in the case of shell operation | [optional] 
**EditCopy** | **bool?** | Copy the file in the edit buffer | [optional] 
**TakingChargeRequired** | **bool?** | Taking Charge Request | [optional] 
**TaskDeadlineDate** | **DateTime?** | Date of expiration of the task | [optional] 
**TaskActivationDate** | **DateTime?** | Task activation date | [optional] 
**ProfessionalRoleSelectionDescription** | **string** | Description of the professionals role selection operation | [optional] 
**ProcessVariablesSetDescription** | **string** | Description of the operation of process variables setting | [optional] 
**OrganizationChartId** | **int?** | Organization Chart Identifier | [optional] 
**DelegationId** | **int?** | Delegation Identifier | [optional] 
**OpenedTaskDate** | **DateTime?** | Date of opening | [optional] 
**ExitState** | **string** | Exit State | [optional] 
**GroupTaskId** | **string** | Group Task Identifier | [optional] 
**OrganizationChartOriginalUserId** | **int?** | Organization Identifier associated with the original user. | [optional] 
**OriginalUserId** | **int?** | Identifier of Original User to delegation | [optional] 
**ExternalTaskTypeId** | **string** | External Identifier | [optional] 
**ManageMaster** | **bool?** | It allows you to view and act on workflow master that you are endorsing undergoing workflow approval process | [optional] 
**WaitUserExecutionMode** | **int?** | It tells the workflow engine whether to proceed immediately to the conclusion of the task, or whether it should wait for all users who have been assigned the task have concluded their activities | [optional] 
**ManageInstruction** | **bool?** | It allows to manage the operating instructions by means of an operation on the task | [optional] 
**HtmlDescriptionEnabled** | **string** | Specifies whether the task description is html | [optional] 
**DynamicMansionDescription** | **string** | Descritpion for the dynamic mansion operation | [optional] 
**PartsVisibility** | **int?** | This flags enum indicates wich part is visible in the task | [optional] 
**DefaultExitState** | **string** | Default exit state for the task | [optional] 
**ReassignMode** | **int?** | Possible values:  0: NotEnabled  1: EnabledToEveryone  2: EnabledToSelected  | [optional] 
**AutoAssignMode** | **int?** | Possible values:  0: NotEnabled  1: EnabledToEveryone  2: EnabledToSelected  | [optional] 
**NameTranslationId** | **int?** | Id of the translation for the name of the task | [optional] 
**DescriptionTranslationId** | **int?** | Id of the translation for the description of the task | [optional] 
**ProfessionalRolesDescriptionTranslationId** | **int?** | Id of the translation for the task professional figures selection operation description | [optional] 
**VariablesDescriptionTranslationId** | **int?** | Id of the translation for task set variables operation description | [optional] 
**HtmlDescriptionTranslationId** | **int?** | Id of the translation for Html description of the task | [optional] 
**DynamicMansionDescriptionTranslationId** | **int?** | Id of the translation for task dynamic mansion selection operation | [optional] 
**GroupIcon** | **bool?** | Icon for the group | [optional] 
**Executers** | [**List&lt;UserCompleteDTO&gt;**](UserCompleteDTO.md) | Executers of the task | [optional] 
**AttachmentsVisible** | **bool?** | Attachments part visibility | [optional] 
**DetailsVisible** | **bool?** | Task details part visibility | [optional] 
**ProfilesVisible** | **bool?** | Profiles part visibility | [optional] 
**NotesVisible** | **bool?** | Notes part visibility | [optional] 
**HistoryVisible** | **bool?** | History part visibility | [optional] 
**InstructionVisible** | **bool?** | Instructions part visibility | [optional] 
**ShowProcessVisible** | **bool?** | Show process command part visibility | [optional] 
**VariablesVisible** | **bool?** | Variables part visibility | [optional] 
**ExitStateComboVisible** | **bool?** | Exit state part visibility | [optional] 
**OperationsVisible** | **bool?** | Operations part visibility | [optional] 
**WorkFlowName** | **string** | Name of the workflow | [optional] 
**WorkFlowDescription** | **string** | Description of the workflow | [optional] 
**WorkFlowDetails** | **string** | Details of the workflow | [optional] 
**WorkFlowColor** | **int?** | The color of the workflow | [optional] 
**ShowDesignerVisible** | **bool?** | Show designer command part visibility | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
