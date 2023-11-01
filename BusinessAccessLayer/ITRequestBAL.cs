using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModel;

namespace BusinessAccessLayer
{
    internal interface ITRequestBAL
    {
        void ViewTRequest(); //join to employee for showing employee name
        int AddTReq(int req_id, int emp_id, string Location_from, string Location_to, DateTime t_date, ApprovedStatus A_Status, BookingStatus B_Status, CurrentStatus C_Status);

        int DeleteTReq(int req_id);

        TRequest GetRequestBYid_BAL(int id);
        void EditTReq_BAL(TRequest req_to_change);
        void PendingRequest();
    }
}
