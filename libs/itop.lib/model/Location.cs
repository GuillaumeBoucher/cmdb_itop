using System;
using System.Collections.Generic;

namespace itop.lib
{
	 public class Location:AbstractObject
	 {

		 //Attributs

		 public string address { get; set; }
		 public string postal_code { get; set; }
		 public string city { get; set; }
		 public string country { get; set; }
		 //public LinkedSet Physicaldevice_list { get; set; }
		 public List<Person> person_list { get; set; }

        //Methodes
        public void Create(string nom, string address, string code_postal, string ville, out Response QueryResult)
        {
            ville = ville.ToUpper();
            nom = nom.ToUpper();
            address = address.ToLower();

            Console.WriteLine("Add Location:{0}",nom);

            Response QueryStatus = new Response();

            Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");

            
            List<Location> FindItems = Ws.Find<Location>("SELECT Location WHERE name = '"+nom+"' AND org_id=4", out QueryStatus);
            QueryResult = QueryStatus;
            if (FindItems.Count == 0)
            {

                Location newSite = new Location();
                //Tél. : 01 40 58 34 33

                newSite.address = address;
                newSite.city = ville;
                newSite.country = "France";
                newSite.name = nom;
                newSite.org_id = 4;
                newSite.postal_code = postal_code;
                newSite.status = "active";
                Ws.Create<Location>(newSite, out QueryStatus);
            }            
            else
            {
                QueryStatus.code = 999;
                QueryStatus.message = "Déja présent ?";
            }

        }

    } //end classLocation
} //end namespace