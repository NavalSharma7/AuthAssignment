using System;
using System.Collections.Generic;
using System.Text;
using AuthAssignment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthAssignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {   public DbSet<ApplicationUser> AppUSer { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
