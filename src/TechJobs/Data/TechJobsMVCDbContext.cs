using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TechJobsMVC.Data
{
    public class TechJobsMVCDbContext : DbContext
    {
        //DbSet should hold the Class Type which mirrors the database
        public DbSet<Object> VARIABLE_NAME { get; set; }
        
        public TechJobsMVCDbContext(DbContextOptions<TechJobsMVCDbContext> options) : base(options)
        {
        
        }
    }
}
