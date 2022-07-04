using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.DTOs
{
    public class LoginDto
    {
        //Login sırasında kullanıcının görebileceği veriler.
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
