using System;
using CapMobileWebApp.Models;

using Microsoft.EntityFrameworkCore;

namespace CapMobileWebApp.Data
{
    public partial class UserContext : DbContext
    {
        public UserContext()
        {

        }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
       //public  DbSet<LoginModel> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("uid=samtatest;password=Samata@65#678;server=49.50.78.108;database=DbTub;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<LoginModel>(entity =>
            {

               

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .IsUnicode(false);


                entity.Property(e => e.Apassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
