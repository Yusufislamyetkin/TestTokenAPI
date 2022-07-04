using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.DTOs
{
    public class TokenDto
    {   //Kimlik doğrulama sonrasında görebileceği token ve RefreshToken bilgisi
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiration { get; set; }

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpriration { get; set; }

    }
}
