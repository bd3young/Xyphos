using CIT280App.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CIT280App.DAL
{
    public class XyphosContext: DbContext
    {
        public XyphosContext() : base("XyphosContext")
        {
        }

        public DbSet<StudentModel> Students { get; set; }
        public DbSet<JobsModel> Jobs { get; set; }
        public DbSet<EmployerModel> Employers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}