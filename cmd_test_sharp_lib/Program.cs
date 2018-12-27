using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itop.lib;
using activedirectory.lib;

namespace cmd_test_sharp_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Initialisation _Init = new Initialisation();

            //Création des types de contacts (Interne / Prestataire / Fourniseur)
            _Init.TypoConfig_TypeDeContact();

            //Création des sites géographique ( Paris & CTA )
            _Init.Creation_Location();

            //Création des équipes ( Directions et Département )
            _Init.Creation_Team();

            _Init.Creation_Person();

            


            //   Response QueryStatus = new Response();
            //   Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");
            //  List<User> FindItems = Ws.Find<User>("SELECT User WHERE org_id = 4", out QueryStatus);


            //todo association Person / team

            //todo create User (aka Login as external user)

            //todo create user device

            //todo create server device


        }
    }
}
