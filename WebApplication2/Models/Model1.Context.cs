﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class swdEntities1 : DbContext
    {
        public swdEntities1()
            : base("name=swdEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BasicSalary> BasicSalaries { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyPayroll> CompanyPayrolls { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmpPayroll> EmpPayrolls { get; set; }
        public virtual DbSet<Extra> Extras { get; set; }
        public virtual DbSet<Payslip> Payslips { get; set; }
        public virtual DbSet<PaySlipDetail> PaySlipDetails { get; set; }
    }
}
