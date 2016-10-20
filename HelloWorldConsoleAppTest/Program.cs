using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Person minPerson = new Person();

            minPerson.Name = "Linus";
            minPerson.Sex = "Male";

            Console.WriteLine("Jag heter {0} och jag är {1}", minPerson.Sex, minPerson.Name );
            Console.ReadKey();


            //Some change to my code.

            //Some more change

            //Some more change

            //Some more change

            //A new change 3.

            //A new change 4.

            //Features1.1 branch...

            //Additional change to feature 1.1..
        }
    }
}
