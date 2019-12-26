using BLL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toptanci.CodeFirst;

namespace DAL
{
    public class ToptanciDbContext : DbContext
    {
        public ToptanciDbContext() : base("cstr")
        {

        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Form1> Firmalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Entity<Urun>().ToTable("URUNLER");

            modelBuilder.Entity<Urun>().Property(u => u.Urun_Adi).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Urun>().Property(u => u.Kategori_ID).HasMaxLength(75).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Urun>().Property(u => u.Firma_ID).HasMaxLength(10).IsRequired().HasColumnType("varchar");

        }

    }
}
