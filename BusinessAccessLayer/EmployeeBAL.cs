using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ClassModel;

namespace BusinessAccessLayer
{
    public class EmployeeBAL: IEmployeeBAL
    {

        private static readonly EmpDataManager _empData = new EmpDataManager();
        public void ViewAllEmployee_BAL()
        {
           
            _empData.ViewAllEmployee();
        }

        public int AddEmployee_BAL(int id, string fname, string lname, DateTime dob, string address, string contact) 
        {
            
            _empData.AddEmployee_DAL(id,fname,lname,dob,address,contact);
            return 1;
        }

        public Employee GetEmployeeBYid_BAL(int id)
        {
            
            Employee emp = _empData.GetEmployeeBYid_DAL(id);
            
            return emp ;
        }

        public void EditEmployee_BAL(Employee emp_to_change)
        {
            
            _empData.EditEmployee_DAL(emp_to_change);
        }

        public int DltEmployee_BAL(int id)
        {
            _empData.DeleteEmplDL(id);
            return 1;
        }
        //public int Delete
    }
}
