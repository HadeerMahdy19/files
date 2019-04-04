using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace scalarFunctionProject
{

    class service
    {
        public int serviceId;
        public string serviceName;
        public int cost;
        public int numEmp;
        public service(int serviceId, string serviceName, int cost, int numEmp)
        {
            this.serviceId = serviceId;
            this.serviceName = serviceName;
            this.cost = cost;
            this.numEmp = numEmp;
        }
        public void writeService()
        {
            if (!File.Exists("service.xml")) //case file doesnot exist
            {
                XmlWriter writer = XmlWriter.Create("service.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteStartAttribute("name", "service");
                //data of employee,id,name,salary,bonus,taxes,department,depId
                writer.WriteStartElement("service");
                writer.WriteStartElement("serviceId");
                writer.WriteString(Convert.ToString(serviceId));
                writer.WriteEndElement();
                //--------------------------------------------------

                writer.WriteStartElement("serviceName");
                writer.WriteString(serviceName);
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("cost");
                writer.WriteString(Convert.ToString(cost));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("numEmp");
                writer.WriteString(Convert.ToString(numEmp));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            else //case file already exist 
            {

                XmlDocument doc = new XmlDocument();


                doc.Load("service.xml");
                XmlElement parent = doc.CreateElement("service");
                //------------------------------------------------
                XmlElement node = doc.CreateElement("");
                node.InnerText = Convert.ToString(serviceId);
                XmlAttribute attribute1 = doc.CreateAttribute("datatype");
                attribute1.Value = "int";
                node.Attributes.Append(attribute1);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("serviceName");
                node.InnerText = serviceName;
                XmlAttribute attribute2 = doc.CreateAttribute("datatype");
                attribute2.Value = "string";
                node.Attributes.Append(attribute2);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("cost");
                node.InnerText = Convert.ToString(cost);
                XmlAttribute attribute3 = doc.CreateAttribute("datatype");
                attribute3.Value = "int";
                node.Attributes.Append(attribute3);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("numEmp");
                node.InnerText = Convert.ToString(numEmp);
                XmlAttribute attribute4 = doc.CreateAttribute("datatype");
                attribute4.Value = "int";
                node.Attributes.Append(attribute4);
                parent.AppendChild(node);
                //------------------------------------------------
                XmlElement root = doc.DocumentElement;
                root.AppendChild(parent);
                doc.Save("service.xml");
            }
        }
    }



   
}

