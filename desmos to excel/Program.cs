using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using desmos_to_excel;

namespace desmos_to_excel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fuck you!");
            Console.WriteLine("paste the shit you got from desmos");
            string input = Console.ReadLine();
            desToExc desToExc = new desToExc();
            desToExc.input(input);
            Console.ReadLine();
        }
    }
}