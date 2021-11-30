using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention (isimlendirme kuralı)
        public void Ekle(Urun urun) //---- parametre
        {
            Console.WriteLine("Ürününüz Sepete Eklendi : " + urun.Adi);
        }

        //niye asagıdaki gibi yazmamalıyız. cünkü class yaptıgımızda tek bir kere tanımlarız ve her yerde yazmamıza gerek yok
        //asagıdaki gibi yaparsak her daim tek tek yazmamız gerekecek
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Ürününüz Sepete Eklendi : " + urunAdi);
        }

    }
}
