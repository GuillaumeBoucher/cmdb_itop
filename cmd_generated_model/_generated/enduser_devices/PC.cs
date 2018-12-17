using cmdb;
using System;

namespace cmdb.enduser_devices
{
	 public class PC:ConnectableCI
	 {

		 //Attributs

		 public ExternalKey Osfamily_id { get; set; }
		 public ExternalField Osfamily_name { get; set; }
		 public ExternalKey Osversion_id { get; set; }
		 public ExternalField Osversion_name { get; set; }
		 public string Cpu { get; set; }
		 public string Ram { get; set; }
		 public Enum Type { get; set; }

		 //Methodes

	 } //end classPC
} //end namespace