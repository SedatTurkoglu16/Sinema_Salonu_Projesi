using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    public class Salon2 : BaseSalonlar                 // Salon1 de açıklamalar mevcuttur.
    {
        private string film_isim = "Coco";

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

        FilmOzellikler fo = new FilmOzellikler();

        public ArrayList Salon2Koltuk = new ArrayList();

        public Salon2()
        {

            fo.isim = Film_isim;
            fo.tur = "Animasyon";
            fo.sure = "01:52:26";
            fo.yerli_yabanci = "yabanci";

            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(0);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(0);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
            Salon2Koltuk.Add(1);
        }

    }
}
