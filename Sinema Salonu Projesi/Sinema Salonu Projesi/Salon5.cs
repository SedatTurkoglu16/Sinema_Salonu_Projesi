using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    class Salon5 : BaseSalonlar                                // Salon1 de açıklamalar mevcuttur.
    {
        private string film_isim = "Korku Seansı";

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


        public ArrayList Salon5Koltuk = new ArrayList();

        public Salon5()
        {
            fo.isim = Film_isim;
            fo.tur = "Korku";
            fo.sure = "01:58:37";
            fo.yerli_yabanci = "yabanci";

            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(1);
            Salon5Koltuk.Add(0);
            Salon5Koltuk.Add(1);




        }
    }
}
