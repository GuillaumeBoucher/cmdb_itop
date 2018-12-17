using cmdb;
using System;

namespace cmdb.tickets
{
	 public class lnkFunctionalCIToTicket:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Ticket_id { get; set; }
		 public ExternalField Ticket_ref { get; set; }
		 public ExternalField Ticket_title { get; set; }
		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }
		 public string Impact { get; set; }
		 public Enum Impact_code { get; set; }

		 //Methodes

	 } //end classlnkFunctionalCIToTicket
} //end namespace