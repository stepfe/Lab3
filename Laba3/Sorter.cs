using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public class Sorter
    {
        public void sort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = i; j > 0 && a[j - 1] > a[j]; j--)
                {
                    int h = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = h;
                }
            }
        }
    }
}
