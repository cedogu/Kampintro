using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            // IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager(); bu klasik kullanısı ve instance alma yöntemi
            //aşağıda yazdıgımız gibi inherit edilen Interface de miras yaptıgı classların referanslarını tutuyor.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            


            IKrediManager tasitKrediManager = new TasitKrediManager();
           


            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLogerService = new DatabaseLoggerService(); //klasik kullanma yolu
            ILoggerService fileLogerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};
         

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);  //bu da pratik kullanma yolu

            //basvurumanager.Basvuruyap(); kısmında parametre olarak hangisini verirsek hesapla otomatik olarak verdiğimiz Instance'i alır ve onun hesapla methodunu calıstırır.
            //kısaca hangi krediyi veirrsek onun hesapla methodu otomatik olarak calısır.



            //instance aldıgımızda class adıyla yazar ve new ile instance alarak onu Heap'a yollarız
            //Interface'ler de inherit/miras yaptığı class'ın referans numarasını tutar. Yani iki sekilde kullanımı yukarıda verildi.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            Console.Read();
        }
    }
}
