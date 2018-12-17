using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkPersonToTeam:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Team_id { get; set; }
		 public ExternalField Team_name { get; set; }
		 public ExternalKey Person_id { get; set; }
		 public ExternalField Person_name { get; set; }
		 public ExternalKey Role_id { get; set; }
		 public ExternalField Role_name { get; set; }

		 //Methodes

	 } //end classlnkPersonToTeam
} //end namespace