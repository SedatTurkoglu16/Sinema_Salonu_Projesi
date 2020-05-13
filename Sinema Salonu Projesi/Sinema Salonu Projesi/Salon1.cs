using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{                                                 // Bu Salon1 classında yapılan tüm işlemler aynı şekilde diğer 5 salon classında da yapılıyor.
                                                  // dolayısıyla diğer classlar için bu yorum satırları eklenmeyecektir.
    public class Salon1: BaseSalonlar     // BaseFilmler classından miras alınıyor.
    {
        private string film_isim = "Avengers End Game";      // film ismini private olarak tanımlıyoruz.

        FilmOzellikler fo = new FilmOzellikler();

        public string Film_isim         // Kapsülleme yöntemini kullanarak private olan film_isim fieldımızı başka yerlerde kullanılabiliyor.
        { 
            get
            {
                return film_isim;
            }
            set
            {
            }
        }      

        public ArrayList Salon1Koltuk = new ArrayList();    // yeni arraylist oluşturuluyor.

        public Salon1()
        {

            fo.isim = Film_isim;                // classımızda yapıcı metot(CONSTRUCTOR) tanımlayıp içine salon bilgileri ekleniyor,
            fo.tur = "Süper Kahraman";          
            fo.sure = "02:42:34";
            fo.yerli_yabanci = "yabanci";

            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(0);
            Salon1Koltuk.Add(0);
            Salon1Koltuk.Add(0);                 // ve arraylist içine koltuk boş dolu durumları ekleniyor.
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(0);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(0);
            Salon1Koltuk.Add(0);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(0);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(1);
            Salon1Koltuk.Add(0);
            Salon1Koltuk.Add(1);
        }        
        
        
        
    }
}
