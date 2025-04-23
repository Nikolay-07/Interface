using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Textbook : IBook
    {
        private string title, author, subject;
        private int year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Subject { get => subject; set => subject = value; }
        public int Year { get => year; set => year = value; }

        public Textbook(string title, string author, string subject, int year)
        {
            Title = title;
            Author = author;
            Subject = subject;
            Year = year;
        }

        public string GetTitle() => Title;
        public string GetAuthor() => Author;
        public int YearBook() => Year;
        public void GetInfo()
        {
            Console.WriteLine($"Учебник: {Title}\nАвтор: {Author}\nГод: {Year}\nПредмет: {Subject}");
        }

    }
}
