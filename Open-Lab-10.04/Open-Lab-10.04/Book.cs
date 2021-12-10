using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._04
{
    public class Book
    {
        public Book()
        {
            Title = "-1";
            ReleaseDate = -1;
            Author = "-1";
            Pages = -1;
            Category = "-1";
        }

        public Book(string titleofbook, int pagesofbook)
        {
            Title = titleofbook;
            ReleaseDate = -1;
            Author = "-1";
            Pages = pagesofbook;
            Category = "-1";
        }
        public Book(string titleofbook, string authorofbook, string categoryofbook, int pagesofbook, int releasedateofbook)
        {
            Title = titleofbook;
            ReleaseDate = releasedateofbook;
            Author = authorofbook;
            Pages = pagesofbook;
            Category = categoryofbook;
        }
        public string Title { set; get; }

        private int pages;
        public int Pages
        {

            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    value = 1;
                }
                pages = value;
            }

        }

        public string Category { set; get; }
        public string Author { set; get; }

        private int releaseDate;
        public int ReleaseDate
        {

            get
            {
                return releaseDate;
            }
            set
            {
                if (value < 1405)
                {
                    value = -1;
                }
                else
                {
                    if (value > 2021)
                    {
                        value = -1;
                    }
                }
                releaseDate = value;
            }

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
