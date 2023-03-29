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
        public dbConnector test = dbConnectionString();
    
        public string dbConnectionString(dbConnector dbInfo)
        {
            string DbConnectionString;
            DbConnectionString = "Data Source = " + dbInfo.dataSource +
                                "; Port = " + dbInfo.port +
                                "; Initial Catalog = " + dbInfo.initialCatalog +
                                "; User id = " + dbInfo.userId +
                                "; Password = " + dbInfo.password + ";";
            return DbConnectionString;
        }
        public void connection()
        {
            MySqlCommand cmd = null;
            using (MySqlConnection conn = new MySqlConnection(dbConnectionString(test)))
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
        //public void dbConnect()
        //{

        //}

        //public static System.Data.DataSet ReadCustomer()
        //{
        //    MySqlCommand cmd = null;
        //    using (MySqlConnection conn = new MySqlConnection(dbConnectionString(test)))
        //    {
        //        {
        //            conn.Open();
        //            cmd = new MySqlCommand();
        //            cmd = conn.CreateCommand();
        //            cmd.CommandText = @"SELECT * FROM employee ;";
        //            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
        //            DataSet ds = new DataSet();
        //            adap.Fill(ds);
        //            conn.Close();

        //            return ds;
        //        }
        //        return new DataSet();
        //    }

        //}
    }