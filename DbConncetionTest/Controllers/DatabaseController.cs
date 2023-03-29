using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using DbConncetionTest.Models;


namespace DbConncetionTest.Controllers
{
    public class DatabaseController : ApiController
    {
        //public dbConnector test = dbConnectionString();


        public void startDbconnection()
        {
            MySqlCommand cmd = null;
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM employee ;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                conn.Close();

            }
        }
        public void endConnection()
        {
            
        }


    }
}