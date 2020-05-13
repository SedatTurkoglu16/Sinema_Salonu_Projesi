using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    class Salon4 : BaseSalonlar                                        // Salon1 de açıklamalar mevcuttur.
    {         
        private string film_isim = "7.Koğuştaki Mucize";

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


        public ArrayList Salon4Koltuk = new ArrayList();

        public Salon4()
        {
            fo.isim = Film_isim;
            fo.tur = "Dram";
            fo.sure = "01:48:55";
            fo.yerli_yabanci = "yerli";

            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(1);
            Salon4Koltuk.Add(0);
            Salon4Koltuk.Add(0);
        }
    }
}
