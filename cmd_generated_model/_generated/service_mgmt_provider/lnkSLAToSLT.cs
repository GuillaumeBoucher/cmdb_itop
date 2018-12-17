using cmdb;
using System;

namespace cmdb.service_mgmt_provider
{
	 public class lnkSLAToSLT:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Sla_id { get; set; }
		 public ExternalField Sla_name { get; set; }
		 public ExternalKey Slt_id { get; set; }
		 public ExternalField Slt_name { get; set; }
		 public ExternalField Slt_metric { get; set; }
		 public ExternalField Slt_request_type { get; set; }
		 public ExternalField Slt_ticket_priority { get; set; }
		 public ExternalField Slt_value { get; set; }
		 public ExternalField Slt_value_unit { get; set; }

		 //Methodes

	 } //end classlnkSLAToSLT
} //end namespace