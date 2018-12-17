using cmdb;
using System;

namespace cmdb.problem_mgmt
{
	 public class Problem:Ticket
	 {

		 //Attributs

		 public Enum Status { get; set; }
		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalKey Servicesubcategory_id { get; set; }
		 public ExternalField Servicesubcategory_name { get; set; }
		 public string Product { get; set; }
		 public Enum Impact { get; set; }
		 public Enum Urgency { get; set; }
		 public Enum Priority { get; set; }
		 public ExternalKey Related_change_id { get; set; }
		 public ExternalField Related_change_ref { get; set; }
		 public DateTime Assignment_date { get; set; }
		 public DateTime Resolution_date { get; set; }
		 public LinkedSet Knownerrors_list { get; set; }
		 public LinkedSet Related_request_list { get; set; }
		 public LinkedSet Related_incident_list { get; set; }

		 //Methodes

		 public void SetAssignedDate()
		 {
			 // public function SetAssignedDate($sStimulusCode)
			 // {
			 // $this->Set('assignment_date', time());
			 // return true;
			 // }
		 }
		 public void SetResolveDate()
		 {
			 // public function SetResolveDate($sStimulusCode)
			 // {
			 // $this->Set('resolution_date', time());
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
		 public void ComputePriority()
		 {
			 // public function ComputePriority()
			 // {
			 // // priority[impact][urgency]
			 // $aPriorities = array(
			 // // single person
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
			 // // a departement!
			 // 3 => array(
			 // 1 => 2,
			 // 2 => 3,
			 // 3 => 3,
			 // 4 => 4,
			 // ),
			 // );
			 // $iPriority = 1;
			 // if (isset($aPriorities[(int)$this->Get('impact')][(int)$this->Get('urgency')]))
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
			 // // Compute the priority of the ticket
			 // $this->Set('priority', $this->ComputePriority());
			 // }
		 }
		 public void OnInsert()
		 {
			 // protected function OnInsert()
			 // {
			 // $this->Set('start_date', time());
			 // $this->Set('last_update', time());
			 // }
		 }
		 public void OnUpdate()
		 {
			 // protected function OnUpdate()
			 // {
			 // $this->Set('last_update', time());
			 // }
		 }
	 } //end classProblem
} //end namespace