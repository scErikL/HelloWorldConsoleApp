using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleAppTest
{
    public class Book
    {

        public string Author { get; set; }
        public string Title { get; set; }
        public int ReleaseYear {get; set; }

        public override string ToString()
        {
            return (this.Author + " : " +this.Title + " : " +this.ReleaseYear);
        }
    }
}
