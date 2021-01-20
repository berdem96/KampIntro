using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 0.20;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] {urun1, urun2 };


            //type safe - tip güvenliği
            foreach (Urun urun in urunler)

            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------Metotlar--------------");


            //instance - örnek
            //encapsulation

            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);

            sepetManeger.Ekle2("Armut", "Yelil armut", 12,10);
            sepetManeger.Ekle2("elma", "Yelil elma", 12,9);
            sepetManeger.Ekle2("karpuz", "Diyarbakır karpuzu", 12,4);





        }
    }
}



//Dont repeat yourself - DRY - Clean Code - Best practice