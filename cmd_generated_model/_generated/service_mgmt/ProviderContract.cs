using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class ProviderContract:Contract
	 {

		 //Attributs

		 public LinkedSetIndirect Functionalcis_list { get; set; }
		 public string Sla { get; set; }
		 public string Coverage { get; set; }

		 //Methodes

	 } //end classProviderContract
} //end namespace