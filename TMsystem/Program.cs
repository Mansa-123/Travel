using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer;
using BusinessAccessLayer;
using ClassLibrary_MainMenu;

namespace TMsystem
{
    
    public class Program
    {
        static void Main(string[] args)
        {
           Menu.ShowMain();
            //EmployeeBAL e = new EmployeeBAL(); ////IN MENU
            // e.ViewAllEmployee_BAL();

            //RequestDataManager r = new RequestDataManager();
            // r.ViewTReqDL();
            //Hello
            //EmpDataManager emp = new EmpDataManager();
            //emp.DeleteEmplDL(2);
            //EmpDataManager emp = new EmpDataManager();
            //emp.GetEmployeeBYid(3);

        }
    }
}
