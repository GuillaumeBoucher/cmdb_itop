using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using activedirectory.lib;
using itop.lib;

using Newtonsoft.Json;
using ServiceStack.Text;

namespace cmd_test_sharp_lib
{
    public class Initialisation
    {
        //Constructeur
        public Initialisation()
        {

        }

        internal void TypoConfig_TypeDeContact()
        {
            //Création des types de contacts (Interne / Prestataire / Fourniseur)
            ContactType _ContactType = new ContactType();
            Response QueryResult = new Response();

            _ContactType.Create("Interne", out QueryResult);
            _ContactType.Create("Externe", out QueryResult);
            _ContactType.Create("Fournisseur", out QueryResult);
            Console.WriteLine("");
        }

        internal void Creation_Location()
        {
            Location loc = new Location();
            Response QueryResult = new Response();
            loc.Create("PARIS", "Tour Mirabeau 39-43, Quai André Citroën", "75739", "PARIS", out QueryResult);
            loc.Create("BORDEAUX", "16 rue Montesquieu", "33000", "BORDEAUX", out QueryResult);

            loc.Create("MARTINIQUE", "Centre d'affaires Beterbat Angle de la rue Victor Lamon et de la route du Stade Place d'armes", "97232", "Le Lamentin-Martinique", out QueryResult);
            loc.Create("CAEN", "15 rue Saint-Ouen", "14000", "CAEN", out QueryResult);
            loc.Create("Clermont", "69, rue Anatole France", "63000", "Clermont-Ferrand", out QueryResult);
            loc.Create("Dijon", "33 ter rue Diderot", "21000", "Dijon", out QueryResult);
            loc.Create("LAREUNION", "Immeuble Darwin 4 rue Emile Hugot CS 60584", "97495", "Sainte-Clotilde", out QueryResult);
            loc.Create("Lille", "2 rue du Priez", "59000", "Lille", out QueryResult);
            loc.Create("LYON", "Préfecture du Rhône 106, rue Pierre Corneille", "69419", "LYON", out QueryResult);
            loc.Create("MARSEILLE", "3 rue de la République", "13002", "MARSEILLE", out QueryResult);
            loc.Create("NANCY", "12, avenue du XXe Corps", "54000", "NANCY", out QueryResult);
            loc.Create("Nouméa", "1 rue du Contre-amiral Joseph-Bouzet", "98845", "Nouméa", out QueryResult);
            loc.Create("Poitiers", "2 rue Thibaudeau", "86000", "POITIERS", out QueryResult);
            loc.Create("Papeete", "Immeuble Charles Lévy Boulevard Pomaré BP 20659", "98713", "Papeete Polynésie", out QueryResult);
            loc.Create("Rennes", "1 rue Raoul Ponchon Centre d'affaires Oberthur", "35000", "RENNES", out QueryResult);
            loc.Create("Toulouse", "Hôtel des Chevaliers de Saint-Jean de Jérusalem 32 rue de la Dalbade", "31000", "TOULOUSE", out QueryResult);
            Console.WriteLine("");

        }

        internal void Creation_Team()
        {
            List<string> DirectionCSA = ADUser.GetDirection();
            foreach (string Direction in DirectionCSA)
            {
                Team _team1 = new Team();
                Response QueryResult1 = new Response();
                _team1.Create(Direction, "", "", "Direction", out QueryResult1);

                List<string> DepartementCSA = ADUser.GetDepartements(Direction);
                foreach (string Departement in DepartementCSA)
                {
                    Team _team2 = new Team();
                    Response QueryResult2 = new Response();
                    _team2.Create(Departement, "", "", "Departement", out QueryResult2);
                }
            }
        }

        //internal void Creation_Team()
        //{
        //    string DirectionCsvFile = @"C:\_dev\itop\cmdb_itop\cmd_test_sharp_lib\data\directions.csv.txt";

