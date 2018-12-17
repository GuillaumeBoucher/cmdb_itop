using cmdb;
using System;

namespace cmdb.storage_mgmt
{
	 public class NASFileSystem:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Text Description { get; set; }
		 public string Raid_level { get; set; }
		 public string Size { get; set; }
		 public ExternalKey Nas_id { get; set; }
		 public ExternalField Nas_name { get; set; }

		 //Methodes

	 } //end classNASFileSystem
} //end namespace