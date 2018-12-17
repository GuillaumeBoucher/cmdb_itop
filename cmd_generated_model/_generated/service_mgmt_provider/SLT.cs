using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class SLT:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Enum Priority { get; set; }
		 public Enum Request_type { get; set; }
		 public Enum Metric { get; set; }
		 public int Value { get; set; }
		 public Enum Unit { get; set; }

		 //Methodes

	 } //end classSLT
} //end namespace