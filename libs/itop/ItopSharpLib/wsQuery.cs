using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItopSharpLib
{
    

        public class wsQuery
        {
            public string operation { get; set; }
            public string comment { get; set; }
            public string @class { get; set; }
            public string key { get; set; }
            public string output_fields { get; set; }

            public Fields fields { get; set; }
        }

        public class Fields
        {
            public string org_id { get; set; }
            public Caller_id caller_id { get; set; }
            public string title { get; set; }
            public string description { get; set; }


        }

        public class Caller_id
        {
            public string name { get; set; }
            public string first_name { get; set; }
        }


    
}
