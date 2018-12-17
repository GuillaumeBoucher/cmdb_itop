using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class OSLicence:Licence
	 {

		 //Attributs

		 public ExternalKey Osversion_id { get; set; }
		 public ExternalField Osversion_name { get; set; }
		 public LinkedSet Virtualmachines_list { get; set; }
		 public LinkedSet Servers_list { get; set; }

		 //Methodes

	 } //end classOSLicence
} //end namespace