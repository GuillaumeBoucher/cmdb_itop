using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class lnkCustomerContractToProviderContract:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Customercontract_id { get; set; }
		 public ExternalField Customercontract_name { get; set; }
		 public ExternalKey Providercontract_id { get; set; }
		 public ExternalField Providercontract_name { get; set; }

		 //Methodes

	 } //end classlnkCustomerContractToProviderContract
} //end namespace