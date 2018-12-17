using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class SoftwareLicence:Licence
	 {

		 //Attributs

		 public ExternalKey Software_id { get; set; }
		 public ExternalField Software_name { get; set; }
		 public LinkedSet Softwareinstance_list { get; set; }

		 //Methodes

	 } //end classSoftwareLicence
} //end namespace