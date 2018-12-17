using System;
using System.Collections.Generic;
using System.Text;

namespace itop.lib
{
    public class AbstractObject
    {

        public string name { get; set; }
        public string status { get; set; } // active | inactive
        public int org_id { get; set; }
        public string org_name { get; set; }
    }
}
