using cmdb;
using System;

namespace cmdb.storage_mgmt
{
	 public class LogicalVolume:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public string Lun_id { get; set; }
		 public Text Description { get; set; }
		 public string Raid_level { get; set; }
		 public string Size { get; set; }
		 public ExternalKey Storagesystem_id { get; set; }
		 public ExternalField Storagesystem_name { get; set; }
		 public LinkedSetIndirect Servers_list { get; set; }
		 public LinkedSetIndirect Virtualdevices_list { get; set; }

		 //Methodes

	 } //end classLogicalVolume
} //end namespace