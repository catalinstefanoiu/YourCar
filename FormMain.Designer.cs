namespace YourCar
{
	partial class FormMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDateInsurance = new System.Windows.Forms.Button();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.lblPti = new System.Windows.Forms.Label();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDatePti = new System.Windows.Forms.Button();
            this.btnDateMaintenance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YourCar.Properties.Resources.super_car_logo_free_vector_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, -35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(398, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome to Your Car!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "We remember your expiry dates so you don\'t have to!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Insurance Expiry Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "PTI Expiry Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Periodic Maintenance:";
            // 
            // btnDateInsurance
            // 
            this.btnDateInsurance.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDateInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateInsurance.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateInsurance.ForeColor = System.Drawing.Color.White;
            this.btnDateInsurance.Location = new System.Drawing.Point(493, 135);
            this.btnDateInsurance.Name = "btnDateInsurance";
            this.btnDateInsurance.Size = new System.Drawing.Size(91, 30);
            this.btnDateInsurance.TabIndex = 7;
            this.btnDateInsurance.Text = "Set new date";
            this.btnDateInsurance.UseVisualStyleBackColor = false;
            this.btnDateInsurance.Click += new System.EventHandler(this.btnDateInsurance_Click);
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(489, 100);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(104, 23);
            this.lblInsurance.TabIndex = 10;
            this.lblInsurance.Text = "dd/MM/yyyy";
            // 
            // lblPti
            // 
            this.lblPti.AutoSize = true;
            this.lblPti.Location = new System.Drawing.Point(489, 219);
            this.lblPti.Name = "lblPti";
            this.lblPti.Size = new System.Drawing.Size(104, 23);
            this.lblPti.TabIndex = 11;
            this.lblPti.Text = "dd/MM/yyyy";
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Location = new System.Drawing.Point(489, 348);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(104, 23);
            this.lblMaintenance.TabIndex = 12;
            this.lblMaintenance.Text = "dd/MM/yyyy";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSpring,
            this.tsslDate,
            this.tsslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 26);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslSpring
            // 
            this.tsslSpring.Name = "tsslSpring";
            this.tsslSpring.Size = new System.Drawing.Size(717, 20);
            this.tsslSpring.Spring = true;
            // 
            // tsslDate
            // 
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(75, 20);
            this.tsslDate.Text = "zz/ll/aaaa";
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(54, 20);
            this.tsslTime.Text = "hh:mm";
            // 
            // btnDatePti
            // 
            this.btnDatePti.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDatePti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatePti.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatePti.ForeColor = System.Drawing.Color.White;
            this.btnDatePti.Location = new System.Drawing.Point(493, 261);
            this.btnDatePti.Name = "btnDatePti";
            this.btnDatePti.Size = new System.Drawing.Size(91, 30);
            this.btnDatePti.TabIndex = 18;
            this.btnDatePti.Text = "Set new date";
            this.btnDatePti.UseVisualStyleBackColor = false;
            this.btnDatePti.Click += new System.EventHandler(this.btnDatePti_Click);
            // 
            // btnDateMaintenance
            // 
            this.btnDateMaintenance.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDateMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateMaintenance.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnDateMaintenance.Location = new System.Drawing.Point(493, 384);
            this.btnDateMaintenance.Name = "btnDateMaintenance";
            this.btnDateMaintenance.Size = new System.Drawing.Size(91, 30);
            this.btnDateMaintenance.TabIndex = 19;
            this.btnDateMaintenance.Text = "Set new date";
            this.btnDateMaintenance.UseVisualStyleBackColor = false;
            this.btnDateMaintenance.Click += new System.EventHandler(this.btnDateMaintenance_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 490);
            this.Controls.Add(this.btnDateMaintenance);
            this.Controls.Add(this.btnDatePti);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblMaintenance);
            this.Controls.Add(this.lblPti);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.btnDateInsurance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Car";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDateInsurance;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label lblPti;
        private System.Windows.Forms.Label lblMaintenance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslDate;
		private System.Windows.Forms.ToolStripStatusLabel tsslSpring;
		private System.Windows.Forms.ToolStripStatusLabel tsslTime;
		private System.Windows.Forms.Button btnDatePti;
		private System.Windows.Forms.Button btnDateMaintenance;
	}
}

