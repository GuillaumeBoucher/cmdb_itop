using System;
using System.Collections.Generic;

namespace itop.lib
{
	 public class Person:Contact
	 {

		 //Attributs

		 public Picture picture { get; set; } //v�rifier si un type image n'est pas mieux
		 public string first_name { get; set; }
		 public string employee_number { get; set; }
		 public string mobile_phone { get; set; } //PhoneNumber
        public int location_id { get; set; } // ExternalKey
        public string location_name { get;  } //ExternalField
        public int manager_id { get; set; } // ExternalKey
        public string manager_name { get; set; } // ExternalField
        public List<Team> team_list { get; set; }
		public List<Ticket> tickets_list { get; set; }

        //Methodes

        public void Create(string nom,string prenom,string email,string fonction,out Response QueryResult )
        {

            QueryResult = new Response();

            Webservice Ws = new Webservice("http://cmdb/itop2/webservices/rest.php?version=1.3", "admin", "itop");

            Response QueryStatus = new Response();
            //todo add email as key ?
            List<Person> ListFindPerson = Ws.Find<Person>("SELECT Person WHERE name ='"+nom+"'", out QueryStatus);

            if(ListFindPerson.Count == 0)
            {
                Person newPerson = new Person();
                newPerson.name = nom.ToUpper();
                newPerson.first_name = new System.Globalization.CultureInfo("FR-fr", false).TextInfo.ToTitleCase(prenom.ToLower());
                newPerson.email = email.ToLower();
                
                newPerson.function = new System.Globalization.CultureInfo("FR-fr", false).TextInfo.ToTitleCase(fonction.ToLower());
                newPerson.org_id = 4;
                newPerson.status = "active";

                Ws.Create<Person>(newPerson, out QueryResult);
                
            }
            else
            {
                QueryStatus.code = 999;
                QueryStatus.message = "D�ja pr�sent ?";
            }

        }


            public void CheckToDelete()
		 {
			 // public function CheckToDelete(&$oDeletionPlan)
			 // {
			 // if (MetaModel::GetConfig()->Get('demo_mode'))
			 // {
			 // if ($this->HasUserAccount())
			 // {
			 // // Do not let users change user accounts in demo mode
			 // $oDeletionPlan->AddToDelete($this, null);
			 // $oDeletionPlan->SetDeletionIssues($this, array('deletion not allowed in demo mode.'), true);
			 // $oDeletionPlan->ComputeResults();
			 // return false;
			 // }
			 // }
			 // return parent::CheckToDelete($oDeletionPlan);
			 // }
			 // 
		 }
		 public void DBDeleteSingleObject()
		 {
			 // public function DBDeleteSingleObject()
			 // {
			 // if (MetaModel::GetConfig()->Get('demo_mode'))
			 // {
			 // if ($this->HasUserAccount())
			 // {
			 // // Do not let users change user accounts in demo mode
			 // return;
			 // }
			 // }
			 // parent::DBDeleteSingleObject();
			 // }
			 // 
		 }
		 public void GetAttributeFlags()
		 {
			 // public function GetAttributeFlags($sAttCode, &$aReasons = array(), $sTargetState = '')
			 // {
			 // if ( ($sAttCode == 'org_id') && (!$this->IsNew()) )
			 // {
			 // if (MetaModel::GetConfig()->Get('demo_mode'))
			 // {
			 // if ($this->HasUserAccount())
			 // {
			 // // Do not let users change user accounts in demo mode
			 // return OPT_ATT_READONLY;
			 // }
			 // }
			 // }
			 // return parent::GetAttributeFlags($sAttCode, $aReasons, $sTargetState);
			 // }
			 // 
		 }
		 public void HasUserAccount()
		 {
			 // public function HasUserAccount()
			 // {
			 // static $bHasUserAccount = null;
			 // if (is_null($bHasUserAccount))
			 // {
			 // $oUserSet = new DBObjectSet(DBSearch::FromOQL('SELECT User WHERE contactid = :person', array('person' => $this->GetKey())));
			 // $bHasUserAccount = ($oUserSet->Count() > 0);
			 // }
			 // return $bHasUserAccount;
			 // }
			 // 
		 }
	 } //end classPerson
} //end namespace