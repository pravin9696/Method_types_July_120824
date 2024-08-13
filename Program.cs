using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_types_July_120824
{
    class class1
    {
        int y;
        float pi = 3.14f;
        public double getPI()
        {
            return pi;
        }
        public void show(int x)//method with argument without return value
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
            
        }
        public int sum(int a, int b)//a=100  b=200 //metod with argument and return value
        {
            int total = a + b;//total=300
            return total;
            Console.WriteLine("hello");
        }


        public Boolean IsEven(int n) // method with argument and return value
        {
            if (n%2==0)
            {
                return true; ;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 12-8-24 code

            // //step1 object of class in which method is written
            // //step2 using that object class method with the help of 
            // //  .(member access operator)  

            // class1 obj1 = new class1();
            // //obj1.show(14);
            // //int n;
            // //Console.WriteLine("enter no");
            // //n = int.Parse(Console.ReadLine());
            // //obj1.show(n);
            // int x = 100;
            // int y = 200;
            // int z;

            // z = obj1.sum(x,y);
            // Console.WriteLine("total of x and y="+z);//300


            // // condition 1
            // //check given number is even or odd

            // int nn;
            //// Console.WriteLine("Enter no");
            //// nn = Convert.ToInt32(Console.ReadLine());//34

            ////bool v=  obj1.IsEven(nn);
            //// if (v==true)
            //// {
            ////     Console.WriteLine($"{nn} is Even number");
            //// }
            //// else
            //// {
            ////     Console.WriteLine($"{nn} is odd number");
            //// }
            // // condition 2
            // // accept array from user and print sum of even elements from array

            // int[] arr = new int[] { 10, 11, 12, 13, 14, 16 };//52
            // int sm = 0;

            // //arr====================> Single element or array
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     //bool result = obj1.IsEven(arr[i]);
            //     //if (result==true)
            //     //{
            //     //    sm = sm + arr[i];
            //     //}

            //     if (obj1.IsEven(arr[i]))
            //     {
            //         sm = sm + arr[i];
            //     }
            // }
            // //Console.WriteLine("sum="+sm);
            // Console.WriteLine($"sum={sm}");

            // //float p=(float)obj1.getPI();

            // //var p = obj1.getPI();
            // var p = obj1.IsEven(11);
            #endregion

            //Class130824 obj1 = new Class130824();
            //obj1.show();

            //--------------------------------

            checkEvenNoInArray ceObj = new checkEvenNoInArray();
            ceObj.ArrayDemo();
            
            Console.ReadKey();
        }
    }
}
