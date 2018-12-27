using System;
using System.Collections.Generic;
using System.Text;

namespace itop.lib
{
    public class lnkPersonToTeam
    {
        public int team_id { get; set; }
        public string team_name { get; set; }
        public int person_id { get; set; }
        public string person_name { get; set; }
        public int role_id { get; set; }
        public string role_name { get; set; }


        public void Create(int Person_id, int Team_id, int Role_id, out Response queryResult)
        {
            Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");

            Console.WriteLine("Add lnkPersonToTeam ");

            Response QueryStatus = new Response();
            string query = "SELECT lnkPersonToTeam WHERE person_id="+ Person_id +" AND team_id="+Team_id+" AND role_id="+Role_id;
            List<lnkPersonToTeam> FindItems = Ws.Find<lnkPersonToTeam>(query, out QueryStatus);
            queryResult = QueryStatus;
            if (FindItems.Count == 0)
            {

                lnkPersonToTeam newItem = new lnkPersonToTeam();

                newItem.person_id = Person_id;
                newItem.role_id = Role_id;
                newItem.team_id = Team_id;
               
                Ws.Create<lnkPersonToTeam>(newItem, out QueryStatus);
            }
            else
            {
                QueryStatus.code = 999;
                QueryStatus.message = "Déja présent ?";
            }

        }

    }
}
