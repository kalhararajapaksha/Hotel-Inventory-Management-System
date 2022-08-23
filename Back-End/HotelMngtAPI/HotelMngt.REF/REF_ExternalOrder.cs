using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMngt.REF
{
    public class REF_ExternalOrder
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int AV_QTY { get; set; }
        public int Req_QTY { get; set; }
        public int Status { get; set; }
        public double PricePerUnit { get; set; }
        public string OrderDate { get; set; }
        public int OrderBy { get; set; }
        public string RecivedDateAndTime { get; set; }
        public string ApprovedDate { get; set; }
        public int ApprovedBy { get; set; }
    }
}
