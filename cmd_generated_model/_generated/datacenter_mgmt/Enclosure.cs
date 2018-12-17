using cmdb;
using System;

namespace cmdb.datacenter_mgmt
{
	 public class Enclosure:PhysicalDevice
	 {

		 //Attributs

		 public ExternalKey Rack_id { get; set; }
		 public ExternalField Rack_name { get; set; }
		 public int Nb_u { get; set; }
		 public LinkedSet Device_list { get; set; }

		 //Methodes

	 } //end classEnclosure
} //end namespace