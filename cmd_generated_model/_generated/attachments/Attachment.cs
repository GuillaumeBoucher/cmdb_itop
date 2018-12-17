using cmdb;
using System;

namespace cmdb.attachments
{
	 public class Attachment:DBObject
	 {

		 //Attributs

		 public DateTime Expire { get; set; }
		 public string Temp_id { get; set; }
		 public string Item_class { get; set; }
		 public int Item_id { get; set; }
		 public int Item_org_id { get; set; }
		 public string Contents { get; set; }

		 //Methodes

		 public void MapContextParam()
		 {
			 // public static function MapContextParam($sContextParam)
			 // {
			 // if ($sContextParam == 'org_id')
			 // {
			 // return 'item_org_id';
			 // }
			 // else
			 // {
			 // return null;
			 // }
			 // }
		 }
		 public void SetItem()
		 {
			 // public function SetItem($oItem, $bUpdateOnChange = false)
			 // {
			 // $sClass = get_class($oItem);
			 // $iItemId = $oItem->GetKey();
			 // 
			 // $this->Set('item_class', $sClass);
			 // $this->Set('item_id', $iItemId);
			 // 
			 // $aCallSpec = array($sClass, 'MapContextParam');
			 // if (is_callable($aCallSpec))
			 // {
			 // $sAttCode = call_user_func($aCallSpec, 'org_id'); // Returns null when there is no mapping for this parameter
			 // if (MetaModel::IsValidAttCode($sClass, $sAttCode))
			 // {
			 // $iOrgId = $oItem->Get($sAttCode);
			 // if ($iOrgId > 0)
			 // {
			 // if ($iOrgId != $this->Get('item_org_id'))
			 // {
			 // $this->Set('item_org_id', $iOrgId);
			 // if ($bUpdateOnChange)
			 // {
			 // $this->DBUpdate();
			 // }
			 // }
			 // }
			 // }
			 // }
			 // }
		 }
		 public void SetDefaultOrgId()
		 {
			 // public function SetDefaultOrgId()
			 // {
			 // // First check that the organization CAN be fetched from the target class
			 // //
			 // $sClass = $this->Get('item_class');
			 // $aCallSpec = array($sClass, 'MapContextParam');
			 // if (is_callable($aCallSpec))
			 // {
			 // $sAttCode = call_user_func($aCallSpec, 'org_id'); // Returns null when there is no mapping for this parameter
			 // if (MetaModel::IsValidAttCode($sClass, $sAttCode))
			 // {
			 // // Second: check that the organization CAN be fetched from the current user
			 // //
			 // if (MetaModel::IsValidClass('Person'))
			 // {
			 // $aCallSpec = array($sClass, 'MapContextParam');
			 // if (is_callable($aCallSpec))
			 // {
			 // $sAttCode = call_user_func($aCallSpec, 'org_id'); // Returns null when there is no mapping for this parameter
			 // if (MetaModel::IsValidAttCode($sClass, $sAttCode))
			 // {
			 // // OK - try it
			 // //
			 // $oCurrentPerson = MetaModel::GetObject('Person', UserRights::GetContactId(), false);
			 // if ($oCurrentPerson)
			 // {
			 // $this->Set('item_org_id', $oCurrentPerson->Get($sAttCode));
			 // }
			 // }
			 // }
			 // }
			 // }
			 // }
			 // }
		 }
	 } //end classAttachment
} //end namespace