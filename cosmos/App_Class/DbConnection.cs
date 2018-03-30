using cosmos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosmos.App_Class
{
    public class DbConnection
    {
        private static Northwind Db;

        public static Northwind _db {
            get
            {
                Db = Db ?? new Northwind();
                return Db;
            }
            set
            {               
                Db = _db;
            }                
         }

    }
}