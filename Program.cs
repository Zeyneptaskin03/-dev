using System;

namespace ClassMetoDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Müsteri musteri1 = new Müsteri();
            musteri1.Id = 1;
            musteri1.TC = "123456789111";
            musteri1.Müsteriİsim = "Hacer";
            musteri1.MüsteriSoyisim = "Taskin";
            musteri1.MüsteriYas = 15;


            Müsteri musteri2 = new Müsteri();
            musteri2.Id = 2;
            musteri2.TC = "12342222211";
            musteri2.Müsteriİsim = "Zeynep";
            musteri2.MüsteriSoyisim = "Taskin";
            musteri2.MüsteriYas = 26;

            Müsteri musteri3 = new Müsteri();
            musteri3.Id = 3;
            musteri3.TC = "123456744411";
            musteri3.Müsteriİsim = "Rukiye";
            musteri3.MüsteriSoyisim = "Taskin";
            musteri3.MüsteriYas = 20;

            Müsteri[] müsteriler = new Müsteri[] { musteri1, musteri2, musteri3 };
            foreach (var musteri in müsteriler)
            {
                Console.WriteLine(musteri.Id+"   "+musteri.Müsteriİsim + "  "+ musteri.MüsteriSoyisim + "   " + musteri.MüsteriYas + "  " + musteri.TC);
                
            }

            MüsteriManager müsteriManager = new MüsteriManager();
            müsteriManager.Ekle(musteri1);
            müsteriManager.Ekle(musteri2);
            müsteriManager.Ekle(musteri3);


            MüsteriManager müsteriManager1 = new MüsteriManager();
            müsteriManager1.Liste(musteri1);
            müsteriManager1.Liste(musteri2);
            müsteriManager1.Liste(musteri3);

            MüsteriManager müsteriManager2 = new MüsteriManager();
            müsteriManager2.Silme(musteri1);
            müsteriManager2.Silme(musteri2);
            müsteriManager2.Silme(musteri3);

        }
    }
}
