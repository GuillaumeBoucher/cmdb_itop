using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkPhysicalInterfaceToVLAN:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Physicalinterface_id { get; set; }
		 public ExternalField Physicalinterface_name { get; set; }
		 public ExternalField Physicalinterface_device_id { get; set; }
		 public ExternalField Physicalinterface_device_name { get; set; }
		 public ExternalKey Vlan_id { get; set; }
		 public ExternalField Vlan_tag { get; set; }

		 //Methodes

	 } //end classlnkPhysicalInterfaceToVLAN
} //end namespace