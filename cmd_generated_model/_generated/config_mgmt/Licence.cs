using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Licence:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public LinkedSetIndirect Documents_list { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Organization_name { get; set; }
		 public string Usage_limit { get; set; }
		 public Text Description { get; set; }
		 public Date Start_date { get; set; }
		 public Date End_date { get; set; }
		 public string Licence_key { get; set; }
		 public Enum Perpetual { get; set; }

		 //Methodes

	 } //end classLicence
} //end namespace