using Microsoft.EntityFrameworkCore;

namespace EmreProje.Models
{
    public class AppDbContext : DbContext
    {
        public IConfiguration _config { get; set; }

        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        public DbSet<Urunler> Urunler_Db { get; set; }

        public DbSet<Kategoriler> Kategoriler_Db { get; set;}

        public DbSet<Musteri> Musteri_Db { get; set; } 

        public DbSet<Personel> Personel_Db { get; set;}
        
    }
}
