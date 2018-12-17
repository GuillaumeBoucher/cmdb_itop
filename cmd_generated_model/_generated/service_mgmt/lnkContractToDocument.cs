using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class lnkContractToDocument:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Contract_id { get; set; }
		 public ExternalField Contract_name { get; set; }
		 public ExternalKey Document_id { get; set; }
		 public ExternalField Document_name { get; set; }

		 //Methodes

	 } //end classlnkContractToDocument
} //end namespace