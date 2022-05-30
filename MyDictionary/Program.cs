using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plakaSehir1 = new MyDictionary<int, string>();
            plakaSehir1.Add(54,"Sakarya");

            for (int i = 0; i < plakaSehir1.Count; i++)
            {
                plakaSehir1.Count = i;
                Console.WriteLine("Plaka: {0}, Şehir: {1}", plakaSehir1.Count, plakaSehir1.Count);
            }
        }
    }
}
