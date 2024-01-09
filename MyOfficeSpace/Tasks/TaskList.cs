using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOfficeSpace.Tasks
{
    internal class TaskList
    {
        public string TaskNumber { get; set; }
        public string EmployeeName { get; set; }
        public string TaskDetails { get; set; }

        
        public TaskList(string taskNumber, string employeeName, string taskDetails)
        {
            TaskNumber = taskNumber;
            EmployeeName = employeeName;
            TaskDetails = taskDetails;
        }
    }
}
