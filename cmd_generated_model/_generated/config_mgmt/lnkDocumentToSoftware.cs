using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkDocumentToSoftware:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Software_id { get; set; }
		 public ExternalField Software_name { get; set; }
		 public ExternalKey Document_id { get; set; }
		 public ExternalField Document_name { get; set; }

		 //Methodes

	 } //end classlnkDocumentToSoftware
} //end namespace