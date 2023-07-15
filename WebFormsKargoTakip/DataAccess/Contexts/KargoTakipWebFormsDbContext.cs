using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebFormsKargoTakip.Model;

namespace WebFormsKargoTakip.DataAccess.Contexts
{
    public class KargoTakipWebFormsDbContext:DbContext
    {
        public KargoTakipWebFormsDbContext():base("DefaultConnectionString")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users").HasKey(p => p.Id).Property(p => p.Name).HasColumnName("Name");
            modelBuilder.Entity<User>().Property(p => p.Password).HasColumnName("Password");
            modelBuilder.Entity<User>().Property(p => p.EMail).HasColumnName("EMail");
            modelBuilder.Entity<User>().Property(p => p.UserName).HasColumnName("UserName");


            modelBuilder.Entity<Cargo>().ToTable("Cargos").HasKey(p => p.Id).Property(p => p.SenderName).HasColumnName("SenderName");
            modelBuilder.Entity<Cargo>().Property(p => p.Address).HasColumnName("Address");
            modelBuilder.Entity<Cargo>().Property(p => p.BuyerName).HasColumnName("BuyerName");
            modelBuilder.Entity<Cargo>().Property(p => p.Status).HasColumnName("Status");
        }
        }
}