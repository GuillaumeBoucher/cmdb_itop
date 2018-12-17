using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkSoftwareInstanceToSoftwarePatch:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Softwarepatch_id { get; set; }
		 public ExternalField Softwarepatch_name { get; set; }
		 public ExternalKey Softwareinstance_id { get; set; }
		 public ExternalField Softwareinstance_name { get; set; }

		 //Methodes

	 } //end classlnkSoftwareInstanceToSoftwarePatch
} //end namespace