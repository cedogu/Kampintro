using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap(); 
        
        //interface= birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.





  //imzanın aynı ama içeriğin farklı olduğu durumlarda base'de olusturdumuz class'ı class olarak degil, interface olarak olustururuz.
  //Eğer bir interface kullanılmak istenilirse, onun içerdiği tüm metotlar da kullanılmak zorunda.
  //Yukarıdaki Hesapla ve diğer metotlar miras alan tüm classlar içinde geçerlidir.
  //Okunurluğu arttırmak için Interface'in basına I harfini veririz.
        
    }
}