        //    if(File.Exists(DirectionCsvFile))
        //    {
        //        TextReader reader = File.OpenText(DirectionCsvFile);
        //        List<TeamDirection> TeamDirection = CsvSerializer.DeserializeFromReader<List<TeamDirection>>(reader);
        //        Creation_Team_Direction(TeamDirection,true);
        //    }
        //    else
        //    {
        //        List<string> DirectionCsaShortName = new List<string>();
        //        DirectionCsaShortName.Add("DAFSI");
        //        DirectionCsaShortName.Add("AC");
        //        DirectionCsaShortName.Add("DICI");
        //        DirectionCsaShortName.Add("DAEI");
        //        DirectionCsaShortName.Add("DP");
        //        DirectionCsaShortName.Add("DG");
        //        DirectionCsaShortName.Add("DJ");
        //        DirectionCsaShortName.Add("DMR");
        //        DirectionCsaShortName.Add("DMT");
        //        DirectionCsaShortName.Add("PRESIDENCE");

        //        List<string> DirectionCsaEmail = new List<string>();
        //        DirectionCsaEmail.Add("diffusionDAFSI@csa.fr");
        //        DirectionCsaEmail.Add("diffusionAC@csa.fr");
        //        DirectionCsaEmail.Add("diffusionDICI@csa.fr");
        //        DirectionCsaEmail.Add("diffusionDAEI@csa.fr");
        //        DirectionCsaEmail.Add("diffusionDP@csa.fr");
        //        DirectionCsaEmail.Add("diffusionDG@csa.fr");
        //        DirectionCsaEmail.Add("diffusionDJ@csa.fr");
        //        DirectionCsaEmail.Add("diffusionDMR@csa.fr");
        //        DirectionCsaEmail.Add("diffusionDMT@csa.fr");
        //        DirectionCsaEmail.Add("");

        //        List<TeamDirection> TeamDirection = new List<TeamDirection>();
        //        List<string> DirectionCSA = ADUser.GetDirection();
        //        int i = 0;
        //        foreach (string dir in DirectionCSA)
        //        {
        //            TeamDirection newTeam = new TeamDirection();
        //            newTeam.NameFromAD = dir;
        //            newTeam.ShortName = DirectionCsaShortName[i];
        //            newTeam.Mail = DirectionCsaEmail[i];
        //            i++;
        //            TeamDirection.Add(newTeam);                    
        //        }
        //        TextWriter writer = File.CreateText(DirectionCsvFile);
        //        CsvSerializer.SerializeToWriter<List<TeamDirection>>(TeamDirection, writer);
        //        writer.Close();

        //        this.Creation_Team(); // appel de creation team cette fois le fichier existe                

        //    }
        //    Console.WriteLine("");

        //}
        //internal void Creation_Team_Direction(List<TeamDirection> TeamDirection, bool isDirection)
        //{
        //    foreach(TeamDirection td in TeamDirection)
        //    {
        //        Team _team = new Team();
        //        Response QueryResult = new Response();
        //        if(td.Mail == null)
        //        {
        //            td.Mail = "";
        //        }
        //        if (isDirection)
        //        {
        //            _team.Create(td.ShortName, td.Mail, "", "Direction", out QueryResult);
        //            List<string> Departements = ADUser.GetDepartements(td.NameFromAD);
        //            Creation_Team_Departement(Departements, td.ShortName);
        //        }
        //        else
        //        {
        //            _team.Create(td.ShortName, td.Mail, "", "Departement", out QueryResult);
        //        }

        //    }
        //}
        //internal void Creation_Team_Departement(List<string> Departement,string direction)
        //{
        //    List<string> DirectionCsaShortName = new List<string>();
        //    List<string> DirectionCsaEmail = new List<string>();
        //    List<TeamDirection> TeamDepartement = new List<TeamDirection>();
        //    switch (direction)
        //    {
        //        case "DAFSI":
        //            {

        //                DirectionCsaShortName.Add("Dabf");
        //                DirectionCsaShortName.Add("Dmg");
        //                DirectionCsaShortName.Add("Drh");
        //                DirectionCsaShortName.Add("Dsi");    

