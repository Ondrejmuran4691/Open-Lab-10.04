using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._04
{
    public class Book
    {
        public string Title;

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

        public string category;
        public string author;
        
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
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(ReleaseDate);
        }
    }
}