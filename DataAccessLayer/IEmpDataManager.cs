using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModel;

namespace DataAccessLayer
{
    public interface IEmpDataManager
    {
        // // Need later dont delete====================
        int AddEmployee_DAL(int emp_id, string FName, string LName, DateTime DOB, string EAddress, string contact);
        void EditEmployee_DAL(Employee employee);
        int DeleteEmplDL(int emp_id);
        //int ViewEmplDL();
        void ViewAllEmployee();

        Employee GetEmployeeBYid_DAL(int id);

    }
}
