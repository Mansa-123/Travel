using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAccessLayer;
using DataAccessLayer;
using ClassModel;

namespace ClassLibrary_MainMenu
{
   
    public class Menu
    {
        private static readonly EmployeeBAL _empManager = new EmployeeBAL();
        private static readonly TRequestBAL _tRequest = new TRequestBAL();
        private static readonly EmpDataManager _edm = new EmpDataManager();
        private static readonly RequestDataManager _reqMgr = new RequestDataManager();
        public static void ShowMain()
        {
            int choice;
            bool end = true;

            do
            {
                //Console.Clear();
                Console.WriteLine("-------------------------\n");
                Console.WriteLine("{0,15}", "Main Menu");
                Console.WriteLine("-------------------------\n");
                Console.WriteLine("1.Manage Employees\n");
                Console.WriteLine("2.Manage Travel Request\n");
                Console.WriteLine("3.Exit\n");

                Console.WriteLine("Enter Number of your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManageEmployee();
                        break;
                    case 2:
                        ManageTravelRequest();
                        break;
                    case 3:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (end);

        }

        public static void ManageEmployee()
        {
            int choice1;
            bool goBack = false;
            Console.Clear();
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("{0,15}", "Manage Employees");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("1.Add Employee\n");
            Console.WriteLine("2.Edit Employee\n");
            Console.WriteLine("3.Delete Employee\n");
            Console.WriteLine("4.View Employee\n");
            Console.WriteLine("5.Go Back\n");

            Console.WriteLine("Enter Number of your choice: ");
            choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    AddEmpl();
                    break;
                case 2:
                    EditEmp();
                    break;
                case 3:
                    DltEmp();
                    break;
                case 4:
                    ViewEmp();
                    break;
                case 5:
                    goBack = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public static void AddEmpl()
        {
            Console.Clear();
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("{0,15}", "Add Employee");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Enter Employee ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("\n1.Enter First Name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("\n1.Enter Last Name:");
            string name2 = Console.ReadLine();
            Console.WriteLine("\n2.Enter Date of Birth:");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\n3.Address:");
            string add = Console.ReadLine();
            Console.WriteLine("\n4.Contact:");
            string phone = Console.ReadLine();

            Console.WriteLine("\nCongrats {0} your data added successfully!!!", name1);
            
            _empManager.AddEmployee_BAL(id,name1,name2,dob,add,phone);
            //Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10}","ID", "First Name", "Last Name", "DOB", "Address", "Contact");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10}",id, name1, name2, dob, add, phone);


        }

        public static void EditEmp()
        {
           Employee emp_to_Change = new Employee();
            int edit_choice=0;
            int editID;
            do
            {

                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("{0,15}", "Edit Employee");

                Console.WriteLine("-------------------------");

               
                    _empManager.ViewAllEmployee_BAL();

                    Console.WriteLine("\nEnter the Employee ID to edit or 0 to go back: ");
                    editID = int.Parse(Console.ReadLine());

                    ////Get the employee to change from BAL

                if (editID != 0)
                {
                    do
                    {

                        emp_to_Change = _empManager.GetEmployeeBYid_BAL(editID);


                        Console.WriteLine("\n1.Change First Name \n2.Change Last Name \n3.Change DOB \n4.Change Address \n5.Change Contact \n6.Go Back ");
                        Console.WriteLine("\nEnter Number of your choice: ");

                        edit_choice = int.Parse(Console.ReadLine());

                        switch (edit_choice)
                        {
                            case 1:
                                Console.WriteLine("\nEnter new Employee First Name: ");
                                string e_Name1 = Console.ReadLine();
                                emp_to_Change.FName = e_Name1;
                                break;
                            case 2:
                                Console.WriteLine("\nEnter new Employee Last Name: ");
                                string e_Name2 = Console.ReadLine();
                                emp_to_Change.LName = e_Name2;
                                break;
                            case 3:
                                Console.WriteLine("\nEnter new Employee Date of Birth: ");
                                DateTime e_dob = DateTime.Parse(Console.ReadLine());
                                emp_to_Change.DOB = e_dob;
                                break;
                            case 4:
                                Console.WriteLine("\nEnter new Employee Address: ");
                                string e_address = Console.ReadLine();
                                emp_to_Change.EAddress = e_address;
                                break;
                            case 5:
                                Console.WriteLine("\nEnter new Employee Contact: ");
                                string e_contact = Console.ReadLine();
                                emp_to_Change.contact = e_contact;
                                break;

                            case 6:
                                break;
                            case 7:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Wrong Choice!");
                                break;

                        }//switch
                         _empManager.EditEmployee_BAL(emp_to_Change);
                    } while (edit_choice != 6);

                }//if

                
            } while (editID != 0);


        }
        public static void DltEmp()
        {
            //Console.Clear();
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("{0,15}", "Delete Employee");
            Console.WriteLine("-------------------------\n");

            _empManager.ViewAllEmployee_BAL();
            Console.WriteLine("Select Empoyee ID to Delete : ");
            int EmpNo = int.Parse(Console.ReadLine());
            
            _empManager.DltEmployee_BAL(EmpNo);
            

        }
        public static void ViewEmp()
        {
            Console.Clear();
            Console.WriteLine("{0,-10}", "Data of all Employees");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");
            
            //Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10}", "First Name", "Last Name", "DOB", "Address", "Contact");
            //Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
           
            _empManager.ViewAllEmployee_BAL();
        }

        public static void ManageTravelRequest()
        {
            bool goBack = false;
            Console.Clear();

            //hello
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Travel Request");
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("1.Raise Travel Request\n\n2.View Travel Requests\n\n3.Delete Travel Request\n\n4.Approve Travel Requests\n" +
                "\n5.Show Confirm Booking\n\n6.Closed Travel Requests\n\n7.Edit Travel Request\n\n8.Go Back\n\nEnter number of your choice: ");
            int tchoice = int.Parse(Console.ReadLine());

            switch (tchoice)
            {
                case 1:
                    RaiseTReq();
                    break;
                case 2:
                    ViewTReq();
                    break;
                case 3:
                    DelTReq();
                    break;
                case 4:
                    ApproveTReq();
                    break;
                case 5:
                    ConfirmBooking();
                    break;
                case 6:
                    ClosedTReq();
                    break;
                case 7:
                    EditTReq();
                    break;
                case 8:
                    goBack = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
        public static void RaiseTReq()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("{0,15}", "Raise Travel Request");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("1.Enter Request ID:");
            int req_id = int.Parse(Console.ReadLine());
            Console.WriteLine("\n2.Enter Employee ID:");
            int emp_id = int.Parse(Console.ReadLine());
            Console.WriteLine("\n3.Enter From Location");
            string Location_from = Console.ReadLine();
            Console.WriteLine("\n4.Enter Destination Location");
            string Location_to = Console.ReadLine();
            Console.WriteLine("\n5.Enter Journey Date");
            DateTime t_date = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("\nCongrats your Request register successfully!!!\n");
            _tRequest.AddTReq(req_id,emp_id,Location_from,Location_to,t_date, ApprovedStatus.Pending, BookingStatus.Pending, CurrentStatus.Open);

            //Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10}", "Employee ID", "From", "To", "Journey Date");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10}", emp_id, Location_from, Location_to, t_date);
        }
        public static void ViewTReq()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("All Travel Requests");
            Console.WriteLine("-------------------------\n");
            _tRequest.ViewTRequest();

        }
        public static void DelTReq()
        {
            Console.Clear();
            _tRequest.ViewTRequest();
            Console.WriteLine("\nEnter Request ID to delete Travel Request: ");
            int id = int.Parse(Console.ReadLine());
            _tRequest.DeleteTReq(id);

        }

        public static void ApproveTReq()
        {
            Console.Clear();
            
            Console.WriteLine("-------------------------------------------------");    
            Console.WriteLine("View All Pending Travel Requests for Approval");
            Console.WriteLine("-------------------------------------------------\n");
            //Console.WriteLine("\nView All Travel Requests which is Approved by Manager");
            _tRequest.PendingRequest();

            Console.WriteLine("\nSelect Request ID to update Approval Status: ");
            int astats = int.Parse(Console.ReadLine());

            TRequest sts_to_change= _tRequest.GetRequestBYid_BAL(astats);

            Console.WriteLine("\nCurrent Approval Status is 'Pending'.\nChange Status to :\n1.Approved \n2.Not Approved");
           
            Console.WriteLine("\nEnter Number of your choice: ");
            int AStats = int.Parse(Console.ReadLine()); 

            switch(AStats)
            {
                case 1: Console.WriteLine("Approval Status for Request ID {0} is set to Approved",astats);
                        //_tRequest.ChangetoApproved(astats);
                        sts_to_change.Approved_status = ApprovedStatus.Approved;
                        break;
                case 2: Console.WriteLine("Approval Status for Request ID {0} is set to Not Approved and Current Status is Closed", astats);
                    sts_to_change.Approved_status = ApprovedStatus.Not_Approved;
                    sts_to_change.Current_status = CurrentStatus.Closed;
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;
            }

            _tRequest.ViewTRequest();
            Console.WriteLine("Press 1 to continue or 0 to go Back");
            int abc = int.Parse(Console.ReadLine());
            if (abc == 1)
            {
                ApproveTReq();
            }else if(abc==0)
            {
                ManageTravelRequest();
            }
            Console.ReadLine();
            
            
        }
        public static void OpenTReq()
        {
            //Console.Clear();
           // Console.WriteLine("\nView All Requests whose Current status is Open");
            var VieOpenReq = from emp in _edm.employee1
                            join request in _reqMgr.requests
                            on emp.emp_id equals request.emp_id
                            where request.Approved_status== ApprovedStatus.Approved 
                            where request.Current_status == CurrentStatus.Open
                            select new
                            {
                                Request_ID = request.req_id,
                                Employee_ID = request.emp_id,
                                Employee_Name = emp.FName,
                                From = request.Location_from,
                                To = request.Location_to,
                                Date = request.t_date,
                                Approve_Status = request.Approved_status,
                                Booking_Status = request.Booking_status,
                                Current_Status = request.Current_status
                            };
            Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", "Request ID", "Emp ID", "Name", "From", "To", "Journey Date", "Approve Status", "Booking Status", "Current Status");

            foreach (var show in VieOpenReq)
            {
                Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", show.Request_ID, show.Employee_ID, show.Employee_Name, show.From, show.To, show.Date, show.Approve_Status, show.Booking_Status, show.Current_Status);
            }
        }
        public static void ClosedTReq()
        {
            Console.Clear();
            Console.WriteLine("\nView All Requests whose Current status is Closed");
            var VieCloseReq = from emp in _edm.employee1
                             join request in _reqMgr.requests
                             on emp.emp_id equals request.emp_id
                             where request.Current_status == CurrentStatus.Closed
                             select new
                             {
                                 Request_ID = request.req_id,
                                 Employee_ID = request.emp_id,
                                 Employee_Name = emp.FName,
                                 From = request.Location_from,
                                 To = request.Location_to,
                                 Date = request.t_date,
                                 Approve_Status = request.Approved_status,
                                 Booking_Status = request.Booking_status,
                                 Current_Status = request.Current_status
                             };

            Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", "Request ID", "Emp ID", "Name", "From", "To", "Journey Date", "Approve Status", "Booking Status", "Current Status");

            foreach (var show in VieCloseReq)
            {
                Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", show.Request_ID, show.Employee_ID, show.Employee_Name, show.From, show.To, show.Date, show.Approve_Status, show.Booking_Status, show.Current_Status);
            }
        }
        public static void ConfirmBooking()
        {
            Console.Clear();
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Travel requests with 'Pending' booking status");
            Console.WriteLine("----------------------------------------------------");

            OpenTReq();

            Console.WriteLine("\nSelect Request ID to update Booking Status: ");
            int cstats = int.Parse(Console.ReadLine());

            TRequest sts_to_change = _tRequest.GetRequestBYid_BAL(cstats);

            Console.WriteLine("\nCurrent Booking Status is 'Pending'.\nChange Status to :\n1.Booked \n2.Not Booked");

            Console.WriteLine("\nEnter Number of your choice: ");
            int CStats = int.Parse(Console.ReadLine());

            switch (CStats)
            {
                case 1:
                    Console.WriteLine("Booking Status for Request ID {0} is set to Booked and Current Status is Closed", cstats);
                    //_tRequest.ChangetoApproved(astats);
                    sts_to_change.Booking_status = BookingStatus.Booked;
                    sts_to_change.Current_status = CurrentStatus.Closed;
                    break;
                case 2:
                    Console.WriteLine("Booking Status for Request ID {0} is set to Not Booked and Current Status is Closed", cstats);
                    sts_to_change.Booking_status = BookingStatus.Not_Booked;
                    sts_to_change.Current_status = CurrentStatus.Closed;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            _tRequest.ViewTRequest();
            Console.ReadLine();

            //var VieBookReq = from emp in _edm.employee1
            //                 join request in _reqMgr.requests
            //                 on emp.emp_id equals request.emp_id
            //                 where request.Booking_status == BookingStatus.Booked
            //                 select new
            //                 {
            //                     Request_ID = request.req_id,
            //                     Employee_ID = request.emp_id,
            //                     Employee_Name = emp.FName,
            //                     From = request.Location_from,
            //                     To = request.Location_to,
            //                     Date = request.t_date,
            //                     Approve_Status = request.Approved_status,
            //                     Booking_Status = request.Booking_status,
            //                     Current_Status = request.Current_status
            //                 };
            //foreach (var show in VieBookReq)
            //{
            //    Console.WriteLine(show.Request_ID + " " + show.Employee_ID + " " + show.Employee_Name + " " + show.From + " " + show.To + " " + show.Date + " " + show.Approve_Status + " " + show.Booking_Status + " " + show.Current_Status);
            //}
        }

        public static void EditTReq()
        {
            TRequest req_to_Change;
            int req_choice=0;

            do
            {

                Console.Clear();
                _tRequest.ViewTRequest();
                //PendingReq();
                Console.WriteLine("\nEnter Request ID to edit Travel Request: ");
                int r_id = int.Parse(Console.ReadLine());

                req_to_Change = _tRequest.GetRequestBYid_BAL(r_id);
             
                if(req_to_Change.Approved_status==ApprovedStatus.Approved || req_to_Change.Approved_status==ApprovedStatus.Not_Approved)
                { 
                    Console.WriteLine("Request ID: {0} is in Process.....\nCannot be Edited!!!"); 
                }else

                if (req_to_Change.Approved_status == ApprovedStatus.Pending)
                {

                    Console.WriteLine("\n1.Change From Location \n2.Change Destination Location \n3.Change Journey Date \n4.Go Back");
                    //Console.WriteLine("\n1.Change From Location \n2.Change Destination Location \n3.Change Journey Date \n4.Go Back");
                    Console.WriteLine("Enter Number of your choice: ");

                    req_choice = int.Parse(Console.ReadLine());

                    switch (req_choice)
                    {
                        case 1:
                            Console.WriteLine("\nEnter new starting Location: \n");
                            string t_from = Console.ReadLine();
                            req_to_Change.Location_from = t_from;
                            break;
                        case 2:
                            Console.WriteLine("\nEnter New Destination Location: \n");
                            string t_to = Console.ReadLine();
                            req_to_Change.Location_to = t_to;
                            break;
                        case 3:
                            Console.WriteLine("\nEnter New Journey Date: \n");
                            DateTime t_date = DateTime.Parse(Console.ReadLine());
                            req_to_Change.t_date = t_date;
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Wrong Choice!");
                            break;

                    }
                }
                
            } while (req_choice != 4);

        }

        public static void PendingReq()
        {
            var pending = from emp in _edm.employee1
                          join request in _reqMgr.requests
                          on emp.emp_id equals request.emp_id
                          where request.Approved_status == ApprovedStatus.Pending
                          select new
                          {
                              Request_ID = request.req_id,
                              Employee_ID = request.emp_id,
                              Employee_Name = emp.FName,
                              From = request.Location_from,
                              To = request.Location_to,
                              Date = request.t_date,
                              Approve_Status = request.Approved_status,
                              Booking_Status = request.Booking_status,
                              Current_Status = request.Current_status

                          };
            Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", "Request ID", "Emp ID", "Name", "From", "To", "Journey Date", "Approve Status", "Booking Status", "Current Status");

            foreach (var show in pending)
            {
                Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", show.Request_ID, show.Employee_ID, show.Employee_Name, show.From, show.To, show.Date, show.Approve_Status, show.Booking_Status, show.Current_Status);

            }

        }
    }
}
