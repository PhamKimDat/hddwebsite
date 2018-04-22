using Microsoft.EntityFrameworkCore;
using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
           : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Change ApplicationUser to Users table
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Bill>().ToTable("Bills");
            builder.Entity<User>().ToTable("Users");

            //add relationship
            builder.Entity<Bill>().HasMany(b => b.Products).WithOne(p => p.Bill).HasForeignKey(b => b.BillId);  //relation ship with bill and product
            builder.Entity<User>().HasMany(u => u.Bills).WithOne(b => b.User).HasForeignKey(u => u.UserId);
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

