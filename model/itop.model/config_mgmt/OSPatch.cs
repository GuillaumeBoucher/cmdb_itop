using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class OSPatch:Patch
	 {

		 //Attributs

		 public LinkedSetIndirect Functionalcis_list { get; set; }
		 public ExternalKey Osversion_id { get; set; }
		 public ExternalField Osversion_name { get; set; }

		 //Methodes

	 } //end classOSPatch
} //end namespace