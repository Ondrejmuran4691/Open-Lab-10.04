using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._04
{ 
class Program
{
    static void Main(string[] args)
    {

            Book LOTR = new Book();
            Book LOTR2 = new Book();
            Book LOTR3 = new Book();
            Book HOBIT = new Book();


        LOTR.Title = "LOTR";
        LOTR.Author = "J. R. R. Tolkien";
        LOTR.Category = "Fantasy";
        LOTR.Pages = 9250;
        LOTR.ReleaseDate = 1954;
            LOTR2.konstruktor1();
            LOTR3.konstruktor2("LOTR3", 851);
            HOBIT.konstruktor3("Hobit", "J. R. R. Tolkien", "Fantasy", 352, 1954);


            LOTR.writeall();
            LOTR2.writeall();
            LOTR3.writeall();
            HOBIT.writeall();

        }
}
}