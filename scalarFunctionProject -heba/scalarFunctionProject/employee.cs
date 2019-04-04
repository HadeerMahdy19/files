using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace scalarFunctionProject
{

    /// <summary>
    /// DATA TYPES OF EACH ATTRIBUTE IN A STATIC DICTIONARY<STRING ATTRINBUTENAME,STRING DATATYPE>  
    /// 
    /// </summary>
    public class employee
    {
        public int id;
        public string name;
        public double salary;
        public double bonus;
        public double taxes;
        public string department;
        public int depId;
        public employee(int id,string name, double salary, double bonus,double taxes,string department,int depId)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.bonus = bonus;
            this.taxes = taxes;
            this.department = department;
            this.depId = depId;
        }
        public void inputEmployeeData()
        {

            if (!File.Exists("employee.xml")) //case file doesnot exist
            {
                XmlWriter writer = XmlWriter.Create("employee.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteStartAttribute("name", "employee");
               //data of employee,id,name,salary,bonus,taxes,department,depId
                writer.WriteStartElement("employee"); 
                writer.WriteStartElement("id");
                writer.WriteString(Convert.ToString(id));
                writer.WriteEndElement();
                //--------------------------------------------------

                writer.WriteStartElement("name");
                writer.WriteString(name);
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("salary");
                writer.WriteString(Convert.ToString(salary));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("bonus");
                writer.WriteString(Convert.ToString(bonus));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("taxes");
                writer.WriteString(Convert.ToString(taxes));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("department");
                writer.WriteString(department);
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("depId");
                writer.WriteString(Convert.ToString(depId));
                writer.WriteEndElement();
                //--------------------------------------------------

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            else //case file already exist 
            {
               
                XmlDocument doc = new XmlDocument();
                
                
                doc.Load("employee.xml");
                XmlElement parent = doc.CreateElement("employee");
                //------------------------------------------------
                XmlElement node = doc.CreateElement("id");
                node.InnerText=Convert.ToString(id);
                XmlAttribute attribute1 = doc.CreateAttribute("datatype");
                attribute1.Value = "int";
                node.Attributes.Append(attribute1);
                parent.AppendChild(node);
                //------------------------------------------------
                node=doc.CreateElement("name");
                node.InnerText=name;
                XmlAttribute attribute2 = doc.CreateAttribute("datatype");
                attribute2.Value = "string";
                node.Attributes.Append(attribute2);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("salary");
                node.InnerText = Convert.ToString( salary);
                XmlAttribute attribute3 = doc.CreateAttribute("datatype");
                attribute3.Value = "int";
                node.Attributes.Append(attribute3);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("bonus");
                node.InnerText = Convert.ToString( bonus);
                XmlAttribute attribute4 = doc.CreateAttribute("datatype");
                attribute4.Value = "int";
                node.Attributes.Append(attribute4);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("taxes");
                node.InnerText = Convert.ToString(taxes);
                XmlAttribute attribute5 = doc.CreateAttribute("datatype");
                attribute5.Value = "int";
                node.Attributes.Append(attribute5);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("department");
                node.InnerText = department;
                XmlAttribute attribute6 = doc.CreateAttribute("datatype");
                attribute6.Value = "string";
                node.Attributes.Append(attribute6);
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("depId");
                node.InnerText =Convert.ToString(depId);
                XmlAttribute attribute7 = doc.CreateAttribute("datatype");
                attribute7.Value = "int";
                node.Attributes.Append(attribute7);
                parent.AppendChild(node);
                //-------------------------------------------------
                XmlElement root = doc.DocumentElement;
                root.AppendChild(parent);
                doc.Save("employee.xml");
            }
        }
    }
    


    }
