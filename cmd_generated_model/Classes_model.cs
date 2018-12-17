using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cmd_generated_model
{
    public class Classes_model
    {
        public static string ModelPath => ConfigurationManager.AppSettings["iTopModelPath"];
        public List<Classe> classes { get; set; }

        public Classes_model(string XmlFile)
        {

            XDocument myDoc = XDocument.Load(XmlFile);
            this.classes = new List<Classe>();

            //read Classes
            var nodes_classes = (from n in myDoc.Descendants() where n.Name == "classes" select n).ToArray();
            if (nodes_classes.Length >= 1)
            {
                //read all Class in Classes
                var nodes = (from n in nodes_classes.Descendants() where n.Name == "class" select n).ToArray();

                foreach (XElement element in nodes)
                {
                    Classe _newClasse = new Classe();
                    _newClasse.name = (string)element.Attribute("id");


                    _newClasse.parent = (string)element.Element("parent");
                    _newClasse.fields = new List<Field>();
                    _newClasse.methods = new List<Method>();

                    var nodes_properties = (from n in element.Descendants() where n.Name == "properties" select n).ToArray();
                    if (nodes_properties.Length >= 1)
                    {
                        _newClasse.comment = (string)nodes_properties[0].Element("comment");
                        _newClasse.icon = (string)nodes_properties[0].Element("icon");

                    }
                    //read Fields
                    var nodes_fields = (from n in element.Descendants() where n.Name == "field" select n).ToArray();
                    foreach (XElement element_fields in nodes_fields)
                    {
                        XNamespace ns = "http://www.w3.org/2001/XMLSchema-instance";
                        Field _newField = new Field();
                        _newField.name = (string)element_fields.Attribute("id");
                        _newField.name = this.UppercaseFirst(_newField.name);
                        _newField.type = (string)element_fields.Attribute(ns + "type");
                        _newClasse.fields.Add(_newField);

                    }
                    //read Methods
                    var nodes_methods = (from n in element.Descendants() where n.Name == "method" select n).ToArray();
                    foreach (XElement element_methods in nodes_methods)
                    {
                        if (element_methods.HasElements)
                        {
                            Method _newMethod = new Method();
                            _newMethod.name = (string)element_methods.Attribute("id");
                            _newMethod.name = this.UppercaseFirst(_newMethod.name);
                            _newMethod.code = (string)element_methods.Element("code");
                            _newClasse.methods.Add(_newMethod);
                        }

                    }

                    this.classes.Add(_newClasse);
                }
            }

        }

        public class Classe
        {
            public string parent { get; set; }
            public string name { get; set; }
            public string comment { get; set; }
            public string icon { get; set; }
            public List<Field> fields { get; set; }
            public List<Method> methods { get; set; }
        }

        public class Field
        {
            public string name { get; set; }
            public string type { get; set; }
        }

        public class Method
        {
            public string name { get; set; }
            public string code { get; set; }
        }


        private string UppercaseFirst(string s)
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
