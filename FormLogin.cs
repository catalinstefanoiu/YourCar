using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourCar
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
			tbCarPlate.Text = "B01ABC";
			tbPwd.Text = "parola21!";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormRegister frm = new FormRegister();
			if (DialogResult.Cancel == frm.ShowDialog(this))
			{
				Application.Exit();
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			SqlReturn ret = AuthenticationService.Login(tbCarPlate.Text, tbPwd.Text);
			if (ret == SqlReturn.Ok)
			{
				this.DialogResult= DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Username or password is incorrect!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
