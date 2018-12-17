using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace cmd_generated_model
{

    public class installation
    {
        public List<step> steps { get; set; }

        public installation(string XmlFile)
        {
            XDocument myDoc = XDocument.Load(XmlFile);
            this.steps = new List<step>();

            //read steps
            var nodes = (from n in myDoc.Descendants() where n.Name == "step" select n).ToArray();
            foreach (XElement element in nodes)
            {
                step _newStep = new step();
                _newStep.title = element.Element("title").Value;
                _newStep.description = element.Element("description").Value;
                _newStep.banner = element.Element("banner").Value;
                _newStep.choices = new List<choice>();

                //read choices
                var nodes_choice = (from n in element.Descendants() where n.Name == "choice" select n).ToArray();

                foreach (XElement element_choice in nodes_choice)
                {
                    choice _newChoice = new choice();
                    _newChoice.extension_code = (string)element_choice.Element("extension_code");
                    _newChoice.title = (string)element_choice.Element("title");
                    _newChoice.description = (string)element_choice.Element("description");
                    _newChoice.modules = new List<string>();

                    //read modules
                    var nodes_module = (from n in element_choice.Descendants()
                                        where n.Name == "module"
                                        select n).ToArray();

                    foreach (XElement element_module in nodes_module)
                    {

                        _newChoice.modules.Add((string)element_module);

                    }
                    _newStep.choices.Add(_newChoice);
                }
                this.steps.Add(_newStep);
            }
        }

    }


    public class step
    {
        public string title { get; set; }
        public string description { get; set; }
        public string banner { get; set; }
        public List<choice> choices { get; set; }

    }

    public class choice
    {
        public string extension_code { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> modules { get; set; }
    }
}
