using eManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDb : DbContext, IDepartmentDataSource
    {
        public DepartmentDb() : base("DefaultConnection")
        {

        }

        public DbSet<Employee> Empoyees { get; set; }
        public DbSet<Department> Departments { get; set; }

        IQueryable<Employee> IDepartmentDataSource.Empoyees => this.Empoyees;

        IQueryable<Department> IDepartmentDataSource.Departments => this.Departments;
    }
}