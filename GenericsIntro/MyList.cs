using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] İtems;//1 dizim var dizimi ekleyeceğim.
        //constractor
        public MyList()   //ctor tab tab listeyi burda newliyoruz
        {
            İtems = new T[0];// sıfır elemanlı dizi
        }
        public void Add(T item)
        {
            T[] tempArray = İtems;// geçici dizinin refi item in refi
            İtems = new T[İtems.Length+1];//Dizimin elaman sayısını bir arttırıyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                İtems[i] = tempArray[i];
            }
            İtems[İtems.Length - 1] = item;//üstte temp a. items a geçerken +1 index fazlalık kalır
            // o sebepten  -1  ini  alırız null siler

        }
    }
}
