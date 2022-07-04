using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.DTOs
{
    public class ClientTokenDto
    {
        //Clientin görebileceği token bilgisi.
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiration { get; set; }

    }
}
