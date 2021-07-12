using System;
using System.Collections.Generic;
using System.Linq;
using LibraryDAL;

namespace LibraryBLL
{
    public class LibLogics
    {
        //LibData libdata = new LibData();
        public LibDataModel getDatabyid(int id)
        {
                LibData libdata = new();
                List<LibDataModel> alldata;
                alldata = libdata.dataInsert();
                return alldata[id - 1];
        }

        public LibDataModel getDatabyname(string name)
        {
            LibDataModel libdatas = new();
            LibData libdata = new();
            List<LibDataModel> alldata = new();
            alldata = libdata.dataInsert();
            
            if(alldata.Where(w => w.Title == name).Count() > 0)
            {
                libdatas = alldata.FirstOrDefault(w => w.Title == name);
            }
          
           
            return libdatas;
        }

        //public LibDataModel getDatabyname(string name)
        //{
        //    LibDataModel libdatas = new();
        //    LibData libdata = new();
        //    List<LibDataModel> alldata=new();
        //    alldata = libdata.dataInsert();
        //    int index = alldata.FindIndex(a => a.Title == name);
        //    var data = alldata.Where(w => w.Title == name).ToList();
        //    int Count = alldata.Where(w => w.Title == name).Count();
        //    return libdatas;
        //}

        //public List<LibDataModel> getDatabyauthor(string name)
        //{
        //    LibData libdata = new();
        //    List<LibDataModel> alldata;
        //    alldata = libdata.dataInsert();
        //    int index = alldata.FindIndex(a => a.Title == name);
        //    return alldata[index];
        //}

    }
}
