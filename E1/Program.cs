using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Мир ");  //выводим на экран без Line чтобы было в одной строке
            Console.Write("Труд ");
            Console.WriteLine("Май");

            Console.WriteLine("Мир");  // вывод на экран столбцом
            Console.WriteLine("  Труд");
            Console.WriteLine("     Май");

        }
    }
}
