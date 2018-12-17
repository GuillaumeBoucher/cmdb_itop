using cmdb;
using System;

namespace cmdb.knownerror_mgmt
{
	 public class lnkDocumentToError:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Document_id { get; set; }
		 public ExternalField Document_name { get; set; }
		 public ExternalKey Error_id { get; set; }
		 public ExternalField Error_name { get; set; }
		 public string Link_type { get; set; }

		 //Methodes

	 } //end classlnkDocumentToError
} //end namespace