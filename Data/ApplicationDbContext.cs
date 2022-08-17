using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebElectral.Models;

namespace WebElectral.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet <Person> People { get; set; }
        public DbSet <Staff> Staff { get; set; }
        public DbSet <Address> Addresses { get; set; }
    }
}
