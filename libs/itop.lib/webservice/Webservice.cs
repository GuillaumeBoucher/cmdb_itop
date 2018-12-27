using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace itop.lib
{
    public class Webservice
    {
        private string _url { get; set; }
        private string _user { get; set; }
        private string _pwd { get; set; }
        private string _operation { get; set; }
        private string _class_name { get; set; }
        private string _key { get; set; }
        private string _query { get; set; }
        private string _comment { get; set; }
        private string _output_fields { get; set; }
        private string _fields { get; set; }


        
            

        public Webservice(string url,string user,string pwd)
        {
            this._url = url;
            this._user = user;
            this._pwd = pwd;
        }

        public void Create<T>(T p, out Response QueryStatus)
        {

            this._class_name = typeof(T).Name;      //reflexion get class name

            this._comment = string.Format("xxCreate {0}", this._class_name);

            this._operation = "core/create";

            //   this._output_fields = "id, friendlyname";
            this._output_fields = "*";

            //on ne prends pas en compte les object null !
            this._fields = JsonConvert.SerializeObject(p,Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

            
            this._query = PrepareQuery();

            string result = ExecuteQuery();
            QueryStatus = JsonConvert.DeserializeObject<Response>(result);
            QueryStatus.message = result;
          
        }

    

        public List<T> Find<T>(string Key,out Response QueryStatus)
        {

            List<T> _ret = new List<T>();

            this._comment = null;
            this._output_fields = null;
            this._fields = null;
            

            this._key = Key;            
            this._class_name =  typeof(T).Name;      //reflexion get class name

            this._operation = "core/get";
            this._query = PrepareQuery();

            string result = ExecuteQuery();
            QueryStatus = JsonConvert.DeserializeObject<Response>(result);
            QueryStatus.message = result;
            if (QueryStatus.code == 0)
            {
                List<string> res =  ParseQuery(result);
                foreach(string s in res)
                {                    
                    T instance = JsonConvert.DeserializeObject<T>(s);
                    _ret.Add(instance);
                }                
            }
            else
            {
                //todo gestion des erreurs ?
            }            
            
            return _ret;
        }

        private List<string> ParseQuery(string data)
        {

            List<string> _ret = new List<string>();

            JObject o = JObject.Parse(data);
            IEnumerable<JToken> fields = o.SelectTokens("$..fields");
            foreach(JToken field in fields)
            {

                string string_item = field.ToString();
                _ret.Add(string_item);
            //    int aaaaaa = 1;

                //    JToken name = field.SelectToken("name");



                //    JToken org_id = field.SelectToken("org_id");

            }



            //IDictionary<string, JToken> Jsondata = JObject.Parse(data);

            //JToken objects = Jsondata["objects"];



            //var b = a.Values();


            //foreach (KeyValuePair<string, JToken> element in Jsondata)
            //{
            //    string innerKey = (element.Key).ToLower();
            //    if (innerKey == "objects")
            //    {
            //        string data2 = element.Value.ToString();
            //        ParseQuery(data2);
            //    }
            //    else
            //    {
            //        if(innerKey.Contains(":"))
            //        {
            //            string[] InstanceClass =   innerKey.Split(':');
            //            string _obj_ClassName = InstanceClass[0];
            //            string _obj_Id = InstanceClass[2];

            //            if (element.Value is JArray)
            //            {
            //                // Process JArray
            //            }
            //            else if (element.Value is JObject)
            //            {

            //            }


            //            }
            //    }


            //    if (element.Value is JArray)
            //    {
            //        // Process JArray
            //    }
            //    else if (element.Value is JObject)
            //    {
            //        // Process JObject
            //        if (innerKey == "objects")
            //        {
            //            string data2 = element.Value.ToString();

            //        }
            //    }
            //}
            return _ret;
        }

        private string PrepareQuery()
        {
            string _ret = "";

            Query json_query = new Query();
            json_query.operation = this._operation;
            json_query.@class = this._class_name;
            json_query.output_fields = this._output_fields;
            if (this._operation == "core/get")
            {
                json_query.key = this._key;
                _ret = JsonConvert.SerializeObject(json_query);

            }
            if (this._operation == "core/create")
            {
                json_query.comment = this._comment;
                
                _ret = JsonConvert.SerializeObject(json_query);

                //https://stackoverflow.com/questions/42531258/i-want-to-add-value-to-existing-json-without-double-quotes

                JObject rss = JObject.Parse(_ret);
                rss.Property("key").Remove();
                rss.Property("fields").Remove();
                JProperty fields_propery = new JProperty("fields", JObject.Parse(this._fields));

                rss.Property("output_fields").AddAfterSelf(fields_propery);
                _ret = rss.Root.ToString();


            }




            return _ret;
        }

        private string ExecuteQuery()
        {
            string _ret = "";

            RestClient client = new RestClient();
            client.BaseUrl = new Uri(this._url);
            client.Authenticator = new HttpBasicAuthenticator(this._user,this._pwd);
            var request = new RestRequest(Method.POST);            
            request.AddParameter("auth_user", this._user);
            request.AddParameter("auth_pwd", this._pwd);

            request.AddParameter("json_data", this._query);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                _ret = response.Content;
            }
            else
            {
                //todo gestion des erreurs
                _ret = response.Content;
            }

            

            return _ret;


        }


        private string ExecuteQuery2(string version,string json_data)
        {
            string _ret = "";

            RestClient client = new RestClient();
            client.BaseUrl = new Uri(this._url);
            client.Authenticator = new HttpBasicAuthenticator(this._user, this._pwd);
            var request = new RestRequest(Method.POST);
            request.AddParameter("auth_user", this._user);
            request.AddParameter("auth_pwd", this._pwd);

            request.AddParameter("version", version);

            request.AddParameter("json_data", json_data);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                _ret = response.Content;
            }
            else
            {
                //todo gestion des erreurs
                _ret = response.Content;
            }



            return _ret;


        }
    }
}
