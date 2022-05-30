using System;
using System.Collections.Generic;

namespace GenericsTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<double> sehirler = new MyList<double>();
            sehirler.Add(222222222222222222222);
            
        }

    }
    class MyList<T>//GenericsClass
    {
        public void Add(T item)
        {

        }
    }
}
