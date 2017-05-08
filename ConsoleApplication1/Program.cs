using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want me to write the two words?");
            Console.WriteLine("Type y for yes; and n for no, then press <enter>");

            string answer = Console.ReadLine();
            if (answer == "y")
                Console.WriteLine("Hello World!");

            Console.WriteLine("Bye Bye!");
            Console.WriteLine("The result is {0}", 10 - 3 > 2 ? 0 : true ? 5 : 3);
        }
    }
}
