using System;
using System.Collections.Generic;

namespace itop.lib
{
	 public class Contact              //:cmdbAbstractObject supression de cette class a vérifier
	 {

		 //Attributs

		 public string name { get; set; }
		 public string status { get; set; } // Enum class par default itop  valuer actif | inactif
        public int org_id { get; set; } //ExternalKey
        public string org_name { get; } //ExternalField
        public string email { get; set; } //EmailAddress
        public string phone { get; set; } //PhoneNumber
        public string notify { get; set; } //Enum
        public string function { get; set; }
		public List<FunctionalCI> cis_list { get; set; }

		 //Methodes

	 } //end classContact
} //end namespace