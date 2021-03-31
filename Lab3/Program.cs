using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 5, 2, 4, 1, 8, 3 };
            Sorter sorter = new Sorter();
            sorter.sort(a);
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
