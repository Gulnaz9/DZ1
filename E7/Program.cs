using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Случайные числа (после каждого нажмите <Enter>):");
            Random a = new Random();
            int A = a.Next(-100, 100); //пусть любые числа будут в таком диапазоне
            Console.WriteLine(A);
            Console.ReadKey();

            Random b = new Random();
            int B = b.Next(-100, 100);
            Console.WriteLine(B);
            Console.ReadKey();

            Random c = new Random();
            int C = c.Next(-100, 100);
            Console.WriteLine(C);
            Console.ReadKey();


            Random d = new Random();
            int D = d.Next(-100, 100);
            Console.WriteLine(D);
            Console.ReadKey();

        }
    }
}
