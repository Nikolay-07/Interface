using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class FictionBook : IBook
    {
        private string title, author, genre;
        private int year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Year { get => year; set => year = value; }

        public FictionBook(string title, string author, string genre, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Year = year;
        }

        public string GetTitle() => Title;
        public string GetAuthor() => Author;
        public int YearBook() => Year;
        public void GetInfo()
        {
           Console.WriteLine( $"Художественная книга: {Title}\nАвтор: {Author}\nГод издания: {Year}\nЖанр: {Genre}");
        }
    }

}
