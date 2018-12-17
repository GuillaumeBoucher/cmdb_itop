using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class SoftwareInstance:FunctionalCI
	 {

		 //Attributs

		 public ExternalKey System_id { get; set; }
		 public ExternalField System_name { get; set; }
		 public ExternalKey Software_id { get; set; }
		 public ExternalField Software_name { get; set; }
		 public ExternalKey Softwarelicence_id { get; set; }
		 public ExternalField Softwarelicence_name { get; set; }
		 public string Path { get; set; }
		 public Enum Status { get; set; }

		 //Methodes

	 } //end classSoftwareInstance
} //end namespace