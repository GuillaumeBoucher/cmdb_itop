using cmdb;
using System;

namespace cmdb.virtualization_mgmt
{
	 public class VirtualMachine:VirtualDevice
	 {

		 //Attributs

		 public ExternalKey Virtualhost_id { get; set; }
		 public ExternalField Virtualhost_name { get; set; }
		 public ExternalKey Osfamily_id { get; set; }
		 public ExternalField Osfamily_name { get; set; }
		 public ExternalKey Osversion_id { get; set; }
		 public ExternalField Osversion_name { get; set; }
		 public ExternalKey Oslicence_id { get; set; }
		 public ExternalField Oslicence_name { get; set; }
		 public string Cpu { get; set; }
		 public string Ram { get; set; }
		 public LinkedSet Logicalinterface_list { get; set; }
		 public IPAddress Managementip { get; set; }

		 //Methodes

	 } //end classVirtualMachine
} //end namespace