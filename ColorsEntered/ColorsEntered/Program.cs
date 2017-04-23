using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsEntered
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite colors below :");
            char[] delimeters = { ',', ':', ';', ' ' };
            string[] colors = Console.ReadLine().Split(delimeters);
            Console.WriteLine();
            Console.WriteLine("You have {0} favorite colors:", colors.Length);
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }
    }
}
