using HrAppDataAcces.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HrAppDataAcces
{
    public class DataBaseContext  : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DataBaseContext() { }
        public DbSet<User> Users { get; set; }
        public DbSet<APPUser> AplicationUsers { get; set; }

        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Username)
                    .HasColumnName("Username")
                    .IsRequired();
                entity.Property(e => e.Id_AppUser)
                   .HasColumnName("Id_AppUser");
                entity.HasOne(e => e.APPUser)
                   .WithOne()
                   .HasForeignKey<User>(u => u.Id_AppUser)
                    .OnDelete(DeleteBehavior.Cascade);

            });
            modelBuilder.Entity<APPUser>(entity =>
            {
                entity.ToTable("APPUser");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleId)
                    .HasColumnName("Id_Role");

                entity.HasOne(e => e.Role)
                    .WithMany()
                    .HasForeignKey(e => e.RoleId)
                    .OnDelete(DeleteBehavior.Restrict);

                //entity.HasOne(e => e.SecondaryRole)
                //    .WithMany()
                //    .HasForeignKey(e => e.SecondaryRoleId)
                //    .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .IsRequired();
                entity.Property(e => e.Description)
                  .HasColumnName("Description");
            });
        }


        }
}
