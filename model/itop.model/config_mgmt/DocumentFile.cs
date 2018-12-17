using cmdb;
using System;

namespace cmdb.config_mgmt
{
	 public class DocumentFile:Document
	 {

		 //Attributs

		 public string File { get; set; }

		 //Methodes

		 public void DisplayBareRelations()
		 {
			 // public function DisplayBareProperties(WebPage $oPage, $bEditMode = false, $sPrefix = '', $aExtraParams = array())
			 // {
			 // $aFieldsMap = parent::DisplayBareProperties($oPage, $bEditMode, $sPrefix, $aExtraParams);
			 // if (!$bEditMode)
			 // {
			 // $oPage->add('<fieldset>');
			 // $oPage->add('<legend>'.Dict::S('Class:Document:PreviewTab').'</legend>');
			 // $oPage->add($this->DisplayDocumentInline($oPage, 'file'));
			 // $oPage->add('</fieldset>');
			 // }
			 // return $aFieldsMap;
			 // }
		 }
	 } //end classDocumentFile
} //end namespace