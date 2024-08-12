using Microsoft.EntityFrameworkCore;
using HFT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace HFT.DataAccess.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
		public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<ReservationModel> Reservations { get; set; }
       
    }

}
