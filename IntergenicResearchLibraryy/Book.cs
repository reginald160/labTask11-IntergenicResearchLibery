using System;
using System.Collections.Generic;
using System.Text;

namespace IntergenicResearchLibraryy
{
   public class Book
    {
        public string BookName { get; set; }
        public string BookID { get; set; }

        public Book(string bookName, string bookID)
        {
            BookName = bookName;
            BookID = bookID;
        }
    }
}
