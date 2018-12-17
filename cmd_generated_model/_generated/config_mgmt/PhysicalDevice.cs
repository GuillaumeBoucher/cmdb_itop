using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class PhysicalDevice:FunctionalCI
	 {

		 //Attributs

		 public string Serialnumber { get; set; }
		 public ExternalKey Location_id { get; set; }
		 public ExternalField Location_name { get; set; }
		 public Enum Status { get; set; }
		 public ExternalKey Brand_id { get; set; }
		 public ExternalField Brand_name { get; set; }
		 public ExternalKey Model_id { get; set; }
		 public ExternalField Model_name { get; set; }
		 public string Asset_number { get; set; }
		 public Date Purchase_date { get; set; }
		 public Date End_of_warranty { get; set; }

		 //Methodes

	 } //end classPhysicalDevice
} //end namespace