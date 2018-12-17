using cmdb;
using System;

namespace cmdb.change_mgmt_itil
{
	 public class Change:Ticket
	 {

		 //Attributs

		 public Enum Status { get; set; }
		 public string Reason { get; set; }
		 public ExternalKey Requestor_id { get; set; }
		 public ExternalField Requestor_email { get; set; }
		 public DateTime Creation_date { get; set; }
		 public string Impact { get; set; }
		 public ExternalKey Supervisor_group_id { get; set; }
		 public ExternalField Supervisor_group_name { get; set; }
		 public ExternalKey Supervisor_id { get; set; }
		 public ExternalField Supervisor_email { get; set; }
		 public ExternalKey Manager_group_id { get; set; }
		 public ExternalField Manager_group_name { get; set; }
		 public ExternalKey Manager_id { get; set; }
		 public ExternalField Manager_email { get; set; }
		 public Enum Outage { get; set; }
		 public Text Fallback { get; set; }
		 public ExternalKey Parent_id { get; set; }
		 public ExternalField Parent_name { get; set; }
		 public LinkedSet Related_request_list { get; set; }
		 public LinkedSet Related_incident_list { get; set; }
		 public LinkedSet Related_problems_list { get; set; }
		 public LinkedSet Child_changes_list { get; set; }

		 //Methodes

		 public void SetClosureDate()
		 {
			 // public function SetClosureDate($sStimulusCode)
			 // {
			 // $this->Set('close_date', time());
			 // return true;
			 // }
		 }
		 public void ResetRejectReason()
		 {
			 // public function ResetRejectReason($sStimulusCode)
			 // {
			 // $this->Set('reason', '');
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