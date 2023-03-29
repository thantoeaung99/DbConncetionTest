using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbConncetionTest.Models
{
    public class dbConnector
    {
        public string dataSource { get; set; }
        public string port { get; set; }
        public string initialCatalog { get; set; }
        public string userId { get; set; }
        public string password { get; set; }
        public string GetdbConnectionString()
        {
            string DbConnectionString;
            DbConnectionString = "Data Source = " + dataSource +
                                "; Port = " + port +
                                "; Initial Catalog = " + initialCatalog +
                                "; User id = " + userId +
                                "; Password = " + password + ";";
            return DbConnectionString;
        }
    }
    //public class dbConnection
    //{

    //}


}