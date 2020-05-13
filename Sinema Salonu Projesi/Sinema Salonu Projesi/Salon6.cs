using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    class Salon6 : BaseSalonlar                             // Salon1 de açıklamalar mevcuttur.
    {
        private string film_isim = "DeadPool";

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

        public ArrayList Salon6Koltuk = new ArrayList();

        public Salon6()
        {
            fo.isim = Film_isim;
            fo.tur = "Suç";
            fo.sure = "02:07:41";
            fo.yerli_yabanci = "yabanci";

            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(1);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(0);
            Salon6Koltuk.Add(0);
        }
    }
}
