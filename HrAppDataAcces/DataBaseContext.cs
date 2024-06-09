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
                entity.ToTable("Users");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.Username)
                    .HasColumnName("Username")
                    .IsRequired();
                entity.Property(e => e.SysAdmin)
    .HasColumnName("Is_SysAdmin")
    .IsRequired();

                entity.Property(e => e.Password)
                    .HasColumnName("Password")
                    .IsRequired();
                entity.Property(e => e.UnitId)
                    .HasColumnName("Unit_Id")
                    .IsRequired();
                //entity.Property(e => e.Id_AppUser)
                //   .HasColumnName("Id_AppUser");
              
                    

            });
            modelBuilder.Entity<APPUser>(entity =>
            {
                entity.ToTable("APPUsers");

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
                entity.Property(e => e.UserId)
                  .HasColumnName("Id_User");
                entity.Property(e => e.FirstName)
             .HasColumnName("FirstName");
                entity.HasOne(e => e.User)
                 .WithOne()
                 .HasForeignKey<APPUser>(u => u.UserId);
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
