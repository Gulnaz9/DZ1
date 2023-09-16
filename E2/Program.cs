using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любые два числа (при вводе дробного числа используйте запятую)");
            int number = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int temple = number;
            number = num;
            num = temple;
            Console.WriteLine(number);
            Console.WriteLine(num);


        }
    }
}
