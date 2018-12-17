using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class CustomerContract:Contract
	 {

		 //Attributs

		 public LinkedSetIndirect Services_list { get; set; }
		 public LinkedSetIndirect Functionalcis_list { get; set; }
		 public LinkedSetIndirect Providercontracts_list { get; set; }

		 //Methodes

	 } //end classCustomerContract
} //end namespace