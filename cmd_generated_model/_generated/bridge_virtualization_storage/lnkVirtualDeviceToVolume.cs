using cmdb;
using System;

namespace cmdb.bridge_virtualization_storage
{
	 public class lnkVirtualDeviceToVolume:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Volume_id { get; set; }
		 public ExternalField Volume_name { get; set; }
		 public ExternalKey Virtualdevice_id { get; set; }
		 public ExternalField Virtualdevice_name { get; set; }
		 public string Size_used { get; set; }

		 //Methodes

	 } //end classlnkVirtualDeviceToVolume
} //end namespace