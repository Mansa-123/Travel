using ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    
    public class RequestDataManager: IRequestDataManager
    {
        private static readonly EmpDataManager _em1 = new EmpDataManager();

        public List<TRequest> requests = new List<TRequest>()
        {
            new TRequest() { req_id=1, emp_id=1, Location_from="Wardha", Location_to="Pune", t_date=DateTime.Parse("23-11-2023"), Approved_status= ApprovedStatus.Approved, Booking_status = BookingStatus.Booked, Current_status = CurrentStatus.Closed},
            new TRequest() { req_id=2, emp_id=2, Location_from="Amravati", Location_to="Jabalpur", t_date=DateTime.Parse("23-11-2023"), Approved_status= ApprovedStatus.Pending, Booking_status = BookingStatus.Pending, Current_status = CurrentStatus.Open},
            new TRequest() { req_id=3, emp_id=1, Location_from="Nagpur", Location_to="Mumbai", t_date=DateTime.Parse("23-11-2023"), Approved_status= ApprovedStatus.Not_Approved, Booking_status = BookingStatus.Pending, Current_status = CurrentStatus.Closed},
            new TRequest() { req_id=4, emp_id=3, Location_from="Pune", Location_to="Kolhapur", t_date=DateTime.Parse("23-11-2023"), Approved_status= ApprovedStatus.Pending, Booking_status = BookingStatus.Pending, Current_status = CurrentStatus.Open},
            new TRequest() { req_id=5, emp_id=4, Location_from="Mumbai", Location_to="Howrah", t_date=DateTime.Parse("23-11-2023"), Approved_status= ApprovedStatus.Approved, Booking_status = BookingStatus.Not_Booked, Current_status = CurrentStatus.Closed},
            new TRequest() { req_id=6, emp_id=5, Location_from="Badnera", Location_to="Jaipur", t_date=DateTime.Parse("23-11-2023"), Approved_status= ApprovedStatus.Approved, Booking_status = BookingStatus.Pending, Current_status = CurrentStatus.Open},
            new TRequest() { req_id=7, emp_id=4, Location_from="Delhi", Location_to="Mumbai", t_date=DateTime.Parse("23-11-2023"), Approved_status= ApprovedStatus.Approved, Booking_status = BookingStatus.Pending, Current_status = CurrentStatus.Open}



        };
        public int RaiseTReqDL(int id, int e_id, string from, string to, DateTime date, ApprovedStatus AStatus, BookingStatus BStatus, CurrentStatus CStatus)
        {
            requests.Add(new TRequest() { req_id = id, emp_id = e_id, Location_from = from, Location_to = to, t_date = date, Approved_status = AStatus, Booking_status = BStatus, Current_status = CStatus });
            ViewTReqDL();
            return 1;
        }

        public void ViewTReqDL()
        {
            //foreach(TRequest req in requests) 
            //{ 
            //    Console.WriteLine(req.ToString());
            //}
            var ViewReq = from emp in _em1.employee1
                          join req in requests
                          on emp.emp_id equals req.emp_id
                          select new
                          {
                              Request_ID = req.req_id,
                              Employee_ID = req.emp_id,
                              Employee_Name = emp.FName,
                              From = req.Location_from,
                              To = req.Location_to,
                              Date = req.t_date,
                              Approve_Status = req.Approved_status,
                              Booking_Status = req.Booking_status,
                              Current_Status = req.Current_status
                              
                          };
            Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", "Request ID", "Emp ID", "Name", "From", "To", "Journey Date", "Approve Status", "Booking Status", "Current Status");
           
            foreach (var show in ViewReq)
            {

                Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", show.Request_ID, show.Employee_ID, show.Employee_Name, show.From, show.To, show.Date, show.Approve_Status, show.Booking_Status, show.Current_Status);

            }
        }
        public int DelTReq1(int req_id)
        {
            //public static int id { get; set; }
            //Console.WriteLine("Inside Delete");
            var deletedata = requests.Remove(requests.FirstOrDefault(emp => emp.req_id == req_id));

            Console.WriteLine("\nData of Employee with ID {0} is deleted !!!\n", req_id);

            ViewTReqDL();

            return 1;
        }

        public TRequest GetRequestBYid(int id)
        {
            TRequest treq = requests.FirstOrDefault(req => req.req_id == id);
            if (treq != null)
            {
                return treq;
            }
            return null;
        }

        public void EditTReq(TRequest treq)
        {
            TRequest req_main = requests.FirstOrDefault(req=>req.req_id==treq.req_id);
            int index = requests.IndexOf(req_main);

            
            requests[index].Location_from = req_main.Location_from;
            requests[index].Location_to = req_main.Location_to;
            requests[index].t_date = req_main.t_date;
        }

        public void PendingReq()
        {
            var VieAppReq = from emp in _em1.employee1
                            join request in requests
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
            foreach (var show in VieAppReq)
            {
                Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", show.Request_ID, show.Employee_ID, show.Employee_Name, show.From, show.To, show.Date, show.Approve_Status, show.Booking_Status, show.Current_Status);
            }
        }

        //public void Approved(int req)
        //{
        //    var approved = from emp in _em1.employee1
        //                    join request in requests
        //                    on emp.emp_id equals request.emp_id
        //                    where request.req_id == req
        //                    select new
        //                    {
        //                        Request_ID = request.req_id,
        //                        Employee_ID = request.emp_id,
        //                        Employee_Name = emp.FName,
        //                        From = request.Location_from,
        //                        To = request.Location_to,
        //                        Date = request.t_date,
        //                        Approve_Status = ApprovedStatus.Approved,
        //                        Booking_Status = request.Booking_status,
        //                        Current_Status = request.Current_status
        //                    };
            //Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", "Request ID", "Emp ID", "Name", "From", "To", "Journey Date", "Approve Status", "Booking Status", "Current Status");
            //foreach (var show in approved)
            //{
            //    Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -20} {6, -20} {7, -20} {8, -20}", show.Request_ID, show.Employee_ID, show.Employee_Name, show.From, show.To, show.Date, show.Approve_Status, show.Booking_Status, show.Current_Status);
            //}
            //ViewTReqDL();
        //}
    }
}
