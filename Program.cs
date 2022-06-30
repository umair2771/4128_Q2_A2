using System;

namespace _4128_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Elements You want to Enter ");
            int leng =  Convert.ToInt32(Console.ReadLine());

            
            int[] arr = new int[leng];
            
            for (int i=0;i<arr.Length;i++)   // Taking Inputs 
            {
                Console.WriteLine("Enter Value at Index " + i);
                arr[i]= Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\n");

            for (int j = 0; j < arr.Length; j++)   // Displaying Output 
            {
                Console.WriteLine(" Value at Index " + j + " is =  " + arr[j]);
                

            }

            int a=0;

            for (int c = 0; c < arr.Length; c++)   // Displaying Output 
            {
                if (a<arr[c])
                {
                    a = arr[c];
                }

            }


            Console.WriteLine(" Largest Number In The Array is  " + a);

            int b = 0;

            for (int d = 0; d < arr.Length; d++)   // Displaying Output 
            {
                if ((b < arr[d]) && (arr[d]<a))
                {
                    b = arr[d];
                }

            }

            Console.WriteLine("\n Second Largest Number In The Array is  " + b);
            Console.ReadLine();
        }
    }
}
