using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMngt.REF
{
    public class REF_Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Status { get; set; }
        public string CreateDate { get; set; }
        public int CreateBy { get; set; }
        public string ModifyDate { get; set; }
        public int ModifyBy { get; set; }
    }
}
