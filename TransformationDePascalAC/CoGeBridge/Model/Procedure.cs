using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;


namespace CoGeBridge.Model
{
    public class Procedure
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public int LineIndex { get; set; }
        public string Comments { get; set; }
        public int CollectParam {get ; set;}

        private List<Parameter> parameters;

        public Procedure()
        {
                
        }

       

        public List<Parameter> GetParameters()
        {
            return parameters;
        }

        public void SetParameters(List<Parameter> p)
        {
            this.parameters = p;
        }

        public void AddParameter(string pname, string ptype, string piotype)
        {
            Parameter p = new Parameter(pname, ptype, piotype);
            parameters.Add(p);
        }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string IOType { get; set; }

        public Parameter()
        {

        }

        public Parameter(string n, string t, string io)
        {
            Name = n;
            Type = t;
            IOType = io;
        }
    }

    public static class ProceduresBuilder
    {
        public static List<Procedure> BuildProceduresFromXml(string xml)
        {
            List<Procedure> procedures = new List<Procedure>();
            Procedure p = null;
            if(string.IsNullOrEmpty(xml))
            	throw new Exception("Xml is empty");
            
            XDocument doc = XDocument.Parse(@xml);
            foreach (XElement item in doc.Root.Elements("procedure"))
            {
                p = BuildProcedureFromXmlElement(item);
                procedures.Add(p);
            }

            return procedures;
        }

        private static Procedure BuildProcedureFromXmlElement(XElement proc)
        {
            Procedure p = new Procedure();

            p.Identifier = proc.Element("identifier").Value.Trim();
            
            p.LineIndex = Convert.ToInt32(proc.Element("startIndex").Value.Trim());

            p.Name = proc.Element("name").Value.Trim();           
           
            p.Comments = proc.Element("comments").Value.Trim();

            List<Parameter> paramsList = BuildParametersFromXmlElement(proc.Element("parameters").Elements("param"));
            p.SetParameters(paramsList);

            return p;

        }

        private static List<Parameter> BuildParametersFromXmlElement(IEnumerable<XElement> paramsElements)
        {
            List<Parameter> parameters = new List<Parameter>();
            Parameter p = null;

            foreach (XElement param in paramsElements)
            {
            	p = new Parameter();
            	
                p.Name = param.Element("name").Value.Trim();           

                p.Type = param.Element("type").Value.Trim();           

                p.IOType = param.Element("iotype").Value.Trim();           

                parameters.Add(p);
            }

                        

            return parameters;
        }



        
    }


}
