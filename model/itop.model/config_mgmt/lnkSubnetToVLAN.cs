using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkSubnetToVLAN:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Subnet_id { get; set; }
		 public ExternalField Subnet_ip { get; set; }
		 public ExternalField Subnet_name { get; set; }
		 public ExternalKey Vlan_id { get; set; }
		 public ExternalField Vlan_tag { get; set; }

		 //Methodes

	 } //end classlnkSubnetToVLAN
} //end namespace