using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkGroupToCI:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Group_id { get; set; }
		 public ExternalField Group_name { get; set; }
		 public ExternalKey Ci_id { get; set; }
		 public ExternalField Ci_name { get; set; }
		 public string Reason { get; set; }

		 //Methodes

	 } //end classlnkGroupToCI
} //end namespace