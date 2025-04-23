using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class NonFictionBook : IBook
    {
        private string title, author, theme;
        private int year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Theme { get => theme; set => theme = value; }
        public int Year { get => year; set => year = value; }

        public NonFictionBook(string title, string author, string theme, int year)
        {
            Title = title;
            Author = author;
            Theme = theme;
            Year = year;
        }
      
        public string GetTitle() => Title;
        public string GetAuthor() => Author;
        public int YearBook() => Year;
        public void GetInfo()
        {
            Console.WriteLine($"Научная книга: {Title}\nАвтор: {Author}\nГод: {Year}\nТема: {Theme}");
        }
    }
}
