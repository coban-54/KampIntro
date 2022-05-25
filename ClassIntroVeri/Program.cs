using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hüseyin";
            int yas = 26;

            Kurs kurs1 = new Kurs();// tip tanımı class la yapıldı
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();// tip tanımı class la yapıldı
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.İzlenmeOrani = 22;

            Kurs kurs3 = new Kurs();// tip tanımı class la yapıldı
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay bilgin";
            kurs3.İzlenmeOrani = 80;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};// içinde kurs nesnesini barındıran kurs arrayi

            foreach (var kurs in kurslar)// var yerine kurs ta diyebiliriz
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.KursunEgitmeni);//Sadece kurs adları yazar
            }
        }
    }

    class Kurs
    
    {
        //prop yazarsak intelisans ta çıkar
        public string KursAdi { get; set; }

        public string KursunEgitmeni { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}