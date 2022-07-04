using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class CreateUserDto
    { 
        //User kayıt sırasında sadece almak istediğimiz ve sadece clientin göreceği veriler.
        public string  UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
