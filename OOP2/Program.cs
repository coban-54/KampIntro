using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "12345";
            musteri1.Name = "Hüseyin";
            musteri1.Surname = "Çoban";
            musteri1.TcNumber = "21321312";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "342423";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.TaxNumber = "43543534534";
            //Gerçek müsteri -Tüzel müsteri
            //SOLID -L birbirinin yerine kullanma
            //Musteri değişkeni Tuzeli de gerçeğide tutabiliyor
            //BaseClass diğer alt classların referansını tutabiliyor
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

        }
    }
}
