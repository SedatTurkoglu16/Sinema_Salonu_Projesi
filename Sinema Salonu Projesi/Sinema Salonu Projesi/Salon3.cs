using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    class Salon3 : BaseSalonlar                          // Salon1 de açıklamalar mevcuttur.
    {

        private string film_isim = "John Wick";        

        FilmOzellikler fo = new FilmOzellikler();

        public string Film_isim
        {
            get
            {
                return film_isim;
            }
            set
            {
            }
        }

        public ArrayList Salon3Koltuk = new ArrayList();

        public Salon3()
        {
            fo.isim = Film_isim;
            fo.tur = "Aksiyon";
            fo.sure = "02:05:19";
            fo.yerli_yabanci = "yabanci";

            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(0);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(1);
            Salon3Koltuk.Add(0);
        }
    }
}
