using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_types_July_120824
{
    internal class checkEvenNoInArray
    {
        private void PrintEven(int n)
        {
            if (n%2==0)
            {
                Console.WriteLine(n);
            }
        }
        public void ArrayDemo()
        {
            int[] x = new int[] { 4, 3, 5, 2, 8, 9, 1, 7 };

            
            for (int i = 0; i < x.Length; i++)
            {
                int tt = x[i];
                PrintEven(tt);
            }
        }

    }
}
