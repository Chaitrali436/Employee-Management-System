using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employees
    {
        public int empID { get; set; }
        public string empFname { get; set; }
        public string empMname { get; set; }
        public string empLname { get; set; }
        public string empRoleID { get; set; }
        public string empContact { get; set; }
        public string empCountryCode { get; set; }
        public string empAddress { get; set; }
        public DateTime empDOB { get; set; }
        public DateTime empJoiningDate { get; set; }
        public DateTime empLWD { get; set; }
        public decimal empSalary { get; set; }
        public string empGovID { get; set; }
        public string empIDNumber { get; set; }
        public int empCreatedBy { get; set; }
        public int empUpdatedBy { get; set; }
        public int empGenderID { get; set; }
        public string empEmailID { get; set; }
       
    }
}
