using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMngt.REF
{
    public class REF_Employee
    {
        public int EmployeeID { get; set; }
        public int DepatmentID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }
        public int Status { get; set; }
        public string CreateDate { get; set; }
        public int CreateBy { get; set; }
        public string ModifyDate { get; set; }
        public int ModifyBy { get; set; }
    }
}
