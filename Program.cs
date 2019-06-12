using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Main()
        {
            Console.Write("Введiть число: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введiть степiнь: ");
            int stepin = int.Parse(Console.ReadLine());
            int number_stepin = 1;
            for (int i=0; i<stepin; i++)
            {
                number_stepin *= number;
            }
            Console.WriteLine("{0}^{1}={2}", number, stepin, number_stepin);
            Console.ReadKey();
            return 0;
        }
    }
}
