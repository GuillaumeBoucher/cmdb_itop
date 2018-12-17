using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Document:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Org_name { get; set; }
		 public ExternalKey Documenttype_id { get; set; }
		 public ExternalField Documenttype_name { get; set; }
		 public string Version { get; set; }
		 public Text Description { get; set; }
		 public Enum Status { get; set; }
		 public LinkedSetIndirect Cis_list { get; set; }
		 public LinkedSetIndirect Contracts_list { get; set; }
		 public LinkedSetIndirect Services_list { get; set; }

		 //Methodes

	 } //end classDocument
} //end namespace