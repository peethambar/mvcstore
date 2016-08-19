using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> llInt = new LinkedList<int>();
            llInt.Add(7);
            llInt.Add(6);
            llInt.Add(5);
            llInt.Add(4);
            llInt.Add(3);
            llInt.Add(2);
            llInt.Add(1);
            llInt.Add(0);

            //llInt.AddFirst(9);
            //llInt.AddLast(-1);

            foreach (var item in llInt)
            {
                Console.Write(item + " --> ");
            }

            Console.ReadLine();
        }
    }
}
