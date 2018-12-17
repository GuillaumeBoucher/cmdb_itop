using cmdb;
using System;

namespace cmdb.virtualization_mgmt
{
	 public class Hypervisor:VirtualHost
	 {

		 //Attributs

		 public ExternalKey Farm_id { get; set; }
		 public ExternalField Farm_name { get; set; }
		 public ExternalKey Server_id { get; set; }
		 public ExternalField Server_name { get; set; }

		 //Methodes

	 } //end classHypervisor
} //end namespace