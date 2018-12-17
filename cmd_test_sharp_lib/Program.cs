using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itop.lib;


namespace cmd_test_sharp_lib
{
    class Program
    {
        static void Main(string[] args)
        {

            Response QueryStatus = new Response();
            Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");
            List<User> FindItems = Ws.Find<User>("SELECT User WHERE org_id = 4", out QueryStatus);



            Initialisation _Init = new Initialisation();
            _Init.Creation_Location();
            _Init.Creation_Person();

            _Init.Creation_Team();

            //todo association Person / team

            //todo create User (aka Login as external user)

            //todo create user device

            //todo create server device


        }
    }
}
