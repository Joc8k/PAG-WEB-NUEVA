using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PAG.WEB___NUEVA.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=URLIMAGENES;Integrated Security=True")
        {




        }

        public DbSet<Datos> Datos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Fabricantes> Fabricantes { get; set; }
        public DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("Categoria");


        }



    }
}