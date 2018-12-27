using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace itop.lib
{
    public class ContactType
    {
        
        public string name { get; set; }

        public void Create(string nom, out Response queryResult)
        {
            Console.WriteLine("Add ContactType:{0}", nom);

            Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");

            Response QueryStatus = new Response();
            List<ContactType> FindItems = Ws.Find<ContactType>("SELECT ContactType WHERE name='"+nom+"'", out QueryStatus);
            queryResult = QueryStatus;
            if (FindItems.Count == 0)
            {

                ContactType newItem = new ContactType();

                newItem.name = nom;
              
                Ws.Create<ContactType>(newItem, out QueryStatus);
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
                        
            List<ContactType> FindItems = Ws.Find<ContactType>("SELECT ContactType WHERE name='" + nom + "'", out QueryStatus);
            JObject jsonMessage = JObject.Parse(QueryStatus.message);
            JToken a = jsonMessage.GetValue("objects");
            a = a.First;
            a = a.First;
            string b = a.Path;
            _ret = Convert.ToInt32(b.Split(':')[2]);
            return _ret;
        }

    }
}
