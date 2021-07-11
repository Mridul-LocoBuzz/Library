using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL
{
    public class LibData
    {
        public List<LibDataModel> dataInsert()
        {
             List<LibDataModel> Data = new();
            {
                Data.Add(new LibDataModel { Id = 1, Title="Data Structures and Algo.", Author="Thomas Cormen", Publisher="MIT", Price=120.00 });
                Data.Add(new LibDataModel { Id = 2, Title = "Programming with C", Author = "Rahul Roy", Publisher = "BHU", Price = 70.00 });
                Data.Add(new LibDataModel { Id = 3, Title = "Technical Writing", Author = "Karan Ahuja", Publisher = "IIT", Price = 80.00 });
                Data.Add(new LibDataModel { Id = 4, Title = "Software Design", Author = "Rakhi Khare", Publisher = "BIT", Price = 250.00 });
                Data.Add(new LibDataModel { Id = 5, Title = "Cryptography", Author = "Mridul", Publisher = "CSJM", Price = 1252.00 });
            }
            return Data;
        }
    }
}
