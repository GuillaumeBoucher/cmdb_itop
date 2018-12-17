using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class NetworkDevice:DatacenterDevice
	 {

		 //Attributs

		 public ExternalKey Networkdevicetype_id { get; set; }
		 public ExternalField Networkdevicetype_name { get; set; }
		 public LinkedSetIndirect Connectablecis_list { get; set; }
		 public ExternalKey Iosversion_id { get; set; }
		 public ExternalField Iosversion_name { get; set; }
		 public string Ram { get; set; }

		 //Methodes

	 } //end classNetworkDevice
} //end namespace