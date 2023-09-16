using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное трЁхзначноое число");

            int A = int.Parse(Console.ReadLine());
            double c = A % 10;  //выделяем остаток
            int b = A % 100 / 10;  //выделяем целое
            int a = A % 1000 / 100;

            Console.Write(c);
            Console.Write(a);
            Console.WriteLine(b);

        }
    }
}
