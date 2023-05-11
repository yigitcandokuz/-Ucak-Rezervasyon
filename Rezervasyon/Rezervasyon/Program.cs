using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Rezervasyon
{
    interface Irezervasyon
    {
        void RezervasyonYap();
    }
    internal class Rezervasyon
    {
        private static object rezervasyonlar;
        private static char tarihsecim;
        private string? musteriAdi;
        private DateTime tarih;
        private string? lokasyon;
        private int koltukNumarasi;
        private char tarihsecim1;

        public Rezervasyon(string? musteriAdi, DateTime tarih, int koltukNumarasi)
        {
            this.musteriAdi = musteriAdi;
            this.tarih = tarih;
            this.koltukNumarasi = koltukNumarasi;
        }

        public Rezervasyon(string? musteriAdi, char tarihsecim1, int koltukNumarasi)
        {
            this.musteriAdi = musteriAdi;
            this.tarihsecim1 = tarihsecim1;
            this.koltukNumarasi = koltukNumarasi;
        }

        public Rezervasyon(string? musteriAdi, DateTime tarih, string? lokasyon, int koltukNumarasi)



        {
            this.musteriAdi = musteriAdi;
            this.tarih = tarih;
            this.lokasyon = lokasyon;
            this.koltukNumarasi = koltukNumarasi;
        }

        public static void Main(string[] args)
        {





            char anamenusecim = '0', altmenusecim = '0', lokasyonsecim = '0', tarihsecim = '0';
        MENU:
            Console.WriteLine("Uçak Rezervasyon Sistemi");
            Console.WriteLine("........................");
            Console.WriteLine("1-Lokasyonlar");
            Console.WriteLine("2-Tarihler");
            Console.WriteLine("3-Uçak");
            Console.WriteLine("4-Rezervasyon Yap");
            Console.WriteLine("5-çıkış");


            Console.Write("Seçiminizi Yapınız [1,2,3,4,5]:");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            if (anamenusecim == '1')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:1");
                Console.WriteLine("---Lokasyon Listesi---");
                Console.WriteLine("Londra (İngiltere):{5000 km}");
                Console.WriteLine("Paris (Fransa):{4000 km}");
                Console.WriteLine("Amsterdam (Hollanda):{4500 km}");
                Console.WriteLine(">>>Konumunuz İstanbul<<<");
            ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim == '2')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:2");
                Console.WriteLine("---Tarihler---");

                {
                    Console.WriteLine("12/05/2023 17,30  Londra (İngiltere)   A Uçağı");
                    Console.WriteLine("13/05/2023 15,20  Paris  (Fransa)   B Uçağı");
                    Console.WriteLine("13/05/2023 16,00  Amsterdam  (Hollanda)  C Uçağı");
                }
            ALTMENU:

                Console.Write("Seçimizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim == '3')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:2");
                Console.WriteLine("---uçaklar---");
                {
                    Console.WriteLine("A Uçağı  Kapasite=100   Boş Koltuk=55  ");
                    Console.WriteLine("B Uçağı  Kapasite=100   Boş Koltuk=48  ");
                    Console.WriteLine("C Uçağı  Kapasite=100   Boş Koltuk=67  ");
                }
            ALTMENU:

                Console.Write("Seçimizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }




            }
            else if (anamenusecim == '4')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:2");
                Console.WriteLine("---Rezervasyon Yap---");
                Console.WriteLine("A Uçağı Londra (İngiltere)  Kapasite=100   Boş Koltuk=55  ");
                Console.WriteLine("B Uçağı Paris (Fransa)  Kapasite=100   Boş Koltuk=48  ");
                Console.WriteLine("C Uçağı Amsterdam (Hollanda) Kapasite=100   Boş Koltuk=67  ");
                Console.WriteLine("Lokasyon Seçiniz [A,B,C]");
                lokasyonsecim = Convert.ToChar(Console.ReadLine());
                if (lokasyonsecim == 'A')
                {
                    Console.WriteLine("A Uçağı Londra (İngiltere)");
                }
                if (lokasyonsecim == 'B')
                {
                    Console.WriteLine("B Uçağı Paris(Fransa)"); 
                }
                if (lokasyonsecim == 'C')
                {
                    Console.WriteLine("C Uçağı Amsterdam (Hollanda)");
                }
                {
                    Console.WriteLine("12/05/2023 17.30 [A]");
                    Console.WriteLine("13/05/2023 15.20 [B]");
                    Console.WriteLine("13/05/2023 16,00 [C]");
                    Console.WriteLine("Tarih Seçiniz [A,B,C]");



                    Console.Write("Tarih: ");
                    tarihsecim = Convert.ToChar(Console.ReadLine());
                    if (tarihsecim == 'A')
                    {
                        Console.WriteLine("12/05/2023 17.30");
                    }
                    if (tarihsecim == 'B')
                    {
                        Console.WriteLine("13/05/2023 15.20");
                    }
                    if (tarihsecim == 'C')
                    {
                        Console.WriteLine("13/05/2023 16.00");
                    }
                    Console.Write("Müşteri Adı: ");
                    string musteriAdi = Console.ReadLine();

                    Console.Write("Koltuk Numarası: ");
                    int koltukNumarasi = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Rezervasyon başarıyla eklendi.\n");



                    Rezervasyon rezervasyon = new Rezervasyon(musteriAdi, tarihsecim,  koltukNumarasi);



                }
            ALTMENU:

                Console.Write("Seçimizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
                {

                }

            }
        }


    }
}