﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryBLL;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        [HttpGet]
        public List<LibDataModel> getData()
        {
            LibData libdata = new();
            List<LibDataModel> alldata;
            alldata = libdata.dataInsert();
            return alldata;
        }


        [HttpPost]
        [Route("id")]
        public LibDataModel Getbyid(int id=0)
        {
            LibLogics libdata = new();
            LibDataModel alldata;
            alldata = libdata.getDatabyid(id);
            return alldata;     
        }

        //[HttpPost]
        //public 
    }
}
