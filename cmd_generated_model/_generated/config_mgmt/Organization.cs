using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Organization:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public string Code { get; set; }
		 public Enum Status { get; set; }
		 public HierarchicalKey Parent_id { get; set; }
		 public ExternalField Parent_name { get; set; }

		 //Methodes

	 } //end classOrganization
} //end namespace