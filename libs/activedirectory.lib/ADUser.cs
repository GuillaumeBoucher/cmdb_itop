using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Net;
using System.Text;

namespace activedirectory.lib
{
    /// <summary>
    /// Active Directory User.
    /// </summary>
    public class ADUser
    {


        #region Properties
        //public Boolean isNormalAccount { get; set; }
        //public Boolean AccoutIsLock { get; set; }
        //public Boolean isAccountExpire { get; set; }
        //public Boolean isAccountDisabled { get; set; }
        //public string nom { get; set; }
        //public string prenom { get; set; }
        //public string mail { get; set; }
        //public string tel { get; set; }
        //public string login { get; set; }
        //public string photo { get; set; }
        //public string thumbnailphoto { get; set; }
        //public Byte[] b_photo { get; set; }
        //public Byte[] b_thumbnailphoto { get; set; }
        //public DateTime whenchanged { get; set; }
        //public DateTime whencreated { get; set; }
        //public Int32 admincount { get; set; }
        //public Int32 badpwdcount { get; set; }
        //public Int32 logoncount { get; set; }
        //public DateTime accountexpires { get; set; }
        //public Int64 badpasswordtime { get; set; }
        //public Int64 lastlogoff { get; set; }
        //public DateTime lastlogon { get; set; }
        //public DateTime lastlogontimestamp { get; set; }
        //public Int64 lockouttime { get; set; }
        //public DateTime pwdlastset { get; set; }
        //public List<String> memberof { get; set; }
        //public String adspath { get; set; }
        //public String adspath_file { get; set; }
        //public String altrecipient { get; set; }
        //public String cn { get; set; }
        //public String comment { get; set; }
        //public String company { get; set; }
        //public String department { get; set; }
        //public String description { get; set; }
        //public String displayname { get; set; }
        //public String displaynameprintable { get; set; }
        ////     public String distinguishedname { get; set; }
        //public String extensionattribute1 { get; set; }
        //public String facsimiletelephonenumber { get; set; }
        //public String givenname { get; set; }
        //public String homemdb { get; set; }
        ////public String homemta { get; set; }
        //public String info { get; set; }
        //public String initials { get; set; }
        //public String ipphone { get; set; }
        ////  public String legacyexchangedn { get; set; }        
        //public String mailnickname { get; set; }
        //public String manager { get; set; }
        //public String name { get; set; }
        //public String objectcategory { get; set; }
        //public String physicaldeliveryofficename { get; set; }
        //public String postalcode { get; set; }
        //public String postofficebox { get; set; }
        //public String samaccountname { get; set; }
        //public String streetaddress { get; set; }
        //public String targetaddress { get; set; }
        //public String title { get; set; }
        //public String userparameters { get; set; }
        //public String userprincipalname { get; set; }
        //public String wwwhomepage { get; set; }
        //public String sn { get; set; }
        //public String l { get; set; }
        //public String telephonenumber { get; set; }



        public string CN { get; set; }        
        public string SamAcountName { get; set; }        
        public string mail { get; set; }
        public string telephoneNumber { get; set; }
        public string departement { get; set; }
        public string title { get; set; }


        public static string OuArrayToString(string[] data)
        {
            string _ret = "";

            foreach(string s in data)
            {
                _ret = _ret + "," + s;
            }
            return _ret;            
        }

        public static List<string> GetDirection()
        {
            // Get 1er niveau ou par rapport a siege
            List<string> OuPremierNiveau = new List<string>();
            var OUs = ADUser.GetOU("LDAP://OU=Siege,DC=csa,DC=lan");
            foreach (string _curentOU in OUs)
            {
                string[] OUpath = ADUser.OuToArray(_curentOU);

                if (OUpath.Length == 4)
                {
                    string OuName = OUpath[0];
                    OuName = OuName.Split('=')[1];
                    if (OuName.StartsWith("direction") || OuName.StartsWith("presidence"))
                    {
                        OuPremierNiveau.Add(OuName);
                    }
                }
            }
            return OuPremierNiveau;
        }


        public static List<string> GetDepartements(string direction)
        {
            // Get 1er niveau ou par rapport a siege
            List<string> OuPremierNiveau = new List<string>();            
            var Departements = ADUser.GetOU("LDAP://OU=" + direction + ",OU=Siege,DC=csa,DC=lan");

            foreach (string _curentOU in Departements)
            {
                string[] OUpath = ADUser.OuToArray(_curentOU);

                if (OUpath.Length == 5)
                {
                    string OuName = OUpath[0];
                    OuName = OuName.Split('=')[1];
                    if (OuName.StartsWith("département") || OuName.StartsWith("departement"))
                    {
                        OuPremierNiveau.Add(OuName);
                    }
                }
            }
            return OuPremierNiveau;
        }




