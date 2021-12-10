using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._04
{
    class Book4
    {
        public string Title;
        public int ReleaseDate;
        public string Author;
        public int Pages;
        public string Category;

        public Book4(string category)
        {
            Category = category;
        }

        public Book4(string title, string author, string category, int pages, int releaseDate)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Author = author;
            Pages = pages;
            Category = category;


        }

        public void writeall()
        {

            Console.WriteLine(Title);
            Console.WriteLine(Pages);
            Console.WriteLine(Category);
            Console.WriteLine(Author);
            Console.WriteLine(ReleaseDate);
        }
    }
}
