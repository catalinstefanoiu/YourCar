namespace YourCar
{
	partial class FormDate
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mcDate = new System.Windows.Forms.MonthCalendar();
			this.Ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mcDate
			// 
			this.mcDate.Location = new System.Drawing.Point(5, 7);
			this.mcDate.MaxSelectionCount = 1;
			this.mcDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
			this.mcDate.Name = "mcDate";
			this.mcDate.TabIndex = 1;
			this.mcDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcDate_DateSelected);
			// 
			// Ok
			// 
			this.Ok.Location = new System.Drawing.Point(82, 181);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(75, 23);
			this.Ok.TabIndex = 2;
			this.Ok.Text = "Ok";
			this.Ok.UseVisualStyleBackColor = true;
			this.Ok.Click += new System.EventHandler(this.Ok_Click);
			// 
			// FormDate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(239, 214);
			this.Controls.Add(this.Ok);
			this.Controls.Add(this.mcDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDate";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Pick date";
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MonthCalendar mcDate;
		private System.Windows.Forms.Button Ok;
	}
}