using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class lnkDeliveryModelToContact:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Deliverymodel_id { get; set; }
		 public ExternalField Deliverymodel_name { get; set; }
		 public ExternalKey Contact_id { get; set; }
		 public ExternalField Contact_name { get; set; }
		 public ExternalKey Role_id { get; set; }
		 public ExternalField Role_name { get; set; }

		 //Methodes

	 } //end classlnkDeliveryModelToContact
} //end namespace