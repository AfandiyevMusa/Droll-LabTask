using System;
using drollLab.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace drollLab.Data
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
    }
}

