using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class DatacenterDevice:ConnectableCI
	 {

		 //Attributs

		 public ExternalKey Rack_id { get; set; }
		 public ExternalField Rack_name { get; set; }
		 public ExternalKey Enclosure_id { get; set; }
		 public ExternalField Enclosure_name { get; set; }
		 public int Nb_u { get; set; }
		 public IPAddress Managementip { get; set; }
		 public ExternalKey PowerA_id { get; set; }
		 public ExternalField PowerA_name { get; set; }
		 public ExternalKey PowerB_id { get; set; }
		 public ExternalField PowerB_name { get; set; }
		 public LinkedSet Fiberinterfacelist_list { get; set; }
		 public LinkedSetIndirect San_list { get; set; }
		 public RedundancySettings Redundancy { get; set; }

		 //Methodes

	 } //end classDatacenterDevice
} //end namespace