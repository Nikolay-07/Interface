using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class Library
    {
        private List books = new List();

        public void AddBook(IBook book) => books.Add(book);

        public void RemoveBook(string title)
        {
            int removed = books.RemoveAll(b => b.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));
            if (removed > 0)
                Console.WriteLine("Книга удалена.");
            else
                Console.WriteLine("Книга не найдена.");
        }

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Библиотека пуста.");
                return;
            }

            Console.WriteLine("Список книг:");
            foreach (var book in books)
            {
                Console.WriteLine(book.GetInfo());
            }
        }
    }
}
