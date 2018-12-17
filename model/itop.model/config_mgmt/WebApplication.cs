using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class WebApplication:FunctionalCI
	 {

		 //Attributs

		 public ExternalKey Webserver_id { get; set; }
		 public ExternalField Webserver_name { get; set; }
		 public URL Url { get; set; }

		 //Methodes

	 } //end classWebApplication
} //end namespace