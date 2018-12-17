using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class PhysicalInterface:IPInterface
	 {

		 //Attributs

		 public ExternalKey Connectableci_id { get; set; }
		 public ExternalField Connectableci_name { get; set; }
		 public LinkedSetIndirect Vlans_list { get; set; }

		 //Methodes

	 } //end classPhysicalInterface
} //end namespace