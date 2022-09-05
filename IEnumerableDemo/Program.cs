using System.Collections.Generic;

namespace IEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection;

            unknownCollection = GetCollection(1);

            foreach (var item in unknownCollection)
            {
                System.Console.WriteLine(item + "");
            }

            unknownCollection = GetCollection(2);

            foreach (var item in unknownCollection)
            {
                System.Console.WriteLine(item + "");
            }

            unknownCollection = GetCollection(3);

            foreach (var item in unknownCollection)
            {
                System.Console.WriteLine(item + "");
            }

        }

        static IEnumerable<int> GetCollection(int option)
        {

            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQue = new Queue<int>();
            numbersQue.Enqueue(6);
            numbersQue.Enqueue(7);
            numbersQue.Enqueue(8);
            numbersQue.Enqueue(9);
            numbersQue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
