using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkApplicationSolutionToBusinessProcess:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Businessprocess_id { get; set; }
		 public ExternalField Businessprocess_name { get; set; }
		 public ExternalKey Applicationsolution_id { get; set; }
		 public ExternalField Applicationsolution_name { get; set; }

		 //Methodes

	 } //end classlnkApplicationSolutionToBusinessProcess
} //end namespace