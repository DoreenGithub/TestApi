//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApi
{
    using System;
    using System.Collections.Generic;

    public partial class Employee
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string MailID { get; set; }
        public DateTime DOJ { get; set; }
        //public Nullable<System.DateTime> DOJ { get; set; }

        //public string Image { get; set; }
        public long ProductID { get; set; }
        public string DocumentType { get; set; }
        public string ProductName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ReminderDate { get; set; }
        public string Description { get; set; }
        public string CustomerID { get; set; }
    }

    public partial class Customer
    {
        public string FullName { get; set; }

        public long PhoneNo { get; set; }

        public string Email { get; set; }

        public string id { get; set; }

        public string Password { get; set; }
    }
}

