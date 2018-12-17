using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class ServiceSubcategory:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Text Description { get; set; }
		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_org_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalField Service_provider { get; set; }
		 public Enum Request_type { get; set; }
		 public Enum Status { get; set; }

		 //Methodes

	 } //end classServiceSubcategory
} //end namespace