using cmdb;
using System;

namespace cmdb.request_mgmt_itil
{
	 public class UserRequest:Ticket
	 {

		 //Attributs

		 public Enum Status { get; set; }
		 public Enum Request_type { get; set; }
		 public Enum Impact { get; set; }
		 public Enum Priority { get; set; }
		 public Enum Urgency { get; set; }
		 public Enum Origin { get; set; }
		 public ExternalKey Approver_id { get; set; }
		 public ExternalField Approver_email { get; set; }
		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalKey Servicesubcategory_id { get; set; }
		 public ExternalField Servicesubcategory_name { get; set; }
		 public Enum Escalation_flag { get; set; }
		 public string Escalation_reason { get; set; }
		 public DateTime Assignment_date { get; set; }
		 public DateTime Resolution_date { get; set; }
		 public DateTime Last_pending_date { get; set; }
		 public StopWatch Cumulatedpending { get; set; }
		 public StopWatch Tto { get; set; }
		 public StopWatch Ttr { get; set; }
		 public SubItem Tto_escalation_deadline { get; set; }
		 public SubItem Sla_tto_passed { get; set; }
		 public SubItem Sla_tto_over { get; set; }
		 public SubItem Ttr_escalation_deadline { get; set; }
		 public SubItem Sla_ttr_passed { get; set; }
		 public SubItem Sla_ttr_over { get; set; }
		 public Duration Time_spent { get; set; }
		 public Enum Resolution_code { get; set; }
		 public Text Solution { get; set; }
		 public Text Pending_reason { get; set; }
		 public ExternalKey Parent_request_id { get; set; }
		 public ExternalField Parent_request_ref { get; set; }
		 public ExternalKey Parent_incident_id { get; set; }
		 public ExternalField Parent_incident_ref { get; set; }
		 public ExternalKey Parent_problem_id { get; set; }
		 public ExternalField Parent_problem_ref { get; set; }
		 public ExternalKey Parent_change_id { get; set; }
		 public ExternalField Parent_change_ref { get; set; }
		 public LinkedSet Related_request_list { get; set; }
		 public CaseLog Public_log { get; set; }
		 public Enum User_satisfaction { get; set; }
		 public Text User_comment { get; set; }

		 //Methodes

