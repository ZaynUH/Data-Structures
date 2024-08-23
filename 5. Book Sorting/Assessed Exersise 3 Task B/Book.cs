using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exersise_3_Task_B
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Eventing.Reader;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Week_7_Sort_Algorithms
    {
        internal class Book : IComparable
        {
            private string bookTitle;
            private string authorName;
            private int publicaionYear;
            
            public Book(string bookT, string authorN, int pubYear) //constructor with an item
            {
                this.bookTitle = bookT;
                this.authorName = authorN;
                this.publicaionYear = pubYear;
            }

            public int Publication //property for data
            {
                set { this.publicaionYear = value; }
                get { return this.publicaionYear; }
            }
            public string Title //property for data
            {
                set { this.bookTitle = value; }
                get { return this.bookTitle; }
            }
            public string Author //property for data
            {
                set { this.authorName = value; }
                get { return this.authorName; }
            }


            public int CompareTo(object obj)
            {
                Book other = (Book)obj;     // Compares with Book Titles
                
                return this.Title.CompareTo(other.Title);
               
            }

            public override string ToString()
            {
                return this.bookTitle + " by " + authorName + ". " + publicaionYear;
            }
        }
    }


}
