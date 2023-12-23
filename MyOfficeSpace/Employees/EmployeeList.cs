using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOfficeSpace
{
    internal class EmployeeList
    {
        public string EmployeeName { get; set; }

        public EmployeeList(string Employeename)
        {
            this.EmployeeName = Employeename;
        }
    }
}
