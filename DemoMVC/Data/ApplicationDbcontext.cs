using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Controllers;
using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        
        
        public DbSet<HeThongPhanPhoi> HeThongPhanPhois {get; set;}
        public DbSet<DemoMVC.Models.DaiLy> DaiLy {get; set;} = default!;
        public DbSet<DemoMVC.Models.Person> Person {get; set;} = default!;
        
        public DbSet<DemoMVC.Models.Employee> Employees {get; set;} = default!;
        
        public DbSet<Student> Student { get; set; } = default!;
        
        
        
    }
}