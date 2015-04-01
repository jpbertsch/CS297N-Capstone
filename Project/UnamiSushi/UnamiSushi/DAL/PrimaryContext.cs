using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UnamiSushi.Models;

namespace UnamiSushi.DAL
{
    public class PrimaryContext : DbContext
    {
        public PrimaryContext() : base("PrimaryContext")
        {
        }

        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<MenuItem> Menuitems { get; set; }
        public DbSet<MenuPicture> MenuPictures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}