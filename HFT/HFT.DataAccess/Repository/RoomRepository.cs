using HFT.DataAccess.Data;
using HFT.DataAccess.Repository.IRepository;
using HFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HFT.DataAccess.Repository
{
	public class RoomRepository : Repository<RoomModel>, IRoomRepository
	{
		private ApplicationDbContext _db;
        public RoomRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
		{
			_db.SaveChanges();
		}

		public void Update(RoomModel room)
		{
			_db.Rooms.Update(room);
		}
	}
}
