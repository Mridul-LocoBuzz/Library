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
        public ArrayList insertBooks()
        {
            ArrayList book1 = new();
                {
                book1.Add(1);
                book1.Add("Data Structures and Algo.");
                book1.Add(542);
                book1.Add("new");
                }
            return book1;
        }
         
        
        
    }
}
