using System;

namespace ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Elbise";
            urun1.Fiyat = 125.00;
            urun1.Beden = 36;
            urun1.Renk = "Kırmızı";

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "Etek";
            urun2.Fiyat = 250.00;
            urun2.Beden = 38;
            urun2.Renk = "Siyah";

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "Mont";
            urun3.Fiyat = 650.00;
            urun3.Beden = 40;
            urun3.Renk = "Kahverengi";

            Urunler[] urunler = new Urunler[] { urun1, urun2, urun3 };
            int diziAdet = urunler.Length;
            while (diziAdet > 0)
            {
                Console.WriteLine("ÜRÜN ADI: " + urun1.UrunAdi + "\n" + "Fiyatı: " + urun1.Fiyat + "\n" + "Beden: " + urun1.Beden + "\n" + "Renk: " + urun1.Renk);
                Console.WriteLine();
                Console.WriteLine(" Ürün Adı: " + urun2.UrunAdi + "\n " + "Fiyatı: " + urun2.Fiyat + "\n " + "Beden: " + urun2.Beden + "\n" + " Renk: " + urun2.Renk);
                Console.WriteLine();
                Console.WriteLine(" Ürün Adı: " + urun3.UrunAdi + "\n " + "Fiyatı: " + urun3.Fiyat + "\n " + "Beden: " + urun3.Beden + "\n" + " Renk: " + urun3.Renk);
                diziAdet = 0;
            }
            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("ÜRÜN ADI: " + urun.UrunAdi + "\n" + "Fiyatı: " + urun.Fiyat + "\n" + "Beden: " + urun.Beden + "\n" + "Renk: " + urun.Renk);
            //}

            //for (int i = 0; i <1; i++)
            //{
            //    Console.WriteLine(" Ürün Adı: "+urun1.UrunAdi+"\n "+"Fiyatı: " + urun1.Fiyat+"\n " + "Beden: " + urun1.Beden+"\n" + " Renk: " + urun1.Renk);
            //    Console.WriteLine();
            //    Console.WriteLine(" Ürün Adı: " + urun2.UrunAdi + "\n " + "Fiyatı: " + urun2.Fiyat + "\n " + "Beden: " + urun2.Beden + "\n" + " Renk: " + urun2.Renk);
            //    Console.WriteLine();
            //    Console.WriteLine(" Ürün Adı: " + urun3.UrunAdi + "\n " + "Fiyatı: " + urun3.Fiyat + "\n " + "Beden: " + urun3.Beden + "\n" + " Renk: " + urun3.Renk);

            //}
            Console.Read();
        }
    }

    class Urunler
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public string Detay { get; set; }
        public byte Beden { get; set; }
        public string Renk { get; set; }
    }
}

