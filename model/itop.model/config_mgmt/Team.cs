using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Team:Contact
	 {

		 //Attributs

		 public LinkedSetIndirect Persons_list { get; set; }
		 public LinkedSet Tickets_list { get; set; }

		 //Methodes

	 } //end classTeam
} //end namespace