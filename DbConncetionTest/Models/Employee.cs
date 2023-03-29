using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbConncetionTest.Models
{
    public class ResponseModel
    {
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public Employee myCustomerData { get; set; }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        //public string addressLine1 { get; set; }
        //public string addressLine2 { get; set; }
        //public string city { get; set; }
        //public string state { get; set; }
        //public string postcode { get; set; }
        //public string country { get; set; }
        //public int saleEmployeeNumber { get; set; }
        //public int creditLimit { get; set; }
    }
    public class DetailModel
    {
        public int EmployeeId { get; set; }
    }
}