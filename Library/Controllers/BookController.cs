using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDAL.Data;
using LibraryBLL;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ArrayList Getbooks() 
        {
            BookData bookdata = new();
            ArrayList books = bookdata.insertBooks();
            return books;
        }

        [HttpGet]
        [Route("seralised")]
        public string Getseralisedbooks()
        {
            BookLogics booklogic = new();
            string books = booklogic.seralisedbooks();
            return books;
        }
    }
}
