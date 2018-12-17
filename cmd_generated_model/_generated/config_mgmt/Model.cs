using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Model:Typology
	 {

		 //Attributs

		 public ExternalKey Brand_id { get; set; }
		 public ExternalField Brand_name { get; set; }
		 public Enum Type { get; set; }
		 public LinkedSet Physicaldevices_list { get; set; }

		 //Methodes

	 } //end classModel
} //end namespace