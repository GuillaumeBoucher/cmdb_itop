using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itop.lib;

namespace cmd_test_sharp_lib
{
    public class Initialisation
    {
        //Constructeur
        public Initialisation()
        {

        }

        internal void Creation_Location()
        {
            Location loc = new Location();
            Response QueryResult = new Response();
            loc.Create("PARIS","Tour Mirabeau 39-43, Quai André Citroën", "75739", "PARIS", out QueryResult);
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


        }

        internal void Creation_Team()
        {
            //1 - todo query AD 
            //2 - create team (direction & département & pole)
            Team _team = new Team();
            Response QueryResult = new Response();
            _team.Create("Exploitation", "a@a.fr", "", "Exploitation DAFSI", out QueryResult);
            
        }

        internal void Creation_Person()
        {
            
            //todo : query AD et alimentation en foreach

            Person newPerson = new Person();
            Response QueryResult = new Response();
            newPerson.Create("auda", "thierry", "thierry.auda@csa.fr", "dsi",out QueryResult);

        }
    }
}
