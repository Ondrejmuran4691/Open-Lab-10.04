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
        LOTR.Title = "LOTR";
        LOTR.author = "J. R. R. Tolkien";
        LOTR.category = "Fantasy";
        LOTR.Pages = -9250;
        LOTR.ReleaseDate = -1954;


            LOTR.writeall();

    }
}
}