using cmdb;
using System;

namespace cmdb.knownerror_mgmt
{
	 public class KnownError:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Cust_name { get; set; }
		 public ExternalKey Problem_id { get; set; }
		 public ExternalField Problem_ref { get; set; }
		 public Text Symptom { get; set; }
		 public Text Root_cause { get; set; }
		 public Text Workaround { get; set; }
		 public Text Solution { get; set; }
		 public string Error_code { get; set; }
		 public Enum Domain { get; set; }
		 public string Vendor { get; set; }
		 public string Model { get; set; }
		 public string Version { get; set; }
		 public LinkedSetIndirect Ci_list { get; set; }
		 public LinkedSetIndirect Document_list { get; set; }

		 //Methodes

	 } //end classKnownError
} //end namespace