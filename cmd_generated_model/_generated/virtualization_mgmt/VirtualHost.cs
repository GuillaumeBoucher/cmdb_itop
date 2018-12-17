using cmdb;
using System;

namespace cmdb.virtualization_mgmt
{
	 public class VirtualHost:VirtualDevice
	 {

		 //Attributs

		 public LinkedSet Virtualmachine_list { get; set; }

		 //Methodes

		 public void GetRelationQueries()
		 {
			 // public static function GetRelationQueries($sRelCode){return parent::GetRelationQueries($sRelCode);}
		 }
	 } //end classVirtualHost
} //end namespace