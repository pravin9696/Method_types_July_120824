using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_types_July_120824
{
    class stud
    {
        public int id;
        public string name;
        public int totalMarks;
    }
    class College1
    {

        int[] arr; //member variable or instance variable

        public int[] xyz()
        {
            int []temp=new int[3] { 1111,2222,3333};

            return temp;//
        }
        public void showArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }  
        }
        public void  display(int p)
        { 
        }
        public void setArray(int[] ar1)
        {
            arr = ar1;
        }
        public void sortArray()        
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

        }
    }
    internal class Class130824
    {
        public void show()
        {
            College1 obj = new College1();
            #region
            //int q = 100;
            //obj.display(q);

            //int[] x = new int[] { 11,77,99,22,55,33,100,44,88,66 };


            //Console.WriteLine("Array before sort");

            //obj.setArray(x);
            //obj.showArray();
            //obj.sortArray();
            //Console.WriteLine("Array after sort");
            //obj.showArray();
            #endregion

            int[] t=obj.xyz();//get Array from method

            Console.WriteLine("elements in t array");
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
        }
    }
}
