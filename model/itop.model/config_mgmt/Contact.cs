using System;
using itop.base_types;

namespace itop.config_mgmt
{
	 public class Contact              //:cmdbAbstractObject supression de cette class a vérifier
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Enum Status { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Org_name { get; set; }
		 public EmailAddress Email { get; set; }
		 public PhoneNumber Phone { get; set; }
		 public Enum Notify { get; set; }
		 public string Function { get; set; }
		 public LinkedSetIndirect Cis_list { get; set; }

		 //Methodes

	 } //end classContact
} //end namespace