using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class lnkDocumentToService:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Service_id { get; set; }
		 public ExternalField Service_name { get; set; }
		 public ExternalKey Document_id { get; set; }
		 public ExternalField Document_name { get; set; }

		 //Methodes

	 } //end classlnkDocumentToService
} //end namespace