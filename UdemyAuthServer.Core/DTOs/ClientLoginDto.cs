using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.DTOs
{
    public class ClientLoginDto
    {
        // Client'in göreceği dış pencere.
        public string ClıentID { get; set; }
        public string ClientSecret { get; set; }
    }
}
