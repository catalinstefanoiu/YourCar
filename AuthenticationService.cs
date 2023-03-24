using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourCar
{
	internal class AuthenticationService
	{
		private AuthenticationService() { }
		private static AuthenticationService instance = null;
		public static AuthenticationService Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new AuthenticationService();
				}
				return instance;
			}
		}

		private static User user = null;
		public static User User
		{
			get { return user; }
		}

		public static bool isAuthenticated
		{ get { return user != null; } }

		public static SqlReturn Login(string carPlate, string password)
		{
			User u = DAO.UserLogin(carPlate, password);
			if (u != null)
			{
				user = u;
				return SqlReturn.Ok;
			}

			return SqlReturn.IncorrectUserPwd;
		}
	}
}
