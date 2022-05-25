using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";//Bu gereksiz uygulama

            // array = dizi

            string[] kurslar = new string[] { "Yazılım geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java" ,"Python","C#"};


            for (int i = 0; i<kurslar.Length; i++)//i+=2 iki şer artırır
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)//Koleksiyonun içinde döner.
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
