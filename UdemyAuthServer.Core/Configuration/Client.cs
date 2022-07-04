using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.Configuration
{
    public class Client
    {
        //Sistemimizdeki herkese açık apilere bağlanacak kullanıcı için appsetting.json dosyasında yer alan veriler ile eşleştirme yapacağımız.
        //Client ile ilgili özellikler..
        public string Id { get; set; }
        public string Secret { get; set; }

        public List<String> Audiences { get; set; }
    }
}
