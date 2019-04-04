using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace scalarFunctionProject
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> myTables = new List<string>();
            myTables.Add("Employee");
            myTables.Add("Service");
            this.combobxTableName.DataSource = myTables;
            this.combobxTableName.DropDownStyle = ComboBoxStyle.DropDownList;
            //LAMA N2RA SERVICE DATA N3ML ELSE IF LEHA
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            switch (globals.fnChosen)
            {
                case "sum":
                //globals.fnUsed=globals.fnList.ElementAt(RAQAM EL SUM FN FE FN FILE)
                //SUM(FN N ARGUMENTS STORED IN FNUSED);
                 break;

                case "average":
                //globals.fnUsed=globals.fnList.ElementAt(RAQAM EL AVG FN FE FN FILE)
                //AVERAGE(FN N ARGUMENTS STORED IN FNUSED);
                break;

                case "maximum":
               //globals.fnUsed=globals.fnList.ElementAt(RAQAM EL MAX FN FE FN FILE)
                //MAXIMUM(FN N ARGUMENTS STORED IN FNUSED);
                break;

                case "minimum":
                //globals.fnUsed=globals.fnList.ElementAt(RAQAM EL MIN FN FE FN FILE)     
                //MINIMUM(FN N ARGUMENTS STORED IN FNUSED);
               break;
       
                case "count":
                //globals.fnUsed=globals.fnList.ElementAt(RAQAM EL COUNT FN FE FN FILE)    
               //COUNT(FN N ARGUMENTS STORED IN FNUSED);
                break;

            }
        }



        private void btnShowData_Click(object sender, EventArgs e)
        {
            if ((this.combobxTableName.SelectedValue).ToString() == "Employee")
            {
                readEmployeeData(globals.emplist);
                showEmpData();
            }
            else if ((this.combobxTableName.SelectedValue).ToString() == "Service")
            {
                //readEmployeeData(globals.emplist);
                //showEmpData();
            }
        }
        
        ////////////////////////////////////////////////////////////////////EMPLOYEE FUNCTIONS
        public void showEmpData()
        {
            DataTable empDt = new DataTable();
            if (empDt.Columns.Count == 0)
            {
                empDt.Columns.Add("ID");
                empDt.Columns.Add("Name");
                empDt.Columns.Add("Salary");
                empDt.Columns.Add("Bonus");
                empDt.Columns.Add("Taxes");
                empDt.Columns.Add("Department");
                empDt.Columns.Add("Department ID");
            }
            for (int i = 0; i < globals.emplist.Count;i++ )
                empDt.Rows.Add(globals.emplist.ElementAt(i));
            dataGridViewTable.DataSource = empDt;

        }
        
        public void readEmployeeData(List<employee> eList)
        {
            eList.Clear();
            
            XmlDocument doc = new XmlDocument();
            doc.Load("employee.xml");
            XmlNodeList list = doc.GetElementsByTagName("employee");
            for(int i = 0; i < list.Count; i++)
            {
                XmlNodeList child = list[i].ChildNodes;
                string id = child[0].Name;
                int idValue = Convert.ToInt32(child[0].InnerText);
                
                string name = child[1].Name;
                string nameValue = child[1].InnerText;
                
                string salary = child[2].Name;
                int salaryValue = Convert.ToInt32(child[2].InnerText);
                
                string bonus= child[3].Name;
                int bonusValue = Convert.ToInt32(child[3].InnerText);
                
                string taxes = child[4].Name;
                int taxesValue = Convert.ToInt32(child[4].InnerText);
                
                string department = child[5].Name;
                string departmentValue = child[5].InnerText;
                
                string depId = child[6].Name;
                int depIdValue = Convert.ToInt32(child[6].InnerText);

                employee emp = new employee(idValue,nameValue,salaryValue,bonusValue,taxesValue,departmentValue,depIdValue);
                eList.Add(emp);

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////SERVICE FUNCTIONS
        //public void readServiceData(List<service> eList)

        //public void showServiceData(List<service> eList)



        
        //////////////////////////////////////////////////////////////////////////////////////////FUNCTION SUNCTIONS XD
        
        private void buttonbtnSum_Click(object sender, EventArgs e)
        {
            globals.fnChosen = "sum";
        }

        public void sum() {
            //textboxResult.Text = result;
        }

        public void average() {
            //textboxResult.Text = result;
        }

        public void maximum() {
            //textboxResult.Text = result;
        }

        public void minimum() {
            //textboxResult.Text = result;
        }

        public void count() {
            //textboxResult.Text = result;
        }

    }
}
