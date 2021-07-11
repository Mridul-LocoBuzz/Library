using System;
using System.Collections.Generic;
using LibraryDAL;

namespace LibraryBLL
{
    public class LibLogics
    {
        //LibData libdata = new LibData();
        public LibDataModel getDatabyid(int id=0)
        {
                LibData libdata = new();
                List<LibDataModel> alldata;
                alldata = libdata.dataInsert();
                return alldata[id - 1];
        }
    }
}
