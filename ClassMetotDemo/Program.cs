using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.adi = "Aslı";
            musteri1.soyadi = "Can";
            musteri1.boy = 165;
            musteri1.kilo = 55;

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.adi = "Zeynep";
            musteri2.soyadi = "Gül";
            musteri2.boy = 160;
            musteri2.kilo = 52;

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.adi = "Hakan";
            musteri3.soyadi = "San";
            musteri3.boy = 181;
            musteri3.kilo = 73;

            Musteri musteri4 = new Musteri();
            musteri4.id = 4;
            musteri4.adi = "Mert";
            musteri4.soyadi = "Kan";
            musteri4.boy = 178;
            musteri4.kilo = 69;


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            Console.WriteLine("------Eklendi-----");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.adi + " " + musteri.soyadi + " " + musteri.boy + " " + musteri.kilo);
            }

            Console.WriteLine("-----Listelendi-----");


            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);
            musteriManager.Delete(musteri4);
            Console.WriteLine("-----Silindi-----");


            




        }
    }
}
