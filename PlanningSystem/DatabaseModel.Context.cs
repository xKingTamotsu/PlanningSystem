﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanningSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlanningSysteemEntities : DbContext
    {
        public PlanningSysteemEntities()
            : base("name=PlanningSysteemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Classroom> Classroom { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<DaysOfTheWeek> DaysOfTheWeek { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<SchoolWeekNumber> SchoolWeekNumber { get; set; }
        public virtual DbSet<SchoolYears> SchoolYears { get; set; }
        public virtual DbSet<StudentClass> StudentClass { get; set; }
        public virtual DbSet<Unavailability> Unavailability { get; set; }
    }
}
