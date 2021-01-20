using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;


            //classla yazdırdık yeni bi sistem oluşturup
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Kerem Varış ";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 80;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Engin Demirog";
            kurs3.IzlenmeOrani = 68;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Kerem";
            kurs4.IzlenmeOrani = 100;

            //kurs3 ten yazdırdık
            // Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen);

            //array larak tanımladık Kurs u  (eskiden string tutuyordum şumdu kurs objesi tutuyorum)
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };


            //kurs veri tipi atadık takma isim olarak / burası bizim ekranımız html
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


        }
    }




    class Kurs
    {//prop yaz tab tab
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
    
}
