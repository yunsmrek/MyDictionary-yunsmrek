using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionarys
{
    class MyDictionary<T1, T2>
    {
        T1[] keys;
        T2[] values;
        T1[] tempKeys;
        T2[] tempValues;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];

        }
        public void Add(T1 key1, T2 value1)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key1;
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value1;
        }
        public int Count
        {
            get { return keys.Length; }
        }
    }
}
