using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkDocumentToLicence:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Licence_id { get; set; }
		 public ExternalField Licence_name { get; set; }
		 public ExternalKey Document_id { get; set; }
		 public ExternalField Document_name { get; set; }

		 //Methodes

	 } //end classlnkDocumentToLicence
} //end namespace