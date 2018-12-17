using cmdb;
using System;

namespace cmdb.virtualization_mgmt
{
	 public class Farm:VirtualHost
	 {

		 //Attributs

		 public LinkedSet Hypervisor_list { get; set; }
		 public RedundancySettings Redundancy { get; set; }

		 //Methodes

	 } //end classFarm
} //end namespace