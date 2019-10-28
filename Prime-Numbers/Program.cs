using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        public static bool Prime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) { return false; }
            }
            return true;
        }
        static void Main()
        {
            int num = 2;

            do
            {
                if (Prime(num)) { Console.WriteLine(num); }

                num += 1;
            } while (num < 10000);

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }
    }
}
