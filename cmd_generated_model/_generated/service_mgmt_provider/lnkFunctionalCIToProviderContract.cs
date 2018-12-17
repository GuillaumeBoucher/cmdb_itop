using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class lnkFunctionalCIToProviderContract:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Providercontract_id { get; set; }
		 public ExternalField Providercontract_name { get; set; }
		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }

		 //Methodes

	 } //end classlnkFunctionalCIToProviderContract
} //end namespace