		 public void SetAssignedDate()
		 {
			 // public function SetAssignedDate($sStimulusCode)
			 // {
			 // $this->Set('assignment_date', time());
			 // return true;
			 // }
		 }
		 public void SetLastPendingDate()
		 {
			 // public function SetLastPendingDate($sStimulusCode)
			 // {
			 // $this->Set('last_pending_date', time());
			 // return true;
			 // }
		 }
		 public void SetResolveDate()
		 {
			 // public function SetResolveDate($sStimulusCode)
			 // {
			 // $this->Set('resolution_date', time());
			 // $iTimeSpent = time() - AttributeDateTime::GetAsUnixSeconds($this->Get('start_date'));
			 // $this->Set('time_spent', $iTimeSpent);
			 // return true;
			 // }
		 }
		 public void SetClosureDate()
		 {
			 // public function SetClosureDate($sStimulusCode)
			 // {
			 // $this->Set('close_date', time());
			 // return true;
			 // }
		 }
		 public void SetApprover()
		 {
			 // public function SetApprover($sStimulusCode)
			 // {
			 // $this->Set('approver_id', UserRights::GetUserId());
			 // return true;
			 // }
		 }
		 public void DoCheckToWrite()
		 {
			 // public function DoCheckToWrite()
			 // {
			 // parent::DoCheckToWrite();
			 // if (!$this->IsNew() && ($this->Get('parent_request_id') == $this->GetKey()))
			 // {
			 // $this->m_aCheckIssues[] = Dict::Format('Class:UserRequest/Error:CannotAssignParentRequestIdToSelf');
			 // }
			 // }
		 }
		 public void ComputePriority()
		 {
			 // public function ComputePriority()
			 // {
			 // // priority[impact][urgency]
			 // $aPriorities = array(
			 // // a department
			 // 1 => array(
			 // 1 => 1,
			 // 2 => 1,
			 // 3 => 2,
			 // 4 => 4,
			 // ),
			 // // a group
			 // 2 => array(
			 // 1 => 1,
			 // 2 => 2,
			 // 3 => 3,
			 // 4 => 4,
			 // ),
			 // // a person
			 // 3 => array(
			 // 1 => 2,
			 // 2 => 3,
			 // 3 => 3,
			 // 4 => 4,
			 // ),
			 // );
			 // $iPriority = 1;
			 // if (isset($aPriorities[(int)$this->Get('impact')]) && isset($aPriorities[(int)$this->Get('impact')][(int)$this->Get('urgency')]))
			 // {
			 // $iPriority = $aPriorities[(int)$this->Get('impact')][(int)$this->Get('urgency')];
			 // }
			 // return $iPriority;
			 // }
		 }
		 public void ComputeValues()
		 {
			 // public function ComputeValues()
			 // {
			 // 
			 // // Compute the priority of the ticket
			 // $this->Set('priority', $this->ComputePriority());
			 // 
			 // return parent::ComputeValues();
			 // }
		 }
		 public void DisplayBareRelations()
		 {
			 // function DisplayBareRelations(WebPage $oPage, $bEditMode = false)
			 // {
			 // parent::DisplayBareRelations($oPage, $bEditMode);
			 // 
			 // if (!$bEditMode)
			 // {
			 // 
			 // if (MetaModel::IsValidClass('KnownError'))
			 // {
			 // //Search for known errors
			 // $oPage->SetCurrentTab(Dict::S('Class:UserRequest:KnownErrorList'));
			 // $iTicketID = $this->GetKey();;
			 // $oKnownErrorSet = new CMDBObjectSet(DBObjectSearch::FromOQL("SELECT KnownError AS ke JOIN lnkErrorToFunctionalCI AS l1 ON l1.error_id=ke.id JOIN FunctionalCI AS ci ON l1.functionalci_id=ci.id JOIN lnkFunctionalCIToTicket AS l2 ON l2.functionalci_id=ci.id WHERE l2.ticket_id=$iTicketID"));
			 // $iNumberKE=$oKnownErrorSet->count();
			 // if ($iNumberKE > 0)
			 // {
			 // $oPage->SetCurrentTab(Dict::S('Class:UserRequest:KnownErrorList')." ($iNumberKE)");
			 // }
			 // else
			 // {
			 // $oPage->SetCurrentTab(Dict::S('Class:UserRequest:KnownErrorList'));
			 // }
			 // self::DisplaySet($oPage, $oKnownErrorSet, array ('menu' => false));
			 // }
			 // }
			 // }
		 }
		 public void ResolveChilds()
		 {
			 // public function resolveChilds($sStimulusCode)
			 // {
			 // 
			 // $sOQL = "SELECT UserRequest WHERE parent_request_id=:ticket";
			 // $oChildRequestSet = new DBObjectSet(DBObjectSearch::FromOQL($sOQL),
			 // array(),
			 // array(
			 // 'ticket' => $this->GetKey(),
			 // )
			 // );
			 // while($oRequest = $oChildRequestSet->Fetch())
			 // {
			 // if ( $oRequest->Get('status') != 'resolved')
			 // {
			 // $oRequest->set('servicesubcategory_id',$this->Get('servicesubcategory_id'));
			 // $oRequest->set('service_id',$this->Get('service_id'));
			 // $oRequest->set('team_id',$this->Get('team_id'));
			 // $oRequest->set('agent_id',$this->Get('agent_id'));
			 // $oRequest->set('resolution_code',$this->Get('resolution_code'));
			 // $oRequest->set('solution','Automatically resolved by request:[[UserRequest:'.$this->Get('ref').']]');
			 // $oRequest->ApplyStimulus('ev_autoresolve');
			 // $oRequest->DBUpdate();
			 // }
			 // }
			 // return true;
			 // 
			 // }
		 }
		 public void ResolveChildTickets()
		 {
			 // public function ResolveChildTickets()
			 // {
			 // static $aTickets = array(); // prevent infinite recursion
			 // 
			 // // Automatically resolve child requests
			 // $sOQL = "SELECT UserRequest WHERE parent_request_id = :ticket AND status != 'resolved'";
			 // $oChildRequestSet = new DBObjectSet(DBObjectSearch::FromOQL($sOQL), array(), array('ticket' => $this->GetKey()));
			 // while($oRequest = $oChildRequestSet->Fetch())
			 // {
			 // if (!array_key_exists($oRequest->GetKey(), $aTickets))
			 // {
			 // $aTickets[$oRequest->GetKey()] = true;
			 // $oRequest->ResolveFrom($this);
			 // }
			 // }
			 // return true;
			 // }
		 }
		 public void ResolveFrom()
		 {
			 // public function ResolveFrom($oParentTicket)
			 // {
			 // if ($this->Get('status') != 'resolved')
			 // {
			 // $this->Set('servicesubcategory_id', $oParentTicket->Get('servicesubcategory_id'));
			 // $this->Set('service_id', $oParentTicket->Get('service_id'));
			 // $this->Set('team_id', $oParentTicket->Get('team_id'));
			 // $this->Set('agent_id', $oParentTicket->Get('agent_id'));
			 // $this->Set('resolution_code', $oParentTicket->Get('resolution_code'));
			 // $sParent = '[['.get_class($oParentTicket).':'.$oParentTicket->Get('ref').']]';
			 // $this->Set('solution', Dict::Format('Tickets:ResolvedFrom', $sParent, MetaModel::GetName(get_class($oParentTicket))));
			 // $this->ApplyStimulus('ev_autoresolve');
			 // $this->DBUpdate();
			 // }
			 // }
		 }
		 public void UpdateChildRequestLog()
		 {
			 // public function UpdateChildRequestLog()
			 // {
			 // $oLog = $this->Get('public_log');
			 // $sLogPublic = $oLog->GetModifiedEntry('html');
			 // if ($sLogPublic != '')
			 // {
			 // $sOQL = "SELECT UserRequest WHERE parent_request_id=:ticket";
			 // $oChildRequestSet = new DBObjectSet(DBObjectSearch::FromOQL($sOQL),
			 // array(),
			 // array(
			 // 'ticket' => $this->GetKey(),
			 // )
			 // );
			 // while($oRequest = $oChildRequestSet->Fetch())
			 // {
			 // $oRequest->set('public_log',$sLogPublic);
			 // $oRequest->DBUpdate();
			 // }
			 // 
			 // }
			 // $oLog = $this->Get('private_log');
			 // $sLogPrivate = $oLog->GetModifiedEntry('html');
			 // if ($sLogPrivate != '')
			 // {
			 // $sOQL = "SELECT UserRequest WHERE parent_request_id=:ticket";
			 // $oChildRequestSet = new DBObjectSet(DBObjectSearch::FromOQL($sOQL),
			 // array(),
			 // array(
			 // 'ticket' => $this->GetKey(),
			 // )
			 // );
			 // while($oRequest = $oChildRequestSet->Fetch())
			 // {
			 // $oRequest->set('private_log',$sLogPrivate);
			 // $oRequest->DBUpdate();
			 // }
			 // }
			 // return true;
			 // 
			 // }
		 }
		 public void ComputeImpactedItems()
		 {
			 // 
			 // public function ComputeImpactedItems()
			 // {
			 // // This method is kept for backward compatibility
			 // // in case a delta redefines it, but you may call
			 // // UpdateImpactedItems directly
			 // $this->UpdateImpactedItems();
			 // }
		 }
		 public void OnInsert()
		 {
			 // 
			 // protected function OnInsert()
			 // {
			 // $this->ComputeImpactedItems();
			 // $this->Set('last_update', time());
			 // $this->Set('start_date', time());
			 // }
		 }
		 public void OnUpdate()
		 {
			 // 
			 // protected function OnUpdate()
			 // {
			 // parent::OnUpdate();
			 // $aChanges = $this->ListChanges();
			 // if (array_key_exists('functionalcis_list', $aChanges))
			 // {
			 // $this->UpdateImpactedItems();
			 // }
			 // $this->Set('last_update', time());
			 // $this->UpdateChildRequestLog();
			 // }
		 }
	 } //end classUserRequest
} //end namespace