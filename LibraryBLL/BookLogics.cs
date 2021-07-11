using LibraryDAL.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryBLL
{
    public class BookLogics
    {
        public string seralisedbooks() 
        {
            BookData bookdata = new();
            ArrayList books = bookdata.insertBooks();
            string sbooks = JsonConvert.SerializeObject(books);
            return sbooks;
        }
    }
}
