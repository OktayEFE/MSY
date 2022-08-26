using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        #region MSSQL BAĞLANTI
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=msydb;integrated security=true;user=sa;password=Semok5565");
        }
        #endregion
        #region POSTGRE SQL BAĞLANTI
        //public Context(DbContextOptions<Context> options)
        //    : base(options)
        //{
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.UseSerialColumns();
        //}
        #endregion
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contects { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
