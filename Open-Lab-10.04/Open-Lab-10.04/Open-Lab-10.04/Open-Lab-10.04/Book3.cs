using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._04
{
    class Book3
    {

        
        public int ReleaseDate = -1;
        public string Author = "-1";
        
        public string Category = "-1";
        public string Title;
        public int Pages;
        public Book3(string title, int pages)
        {
            Pages = pages;
            Title = title;
            
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
