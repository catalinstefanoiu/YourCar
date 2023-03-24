 using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace YourCar
{
	enum SqlReturn
	{
		Ok = 0,
		Error = 1,
		UserExists = 2,
		IncorrectUserPwd = 3,
	}

	static internal class DAO
	{
		public static SqlReturn RegisterUser(string carPlate, string password, string email)
		{
			try
			{
				bool exists = UserExists(carPlate);
				if (exists)
				{
					return SqlReturn.UserExists;
				}

				string cmdText = "INSERT INTO [Login](carPlate, password, email) VALUES(@usr, @pwd, @email)";
				byte[] salt;
				new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
				var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
				byte[] hash = pbkdf2.GetBytes(20);
				byte[] hashBytes = new byte[36];
				Array.Copy(salt, 0, hashBytes, 0, 16);
				Array.Copy(hash, 0, hashBytes, 16, 20);
				string savedPasswordHash = Convert.ToBase64String(hashBytes);
				Console.WriteLine("{0} {1}", savedPasswordHash.Length, savedPasswordHash);
				using (SqlConnection cnn = Program.GetDbConnection())
				{
					using (SqlCommand comm = new SqlCommand())
					{
						comm.Connection = cnn;
						comm.CommandText = cmdText;
						comm.Parameters.AddWithValue("@usr", carPlate);
						comm.Parameters.AddWithValue("@pwd", savedPasswordHash);
						comm.Parameters.AddWithValue("@email", email);
						cnn.Open();
						comm.ExecuteNonQuery();
						cnn.Close();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return SqlReturn.Error;
			}

			return SqlReturn.Ok;
		}

		public static User UserLogin(string carPlate, string password)
		{
			try
			{
				string query = String.Format("SELECT * FROM [Login] WHERE carPlate = @usr");
				using (SqlConnection cnn = Program.GetDbConnection())
				{
					SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
					SqlCommand command = new SqlCommand("SELECT * FROM [Login] WHERE carPlate = @usr", cnn);
					command.Parameters.AddWithValue("@usr", carPlate);
					sda.SelectCommand = command;
					DataTable dt = new DataTable();
					sda.Fill(dt);
					if (dt.Rows.Count == 1)
					{
						string savedPasswordHash = dt.Rows[0]["password"].ToString();
						byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
						byte[] salt = new byte[16];
						Array.Copy(hashBytes, 0, salt, 0, 16);
						var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
						byte[] hash = pbkdf2.GetBytes(20);
						for (int i = 0; i < 20; i++)
						{
							if (hashBytes[i + 16] != hash[i])
							{
								return null;
							}
						}

						User user = new User();
						user.Id = Convert.ToInt32(dt.Rows[0]["id"]);
						user.Username = dt.Rows[0]["carPlate"].ToString();
						user.Email = dt.Rows[0]["email"].ToString();
						if (dt.Rows[0]["insurance"] != DBNull.Value)
						{
							user.InsuranceExpiry = Convert.ToDateTime(dt.Rows[0]["insurance"]);
						} else
						{
							user.InsuranceExpiry = DateTime.Parse("2000-01-01");
						}
						if (dt.Rows[0]["pti"] != DBNull.Value)
						{
							user.PtiExpiry = Convert.ToDateTime(dt.Rows[0]["pti"]);
						}
						else
						{
							user.PtiExpiry = DateTime.Parse("2000-01-01");
						}
						if (dt.Rows[0]["maintenance"] != DBNull.Value)
						{
							user.MaintenanceExpiry = Convert.ToDateTime(dt.Rows[0]["maintenance"]);
						}
						else
						{
							user.MaintenanceExpiry = DateTime.Parse("2000-01-01");
						}
						return user;
					}
					else
					{
						return null;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}

		public static bool UserExists(string carPlate)
		{
			string cmdText = "SELECT id FROM [Login] WHERE carPlate = @usr";
			using (SqlConnection cnn = Program.GetDbConnection())
			{
				using (SqlCommand comm = new SqlCommand())
				{
					comm.Connection = cnn;
					comm.CommandText = cmdText;
					comm.Parameters.AddWithValue("@usr", carPlate);
					cnn.Open();
					int count = 0;
					var  result = comm.ExecuteScalar();
					if (result != null)
					{
						count = Convert.ToInt32(result);
					}
					cnn.Close();
					return count > 0;
				}
			}
		}

		public static bool SaveUser(User user)
		{
			try
			{
				string cmdText = "UPDATE [Login] SET insurance = @insurance, pti = @pti, maintenance = @maintenance WHERE id = @id";
				using (SqlConnection cnn = Program.GetDbConnection())
				{
					using (SqlCommand comm = new SqlCommand())
					{
						comm.Connection = cnn;
						comm.CommandText = cmdText;
						comm.Parameters.AddWithValue("@id", user.Id);
						comm.Parameters.AddWithValue("@insurance", user.InsuranceExpiry);
						comm.Parameters.AddWithValue("@pti", user.PtiExpiry);
						comm.Parameters.AddWithValue("@maintenance", user.MaintenanceExpiry);
						cnn.Open();
						comm.ExecuteNonQuery();
						cnn.Close();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return false;
			}
		}
	}
}
