using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Person:Contact
	 {

		 //Attributs

		 public Image Picture { get; set; }
		 public string First_name { get; set; }
		 public string Employee_number { get; set; }
		 public PhoneNumber Mobile_phone { get; set; }
		 public ExternalKey Location_id { get; set; }
		 public ExternalField Location_name { get; set; }
		 public ExternalKey Manager_id { get; set; }
		 public ExternalField Manager_name { get; set; }
		 public LinkedSetIndirect Team_list { get; set; }
		 public LinkedSet Tickets_list { get; set; }

		 //Methodes

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