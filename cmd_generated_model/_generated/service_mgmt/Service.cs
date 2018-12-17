using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class Service:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Organization_name { get; set; }
		 public ExternalKey Servicefamily_id { get; set; }
		 public ExternalField Servicefamily_name { get; set; }
		 public Text Description { get; set; }
		 public LinkedSetIndirect Documents_list { get; set; }
		 public LinkedSetIndirect Contacts_list { get; set; }
		 public Enum Status { get; set; }
		 public Image Icon { get; set; }
		 public LinkedSetIndirect Customercontracts_list { get; set; }
		 public LinkedSetIndirect Providercontracts_list { get; set; }
		 public LinkedSetIndirect Functionalcis_list { get; set; }
		 public LinkedSet Servicesubcategories_list { get; set; }

		 //Methodes

	 } //end classService
} //end namespace