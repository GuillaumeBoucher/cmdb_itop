using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmd_generated_model
{
    class Program
    {
        public static string ModelPath => ConfigurationManager.AppSettings["iTopModelPath"];
        static void Main(string[] args)
        {
            GeneratedClassFrom_installationXML();
            GeneratedClassFrom_ModelPath();
        }


        static void GeneratedClassFrom_installationXML()
        {
            if (File.Exists(ModelPath + "installation.xml"))
            {
                //Lecture du fichier de configuration
                installation ConfigInstall = new installation(ModelPath + "installation.xml");

                //Initialisation des class c#
                foreach (step _steps in ConfigInstall.steps)
                {
                    foreach (choice _choices in _steps.choices)
                    {
                        foreach (string _module in _choices.modules)
                        {
                            string s_titre = _steps.title;
                            string s_desc = _steps.description;
                            string s_banner = _steps.banner;

                            string c_titre = _choices.title;
                            string c_desc = _choices.description;
                            string c_code = _choices.extension_code;


                            if (File.Exists(ModelPath + _module + "/datamodel." + _module + ".xml"))
                            {
                                Classes_model _ItopClass = new Classes_model(ModelPath + _module + "/datamodel." + _module + ".xml");
                                //Génération des class c#
                                CreateSharpClasse(_ItopClass, _module);

                            }
                        }
                    }
                }
                Console.ReadKey();
            }//file exist: installation.xml
        }

        static void GeneratedClassFrom_ModelPath()
        {
            IEnumerable<string> dirs = Directory.EnumerateDirectories(ModelPath);
            foreach (string dir in dirs)
            {

                Console.WriteLine(dir);
                string[] ListXmlFiles = Directory.GetFiles(dir, "*.xml", SearchOption.TopDirectoryOnly);
                foreach (string FileName in ListXmlFiles)
                {
                    string[] FileItems = FileName.Split('\\');
                    if (FileItems.Length == 2)
                    {
                        string cleanFile1 = FileItems[1];
                        if (cleanFile1.StartsWith("datamodel."))
                        {
                            string[] FolderNameItems = cleanFile1.Split('.');
                            if (FolderNameItems[1].StartsWith("itop-"))
                            {
                                string ModelName = FolderNameItems[1].Substring(5, FolderNameItems[1].Length - 5);
                                Classes_model ClassModelFromDir = new Classes_model(FileName);
                                CreateSharpClasse(ClassModelFromDir, ModelName);
                            }
                            else
                            {
                                throw new NotImplementedException();
                            }

                        }
                        else
                        {
                            //todo
                            //throw new NotImplementedException();
                        }

                    }


                }
                //Console.ReadKey();    
            }
        }

        static void CreateSharpClasse(Classes_model ClassModel, string ModelName)
        {

            //Netoyage du Namespace Name
            if (ModelName.StartsWith("itop-"))
            {
                ModelName = ModelName.Substring(5, ModelName.Length - 5);
            }
            if (ModelName.Contains("-"))
            {
                ModelName = ModelName.Replace('-', '_');
            }

            //Creation du contenu de la class

            foreach (Classes_model.Classe _curClass in ClassModel.classes)
            {

                string fn = _curClass.name;

                string fc = "using cmdb;" + Environment.NewLine;
                fc = fc + "using System;" + Environment.NewLine;
                fc = fc + Environment.NewLine;
                fc = fc + "namespace cmdb." + ModelName + Environment.NewLine;

                fc = fc + "{" + Environment.NewLine;
                if (_curClass.parent == null)
                {
                    fc = fc + "\t public class " + _curClass.name + Environment.NewLine;
                }
                else
                {
                    fc = fc + "\t public class " + _curClass.name + ":" + _curClass.parent + Environment.NewLine;
                }
                fc = fc + "\t {" + Environment.NewLine;
                fc = fc + "" + Environment.NewLine;
                fc = fc + "\t\t //Attributs" + Environment.NewLine;
                fc = fc + "" + Environment.NewLine;
                //fc = fc + "\t\t public string Icon { get; set; }" + Environment.NewLine;
                foreach (Classes_model.Field _curField in _curClass.fields)
                {
                    switch (_curField.type)
                    {
                        case "AttributeBlob":
                        case "AttributeString":
                            {
                                fc = fc + "\t\t public string " + _curField.name + " { get; set; }" + Environment.NewLine;
                                break;
                            }

                        case "AttributeObjectKey":
                        case "AttributeInteger":
                            {
                                fc = fc + "\t\t public int " + _curField.name + " { get; set; }" + Environment.NewLine;
                                break;
                            }
                        default:
                            {
                                if (_curField.type.StartsWith("Attribute"))
                                {
                                    string AttributeType = _curField.type.Substring(9, _curField.type.Length - 9);
                                    fc = fc + "\t\t public " + AttributeType + " " + _curField.name + " { get; set; }" + Environment.NewLine;
                                }
                                else
                                {
                                    throw new NotImplementedException();
                                }
                                break;
                            }
                    }
                }

                fc = fc + "" + Environment.NewLine;
                fc = fc + "\t\t //Methodes" + Environment.NewLine;
                fc = fc + "" + Environment.NewLine;

                foreach (Classes_model.Method _curMethod in _curClass.methods)
                {
                    if (_curMethod.name == "GetRelationQueries")
                    {
                        if (_curClass.name == "FunctionalCI" || _curClass.name == "PowerConnection" || _curClass.name == "VirtualHost")
                        {
                            fc = fc + "\t\t public void " + _curMethod.name + "()" + Environment.NewLine;
                            fc = fc + "\t\t {" + Environment.NewLine;
                            if (_curMethod.code != null)
                            {
                                fc = fc + CleanCode(_curMethod.code);
                            }
                            fc = fc + "\t\t }" + Environment.NewLine;
                        }
                        //else
                        //{
                        //    string s = _curClass.name;
                        //    int i = 0;
                        //}

                    }
                    else
                    {
                        fc = fc + "\t\t public void " + _curMethod.name + "()" + Environment.NewLine;
                        fc = fc + "\t\t {" + Environment.NewLine;
                        if (_curMethod.code != null)
                        {
                            fc = fc + CleanCode(_curMethod.code);
                        }
                        fc = fc + "\t\t }" + Environment.NewLine;
                    }
                }

                fc = fc + "\t } //end class" + _curClass.name + Environment.NewLine;
                //public List<step> steps { get; set; }
                fc = fc + "} //end namespace";

                //Sauvegarde du fichier
                string SaveDirectory = ConfigurationManager.AppSettings["SaveDirectory"];
                if (!Directory.Exists(SaveDirectory))
                {
                    Directory.CreateDirectory(SaveDirectory);
                }
                if (!Directory.Exists(SaveDirectory + ModelName))
                {
                    Directory.CreateDirectory(SaveDirectory + ModelName);
                }

                System.IO.File.WriteAllText(SaveDirectory + ModelName + "/" + _curClass.name + ".cs", fc);
                PrintProgress(ModelName, _curClass.name);
            }
        }//CreateSharpClasse

        private static void PrintProgress(string modelName, string name)
        {
            Console.WriteLine("Namespace: {0} | class: {1}", modelName, name);
            //Console.ReadKey();
        }

        private static string CleanCode(string code)
        {
            string _ret = "";
            string[] result = code.Split(new[] { '\r', '\n' });
            foreach (string str in result)
            {
                _ret = _ret + "\t\t\t // " + str.Trim() + Environment.NewLine;
            }
            return _ret;
        }//End CleanCode


        private static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }



    }
}
