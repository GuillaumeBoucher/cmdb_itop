using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class ServiceFamily:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Image Icon { get; set; }
		 public LinkedSet Services_list { get; set; }

		 //Methodes

	 } //end classServiceFamily
} //end namespace