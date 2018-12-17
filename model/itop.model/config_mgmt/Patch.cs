using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Patch:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public LinkedSetIndirect Documents_list { get; set; }
		 public Text Description { get; set; }

		 //Methodes

	 } //end classPatch
} //end namespace