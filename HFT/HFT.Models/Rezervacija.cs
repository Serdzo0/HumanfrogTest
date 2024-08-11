using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFT.Models
{
	internal class Rezervacija
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Message { get; set; }	
		public DateOnly CheckIn { get; set; }
		public DateOnly CheckOut { get; set;
		}
	}
}
