namespace QuanLyQuanAn
{
	partial class fTableManager
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
            this.flpGround = new System.Windows.Forms.FlowLayoutPanel();
            this.g2cbtnQuit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.g2cbtnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.g2pnlFloor = new Guna.UI2.WinForms.Guna2Panel();
            this.g2pnlGround = new Guna.UI2.WinForms.Guna2Panel();
            this.g2btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.g2btnFloor = new Guna.UI2.WinForms.Guna2Button();
            this.g2btnGround = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpGround
            // 
            this.flpGround.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpGround.BackColor = System.Drawing.Color.Transparent;
            this.flpGround.Location = new System.Drawing.Point(307, 68);
            this.flpGround.Name = "flpGround";
            this.flpGround.Size = new System.Drawing.Size(1623, 959);
            this.flpGround.TabIndex = 0;
            this.flpGround.Paint += new System.Windows.Forms.PaintEventHandler(this.flpGround_Paint);
            // 
            // g2cbtnQuit
            // 
            this.g2cbtnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.g2cbtnQuit.BackColor = System.Drawing.Color.Transparent;
            this.g2cbtnQuit.BorderThickness = 2;
            this.g2cbtnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.g2cbtnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.g2cbtnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.g2cbtnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.g2cbtnQuit.FillColor = System.Drawing.Color.Red;
            this.g2cbtnQuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.g2cbtnQuit.ForeColor = System.Drawing.Color.White;
            this.g2cbtnQuit.Location = new System.Drawing.Point(1890, 12);
            this.g2cbtnQuit.Name = "g2cbtnQuit";
            this.g2cbtnQuit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.g2cbtnQuit.Size = new System.Drawing.Size(34, 30);
            this.g2cbtnQuit.TabIndex = 5;
            this.g2cbtnQuit.Click += new System.EventHandler(this.g2cbtnQuit_Click);
            // 
            // g2cbtnBack
            // 
            this.g2cbtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.g2cbtnBack.BackColor = System.Drawing.Color.Transparent;
            this.g2cbtnBack.BorderThickness = 2;
            this.g2cbtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.g2cbtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.g2cbtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.g2cbtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.g2cbtnBack.FillColor = System.Drawing.Color.Yellow;
            this.g2cbtnBack.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.g2cbtnBack.ForeColor = System.Drawing.Color.Black;
            this.g2cbtnBack.Location = new System.Drawing.Point(1850, 12);
            this.g2cbtnBack.Name = "g2cbtnBack";
            this.g2cbtnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.g2cbtnBack.Size = new System.Drawing.Size(34, 30);
            this.g2cbtnBack.TabIndex = 6;
            this.g2cbtnBack.Click += new System.EventHandler(this.g2cbtnBack_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.loginb_1;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.g2pnlFloor);
            this.guna2Panel1.Controls.Add(this.g2pnlGround);
            this.guna2Panel1.Controls.Add(this.g2btnAdmin);
            this.guna2Panel1.Controls.Add(this.g2btnFloor);
            this.guna2Panel1.Controls.Add(this.g2btnGround);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(290, 1200);
            this.guna2Panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyQuanAn.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 996);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // g2pnlFloor
            // 
            this.g2pnlFloor.BackColor = System.Drawing.Color.OrangeRed;
            this.g2pnlFloor.Location = new System.Drawing.Point(3, 148);
            this.g2pnlFloor.Name = "g2pnlFloor";
            this.g2pnlFloor.Size = new System.Drawing.Size(10, 45);
            this.g2pnlFloor.TabIndex = 4;
            // 
            // g2pnlGround
            // 
            this.g2pnlGround.BackColor = System.Drawing.Color.OrangeRed;
            this.g2pnlGround.Location = new System.Drawing.Point(3, 97);
            this.g2pnlGround.Name = "g2pnlGround";
            this.g2pnlGround.Size = new System.Drawing.Size(10, 45);
            this.g2pnlGround.TabIndex = 3;
            // 
            // g2btnAdmin
            // 
            this.g2btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.g2btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.g2btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.g2btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.g2btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.g2btnAdmin.FillColor = System.Drawing.Color.Transparent;
            this.g2btnAdmin.Font = new System.Drawing.Font("Magneto", 16F);
            this.g2btnAdmin.ForeColor = System.Drawing.Color.White;
            this.g2btnAdmin.Location = new System.Drawing.Point(0, 199);
            this.g2btnAdmin.Name = "g2btnAdmin";
            this.g2btnAdmin.Size = new System.Drawing.Size(291, 45);
            this.g2btnAdmin.TabIndex = 2;
            this.g2btnAdmin.Text = "Admin";
            this.g2btnAdmin.Click += new System.EventHandler(this.g2btnAdmin_Click);
            // 
            // g2btnFloor
            // 
            this.g2btnFloor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2btnFloor.BackColor = System.Drawing.Color.Transparent;
            this.g2btnFloor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.g2btnFloor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.g2btnFloor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.g2btnFloor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.g2btnFloor.FillColor = System.Drawing.Color.Transparent;
            this.g2btnFloor.Font = new System.Drawing.Font("Magneto", 16F);
            this.g2btnFloor.ForeColor = System.Drawing.Color.White;
            this.g2btnFloor.Location = new System.Drawing.Point(-3, 148);
            this.g2btnFloor.Name = "g2btnFloor";
            this.g2btnFloor.Size = new System.Drawing.Size(291, 45);
            this.g2btnFloor.TabIndex = 1;
            this.g2btnFloor.Text = "Tầng 1";
            this.g2btnFloor.Click += new System.EventHandler(this.g2btnFloor_Click);
            // 
            // g2btnGround
            // 
            this.g2btnGround.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2btnGround.BackColor = System.Drawing.Color.Transparent;
            this.g2btnGround.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.g2btnGround.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.g2btnGround.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.g2btnGround.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.g2btnGround.FillColor = System.Drawing.Color.Transparent;
            this.g2btnGround.Font = new System.Drawing.Font("Magneto", 16F);
            this.g2btnGround.ForeColor = System.Drawing.Color.White;
            this.g2btnGround.Location = new System.Drawing.Point(0, 97);
            this.g2btnGround.Name = "g2btnGround";
            this.g2btnGround.Size = new System.Drawing.Size(291, 45);
            this.g2btnGround.TabIndex = 0;
            this.g2btnGround.Text = "Tầng Trệt";
            this.g2btnGround.Click += new System.EventHandler(this.g2btnGround_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.flpGround);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.g2cbtnBack);
            this.Controls.Add(this.g2cbtnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Sơ đồ bàn ăn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flpGround;
		private Guna.UI2.WinForms.Guna2CircleButton g2cbtnQuit;
		private Guna.UI2.WinForms.Guna2CircleButton g2cbtnBack;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button g2btnGround;
		private Guna.UI2.WinForms.Guna2Button g2btnFloor;
		private Guna.UI2.WinForms.Guna2Button g2btnAdmin;
		private Guna.UI2.WinForms.Guna2Panel g2pnlFloor;
		private Guna.UI2.WinForms.Guna2Panel g2pnlGround;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}