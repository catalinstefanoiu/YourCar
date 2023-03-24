using System;
using System.Timers;
using System.Windows.Forms;

namespace YourCar
{
	public partial class FormMain : Form
	{
		private System.Timers.Timer aTimer;

		public FormMain()
		{
			InitializeComponent();
		}

		private void SetTimeTimer()
		{
			// Create a timer with a one second interval.
			aTimer = new System.Timers.Timer(1000);
			aTimer.Elapsed += OnTimedEvent;
			aTimer.AutoReset = true;
			aTimer.Enabled = true;
		}

		private void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			tsslTime.Text = DateTime.Now.ToString("HH:mm");
		}

		protected override void OnLoad(EventArgs e)
		{
			SetTimeTimer();
			tsslDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

			if (AuthenticationService.isAuthenticated)
			{
				User user = AuthenticationService.User;

				lblTitle.Text = String.Format("Welcome to Your Car: {0}", user.Username);

				if (user.InsuranceExpiry.Year < 2001)
				{
					lblInsurance.Text = "Not set";
				}
				else
				{
					lblInsurance.Text = user.InsuranceExpiry.ToString("dd/MM/yyyy");
				}
				if (user.PtiExpiry.Year < 2001)
				{
					lblPti.Text = "Not set";
				}
				else
				{
					lblPti.Text = user.PtiExpiry.ToString("dd/MM/yyyy");
				}
				if (user.MaintenanceExpiry.Year < 2001)
				{
					lblMaintenance.Text = "Not set";
				}
				else
				{
					lblMaintenance.Text = user.MaintenanceExpiry.ToString("dd/MM/yyyy");
				}
			}

			base.OnLoad(e);
		}

        private void btnDateInsurance_Click(object sender, EventArgs e)
        {
			FormDate frm = new FormDate();
			if (frm.ShowDialog(this) == DialogResult.OK)
			{
				AuthenticationService.User.InsuranceExpiry = frm.Date;
				lblInsurance.Text = AuthenticationService.User.InsuranceExpiry.ToString("dd/MM/yyyy");
				DAO.SaveUser(AuthenticationService.User);
			}
        }

		private void btnDatePti_Click(object sender, EventArgs e)
		{
			FormDate frm = new FormDate();
			if (frm.ShowDialog(this) == DialogResult.OK)
			{
				AuthenticationService.User.PtiExpiry = frm.Date;
				lblPti.Text = AuthenticationService.User.PtiExpiry.ToString("dd/MM/yyyy");
				if (!DAO.SaveUser(AuthenticationService.User))
				{
					MessageBox.Show("Error saving data. Please try again later.");
				}
			}
		}

		private void btnDateMaintenance_Click(object sender, EventArgs e)
		{
			FormDate frm = new FormDate();
			if (frm.ShowDialog(this) == DialogResult.OK)
			{
				AuthenticationService.User.MaintenanceExpiry = frm.Date;
				lblMaintenance.Text = AuthenticationService.User.MaintenanceExpiry.ToString("dd/MM/yyyy");
				DAO.SaveUser(AuthenticationService.User);
			}
		}

        private void FormMain_Load(object sender, EventArgs e)
        {
			
        }
    }
}
