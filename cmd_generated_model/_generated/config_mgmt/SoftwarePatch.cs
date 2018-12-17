using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class SoftwarePatch:Patch
	 {

		 //Attributs

		 public ExternalKey Software_id { get; set; }
		 public ExternalField Software_name { get; set; }
		 public LinkedSetIndirect Softwareinstances_list { get; set; }

		 //Methodes

	 } //end classSoftwarePatch
} //end namespace