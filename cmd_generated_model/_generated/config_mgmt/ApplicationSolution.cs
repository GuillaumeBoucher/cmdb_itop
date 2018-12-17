using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class ApplicationSolution:FunctionalCI
	 {

		 //Attributs

		 public LinkedSetIndirect Functionalcis_list { get; set; }
		 public LinkedSetIndirect Businessprocess_list { get; set; }
		 public Enum Status { get; set; }
		 public RedundancySettings Redundancy { get; set; }

		 //Methodes

	 } //end classApplicationSolution
} //end namespace