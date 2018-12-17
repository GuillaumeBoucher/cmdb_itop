using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkContactToFunctionalCI:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }
		 public ExternalKey Contact_id { get; set; }
		 public ExternalField Contact_name { get; set; }

		 //Methodes

	 } //end classlnkContactToFunctionalCI
} //end namespace