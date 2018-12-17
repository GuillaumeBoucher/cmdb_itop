using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class lnkConnectableCIToNetworkDevice:cmdbAbstractObject
	 {

		 //Attributs

		 public ExternalKey Networkdevice_id { get; set; }
		 public ExternalField Networkdevice_name { get; set; }
		 public ExternalKey Connectableci_id { get; set; }
		 public ExternalField Connectableci_name { get; set; }
		 public string Network_port { get; set; }
		 public string Device_port { get; set; }
		 public Enum Connection_type { get; set; }

		 //Methodes

		 public void AddConnectedNetworkDevice()
		 {
			 // protected function AddConnectedNetworkDevice()
			 // {
			 // $oDevice = MetaModel::GetObject('ConnectableCI', $this->Get('connectableci_id'));
			 // if (is_object($oDevice) && (get_class($oDevice) == 'NetworkDevice'))
			 // {
			 // $sOQL = "SELECT  lnkConnectableCIToNetworkDevice WHERE connectableci_id = :device AND networkdevice_id = :network AND network_port = :nwport AND device_port = :devport";
			 // $oConnectionSet = new DBObjectSet(DBObjectSearch::FromOQL($sOQL),
			 // array(),
			 // array(
			 // 'network' => $this->Get('connectableci_id'),
			 // 'device' => $this->Get('networkdevice_id'),
			 // 'devport' => $this->Get('network_port'),
			 // 'nwport' => $this->Get('device_port'),
			 // )
			 // );
			 // if ($oConnectionSet->Count() == 0)
			 // {
			 // $sLink = $this->Get('connection_type');
			 // $sConnLink = ($sLink == 'uplink') ? 'downlink' : 'uplink';
			 // 
			 // $oNewLink = new lnkConnectableCIToNetworkDevice();
			 // $oNewLink->Set('networkdevice_id', $this->Get('connectableci_id'));
			 // $oNewLink->Set('connectableci_id', $this->Get('networkdevice_id'));
			 // $oNewLink->Set('network_port', $this->Get('device_port'));
			 // $oNewLink->Set('device_port', $this->Get('network_port'));
			 // $oNewLink->Set('connection_type', $sConnLink);
			 // $oNewLink->DBInsert();
			 // }
			 // }
			 // }
		 }
		 public void UpdateConnectedNetworkDevice()
		 {
			 // protected function UpdateConnectedNetworkDevice()
			 // {
			 // $oDevice = MetaModel::GetObject('ConnectableCI', $this->Get('connectableci_id'));
			 // if (is_object($oDevice) && (get_class($oDevice) == 'NetworkDevice'))
			 // {
			 // // Note: in case a port has been changed, search with the original values
			 // $sOQL = "SELECT  lnkConnectableCIToNetworkDevice WHERE connectableci_id = :device AND networkdevice_id = :network AND network_port = :nwport AND device_port = :devport";
			 // $oConnectionSet = new DBObjectSet(DBObjectSearch::FromOQL($sOQL),
			 // array(),
			 // array(
			 // 'network' => $this->Get('connectableci_id'),
			 // 'device' => $this->Get('networkdevice_id'),
			 // 'devport' => $this->GetOriginal('network_port'),
			 // 'nwport' => $this->GetOriginal('device_port'),
			 // )
			 // );
			 // $sLink = $this->Get('connection_type');
			 // $sConnLink = ($sLink == 'uplink') ? 'downlink' : 'uplink';
			 // 
			 // // There should be one link - do it in a safe manner anyway
			 // while ($oConnection = $oConnectionSet->Fetch())
			 // {
			 // $oConnection->Set('connection_type', $sConnLink);
			 // $oConnection->Set('network_port', $this->Get('device_port'));
			 // $oConnection->Set('device_port', $this->Get('network_port'));
			 // $oConnection->DBUpdate();
			 // }
			 // }
			 // }
		 }
		 public void DeleteConnectedNetworkDevice()
		 {
			 // protected function DeleteConnectedNetworkDevice()
			 // {
			 // // The device might be already deleted (reentrance in the current procedure when both device are NETWORK devices!)
			 // $oDevice = MetaModel::GetObject('ConnectableCI', $this->Get('connectableci_id'), false);
			 // if (is_object($oDevice) && (get_class($oDevice) == 'NetworkDevice'))
			 // {
			 // // Track and delete the counterpart link
			 // $sOQL = "SELECT  lnkConnectableCIToNetworkDevice WHERE connectableci_id = :device AND networkdevice_id = :network AND network_port = :nwport AND device_port = :devport";
			 // $oConnectionSet = new DBObjectSet(DBObjectSearch::FromOQL($sOQL),
			 // array(),
			 // array(
			 // 'network' => $this->Get('connectableci_id'),
			 // 'device' => $this->Get('networkdevice_id'),
			 // 'devport' => $this->Get('network_port'),
			 // 'nwport' => $this->Get('device_port'),
			 // )
			 // );
			 // // There should be one link - do it in a safe manner anyway
			 // while ($oConnection = $oConnectionSet->Fetch())
			 // {
			 // $oConnection->DBDelete();
			 // }
			 // }
			 // }
		 }
		 public void AfterInsert()
		 {
			 // protected function AfterInsert()
			 // {
			 // $this->AddConnectedNetworkDevice();
			 // parent::AfterInsert();
			 // }
		 }
		 public void AfterUpdate()
		 {
			 // protected function AfterUpdate()
			 // {
			 // $this->UpdateConnectedNetworkDevice();
			 // parent::AfterUpdate();
			 // }
		 }
		 public void AfterDelete()
		 {
			 // protected function AfterDelete()
			 // {
			 // $this->DeleteConnectedNetworkDevice();
			 // parent::AfterDelete();
			 // }
		 }
	 } //end classlnkConnectableCIToNetworkDevice
} //end namespace