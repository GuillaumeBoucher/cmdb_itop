using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class IPInterface:NetworkInterface
	 {

		 //Attributs

		 public IPAddress Ipaddress { get; set; }
		 public string Macaddress { get; set; }
		 public Text Comment { get; set; }
		 public IPAddress Ipgateway { get; set; }
		 public IPAddress Ipmask { get; set; }
		 public Decimal Speed { get; set; }

		 //Methodes

	 } //end classIPInterface
} //end namespace