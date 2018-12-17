using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Location:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Enum Status { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Org_name { get; set; }
		 public Text Address { get; set; }
		 public string Postal_code { get; set; }
		 public string City { get; set; }
		 public string Country { get; set; }
		 public LinkedSet Physicaldevice_list { get; set; }
		 public LinkedSet Person_list { get; set; }

		 //Methodes

	 } //end classLocation
} //end namespace