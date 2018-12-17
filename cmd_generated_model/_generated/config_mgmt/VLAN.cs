using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class VLAN:cmdbAbstractObject
	 {

		 //Attributs

		 public string Vlan_tag { get; set; }
		 public Text Description { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Org_name { get; set; }
		 public LinkedSetIndirect Subnets_list { get; set; }
		 public LinkedSetIndirect Physicalinterfaces_list { get; set; }

		 //Methodes

	 } //end classVLAN
} //end namespace