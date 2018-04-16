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
            builder.Entity<Customer>().ToTable("Customers");
            builder.Entity<Bill>().ToTable("Bills");
            builder.Entity<User>().ToTable("Users");
            builder.Entity<UserRole>().ToTable("UserRoles");


            ////add relationship (1(product)->n(bill))
            //builder.Entity<Bill>().HasMany(x => x.Products).WithOne(x => x.Bill).HasForeignKey(x => x.BillId);

        }

        #region DbSet

        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }



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

