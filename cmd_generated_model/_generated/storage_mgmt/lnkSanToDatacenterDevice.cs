using cmdb;
using System;

namespace cmdb.storage_mgmt
{
	 public class lnkSanToDatacenterDevice:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey San_id { get; set; }
		 public ExternalField San_name { get; set; }
		 public ExternalKey Datacenterdevice_id { get; set; }
		 public ExternalField Datacenterdevice_name { get; set; }
		 public string San_port { get; set; }
		 public string Datacenterdevice_port { get; set; }

		 //Methodes

	 } //end classlnkSanToDatacenterDevice
} //end namespace