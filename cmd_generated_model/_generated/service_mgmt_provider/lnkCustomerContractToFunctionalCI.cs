using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class lnkCustomerContractToFunctionalCI:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Customercontract_id { get; set; }
		 public ExternalField Customercontract_name { get; set; }
		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }

		 //Methodes

	 } //end classlnkCustomerContractToFunctionalCI
} //end namespace