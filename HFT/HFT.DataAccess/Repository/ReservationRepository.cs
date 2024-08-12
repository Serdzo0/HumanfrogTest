using HFT.DataAccess.Data;
using HFT.DataAccess.Repository.IRepository;
using HFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFT.DataAccess.Repository
{
    public class ReservationRepository : Repository<ReservationModel>, IReservationRepository
    {
        private ApplicationDbContext _db;
        public ReservationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(ReservationModel reservation)
        {
            _db.Reservations.Update(reservation);
        }
    }
}
