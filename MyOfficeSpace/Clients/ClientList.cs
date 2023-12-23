using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOfficeSpace
{
    internal class ClientList
    {
        public string ClientName { get; set; }

        public ClientList(String clientname)
        {
            ClientName = clientname;
        }
    }
}
