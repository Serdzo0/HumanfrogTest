using HFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFT.DataAccess.Repository.IRepository
{
	public interface IRoomRepository : IRepository<RoomModel>
	{
		void Update(RoomModel room);
		void Save();
	}
}
