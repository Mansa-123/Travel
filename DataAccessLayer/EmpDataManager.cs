using ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class EmpDataManager: IEmpDataManager
    {
        // // Need later dont delete
        //public int AddEmplDL(int emp_id, string FName, string LName, DateTime DOB, string EAddress, string contact)
        //{
        //    Employee emp = new Employee(emp_id, FName, LName, DOB, EAddress, contact);
        //    Console.WriteLine(emp.ToString());
        //    return 1;
        //}
        public void EditEmployee_DAL(Employee e_change)
        {
            Employee emp_Main = employee1.FirstOrDefault(emp=>emp.emp_id == e_change.emp_id);
            int index = employee1.IndexOf(emp_Main);

            employee1[index].FName = emp_Main.FName;
            employee1[index].LName = emp_Main.LName;
            employee1[index].DOB = emp_Main.DOB;
            employee1[index].EAddress = emp_Main.EAddress;
            employee1[index].contact = emp_Main.contact;

            ViewAllEmployee();

            
        }
        public int DeleteEmplDL(int emp_id)
        {
            //public static int id { get; set; }
            
            var deletedata = employee1.Remove(employee1.FirstOrDefault(emp=>emp.emp_id==emp_id));

            //Console.WriteLine("Employee with ID {0} is deleted !!!", emp_id);
            Console.WriteLine("\nData of Employee ID: {0} is deleted successfully... ", emp_id);

            ViewAllEmployee();
            
            return 1;
        }

        public List<Employee> employee1 = new List<Employee>()


        {
           // public int ViewEmplDL(int emp_id, string FName, string LName, DateTime DOB, string EAddress, string contact)
            //employee1.Add(
            
                new Employee() { emp_id = 1, FName = "Mansa", LName = "Thakur", DOB = DateTime.Parse("04/02/2001"), EAddress = "Nagpur", contact = "9988776655" },
                new Employee() { emp_id = 2, FName = "Dimpal", LName = "Thanwal", DOB = DateTime.Parse("17/08/2001"), EAddress = "Wardha", contact = "9876789542" },
                new Employee() { emp_id = 3, FName = "Swaraj", LName = "Barwal", DOB = DateTime.Parse("26/10/2001"), EAddress = "Pune", contact = "9756782343" },
                new Employee() { emp_id = 4, FName = "Abha", LName = "Thakur", DOB = DateTime.Parse("06/06/1995"), EAddress = "Akola", contact = "7721435678" },
                new Employee() { emp_id = 5, FName = "Sakshi", LName = "Pawar", DOB = DateTime.Parse("22/04/2001"), EAddress = "Nagar", contact = "8756884245" }
        };


        //Just for try badme nikalna hi hai, AddEmplDL and AddEmployee_DAL alag alag hai but ek hi hai, second wala show karega static data
        public int AddEmployee_DAL(int id, string fname, string lname, DateTime dob, string address, string contact)
        {
            //Employee emp = new Employee(emp_id, FName, LName, DOB, EAddress, contact);
            employee1.Add(new Employee() { emp_id = id, FName = fname, LName = lname, DOB = dob, EAddress = address, contact = contact });
            //Console.WriteLine(emp.ToString());

            Console.WriteLine("-----------------------------------------------");
            
            ViewAllEmployee();
            return 1;
        }

        public void ViewAllEmployee()
        {
            Console.WriteLine("======================================== List Of Employees =====================================================");
            foreach (Employee e in employee1)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("======================================== List Of Employees =====================================================");

        }
        //// What I tried
        //public int GetEmployeeBYid(int emp_id)
        //{
        //    var lstEmp = employee1.FirstOrDefault(emp=>emp.emp_id == emp_id);
        //    int index=employee1.IndexOf(lstEmp);

        //    Console.WriteLine(index); 
        //    return 1;
        //}

        public Employee GetEmployeeBYid_DAL(int id)
        {
            Employee empl = employee1.FirstOrDefault(emp=>emp.emp_id== id);
            if(empl != null)
            {
                return empl;
            }
            return null;
        }
    }

}

