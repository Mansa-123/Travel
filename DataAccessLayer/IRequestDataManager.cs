using ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRequestDataManager
    {
        //int RaiseTReqDL(int req_id, int emp_id, string Locatio_from, string Location_to, DateTime t_date);

        //Edit ka baki hai travel request me
        //int EditTReqDL(TRequest trequest);
        void ViewTReqDL();

        int RaiseTReqDL(int id, int e_id, string from, string to, DateTime date, ApprovedStatus AStatus, BookingStatus BStatus, CurrentStatus CStatus);

        int DelTReq1(int req_id);
        //int DelTReqDL(int req_id);
        //int ApproveTReqDL(int req_id, ApprovedStatus appstatus);

        ////int OpenTReqDL();
        ////int CloseTReqDL();
        //int ConfirmBookingDL(int req_id, BookingStatus bookstatus);
    }
}
