using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class lnkFunctionalCIToService:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }

		 //Methodes

	 } //end classlnkFunctionalCIToService
} //end namespace