        public static string[] OuToArray(string data)
        {
            string[] _ret = data.Split(',');
            return _ret;
        }



        #endregion
        public static List<string> GetOU(string domain)
        {
            List<string> orgUnits = new List<string>();
            DirectoryEntry startingPoint = new DirectoryEntry(domain);

            DirectorySearcher searcher = new DirectorySearcher(startingPoint);
            searcher.SearchScope = SearchScope.OneLevel;
            searcher.Filter = "(objectCategory=organizationalUnit)";
            foreach (SearchResult res in searcher.FindAll()) 
            {
                orgUnits.Add(res.Path.ToLower());
            }

            orgUnits.Sort();
            return orgUnits;
        }



    /// <summary>
    /// Gets all users of a given domain.
    /// </summary>
    /// <param name="domain">Domain to query. Should be given in the form ldap://domain.com/ </param>
    /// <returns>A list of users.</returns>
    public static List<ADUser> GetUsers(string domain)
        {
            List<ADUser> users = new List<ADUser>();

            

            using (DirectoryEntry searchRoot = new DirectoryEntry(domain))
            using (DirectorySearcher directorySearcher = new DirectorySearcher(searchRoot))
            {

                // Set the filter
                directorySearcher.SearchScope = SearchScope.OneLevel;
                directorySearcher.Filter = "(&(objectCategory=person)(objectClass=user))";

                // Set the properties to load.
                directorySearcher.PropertiesToLoad.Add("CN");
                directorySearcher.PropertiesToLoad.Add("sAMAccountName");
                directorySearcher.PropertiesToLoad.Add("displayname");
                directorySearcher.PropertiesToLoad.Add("mail");
                directorySearcher.PropertiesToLoad.Add("telephoneNumber");
                directorySearcher.PropertiesToLoad.Add("department");
                directorySearcher.PropertiesToLoad.Add("title");


                try
                {

                    using (SearchResultCollection searchResultCollection = directorySearcher.FindAll())
                    {
                        foreach (SearchResult searchResult in searchResultCollection)
                        {
                            // Create new ADUser instance
                            var user = new ADUser();

                            // Set CN if available.
                            if (searchResult.Properties["CN"].Count > 0)
                                user.CN = searchResult.Properties["CN"][0].ToString();

                            // Set sAMAccountName if available
                            if (searchResult.Properties["sAMAccountName"].Count > 0)
                                user.SamAcountName = searchResult.Properties["sAMAccountName"][0].ToString();

                            if (searchResult.Properties["mail"].Count > 0)
                                user.mail = searchResult.Properties["mail"][0].ToString();

                            if (searchResult.Properties["telephoneNumber"].Count > 0)
                                user.telephoneNumber = searchResult.Properties["telephoneNumber"][0].ToString();

                            if (searchResult.Properties["title"].Count > 0)
                                user.title = searchResult.Properties["department"][0].ToString();

                            if (searchResult.Properties["department"].Count > 0)
                                user.departement = searchResult.Properties["department"][0].ToString();

                          
                            // Add user to users list.
                            if((user.mail != null) && (user.telephoneNumber != null))
                            {
                                //if(user.SamAcountName == "massonneau_n")
                                //{
                                //    int a = 1;
                                //}

                                if(user.SamAcountName != "STAGIAIRE_S")
                                { 
                                    users.Add(user);
                                }
                            }                            
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }

            // Return all found users.
            return users;
        }



        //public void GetAllProperty()
        //{
        //    List<String> properties = new List<String>();
        //    IPAddress[] ips = Dns.GetHostAddresses("ldap.csa.lan").Where(w => w.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToArray();
        //    if (ips.Length > 0)
        //    {
        //        DirectoryContext directoryContext = new DirectoryContext(DirectoryContextType.DirectoryServer, ips[0].ToString() + ":389", "adm_boucher", "lnaf82gaz!");
        //        ActiveDirectorySchema adschema = ActiveDirectorySchema.GetSchema(directoryContext);
        //        ActiveDirectorySchemaClass adschemaclass = adschema.FindClass("User");

        //        // Read the OptionalProperties & MandatoryProperties
        //        ReadOnlyActiveDirectorySchemaPropertyCollection propcol = adschemaclass.GetAllProperties();

        //        foreach (ActiveDirectorySchemaProperty schemaProperty in propcol)
        //            properties.Add(schemaProperty.Name.ToLower());
        //    }
        //}

    }
}
