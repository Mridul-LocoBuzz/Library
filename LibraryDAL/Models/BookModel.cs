using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Models
{
    public class BookModel
    {
        public int uniqueId {get; set;}
        public string bookName { get; set; }
        public int pages { get; set; }
        public string edition { get; set; }
    }
}
