﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManeger

    {
        
        //naming convertion - () görürsen sadece orada bir metod çalışıyor
        
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);

        }



    }
}
