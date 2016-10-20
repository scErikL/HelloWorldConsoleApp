using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleAppTest
{
    public class Person
    {
        private string DateOfBirth;

        public string getDateOfBirth()
        {

            return DateOfBirth;
        }
        public string Name { get; set; }
        public string Sex { get; set; }
    }
}
