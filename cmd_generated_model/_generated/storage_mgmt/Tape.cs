using cmdb;
using System;

namespace cmdb.storage_mgmt
{
	 public class Tape:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Text Description { get; set; }
		 public string Size { get; set; }
		 public ExternalKey Tapelibrary_id { get; set; }
		 public ExternalField Tapelibrary_name { get; set; }

		 //Methodes

	 } //end classTape
} //end namespace