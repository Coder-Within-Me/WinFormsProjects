using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPoC
{
    public class EmployeeDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string Employer { get; set; }
        public string Designation { get; set; }
    }
}
