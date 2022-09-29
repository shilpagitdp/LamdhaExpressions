using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace LambdaExpression
{

    public delegate int sum(int a);
    public delegate int max(int b, int c);
    public delegate void swap(int d, int e);
    public delegate void Sort(int[] arr1);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum res = (p) =>
            {
                for (int j = 1; j <= n; j++)
                {
                    sum = sum + j;

                }
                return sum;
            };
            int result = res.Invoke(n);
            Console.WriteLine("sum is " + result);

            //lambda expression to find greatest num
            Console.WriteLine("Enter the num n1 :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num n2 :");
            int c = Convert.ToInt32(Console.ReadLine());

            max grt = (p2, p3) => (b > c ? b : c);

            int res1 = grt.Invoke(b, c);

            Console.WriteLine("Greater num:" + res1);


            //lambda expression to swap the numbers.
            swap sp = (p4, p5) =>
            {
                b = b + c;
                c = b - c;
                b = b - c;
                Console.WriteLine($"Swap two numbers: n1 :{b}  n2:{c}");
            };
            sp.Invoke(b, c);

            //anonymous function to check given number is prime or not.
            Console.WriteLine("Enter prime number:");
            int d = Convert.ToInt32(Console.ReadLine());
            sum s = (p6) =>
            {
                for (int i = 2; i < d; i++)
                {
                    if (d % i == 0) return 0;
                }
                return 1;
            };
            int flag = s(d);

            if (flag == 1) Console.WriteLine($"{d} is Prime Number");
            else Console.WriteLine($"{d} is not Prime Number");


            //lambda expression to sort an given array.
            Console.WriteLine("Enter Size of Array:");
            int e = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[e];
            for (int i = 0; i < arr.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                arr[i] = x;
            }
            Sort srt = (int[] arr2) =>
            {
                Array.Sort(arr);

                Console.WriteLine("Sorted Array is : ");
                foreach (int i in arr)
                    Console.Write(i + " ");

                Console.WriteLine();
            };

            srt.Invoke(arr);

        }
    }
}
