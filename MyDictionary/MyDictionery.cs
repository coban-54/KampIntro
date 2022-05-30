using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKeys,TValue>
    {
        TKeys[] keys;
        TValue[] values;

        public MyDictionary() //Ctor tanımladık
        {
            keys = new TKeys[0];
            values = new TValue[0];
        }
        public void Add(TKeys key, TValue value)
        {
            TKeys[] tempKeys = keys;
            TValue[] tempValue = values;

            keys = new TKeys[keys.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return keys.Length; }
        }

    }
x
}
