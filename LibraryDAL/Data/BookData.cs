using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Data
{
    public class BookData
    {
        public List<ArrayList> insertBooks()
        {
            ArrayList book1 = new();
            {
                book1.Add(1);
                book1.Add("Data Structures and Algo.");
                book1.Add(542);
                book1.Add("new");
            };
            ArrayList book2 = new();
            {
                book2.Add(2);
                book2.Add("Programming with C");
                book2.Add(412);
                book2.Add("old");
            };
            ArrayList book3 = new();
            {
                book3.Add(3);
                book3.Add("Technical Writing");
                book3.Add(242);
                book3.Add("new");
            };
            ArrayList book4 = new();
            {
                book4.Add(4);
                book4.Add("Cryptography");
                book4.Add(222);
                book4.Add("old");
            };

            List<ArrayList> booklist = new();
            booklist.Add(book1);
            booklist.Add(book2);
            booklist.Add(book3);
            booklist.Add(book4);

            return booklist;
        }
         
        
        
    }
}
