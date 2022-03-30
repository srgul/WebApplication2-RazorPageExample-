﻿using Microsoft.EntityFrameworkCore;
using WebApplication2.model;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                             
        }

        public DbSet<Category> Category { get; set; }

    }
}
