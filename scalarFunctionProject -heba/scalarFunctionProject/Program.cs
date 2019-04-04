using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scalarFunctionProject
{
    
    static class Program
    {
        [STAThread]
        static void Main()
        {
        //    employee emp1 = new employee(1, "heba", 1200, 23, 34, "hr", 1);
        //    emp1.inputEmployeeData();
        //    employee emp2 = new employee(2, "hala", 1300, 24, 36, "hr", 1);
        //    emp2.inputEmployeeData();
        //    employee emp3 = new employee(3, "hadeer", 100, 28, 50, "pr", 2);
        //    emp3.inputEmployeeData();
        //    employee emp4 = new employee(4, "yassmina", 50, 27, 39, "driver", 3);
        //    emp4.inputEmployeeData();
        //    employee emp5 = new employee(5, "muna", 900, 89, 67, "senior", 4);
        //    emp5.inputEmployeeData();

            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
