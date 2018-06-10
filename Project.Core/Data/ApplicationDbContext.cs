using Microsoft.EntityFrameworkCore;
using Project.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.SQLServer.Data
{

    public class ApplicationDbContextSQL : DbContext
    {
        public ApplicationDbContextSQL(DbContextOptions options)
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
            builder.Entity<BillDetail>().ToTable("BillDetails");

            //add relationship
            builder.Entity<Product>().HasMany(b => b.BillDetails).WithOne(p => p.Product).HasForeignKey(b => b.ProductId);  //relation ship with billdetail and product
            builder.Entity<BillDetail>().HasOne(b => b.Bill).WithMany(p => p.BillDetails).HasForeignKey(b =>b.BillId);  //relation ship with billdetail and product
            builder.Entity<User>().HasMany(u => u.Bills).WithOne(b => b.User).HasForeignKey(u => u.UserId);
        }

        #region DbSet

        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }


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

