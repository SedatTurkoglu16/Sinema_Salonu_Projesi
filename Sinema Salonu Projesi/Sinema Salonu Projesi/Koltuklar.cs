using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    public class Koltuklar : KoltukDuzeni                 // KoltukDuzeni interface'inden miras alınıyor.
    {

        public void BosKoltuklariGoster(ArrayList list)       // BosKoltuklariGoster metodu ile içindeki değerler 0 olan indexler
        {                                                     // foreach ile ekrana yazdırılıyor.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void BosKoltukTespit(ArrayList arrayList)      // BosKoltukTespit metodu ile boş olan koltuklar tespit ediliyor.
        {

            ArrayList TempArrayList = new ArrayList();        // öncelikle geçici bir arraylist oluşturuluyor.

            for (int i = 0; i < arrayList.Count; i++)         // burada arraylist içinde 0 değerleri aranıyor ve bulunan index değerleri
            {                                                 // geçici arrayliste atanıyor. 
                 
                if ((int)arrayList[i] == 0)
                {
                    TempArrayList.Add(i);
                }

            }

            BosKoltuklariGoster(TempArrayList);               // Bu geçici arraylist BosKoltuklariGoster() metoduna atanıyor.

        }

       


    }
}
