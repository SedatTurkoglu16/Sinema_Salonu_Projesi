using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Salonu_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Koltuklar koltuk = new Koltuklar();       // koltuklar BaseFilmler ve herbir Salon classının nesnelerini oluşturuyoruz.
            Salon1 s1 = new Salon1();
            Salon2 s2 = new Salon2();
            Salon3 s3 = new Salon3();
            Salon4 s4 = new Salon4();
            Salon5 s5 = new Salon5();
            Salon6 s6 = new Salon6();

        AnaMenu:
            Console.WriteLine(" 1.Yeni Bilet .\n 2.Çıkış  ");
            Console.Write("\nİstediğiniz işlemi seçin: ");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            int secilenBosKoltuk;

            switch (secim)          // switch case ile seçenekli kullanıcı arayüzü oluşturuyoruz
            {
                case 1:
                    Console.Write("Müşteri Adı: ");
                    string musteriAd = Console.ReadLine();        // Müşteriden gerekli bilgiler alınıyor.
                    Console.Write("Müşteri Yaşı: ");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n1- Avengers\n 2- Coco\n 3- John Wick\n 4- 7.Koğuştaki Mucize\n 5- Korku Seansı\n 6- DeadPool\n");
                    Console.Write("\nİstenen filmi seçiniz: ");
                    int filmSecim = Convert.ToInt32(Console.ReadLine());
                    switch (filmSecim)
                    {
                        case 1:
                            Console.WriteLine(s1.Film_isim);
                            Console.WriteLine("Salon 1 boş koltuklar görüntüleniyor: \n");

                            try                //  try catch blokları kullanarak metod parametre hatası olması durumunda
                            {                  //  bununla ilgili kullanıcıya detaylı hata mesajı gönderiliyor.


                                koltuk.BosKoltukTespit(s1.Salon1Koltuk);      // salonların boş koltuklarını görmek için koltuklar classında
                                                                          // bulunan BosKoltukTespit() metoduna ilgili salonun bilgilerini gönderiliyor.
                                                                              
                                Console.Write("\nBoş koltuklardan birini seçiniz: ");
                                secilenBosKoltuk = Convert.ToInt32(Console.ReadLine());
                                s1.BosKoltukSec(secilenBosKoltuk, s1.Salon1Koltuk);  // Müşteri boş koltuklardan birini seçer ve bu seçim ile
                                                                                     // film bilgileri metoda gönderilir.
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex);
                                throw;
                            }

                            goto AnaMenu;

                        case 2:
                            Console.WriteLine(s2.Film_isim);
                            Console.WriteLine("Salon 2 koltuk durumu görüntüleniyor: \n");
                            try
                            {
                                koltuk.BosKoltukTespit(s2.Salon2Koltuk);

                                Console.Write("\nBoş koltuklardan birini seçiniz: ");
                                secilenBosKoltuk = Convert.ToInt32(Console.ReadLine());
                                s2.BosKoltukSec(secilenBosKoltuk, s2.Salon2Koltuk);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex);
                                throw;
                            }
                            goto AnaMenu;

                        case 3:
                            Console.WriteLine(s3.Film_isim);
                            Console.WriteLine("Salon 3 koltuk durumu görüntüleniyor: \n");
                            try
                            {
                                koltuk.BosKoltukTespit(s3.Salon3Koltuk);

                                Console.Write("\nBoş koltuklardan birini seçiniz: ");
                                secilenBosKoltuk = Convert.ToInt32(Console.ReadLine());
                                s3.BosKoltukSec(secilenBosKoltuk, s3.Salon3Koltuk);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex);
                                throw;
                            }
                            goto AnaMenu;

                        case 4:
                            Console.WriteLine(s4.Film_isim);
                            Console.WriteLine("Salon 4 koltuk durumu görüntüleniyor: \n");
                            try
                            {
                                koltuk.BosKoltukTespit(s4.Salon4Koltuk);

                                Console.Write("\nBoş koltuklardan birini seçiniz: ");
                                secilenBosKoltuk = Convert.ToInt32(Console.ReadLine());
                                s4.BosKoltukSec(secilenBosKoltuk, s4.Salon4Koltuk);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex);
                                throw;
                            }
                            goto AnaMenu;

                        case 5:
                            Console.WriteLine(s5.Film_isim);
                            Console.WriteLine("Salon 5 koltuk durumu görüntüleniyor: \n");
                            try
                            {
                                koltuk.BosKoltukTespit(s5.Salon5Koltuk);

                                Console.Write("\nBoş koltuklardan birini seçiniz: ");
                                secilenBosKoltuk = Convert.ToInt32(Console.ReadLine());
                                s5.BosKoltukSec(secilenBosKoltuk, s5.Salon5Koltuk);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex);
                                throw;
                            }
                            goto AnaMenu;

                        case 6:
                            Console.WriteLine(s6.Film_isim);
                            Console.WriteLine("Salon 6 koltuk durumu görüntüleniyor: \n");
                            try
                            {
                                koltuk.BosKoltukTespit(s6.Salon6Koltuk);

                                Console.Write("\nBoş koltuklardan birini seçiniz: ");
                                secilenBosKoltuk = Convert.ToInt32(Console.ReadLine());
                                s6.BosKoltukSec(secilenBosKoltuk, s6.Salon6Koltuk);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex);
                                throw;
                            }
                            goto AnaMenu;

                    }
                    break;

                case 2:
                    break;
                
            }     
        }
    }
}
