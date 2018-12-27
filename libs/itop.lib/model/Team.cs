using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace itop.lib
{
	 public class Team:Contact
    {

        //Attributs

        public string team_id { get; set; }
        public string team_name { get; set; }
        public string role_id { get; set; }
        public string role_name { get; set; }
        public string friendlyname { get;  }
        public string team_id_friendlyname { get; set; }
        public string team_id_obsolescence_flag { get; set; }
        public string role_id_friendlyname { get; set; }

        public void Create(string nom, string email, string telephone, string fonction, out Response queryResult)
        {
            Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");

            Console.WriteLine("Add Team : {0} ({1})", nom, fonction);

            Response QueryStatus = new Response();            
            List<Team> FindItems = Ws.Find<Team>("SELECT Team WHERE name = \""+nom+"\" AND org_id=4", out QueryStatus);
            queryResult = QueryStatus;
            if (FindItems.Count == 0)
            {

                Team newItem = new Team();

                newItem.name = nom;
                newItem.email = email.ToLower();
                newItem.status = "active"; // active | inactive
                newItem.org_id = 4;
                newItem.phone = telephone;
                newItem.notify = "yes";   // yes | no
                newItem.function = fonction;

                Ws.Create<Team>(newItem, out QueryStatus);
            }
            else
            {
                QueryStatus.code = 999;
                QueryStatus.message = "Déja présent ?";
            }

        }
        
        public int GetID(string nom)
        {
            int _ret = 0;

            Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");
            Response QueryStatus = new Response();
                        
            List<Team> FindItem = Ws.Find<Team>("SELECT Team WHERE name = \"" + nom + "\" AND org_id=4", out QueryStatus);

            JObject jsonMessage = JObject.Parse(QueryStatus.message);
            JToken a = jsonMessage.GetValue("objects");
            a = a.First;
            a = a.First;
            string b = a.Path;
            _ret = Convert.ToInt32(b.Split(':')[2]);
            return _ret;
        }


    } //end classTeam
} //end namespace