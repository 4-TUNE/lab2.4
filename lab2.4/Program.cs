using System;

namespace Lab2_4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m=");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int s = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " \t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Число з перших координат=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Число з других координат=");
            int b = int.Parse(Console.ReadLine());
            int res = a * b;
            Console.WriteLine("Результат множення координат = " + res);

        }

    }
}
