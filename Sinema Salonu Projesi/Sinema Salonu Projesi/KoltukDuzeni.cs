using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    public interface KoltukDuzeni
    {

        void BosKoltukTespit(ArrayList arrayList);          // bu interface içinde gerekli metodların şablonlarını oluşturduk.

        void BosKoltuklariGoster(ArrayList list);           // bu metod şablonlarını Koltuklar classında override edeceğiz. 

    }

}
