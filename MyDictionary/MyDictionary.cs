using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] Keys;
        V[] Values;
        public MyDictionary()
        {
            Keys = new K[0];
            Values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempArrayK = Keys;
            V[] tempArrayV = Values;
            Keys = new K[Keys.Length + 1];
            Values = new V[Values.Length + 1];

            for (int i = 0; i <tempArrayK.Length; i++)
            {
                Keys[i] = tempArrayK[i];
                Values[i] = tempArrayV[i];
            }
            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;
        }
    }
}
