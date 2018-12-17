using cmdb;
using System;

namespace cmdb.datacenter_mgmt
{
	 public class PDU:PowerConnection
	 {

		 //Attributs

		 public ExternalKey Rack_id { get; set; }
		 public ExternalField Rack_name { get; set; }
		 public ExternalKey Powerstart_id { get; set; }
		 public ExternalField Powerstart_name { get; set; }

		 //Methodes

	 } //end classPDU
} //end namespace