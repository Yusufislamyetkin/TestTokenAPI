using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class
    {
        //Bu bir dto yapısı yani sadece client ile iletişim kurulacakken kullanırız. Dış dünyaya açılan penceremiz gibi.
        [JsonIgnore] //Json ile göndereceğimiz için bu yapıyı json ignore ise işlem başarılı mı başarısız mı bu kayıtta kendimiz tutarız ve işlemlerimizde kullanırız.
        public bool IsSuccessful { get; private set; }

        public T Data { get; private set; } // Entitynin verisini tutar.
        public int StatusCode { get; private set; } // 200 ok gibi status code tutulur.
        public ErrorDto Error { get; private set; } // Eğer bir hata varsa yapılan işlemde ErrorDto classındaki yapıda hatalar tutulur.

        public static Response<T> Success(T data, int StatusCode)  // Static Response yapısı sayesinde gelen entitynin durumundan sadece data ve status code yapısını geri döndürürüz. Bu client tarafında kodun anlaşılır yapısı için gereklidir.
        {
            return new Response<T> { Data = data, StatusCode = StatusCode , IsSuccessful = true};
        }
        public static Response<T> Success(int StatusCode) // Verilen entity'nin durum kodu döndürülür sadece. (update ve revoke işleminde tercih edilir. Best Prec açısından)
        {
            return new Response<T> {Data=default, StatusCode = StatusCode , IsSuccessful = true};
        }
        public static Response<T> Fail (ErrorDto errorDto, int StatusCode) // Aynı şejkilde verilen entitynin hata mesajları ve hata durum kodu döndürülür.
        {
            return new Response<T> { Error = errorDto, StatusCode = StatusCode, IsSuccessful = false };

        }
        public static Response<T> Fail(string errorMessage,int StatusCode,bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);

            return new Response<T> { Error = errorDto, StatusCode = StatusCode, IsSuccessful = false};

        } // Verilen Entity'nin tek bir mesajı varsa eğer tek mesaj ve tek hata kodu döndürülür.

    }
}
