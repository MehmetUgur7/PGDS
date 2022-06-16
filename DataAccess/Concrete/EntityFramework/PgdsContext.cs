using Core.Entities.Concrete;
using Entities.Concrete.CompanyRelated;
using Entities.Concrete.InspectionRelated;
using Entities.Concrete.InspectorRelated;
using Entities.Concrete.Institution;
using Entities.Concrete.ProductRelated;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class PgdsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PGDS;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyOfficer> CompanyOfficeers { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Determination> Determinations { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Justification> Justifications { get; set; }
        public DbSet<Regulation> Regulations { get; set; }
        public DbSet<SampleInfo> SampleInfos { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Directorship> Directorships { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<InspectionService> InspectionServices { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
