using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Software:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public string Vendor { get; set; }
		 public string Version { get; set; }
		 public LinkedSetIndirect Documents_list { get; set; }
		 public Enum Type { get; set; }
		 public LinkedSet Softwareinstance_list { get; set; }
		 public LinkedSet Softwarepatch_list { get; set; }
		 public LinkedSet Softwarelicence_list { get; set; }

		 //Methodes

	 } //end classSoftware
} //end namespace