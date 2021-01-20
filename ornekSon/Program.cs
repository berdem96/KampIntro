using System;

namespace ornekSon
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Elbise";
            urun1.Fiyat = 12.54;
            urun1.Beden = 42;
            urun1.Renk = "Kırmızı";

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "mont";
            urun2.Fiyat = 120.54;
            urun2.Beden = 40;
            urun2.Renk = "mavi";



            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "şort";
            urun3.Fiyat = 35.54;
            urun3.Beden = 43;
            urun3.Renk = "Kırmızı";

            Urunler urun4 = new Urunler();
            urun4.UrunAdi = "asdasd";
            urun4.Fiyat = 1254.54;
            urun4.Beden = 420;
            urun4.Renk = "yeşil";

          //  Urunler[] urunler = new Urunler[] {urun1, urun2, urun3, urun4 };
            Urunler[] urunler = new Urunler[] { urun1, urun2, urun3, urun4 };
            int urunAdet = urunler.Length;

            Console.WriteLine("while döngüsü" + "\n");

            while (urunAdet > 0)

            {
                Console.WriteLine("Ürün Adı=" + urun1.UrunAdi + "\n" + "fiyatı =" + urun1.Fiyat + "\n" + "Beden =" + urun1.Beden +
                    "\n" + "renk =" + urun1.Renk + "\n");
                Console.WriteLine("Ürün Adı=" + urun2.UrunAdi + "\n" + "fiyatı =" + urun2.Fiyat + "\n" + "Beden =" + urun2.Beden +
                    "\n" + "renk =" + urun2.Renk + "\n");
                Console.WriteLine("Ürün Adı=" + urun3.UrunAdi + "\n" + "fiyatı =" + urun3.Fiyat + "\n" + "Beden =" + urun3.Beden +
                    "\n" + "renk =" + urun3.Renk + "\n");
                Console.WriteLine("Ürün Adı=" + urun4.UrunAdi + "\n" + "fiyatı =" + urun4.Fiyat + "\n" + "Beden =" + urun4.Beden +
                    "\n" + "renk =" + urun4.Renk + "\n");
                urunAdet = 0;

            }
            Console.WriteLine("for each" + "\n");

            foreach (var urun in urunler)
            {

                Console.WriteLine("Ürün adı" + urun.UrunAdi + "\n" + "renk " + urun.Renk + "\n" + "fiyat" + 
                    urun.Fiyat + "\n" + "beden" + urun.Beden + "\n");



            }
            Console.WriteLine("for döngüsü" + "\n");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Ürün Adı=" + urun1.UrunAdi + "\n" + "fiyatı =" + urun1.Fiyat + "\n" + "Beden =" + urun1.Beden +
                    "\n" + "renk =" + urun1.Renk + "\n");
                Console.WriteLine("Ürün Adı=" + urun2.UrunAdi + "\n" + "fiyatı =" + urun2.Fiyat + "\n" + "Beden =" + urun2.Beden +
                    "\n" + "renk =" + urun2.Renk + "\n");
                Console.WriteLine("Ürün Adı=" + urun3.UrunAdi + "\n" + "fiyatı =" + urun3.Fiyat + "\n" + "Beden =" + urun3.Beden +
                    "\n" + "renk =" + urun3.Renk + "\n");
                Console.WriteLine("Ürün Adı=" + urun4.UrunAdi + "\n" + "fiyatı =" + urun4.Fiyat + "\n" + "Beden =" + urun4.Beden +
                    "\n" + "renk =" + urun4.Renk + "\n");




            }




            // Urunler[] urunler = new Urunler[] {urun1, urun2, urun3, urun4 };
            //int urunAdet = urunler.Length;
        }
        class Urunler
        {
            public string UrunAdi { get; set; }
            public string Renk { get; set; }
            public double Fiyat { get; set; }
            public string Detay { get; set; }
            public int Beden { get; set; }

        }
    }
}
