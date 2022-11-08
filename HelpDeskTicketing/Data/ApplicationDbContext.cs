using HelpDeskTicketing.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskTicketing.Data
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
        }
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Department> Departments { get; set; }
        public DbSet<Service> Services { get; set; } 
        public DbSet<Tickets> Tickets { get; set; } 
        public DbSet<Technician> Technicians { get; set; }


    }
}