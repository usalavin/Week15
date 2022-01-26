using System;
using System.Collections.Generic;

namespace Frozen
{
    class Program
    {
        class Gifts
        {
            string name;
            string present;


            public Gifts(string _name, string _present)
            {
                name = _name;
                present = _present;
            }



            public string Name
            {
                get { return name; }
            }
            public string Present
            {
                get { return present; }
            }

        }
        static void Main(string[] agrs)
        {

           List<Gifts> myGifts = new List<Gifts>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Gifts newGift = new Gifts(tempArray[0], tempArray[1]);
                myGifts.Add(newGift);
            }

            foreach (Gifts giftFromList in myGifts)
            {
                Console.WriteLine($" {giftFromList.Name} wants  {giftFromList.Present} for Christmas.");

            }
        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\stano\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}

