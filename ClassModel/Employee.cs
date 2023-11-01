using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModel
{
    public class Employee
    {
        public int emp_id {  get; set; }
        public string FName { get; set; }
        public string LName { get; set;}

        public DateTime DOB { get; set; }
        public string EAddress { get; set; }
        public string contact { get; set; }

        // // Need later dont delete
        //public Employee(int id, string fname, string lname, DateTime dob, string address, string contact)
        //{
        //    emp_id = id;
        //    FName = fname;
        //    LName = lname;
        //    DOB = dob;
        //    EAddress = address;
        //    this.contact = contact;

        //}

        public override string ToString()
        {
            return string.Format("Emp-Id : {0}, First Name: {1}, Last Name: {2}, DOB: {3}, Address: {4}, Contact: {5}", emp_id, FName, LName, DOB, EAddress, contact);

        }
    }

}
