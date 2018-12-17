using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class lnkProviderContractToService:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalKey Providercontract_id { get; set; }
		 public ExternalField Providercontract_name { get; set; }

		 //Methodes

	 } //end classlnkProviderContractToService
} //end namespace