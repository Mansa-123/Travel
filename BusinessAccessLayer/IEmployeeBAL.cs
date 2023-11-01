using ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    internal interface IEmployeeBAL
    {
       void ViewAllEmployee_BAL();

       int AddEmployee_BAL(int emp_id, string FName, string LName, DateTime DOB, string EAddress, string contact);

        Employee GetEmployeeBYid_BAL(int id);

        int DltEmployee_BAL(int id);
    }
}
