using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.id + " " + musteri.adi + " " + musteri.soyadi + " " + musteri.boy + " " + musteri.kilo + "Eklediniz");
        }

        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.id + " " + musteri.adi + " " + musteri.soyadi + " " + musteri.boy + " " + musteri.kilo + "Listelendi");
            }
            
        }
        
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.id + " " + musteri.adi + " " + musteri.soyadi + " " + musteri.boy + " " + musteri.kilo + "Sildiniz");
        }
    }
}
// deneme