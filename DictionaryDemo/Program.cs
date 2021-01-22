using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "ahmet");
            myDictionary.Add(2, "berat");
            myDictionary.Add(3, "engin");
        }
    }
}
