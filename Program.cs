using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YourCar
{
	internal static class Program
	{
		public static String AppTitle = "Your Car";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			FormLogin frm = new FormLogin();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				Application.Run(new FormMain());
			}
		}

		private static string connectionString = null;

		public static SqlConnection GetDbConnection()
		{
			if (connectionString != null)
			{
				return new SqlConnection(connectionString);
			}

			ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
			if (settings != null)
			{
				try
				{
					connectionString = settings[1].ConnectionString;
					return new SqlConnection(connectionString);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			return null;
		}
	}
}
