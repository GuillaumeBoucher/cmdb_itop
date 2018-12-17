using cmdb;
using System;

namespace cmdb.datacenter_mgmt
{
	 public class Rack:PhysicalDevice
	 {

		 //Attributs

		 public int Nb_u { get; set; }
		 public LinkedSet Device_list { get; set; }
		 public LinkedSet Enclosure_list { get; set; }

		 //Methodes

	 } //end classRack
} //end namespace