using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Contact:cmdbAbstractObject
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