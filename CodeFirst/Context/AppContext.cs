using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Context
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("appConnection")
        {
        }

        public IDbSet<Department> Departments { get; set; }
        public IDbSet<Employee> Employees { get; set; }
    }
}