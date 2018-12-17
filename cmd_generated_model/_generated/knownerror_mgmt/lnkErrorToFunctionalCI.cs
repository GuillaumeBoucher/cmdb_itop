using cmdb;
using System;

namespace cmdb.knownerror_mgmt
{
	 public class lnkErrorToFunctionalCI:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }
		 public ExternalKey Error_id { get; set; }
		 public ExternalField Error_name { get; set; }
		 public string Reason { get; set; }

		 //Methodes

	 } //end classlnkErrorToFunctionalCI
} //end namespace