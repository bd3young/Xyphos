using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIT280App.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CIT280App.DataLayer
{
    public class DbSeedContext : DbContext
    {
        public DbSeedContext() : base("DbSeedContext")
        {
        }
        public DbSet<StudentModel> Students {get; set;}
        public DbSet<EmployerModel> Employers { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<JobsModel> Jobs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<CIT280App.Models.AdminModel> AdminModels { get; set; }
    }
}