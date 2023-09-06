using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Student {get; set;} 
        public DbSet<DemoMVC.Models.Faculty> Facuty {get; set;} = default!;
        
    }
}