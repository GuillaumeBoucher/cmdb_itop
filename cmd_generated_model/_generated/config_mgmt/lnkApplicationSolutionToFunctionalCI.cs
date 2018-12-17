using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkApplicationSolutionToFunctionalCI:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Applicationsolution_id { get; set; }
		 public ExternalField Applicationsolution_name { get; set; }
		 public ExternalKey Functionalci_id { get; set; }
		 public ExternalField Functionalci_name { get; set; }

		 //Methodes

	 } //end classlnkApplicationSolutionToFunctionalCI
} //end namespace