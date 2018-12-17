using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class ConnectableCI:PhysicalDevice
	 {

		 //Attributs

		 public LinkedSetIndirect Networkdevice_list { get; set; }
		 public LinkedSet Physicalinterface_list { get; set; }

		 //Methodes

	 } //end classConnectableCI
} //end namespace