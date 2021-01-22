using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<Tkeys, Tvalues>
    {
        Tkeys[] keysArray;
        Tvalues[] valuesArray;

        public MyDictionary()
        {
            keysArray = new Tkeys[0];
            valuesArray = new Tvalues[0];
        }
        public void Add(Tkeys itemKey, Tvalues itemValue)
        {
            Tkeys[] tempKeysArray = keysArray;
            Tvalues[] tempValuesArray = valuesArray;

            keysArray = new Tkeys[keysArray.Length + 1];
            valuesArray = new Tvalues[valuesArray.Length + 1];
            
            for (int i = 0; i < tempKeysArray.Length; i++)
            {
                keysArray[i] = tempKeysArray[i];
                valuesArray[i] = tempValuesArray[i];
            }
            keysArray[keysArray.Length] = itemKey;
            valuesArray[valuesArray.Length] = itemValue;
        }
    }
}
