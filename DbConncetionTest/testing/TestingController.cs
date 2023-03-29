using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DbConncetionTest.Models;
using MySql.Data.MySqlClient;
using System.Data;


namespace DbConncetionTest.testing
{
    public class TestingController : ApiController
    {

        public void insertDatabaseInfo(dbConnector test)
        {
            test.dataSource = "localhost";
            test.initialCatalog = "training";
            test.port = "3307";
            test.userId = "root";
            test.password = "generalkitty";
        }
        public System.Data.DataSet ReadEmployee()
        {
            dbConnector testConnector = new dbConnector();
            insertDatabaseInfo(testConnector);
            MySqlCommand cmd = null;
            using (MySqlConnection conn = new MySqlConnection(testConnector.GetdbConnectionString()))
            {
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = @"SELECT * FROM employee ;";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    conn.Close();

                    return ds;
                }
                return new DataSet();
            }

        }
        [HttpGet]
        [Route("TestGetEmployee")]
        public List<Employee> Get()
        {
            var getCustomer = ReadEmployee();
            var lstOfCustomer = new List<Employee>();
            if (getCustomer != null)
            {

                for (int i = 0; i < getCustomer.Tables[0].Rows.Count; i++)
                {
                    var customer = new Employee();
                    customer.EmployeeId = int.Parse(getCustomer.Tables[0].Rows[0]["EmployeeId"].ToString());
                    customer.FirstName = getCustomer.Tables[0].Rows[0]["FirstName"].ToString();
                    customer.LastName = getCustomer.Tables[0].Rows[0]["LastName"].ToString();
                    customer.Age = int.Parse(getCustomer.Tables[0].Rows[0]["Age"].ToString());
                    customer.PhoneNumber = getCustomer.Tables[0].Rows[0]["PhoneNumber"].ToString();
                    lstOfCustomer.Add(customer);
                }
                return lstOfCustomer;
            }

            return new List<Employee>();
        }


    }
}
