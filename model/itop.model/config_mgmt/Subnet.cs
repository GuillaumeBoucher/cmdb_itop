using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class Subnet:cmdbAbstractObject
	 {

		 //Attributs

		 public Text Description { get; set; }
		 public string Subnet_name { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Org_name { get; set; }
		 public IPAddress Ip { get; set; }
		 public IPAddress Ip_mask { get; set; }
		 public LinkedSetIndirect Vlans_list { get; set; }

		 //Methodes

		 public void DisplayBareRelations()
		 {
			 // function DisplayBareRelations(WebPage $oPage, $bEditMode = false)
			 // {
			 // parent::DisplayBareRelations($oPage, $bEditMode);
			 // 
			 // if (!$bEditMode)
			 // {
			 // $oPage->SetCurrentTab(Dict::S('Class:Subnet/Tab:IPUsage'));
			 // 
			 // $bit_ip = ip2long($this->Get('ip'));
			 // $bit_mask = ip2long($this->Get('ip_mask'));
			 // 
			 // $iIPMin = sprintf('%u', ($bit_ip & $bit_mask) | 1); // exclude the first one: identifies the subnet itself
			 // $iIPMax = sprintf('%u', (($bit_ip | (~$bit_mask))) & 0xfffffffe); // exclude the last one : broadcast address
			 // 
			 // $sIPMin = long2ip($iIPMin);
			 // $sIPMax = long2ip($iIPMax);
			 // 
			 // $oPage->p(Dict::Format('Class:Subnet/Tab:IPUsage-explain', $sIPMin, $sIPMax));
			 // 
			 // $oIfFilter = DBObjectSearch::FromOQL("SELECT IPInterface AS if WHERE INET_ATON(if.ipaddress) >= INET_ATON('$sIPMin') AND INET_ATON(if.ipaddress) <= INET_ATON('$sIPMax')");
			 // $oIfSet = new CMDBObjectSet($oIfFilter);
			 // $oBlock = new DisplayBlock($oIfFilter, 'list', false);
			 // $oBlock->Display($oPage, 'nwif', array('menu' => false));
			 // 
			 // $iCountUsed = $oIfSet->Count();
			 // $iCountRange = $iIPMax - $iIPMin; // On 32-bit systems the substraction will be computed using floats for values greater than PHP_MAX_INT;
			 // $iFreeCount =  $iCountRange - $iCountUsed;
			 // 
			 // $oPage->SetCurrentTab(Dict::S('Class:Subnet/Tab:FreeIPs'));
			 // $oPage->p(Dict::Format('Class:Subnet/Tab:FreeIPs-count', $iFreeCount));
			 // $oPage->p(Dict::S('Class:Subnet/Tab:FreeIPs-explain'));
			 // 
			 // $aUsedIPs = $oIfSet->GetColumnAsArray('ipaddress', false);
			 // $iAnIP = $iIPMin;
			 // $iFound = 0;
			 // while (($iFound < min($iFreeCount, 10)) && ($iAnIP <= $iIPMax))
			 // {
			 // $sAnIP = long2ip($iAnIP);
			 // if (!in_array($sAnIP, $aUsedIPs))
			 // {
			 // $iFound++;
			 // $oPage->p($sAnIP);
			 // }
			 // else
			 // {
			 // }
			 // $iAnIP++;
			 // }
			 // }
			 // }
		 }
	 } //end classSubnet
} //end namespace