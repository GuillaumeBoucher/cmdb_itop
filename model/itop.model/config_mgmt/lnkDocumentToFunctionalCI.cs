using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkDocumentToFunctionalCI:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }
		 public ExternalKey Document_id { get; set; }
		 public ExternalField Document_name { get; set; }

		 //Methodes

	 } //end classlnkDocumentToFunctionalCI
} //end namespace