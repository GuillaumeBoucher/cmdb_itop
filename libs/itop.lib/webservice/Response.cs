using System;
using System.Collections.Generic;
using System.Text;

namespace itop.lib
{

    public class Response
    {
        public int code { get; set; }
        public string message { get; set; }
        public string version { get; set; }
        public IList<Operation> operations { get; set; }



    }

    public class Operation
    {
        public string verb { get; set; }
        public string description { get; set; }
        public string extension { get; set; }

    }


}
