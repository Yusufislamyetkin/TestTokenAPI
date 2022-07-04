using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class UserAppDto
    {
        // User'ın dış dünyaya bakan tarafı. UserApp modelimizde user hakkında onlarca prop varken dış dünyaya sadece bunları açmayı bunlarla işlem yapmayı tercih ettik.
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
