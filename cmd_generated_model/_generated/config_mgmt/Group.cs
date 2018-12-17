using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Group:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Enum Status { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Owner_name { get; set; }
		 public Text Description { get; set; }
		 public string Type { get; set; }
		 public HierarchicalKey Parent_id { get; set; }
		 public ExternalField Parent_name { get; set; }
		 public LinkedSetIndirect Ci_list { get; set; }

		 //Methodes

	 } //end classGroup
} //end namespace