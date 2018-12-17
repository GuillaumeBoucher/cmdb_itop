using cmdb;
using System;

namespace cmdb.change_mgmt
{
	 public class Change:Ticket
	 {

		 //Attributs

		 public Enum Status { get; set; }
		 public Enum Category { get; set; }
		 public Text Reject_reason { get; set; }
		 public ExternalKey Changemanager_id { get; set; }
		 public ExternalField Changemanager_email { get; set; }
		 public ExternalKey Parent_id { get; set; }
		 public ExternalField Parent_name { get; set; }
		 public DateTime Creation_date { get; set; }
		 public DateTime Approval_date { get; set; }
		 public Text Fallback_plan { get; set; }
		 public Enum Outage { get; set; }
		 public LinkedSet Related_request_list { get; set; }
		 public LinkedSet Related_incident_list { get; set; }
		 public LinkedSet Related_problems_list { get; set; }
		 public LinkedSet Child_changes_list { get; set; }

		 //Methodes

		 public void SetApprovalDate()
		 {
			 // public function SetApprovalDate($sStimulusCode)
			 // {
			 // $this->Set('approval_date', time());
			 // return true;
			 // }
		 }
		 public void ResetRejectReason()
		 {
			 // public function ResetRejectReason($sStimulusCode)
			 // {
			 // $this->Set('reject_reason', '');
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
		 public void OnInsert()
		 {
			 // 
			 // protected function OnInsert()
			 // {
			 // parent::OnInsert();
			 // $this->UpdateImpactedItems();
			 // $this->Set('creation_date', time());
			 // $this->Set('last_update', time());
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
			 // }
		 }
	 } //end classChange
} //end namespace