using System;

namespace GenericsIntro // Genericler T =Type a göre ekler
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            
        }
    }
}