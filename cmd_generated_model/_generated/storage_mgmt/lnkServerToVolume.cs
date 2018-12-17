using cmdb;
using System;

namespace cmdb.storage_mgmt
{
	 public class lnkServerToVolume:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Volume_id { get; set; }
		 public ExternalField Volume_name { get; set; }
		 public ExternalKey Server_id { get; set; }
		 public ExternalField Server_name { get; set; }
		 public string Size_used { get; set; }

		 //Methodes

	 } //end classlnkServerToVolume
} //end namespace