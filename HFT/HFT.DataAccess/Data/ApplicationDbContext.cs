using Microsoft.EntityFrameworkCore;
using HFT.Models;

namespace HFT.DataAccess.Data
{
	public class ApplicationDbContext : DbContext
	{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<RoomModel> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomModel>().HasData(
                new RoomModel { RoomID=1, Name="Velika soba", Cena=300, ShortDescription="Velika soba za 6 ljudi s pogledom na morje!", LongDescription="Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje"},
                new RoomModel { RoomID = 2, Name = "Velika soba2", Cena = 300, ShortDescription = "Velika soba za 6 ljudi s pogledom na morje!", LongDescription = "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje" },
                new RoomModel { RoomID = 3, Name = "Majhna soba", Cena = 150, ShortDescription = "Majhna soba za 3 ljudi s pogledom na morje!", LongDescription = "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje" },
                new RoomModel { RoomID = 4, Name = "Majhna soba2", Cena = 150, ShortDescription = "Majhna soba za 3 ljudi s pogledom na morje!", LongDescription = "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje" },
                new RoomModel { RoomID = 5, Name = "Penthouse", Cena = 500, ShortDescription = "Penthouse za 2", LongDescription = "Penthouse za 2 ima spalnico s svojim balkonom in televizijo in 2 kopalnice ter velik dnevni prostor z vhodom na teraso. Ima še prostor za pisarno." }
                );
        }
    }

}
