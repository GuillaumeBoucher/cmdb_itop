using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class DeliveryModel:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Organization_name { get; set; }
		 public Text Description { get; set; }
		 public LinkedSetIndirect Contacts_list { get; set; }
		 public LinkedSet Customers_list { get; set; }

		 //Methodes

	 } //end classDeliveryModel
} //end namespace