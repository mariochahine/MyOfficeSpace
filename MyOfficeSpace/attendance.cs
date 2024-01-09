using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOfficeSpace.Tasks
{
    internal class attendance
    {
        public string EmployeeSSN { get; set; }
        public string Day { get; set; }
        public string SignIn { get; set; }
        public string SignOut { get; set; }

        public attendance(string employeeSSN, string day, string signIn, string signOut)
        {
            EmployeeSSN = employeeSSN;
            Day = day;
            SignIn = signIn;
            SignOut = signOut;
        }
    }
}
