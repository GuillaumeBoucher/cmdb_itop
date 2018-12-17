using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkDocumentToPatch:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Patch_id { get; set; }
		 public ExternalField Patch_name { get; set; }
		 public ExternalKey Document_id { get; set; }
		 public ExternalField Document_name { get; set; }

		 //Methodes

	 } //end classlnkDocumentToPatch
} //end namespace