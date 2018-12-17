using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class lnkContactToService:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalKey Contact_id { get; set; }
		 public ExternalField Contact_name { get; set; }

		 //Methodes

	 } //end classlnkContactToService
} //end namespace