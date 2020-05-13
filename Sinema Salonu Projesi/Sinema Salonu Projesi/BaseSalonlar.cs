using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    public abstract class BaseSalonlar         // diğer 6 tane salon class'ına bu temel class'taki özellikleri miras vermek için
    {                                           // abstract olarak tanımladık.

        public struct FilmOzellikler
        {
            public string isim;
            public string tur;                  // Burada struct yapısı içerisinde film bilgilerini tutacak olan fieldlar tanımlanıyor.
            public string sure;                 // Ve bu fieldlar diğer classlarda kullanılıyor.
            public string yerli_yabanci;
           
        }

        public void BosKoltukSec(int value, ArrayList arraylist)         // Program.cs den gönderilen secilmek istenen koltuk numarası 
        {                                                               // BosKoltukSec() içine yollnıyor.
            if ((int)arraylist[value] == 0)
            {                                                         // Burada boş koltuk (0) bulunup o index değeri yerine 1 yazılıyor.
                                                                     // bu da koltuğun dolması anlamına geliyor.
                arraylist[value] = 1;
                Console.WriteLine("Bilet satın alma işlemi başarıyla gerçekleşti.");

            }
        }
    }
}
