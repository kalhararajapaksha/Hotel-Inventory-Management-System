using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMngt.REF
{
    public class REF_User
    {
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CreateDate { get; set; }
        public int CreateBy { get; set; }
        public string ModifyDate { get; set; }
        public int ModifyBy { get; set; }
        public int Satus { get; set; }
    }
}
