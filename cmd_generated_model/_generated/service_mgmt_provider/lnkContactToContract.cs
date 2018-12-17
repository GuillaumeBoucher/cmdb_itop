using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class lnkContactToContract:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Contract_id { get; set; }
		 public ExternalField Contract_name { get; set; }
		 public ExternalKey Contact_id { get; set; }
		 public ExternalField Contact_name { get; set; }

		 //Methodes

	 } //end classlnkContactToContract
} //end namespace