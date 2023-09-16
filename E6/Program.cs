using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант a
            Console.WriteLine("Введите значение a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            int c = int.Parse(Console.ReadLine());

            int a1 = a;

            a = b; b = c; c = a1;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            /* Вариант b
            Console.WriteLine("Введите значение a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            int c = int.Parse(Console.ReadLine());

            int b1 = b;

            b = c; c = a; a = b1;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c); */
        }
    }
}
