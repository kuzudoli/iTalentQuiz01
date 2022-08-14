using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository
{
    internal class DBContext : DbContext
    {
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Rektor> Rektorler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Kulup> Kulupler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ENESPC\\SQLEXPRESS;Initial Catalog=EnesCakir_Quiz01_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
