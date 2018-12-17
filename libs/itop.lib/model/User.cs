using System;
using System.Collections.Generic;
using System.Text;

namespace itop.lib
{
    public class User
    {

        public int contactid { get; set; }
        public string last_name { get; }
        public string first_name { get; set; }
        public string email { get; set; }
        public int org_id { get; set; }
        public string login { get; set; }
        public string language { get; set; }
        public string status { get; set; }
        //public string profile_list)  Objets liés(1-n) (AttributeLinkedSetIndirect) User
        //public string allowed_org_list)   Objets liés(1-n) (AttributeLinkedSetIndirect) User
        public string finalclass { get; } //(return "UserExternal") ??
        public string friendlyname { get; set; }
        public string contactid_friendlyname { get; set; }
        public string contactid_obsolescence_flag { get; set; }
        public string org_id_friendlyname { get; set; }
        public string org_id_obsolescence_flag { get; set; }

    }
}
