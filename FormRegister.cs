using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YourCar
{
	public partial class FormRegister : Form
	{
		public FormRegister()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			tbCarPlate.Text = "B01ABC";
			tbEmail.Text = "test@yourcar.com";
			tbPwd.Text = tbPwd1.Text = "parola21!";
			base.OnLoad(e);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			string pwd = tbPwd.Text.Trim();
			if (pwd != tbPwd1.Text.Trim())
			{
				MessageBox.Show("Password do not match!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				string carPlate = tbCarPlate.Text.Trim();
				SqlReturn ret = DAO.RegisterUser(carPlate, pwd, tbEmail.Text.Trim());
				if (ret == SqlReturn.Ok)
				{
					MessageBox.Show("Registration was successful. Please login");
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else if (ret == SqlReturn.UserExists)
				{
					MessageBox.Show(String.Format("A user with this {0} car plate already exists!", carPlate),
						Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Registration failed. Please try again");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong");
				Console.WriteLine(ex.Message);
			}
		}

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