        //                DirectionCsaEmail.Add("diffusionDAFSI-DABF@csa.fr");
        //                DirectionCsaEmail.Add("diffusionDAFSI-DMG@csa.fr");
        //                DirectionCsaEmail.Add("diffusionDAFSI-DRH@csa.fr");
        //                DirectionCsaEmail.Add("diffusionDAFSI-DSI@csa.fr");
        //                break;
        //            }
        //    }

        //    int i = 0;
        //    foreach (string Dep in Departement)
        //    {
        //        TeamDirection newTeam = new TeamDirection();
        //        newTeam.NameFromAD = Dep;
        //        newTeam.ShortName = DirectionCsaShortName[i];
        //        newTeam.Mail = DirectionCsaEmail[i];
        //        i++;
        //        TeamDepartement.Add(newTeam);
        //    }
        //    Creation_Team_Direction(TeamDepartement,false);
        //}

        internal void CreateUserInItop(List<ADUser> usersInDir,string direction,string departement,bool prestataire)
        {
            foreach (ADUser usr in usersInDir)
            {
                Person newPerson = new Person();
                Response QueryResult = new Response();

                string[] SplitNom = usr.CN.Split(' ');
                if(SplitNom.Length == 2)
                {
                    string nom = usr.CN.Split(' ')[0];
                    string prenom = usr.CN.Split(' ')[1];

                    if(usr.title == null)
                    {
                        Console.WriteLine("todo titre non saisie dans l'AD: {0}",usr.CN);
                        usr.title = "err2";
                    }

                    if (usr.departement == null)
                    {
                        Console.WriteLine("todo departement non saisie dans l'AD: {0}", usr.CN);
                        usr.title = "err1";
                    }
                    
                    // Creation du contact
                    int person_id = newPerson.Create(nom, prenom, usr.mail, usr.departement, out QueryResult);

                    // creation du lien Equipe / Person : lnkPersonToTeam

                    lnkPersonToTeam lptt = new lnkPersonToTeam();
                    Response QueryResult2 = new Response();

                    ContactType objContactType = new ContactType();
                    int role_id_interne = objContactType.GetID("Interne");
                    int role_id_externe = objContactType.GetID("Externe");

                    if (direction != null)
                    {
                        //Get IDs ( équipe et role )
                        Team objTeam = new Team();
                        int team_id = objTeam.GetID(direction);
                                             
                        lptt.Create(person_id,team_id, role_id_interne, out QueryResult2);                        
                    }

                    if (departement != null)
                    {
                        //Get IDs ( équipe et role )
                        Team objTeam = new Team();
                        int team_id = objTeam.GetID(departement);

                        if (prestataire)
                        {
                            lptt.Create(person_id, team_id, role_id_externe, out QueryResult2);
                        }
                        else
                        {
                            lptt.Create(person_id, team_id, role_id_interne, out QueryResult2);
                        }
                    }

                   


                    Console.WriteLine("Création d'un contact : {0}", usr.CN);
                }
                

            }
        }

        internal void Creation_Person()
        {
            List<string> DirectionCSA = ADUser.GetDirection();
            

            foreach(string dir in DirectionCSA)
            {
                Console.WriteLine("DIRECTION: {0}", dir);
                List<ADUser> usersInDir = ADUser.GetUsers("LDAP://OU="+ dir +",OU=Siege,DC=csa,DC=lan");
                CreateUserInItop(usersInDir,dir,null,false);
                              

                //get departement
                List<string> Departements = ADUser.GetDepartements(dir);                                
                //pour chaque departement get user
                foreach(string depts in Departements)
                {
                    Console.WriteLine("  Département: {0}", depts);
                    var usersInDirAndDepts = ADUser.GetUsers("LDAP://OU="+ depts +",OU = "+ dir + ", OU=Siege,DC=csa,DC=lan");
                    CreateUserInItop(usersInDirAndDepts,dir,depts,false);

                    //pretataires
                    var usersInDirAndDeptsAndPresta = ADUser.GetUsers("LDAP://OU=Prestataires,OU=" + depts + ",OU = " + dir + ", OU=Siege,DC=csa,DC=lan");
                    CreateUserInItop(usersInDirAndDeptsAndPresta,dir,depts,true);
                }
            }
        }

    }
}
