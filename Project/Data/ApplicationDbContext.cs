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
                


                // user farm many to many relationship
                //builder.Entity<UserFarm>().HasOne(uf => uf.User).WithMany(u => u.UserFarms).HasForeignKey(uf => uf.UserId);

                // one area has many devices relatioship
                //builder.Entity<Sensor>().HasOne(d => d.Area).WithMany(a => a.Sensors).HasForeignKey(d => d.AreaId);

            }

            #region DbSet

            public DbSet<Product> Products { get; set; }
            

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

