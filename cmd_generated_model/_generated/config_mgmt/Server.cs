using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Server:DatacenterDevice
	 {

		 //Attributs

		 public ExternalKey Osfamily_id { get; set; }
		 public ExternalField Osfamily_name { get; set; }
		 public ExternalKey Osversion_id { get; set; }
		 public ExternalField Osversion_name { get; set; }
		 public ExternalKey Oslicence_id { get; set; }
		 public ExternalField Oslicence_name { get; set; }
		 public string Cpu { get; set; }
		 public string Ram { get; set; }
		 public LinkedSetIndirect Logicalvolumes_list { get; set; }

		 //Methodes

	 } //end classServer
} //end namespace