using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTesting
{

    public  class Book
    {

        string name;
        string author;
        int pages;
        int sales;

      public Book(string name, string author, int sales, int pages)
        {
            Name = name;
            this.author = author;
            this.sales = sales;
            this.pages = pages;
        }
        public string Name
        {
          get
                {

                    return this.name;
                }
          set 
        {
            this.name = value;
        }

        }
       
    }
}
