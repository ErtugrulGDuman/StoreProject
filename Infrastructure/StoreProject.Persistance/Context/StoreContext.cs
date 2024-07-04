using Microsoft.EntityFrameworkCore;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Persistance.Context
{
    public class StoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EGD\\SQLEXPRESS;initial Catalog=DbStoreProject; integrated security=true");
        }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Product> Products { get; set; }
    }
}
