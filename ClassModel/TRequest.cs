using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassModel
{
    public enum ApprovedStatus { Pending, Approved, Not_Approved };

    public enum BookingStatus { Pending, Booked, Not_Booked };

    public enum CurrentStatus { Open, Closed }
    public class TRequest
    {
        public int req_id {  get; set; }

        public int emp_id { get; set; }

        public string Location_from { get; set; }
        public string Location_to { get; set; }
        public DateTime t_date { get; set; }
        public ApprovedStatus Approved_status { get; set; }
        public BookingStatus Booking_status { get; set; }
        public CurrentStatus Current_status { get; set; }
        //public string Approved_status { get; set; }

        //public string Booking_status { get; set; }
        //public string Current_status { get;set; }

        public override string ToString()
        {
            return string.Format("Req-Id : {0}, Emp-Id : {1}, From: {2}, To: {3}, Date: {4}, Approved Status: {5}, Booking Status: {6}, Current Status:{7}",req_id, emp_id, Location_from, Location_to, t_date, Approved_status, Booking_status, Current_status);

        }
    }
}
