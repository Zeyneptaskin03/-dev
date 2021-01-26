using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetoDemoo
{
    class MüsteriManager
    {
        public void Ekle(Müsteri müsteri)
        {
            Console.WriteLine("Yeni Müsteri: " + müsteri.Müsteriİsim + "   " + müsteri.MüsteriSoyisim + "    " + müsteri.TC + "   " + müsteri.MüsteriYas);
        }

        public void Liste(Müsteri müsteri)
        {
            Console.WriteLine("Müsteriler Listelendi " + müsteri.Müsteriİsim + "   " + müsteri.MüsteriSoyisim + "    " + müsteri.TC + "   " + müsteri.MüsteriYas);

        }

        public void Silme(Müsteri müsteri)
        {
            Console.WriteLine("Müsteriler Silindi: " + müsteri.Müsteriİsim + "   " + müsteri.MüsteriSoyisim + "    " + müsteri.TC + "   " + müsteri.MüsteriYas);

        }
    }
}
