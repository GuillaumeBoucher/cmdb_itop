using cmdb;
using System;

namespace cmdb.service_mgmt
{
	 public class Contract:cmdbAbstractObject
	 {

		 //Attributs

		 public string Name { get; set; }
		 public ExternalKey Org_id { get; set; }
		 public ExternalField Organization_name { get; set; }
		 public LinkedSetIndirect Contacts_list { get; set; }
		 public LinkedSetIndirect Documents_list { get; set; }
		 public Text Description { get; set; }
		 public Date Start_date { get; set; }
		 public Date End_date { get; set; }
		 public string Cost { get; set; }
		 public Enum Cost_currency { get; set; }
		 public ExternalKey Contracttype_id { get; set; }
		 public ExternalField Contracttype_name { get; set; }
		 public string Billing_frequency { get; set; }
		 public string Cost_unit { get; set; }
		 public ExternalKey Provider_id { get; set; }
		 public ExternalField Provider_name { get; set; }
		 public Enum Status { get; set; }

		 //Methodes

		 public void PrefillSearchForm()
		 {
			 // 
			 // public function PrefillSearchForm(&$aContextParam)
			 // {
			 // if($aContextParam['dest_class'] == 'Service' || is_subclass_of($aContextParam['dest_class'], 'Service'))
			 // {
			 // if(MetaModel::IsValidAttCode($aContextParam['dest_class'],'org_id') && !empty($aContextParam['source_obj']->Get('provider_id')))
			 // {
			 // $aContextParam['filter']->ResetCondition();
			 // $aContextParam['filter']->AddCondition('org_id', $aContextParam['source_obj']->Get('provider_id'));
			 // }
			 // }
			 // elseif (($aContextParam['dest_class'] == 'Contact' || is_subclass_of($aContextParam['dest_class'], 'Contact'))
			 // || ($aContextParam['dest_class'] == 'Document' || is_subclass_of($aContextParam['dest_class'], 'Document')))
			 // {
			 // if(MetaModel::IsValidAttCode($aContextParam['dest_class'],'org_id') && !empty($aContextParam['source_obj']->Get('provider_id')) && !empty($aContextParam['source_obj']->Get('org_id')))
			 // {
			 // $aContextParam['filter']->ResetCondition();
			 // $aOrgIds = array( $aContextParam['source_obj']->Get('provider_id'),
			 // $aContextParam['source_obj']->Get('org_id'));
			 // $aContextParam['filter']->AddCondition('org_id', $aOrgIds , 'IN');
			 // }
			 // }
			 // }
			 // 
		 }
	 } //end classContract
} //end namespace