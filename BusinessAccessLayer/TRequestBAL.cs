using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModel;

namespace BusinessAccessLayer
{
    //public enum ApprovedStatus { Pending, Approved, Not_Approved };

    //public enum BookingStatus { Booked, Not_Booked };

    //public enum CurrentStatus { Open, Closed }
    public class TRequestBAL: ITRequestBAL
    {
       private static readonly RequestDataManager _reqManager = new RequestDataManager();
        public void ViewTRequest()
        {
            _reqManager.ViewTReqDL();

        }

        public int AddTReq(int r_id, int e_id, string from, string to, DateTime j_date, ApprovedStatus ap_status, BookingStatus b_status, CurrentStatus c_status )
        {
            _reqManager.RaiseTReqDL(r_id,e_id,from,to,j_date, ap_status, b_status, c_status);
            return 1;
        }

        public int DeleteTReq(int r_id)
        {
            _reqManager.DelTReq1(r_id);
            return 1;
        }

        public TRequest GetRequestBYid_BAL(int id)
        {

            TRequest req = _reqManager.GetRequestBYid(id);

            return req;
        }

        public void EditTReq_BAL(TRequest req_to_change)
        {
            _reqManager.EditTReq(req_to_change);
        }

        public void PendingRequest()
        {
            _reqManager.PendingReq();
        }

        //public void ChangetoApproved(int sts)
        //{
        //    _reqManager.Approved(sts);
        //}
    }
}
