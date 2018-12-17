using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkFunctionalCIToOSPatch:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Ospatch_id { get; set; }
		 public ExternalField Ospatch_name { get; set; }
		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }

		 //Methodes

	 } //end classlnkFunctionalCIToOSPatch
} //end namespace