using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourCar
{
	internal class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public DateTime InsuranceExpiry { get; set; }
		public DateTime PtiExpiry { get; set; }
		public DateTime MaintenanceExpiry { get; set; }
	}
}
