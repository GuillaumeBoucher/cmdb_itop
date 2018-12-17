using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class SLA:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Text Description { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Organization_name { get; set; }
		 public LinkedSetIndirect Slts_list { get; set; }
		 public LinkedSetIndirect Customercontracts_list { get; set; }

		 //Methodes

	 } //end classSLA
} //end namespace