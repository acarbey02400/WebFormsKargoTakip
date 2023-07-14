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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users").HasKey(p => p.Id).Property(p => p.Name).HasColumnName("Name");
            modelBuilder.Entity<User>().Property(p => p.Password).HasColumnName("Password");
            modelBuilder.Entity<User>().Property(p => p.EMail).HasColumnName("EMail");
            modelBuilder.Entity<User>().Property(p => p.UserName).HasColumnName("UserName");
        }
        }
}