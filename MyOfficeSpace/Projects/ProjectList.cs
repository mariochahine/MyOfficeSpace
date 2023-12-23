using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOfficeSpace
{
    internal class ProjectList
    {
        public string ProjectName { get; set; }

        public ProjectList(string projectname)
        {
            ProjectName = projectname;
        }
    }
}
