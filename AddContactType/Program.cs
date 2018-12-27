using itop.lib;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddContactType
{
    class Program
    {
        public static string _objectDataPath = "";
        public static string className = "ContactType";

        static void Main(string[] args)
        {
            string csv_data_path = ConfigurationManager.AppSettings["csv_data_path"];            
            _objectDataPath = csv_data_path + className + ".csv.txt";

            Console.Clear();
            if (File.Exists(_objectDataPath))
            {
                InsertCSV_in_Itop();
            }
            else
            {
                CreateCSV();
            }
        }

        static void CreateCSV()
        {
            //Création des types de contacts (Interne / Prestataire / Fourniseur)
            List<ContactType> ListcontactTypes = new List<ContactType>();

            ContactType obj1 = new ContactType();
            obj1.name = "Interne";
            ContactType obj2 = new ContactType();
            obj2.name = "Externe";
            ContactType obj3 = new ContactType();
            obj3.name = "Fourniseur";

            ListcontactTypes.Add(obj1);
            ListcontactTypes.Add(obj2);
            ListcontactTypes.Add(obj3);

            TextWriter writer = File.CreateText(_objectDataPath);
            CsvSerializer.SerializeToWriter<List<ContactType>>(ListcontactTypes, writer);
            writer.Close();
            InsertCSV_in_Itop();
        }

        static void InsertCSV_in_Itop()
        {
            TextReader reader = File.OpenText(_objectDataPath);
            List<ContactType> ListContactType = CsvSerializer.DeserializeFromReader<List<ContactType>>(reader);

            foreach (ContactType s in ListContactType)
            {
               // ContactType _ContactType = new ContactType();
                Response QueryResult = new Response();
                s.Create(s.name, out QueryResult);                
                Console.WriteLine("{0} - add : {1}",className,s.name);
            }
        }

    }
}
