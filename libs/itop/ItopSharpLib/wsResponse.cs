using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItopSharpLib
{

        //{"code":3,"message":"Error: Missing parameter 'json_data"}

        // {"objects":{"UserRequest::1":{"code":0,"message":"created","class":"UserRequest","key":"1","fields":{"id":"1","friendlyname":"R-000001"}}},"code":0,"message":null}

        // {"objects":{"Person::1":{"code":0,"message":"","class":"Person","key":"1","fields":{"name":"My last name","status":"active","org_id":"1","org_name":"My Company\/Department","email":"my.email@foo.org","phone":"+00 000 000 000","notify":"yes","function":"","cis_list":[],"picture":{"data":"","mimetype":"","filename":""},"first_name":"My first name","employee_number":"","mobile_phone":"","location_id":"0","location_name":"","manager_id":"0","manager_name":"","team_list":[],"tickets_list":[],"finalclass":"Person","friendlyname":"My first name My last name","obsolescence_flag":false,"obsolescence_date":"","org_id_friendlyname":"My Company\/Department","org_id_obsolescence_flag":"","location_id_friendlyname":"","location_id_obsolescence_flag":"","manager_id_friendlyname":" ","manager_id_obsolescence_flag":""}}},"code":0,"message":"Found: 1"}

        public class wsResponse
        {
            public int code { get; set; }
            public string message { get; set; }
            public string version { get; set; }
            public IList<Operation> operations { get; set; }
        
            
            
        }

        public class Operation
        {
            public string verb { get; set; }
            public string description { get; set; }
            public string extension { get; set; }

        }


}
