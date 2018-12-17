using cmdb;
using System;

namespace cmdb.storage_mgmt
{
	 public class FiberChannelInterface:NetworkInterface
	 {

		 //Attributs

		 public Decimal Speed { get; set; }
		 public string Topology { get; set; }
		 public string Wwn { get; set; }
		 public ExternalKey Datacenterdevice_id { get; set; }
		 public ExternalField Datacenterdevice_name { get; set; }

		 //Methodes

	 } //end classFiberChannelInterface
} //end namespace