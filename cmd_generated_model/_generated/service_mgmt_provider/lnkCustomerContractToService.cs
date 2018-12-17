using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class lnkCustomerContractToService:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Customercontract_id { get; set; }
		 public ExternalField Customercontract_name { get; set; }
		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalKey Sla_id { get; set; }
		 public ExternalField Sla_name { get; set; }

		 //Methodes

	 } //end classlnkCustomerContractToService
} //end namespace