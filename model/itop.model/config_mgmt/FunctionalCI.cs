using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class FunctionalCI:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public Text Description { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Organization_name { get; set; }
		 public Enum Business_criticity { get; set; }
		 public Date Move2production { get; set; }
		 public LinkedSetIndirect Contacts_list { get; set; }
		 public LinkedSetIndirect Documents_list { get; set; }
		 public LinkedSetIndirect Applicationsolution_list { get; set; }
		 public LinkedSetIndirect Providercontracts_list { get; set; }
		 public LinkedSetIndirect Services_list { get; set; }
		 public LinkedSet Softwares_list { get; set; }
		 public LinkedSetIndirect Tickets_list { get; set; }

		 //Methodes

		 public void GetRelationQueries()
		 {
			 // public static function GetRelationQueries($sRelCode){return parent::GetRelationQueries($sRelCode);}
		 }
		 public void DisplayBareRelations()
		 {
			 // function DisplayBareRelations(WebPage $oPage, $bEditMode = false)
			 // {
			 // parent::DisplayBareRelations($oPage, $bEditMode);
			 // 
			 // $sTicketListAttCode = 'tickets_list';
			 // 
			 // if (MetaModel::IsValidAttCode(get_class($this), $sTicketListAttCode))
			 // {
			 // // Display one list per leaf class (the only way to display the status as of now)
			 // 
			 // $oAttDef = MetaModel::GetAttributeDef(get_class($this), $sTicketListAttCode);
			 // $sLnkClass = $oAttDef->GetLinkedClass();
			 // $sExtKeyToMe = $oAttDef->GetExtKeyToMe();
			 // $sExtKeyToRemote = $oAttDef->GetExtKeyToRemote();
			 // 
			 // $iTotal = 0;
			 // $aSearches = array();
			 // 
			 // foreach (MetaModel::EnumChildClasses('Ticket') as $sSubClass)
			 // {
			 // if (!MetaModel::HasChildrenClasses($sSubClass))
			 // {
			 // $sStateAttCode = MetaModel::GetStateAttributeCode($sSubClass);
			 // if ($sStateAttCode != '')
			 // {
			 // // Todo: base the search condition on operational_status = 'ongoing' for a more flexible behavior
			 // $oSearch = DBSearch::FromOQL("SELECT $sSubClass AS t JOIN $sLnkClass AS lnk ON lnk.$sExtKeyToRemote = t.id WHERE lnk.$sExtKeyToMe = :myself AND t.$sStateAttCode NOT IN ('rejected', 'resolved', 'closed') AND lnk.impact_code != 'not_impacted'", array('myself' => $this->GetKey()));
			 // $aSearches[$sSubClass] = $oSearch;
			 // 
			 // $oSet = new DBObjectSet($oSearch);
			 // $oSet->SetShowObsoleteData(utils::ShowObsoleteData());
			 // $iTotal += $oSet->Count();
			 // }
			 // }
			 // }
			 // 
			 // $sCount = ($iTotal > 0) ? ' ('.$iTotal.')' : '';
			 // $oPage->SetCurrentTab(Dict::S('Class:FunctionalCI/Tab:OpenedTickets').$sCount);
			 // 
			 // foreach ($aSearches as $sSubClass => $oSearch)
			 // {
			 // $sBlockId = __class__.'_opened_'.$sSubClass;
			 // 
			 // $oPage->add('<fieldset>');
			 // $oPage->add('<legend>'.MetaModel::GetName($sSubClass).'</legend>');
			 // $oBlock = new DisplayBlock($oSearch, 'list', false);
			 // $oBlock->Display($oPage, $sBlockId, array('menu' => false));
			 // $oPage->add('</fieldset>');
			 // }
			 // }
			 // }
		 }
	 } //end classFunctionalCI
} //end namespace