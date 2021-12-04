using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        { 
            //yukarıda ihtiyac,konut,tasit hangisini parametre olarak gönderirsek onların hesapla methodu calısır
            //IKrediManager ise hepsinin referansını tutmaktadır.

            //Basvuru bilgilerini değerlendirme

            krediManager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler )
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
