using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOfficeSpace
{
    internal class FileList
    {
        public string FileName { get; set; }

        public FileList(string fileName)
        {
            FileName = fileName;
        }
    }
}
