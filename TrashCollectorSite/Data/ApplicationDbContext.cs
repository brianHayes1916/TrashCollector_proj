using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrashCollectorSite.Models;

namespace TrashCollectorSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole{ Name = "Employee", NormalizedName = "EMPLOYEE"}, new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" });

        }

        public DbSet<TrashCollectorSite.Models.Customer> Customer { get; set; }

        public DbSet<TrashCollectorSite.Models.Employee> Employee { get; set; }
    }
}
