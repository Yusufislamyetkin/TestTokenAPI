using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        // Hata mesajlarının yönetimi için dış dünyaya açılmak için Dto yapısını kullanmayı tercih ettik. Bu sayede client sadece bizim gönderdiğimiz hata mesajlarını görebilecek. Sistemin aldığı tüm hata yapısını değil.

        public List<string> Errors { get; private set; } // Datanın error listesi
        public bool ısShow { get;private set; } // Error gösterilsin mi ?

        public ErrorDto()
        {
            Errors = new List<string>(); // Lİsteyi tanımladık ilk yapıda.

        }

        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error); // Çıkan hatayı Error Listesine ekledik.

            isShow = true;  
        }


        public ErrorDto(List<string> errors, bool isShow) //Gönderilen hata verisini ekledik.
        {

            Errors = errors;
            this.ısShow = isShow;   
        }
    }
}
