using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleAppTest
{
    class Program
    {
        static List<Book> getBookList()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { Author = "Ed McBain", Title = "Da Capo" ,ReleaseYear=1981});
            books.Add(new Book() { Author = "Ed McBain", Title = "Sångfågel", ReleaseYear = 1982 });
            books.Add(new Book() { Author = "Patricia Cornwell", Title = "Depraved Heart: A Scarpetta Novel", ReleaseYear = 1991 });
            books.Add(new Book() { Author = "Patricia Cornwell", Title = "Grön död", ReleaseYear = 1985 });
            books.Add(new Book() { Author = "Astrid Lindgren", Title = "Bröderna Lejonhjärta", ReleaseYear = 1965 });
            books.Add(new Book() { Author = "Astrid Lindgren", Title = "Pippi Långstrump på de sju haven", ReleaseYear = 1971 });
            books.Add(new Book() { Author = "J. R. R. Tolkien", Title = "The Fellowship of the Ring", ReleaseYear = 1954 });
            books.Add(new Book() { Author = "J. R. R. Tolkien", Title = "The Two Towers", ReleaseYear = 1955 });
            books.Add(new Book() { Author = "J. R. R. Tolkien", Title = "The Return of the King", ReleaseYear = 1955 });
            
            
            return books;
        }
        static void Main(string[] args)
        {
            List<Book> Books = getBookList();

            //SELECT:
            var strQuery = from book in Books select book.Author;
                //strQuery = Books.Select(b => b.Author);

            //foreach (string s in strQuery) Console.WriteLine(s);
            
            
            //WHERE: 
            var Query = from book in Books 
                         where book.Author == "Astrid Lindgren"
                         select book;
            
            Query = Books.Where(b => b.Author == "Astrid Lindgren");

            //ORDERBY & ORDERBYDESCENDING

            Query = from book in Books
                    orderby book.ReleaseYear
                    select book;

            Query = from book in Books
                    orderby book.ReleaseYear descending
                    select book;
            //Query = Books.OrderBy(b => b.ReleaseYear);
            //Query = Books.OrderByDescending(b => b.ReleaseYear);
            

            foreach (Book b in Query)
            {
                Console.WriteLine(b.ToString());

            }

           

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
