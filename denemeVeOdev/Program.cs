using System;

namespace denemeVeOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Dizi dizi1 = new Dizi();
            dizi1.DiziIsmi = "Breking Bad";
            dizi1.DiziPuani = 10;
            dizi1.DiziSuresi = 40;

            Dizi dizi2 = new Dizi();
            dizi2.DiziIsmi = "Himym";
            dizi2.DiziPuani = 8;
            dizi2.DiziSuresi = 60;


            Dizi dizi3 = new Dizi();
            dizi3.DiziIsmi = "Spartacus";
            dizi3.DiziPuani = 9;
            dizi3.DiziSuresi = 45;

            Dizi[] diziler = new Dizi[] { dizi1, dizi2, dizi3 };

            for (int i = 0; i < diziler.Length; i++)
            {
                Console.WriteLine(diziler[i].DiziIsmi + "\n" + "süresi =  " + diziler[i].DiziSuresi + "  " + "puanı=" + diziler[i].DiziPuani);
            }

            // foreach (var dizi in diziler)
            // {


            // Console.WriteLine(dizi.DiziIsmi + "\n" + "süresi =  " + dizi.DiziSuresi+ "  " + "puanı=" + dizi.DiziPuani);

            // }





        }
    }


    class Dizi
    {

        public int DiziPuani { get; set; }

        public string DiziIsmi { get; set; }

        public int DiziSuresi { get; set; }





    }


}
