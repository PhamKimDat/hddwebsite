using Microsoft.EntityFrameworkCore;
using Project.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.MySQL.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
           : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Change ApplicationUser to Users table
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Bill>().ToTable("Bills");
            modelBuilder.Entity<User>().ToTable("Users");

            //add relationship
            modelBuilder.Entity<Bill>().HasMany(b => b.Products).WithOne(p => p.Bill).HasForeignKey(b => b.BillId);  //relation ship with bill and product
            modelBuilder.Entity<User>().HasMany(u => u.Bills).WithOne(b => b.User).HasForeignKey(u => u.UserId);
        }

        #region DbSet

        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Get DbSet
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>DbSet</returns>
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        #endregion DbSet

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }

}

