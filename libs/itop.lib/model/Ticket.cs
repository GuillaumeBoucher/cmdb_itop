using System;
using System.Collections.Generic;

namespace itop.lib
{
	 public class Ticket
    {

		 //Attributs
         
        public string operational_status { get; set; }
        public string @ref { get; set; }
        public int org_id { get; set; }
        public string org_name { get; set; }
        public int team_id { get; set; }
        public string team_name { get; set; }
        public int agent_id { get; set; }
        public string agent_name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string last_update { get; set; }
        public string close_date { get; set; }
        public Private_log private_log { get; set; }
        public List<Contact> contacts_list { get; set; }
        public List<FunctionalCI> functionalcis_list { get; set; }
        // "workorders_list": [],
        public string finalclass { get; set; }
        public string friendlyname { get; set; }
        public string org_id_friendlyname { get; set; }
        public string org_id_obsolescence_flag { get; set; }
        public string team_id_friendlyname { get; set; }
        public string team_id_obsolescence_flag { get; set; }
        public string agent_id_friendlyname { get; set; }
        public string agent_id_obsolescence_flag { get; set; }


		 //Methodes

	 } //end classTicket
} //end namespace