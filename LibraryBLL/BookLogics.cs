using LibraryDAL.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LibraryDAL.Models;


namespace LibraryBLL
{
    public class BookLogics
    {
        public string seralisedbooks() 
        {
            BookData bookdata = new();
            List<ArrayList> books = bookdata.insertBooks();
            string sbooks = JsonConvert.SerializeObject(books);
            return sbooks;
        }

        public List<BookModel> deseralisedbooks()
        {
            BookData bookdata = new();
            List<BookModel> deserbooks;
            List<ArrayList> books = bookdata.insertBooks();
            string sbooks = JsonConvert.SerializeObject(books);
            deserbooks = JsonConvert.DeserializeObject<List<BookModel>>(sbooks);
            return deserbooks;

            
        }
    }
}
