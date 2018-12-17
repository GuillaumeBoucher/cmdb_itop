using cmdb;
using System;

namespace cmdb.tickets
{
	 public class lnkContactToTicket:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Ticket_id { get; set; }
		 public ExternalField Ticket_ref { get; set; }
		 public ExternalKey Contact_id { get; set; }
		 public ExternalField Contact_email { get; set; }
		 public string Role { get; set; }
		 public Enum Role_code { get; set; }

		 //Methodes

	 } //end classlnkContactToTicket
} //end namespace