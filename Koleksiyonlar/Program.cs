using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main()
        {
            List<string> isimler2 = new List<string> { "Engin", "Murat", "kerem", "Halil" };
            //Biz aynı arrayler mantığıyla listeler ekleriz.Arayyler değişmez bellek adresi yüzünden(pointer)Ama  listelere ekleme yapılır.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[2]);
            


        }
    }
}