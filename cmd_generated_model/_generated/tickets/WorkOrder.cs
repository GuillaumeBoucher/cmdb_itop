using cmdb;
using System;

namespace cmdb.tickets
{
	 public class WorkOrder:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Enum Status { get; set; }
		 public Text Description { get; set; }
		 public ExternalKey Ticket_id { get; set; }
		 public ExternalField Ticket_ref { get; set; }
		 public ExternalKey Team_id { get; set; }
		 public ExternalField Team_name { get; set; }
		 public ExternalKey Agent_id { get; set; }
		 public ExternalField Agent_email { get; set; }
		 public DateTime Start_date { get; set; }
		 public DateTime End_date { get; set; }
		 public CaseLog Log { get; set; }

		 //Methodes

		 public void UpdateParentTicketLog()
		 {
			 // public function UpdateParentTicketLog()
			 // {
			 // $oLog = $this->Get('log');
			 // $sLog = $oLog->GetModifiedEntry('html');
			 // if ($sLog != '')
			 // {
			 // $oTicket = MetaModel::GetObject('Ticket', $this->Get('ticket_id'), false);
			 // if ($oTicket)
			 // {
			 // $oTicket->Set('private_log', $sLog);
			 // $oTicket->DBUpdate();
			 // }
			 // }
			 // }
		 }
		 public void OnUpdate()
		 {
			 // protected function OnUpdate()
			 // {
			 // $this->UpdateParentTicketLog();
			 // }
		 }
	 } //end classWorkOrder
} //end namespace