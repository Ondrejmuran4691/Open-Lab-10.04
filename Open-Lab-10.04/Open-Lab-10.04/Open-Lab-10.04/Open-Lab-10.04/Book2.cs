using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._04
{
    class Book2
    {

        
        


        public string Title = "-1";
        public int ReleaseDate = -1;
        public string Author = "-1";
        public int Pages = -1;
        public string Category = "-1";

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
