namespace QuanLyQuanAn
{
	partial class ItemFood
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.idFood = new System.Windows.Forms.Label();
			this.idTable = new System.Windows.Forms.Label();
			this.g2tbQuantity = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.g2btnPlus = new Guna.UI2.WinForms.Guna2Button();
			this.btnPicFood = new System.Windows.Forms.Button();
			this.g2tbNote = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên món";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// idFood
			// 
			this.idFood.AutoSize = true;
			this.idFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idFood.Location = new System.Drawing.Point(139, 0);
			this.idFood.Name = "idFood";
			this.idFood.Size = new System.Drawing.Size(73, 25);
			this.idFood.TabIndex = 3;
			this.idFood.Text = "IdFood";
			this.idFood.Visible = false;
			// 
			// idTable
			// 
			this.idTable.AutoSize = true;
			this.idTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idTable.Location = new System.Drawing.Point(-5, 0);
			this.idTable.Name = "idTable";
			this.idTable.Size = new System.Drawing.Size(78, 25);
			this.idTable.TabIndex = 4;
			this.idTable.Text = "IdTable";
			this.idTable.Visible = false;
			// 
			// g2tbQuantity
			// 
			this.g2tbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.g2tbQuantity.AutoSize = true;
			this.g2tbQuantity.BackColor = System.Drawing.Color.Transparent;
			this.g2tbQuantity.BorderColor = System.Drawing.Color.Transparent;
			this.g2tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2tbQuantity.DefaultText = "";
			this.g2tbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.g2tbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.g2tbQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.g2tbQuantity.ForeColor = System.Drawing.Color.Black;
			this.g2tbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbQuantity.Location = new System.Drawing.Point(248, -1);
			this.g2tbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.g2tbQuantity.Name = "g2tbQuantity";
			this.g2tbQuantity.PasswordChar = '\0';
			this.g2tbQuantity.PlaceholderText = "";
			this.g2tbQuantity.SelectedText = "";
			this.g2tbQuantity.Size = new System.Drawing.Size(44, 35);
			this.g2tbQuantity.TabIndex = 7;
			this.g2tbQuantity.TextChanged += new System.EventHandler(this.g2tbQuantity_TextChanged);
			// 
			// guna2Button1
			// 
			this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.minus;
			this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = System.Drawing.Color.Black;
			this.guna2Button1.Location = new System.Drawing.Point(208, 284);
			this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(30, 30);
			this.guna2Button1.TabIndex = 6;
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// g2btnPlus
			// 
			this.g2btnPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.g2btnPlus.BackColor = System.Drawing.Color.Transparent;
			this.g2btnPlus.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.plus__2_;
			this.g2btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.g2btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.g2btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.g2btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.g2btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.g2btnPlus.FillColor = System.Drawing.Color.Transparent;
			this.g2btnPlus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			this.g2btnPlus.ForeColor = System.Drawing.Color.Black;
			this.g2btnPlus.Location = new System.Drawing.Point(248, 283);
			this.g2btnPlus.Margin = new System.Windows.Forms.Padding(0);
			this.g2btnPlus.Name = "g2btnPlus";
			this.g2btnPlus.Size = new System.Drawing.Size(30, 30);
			this.g2btnPlus.TabIndex = 5;
			this.g2btnPlus.Click += new System.EventHandler(this.g2btnPlus_Click);
			// 
			// btnPicFood
			// 
			this.btnPicFood.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.mc_haisan;
			this.btnPicFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPicFood.Location = new System.Drawing.Point(-1, -5);
			this.btnPicFood.Name = "btnPicFood";
			this.btnPicFood.Size = new System.Drawing.Size(312, 208);
			this.btnPicFood.TabIndex = 2;
			this.btnPicFood.UseVisualStyleBackColor = true;
			this.btnPicFood.Click += new System.EventHandler(this.btnPicFood_Click);
			// 
			// g2tbNote
			// 
			this.g2tbNote.BorderThickness = 0;
			this.g2tbNote.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2tbNote.DefaultText = "";
			this.g2tbNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.g2tbNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.g2tbNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbNote.FillColor = System.Drawing.Color.WhiteSmoke;
			this.g2tbNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbNote.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.g2tbNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbNote.Location = new System.Drawing.Point(0, 236);
			this.g2tbNote.Multiline = true;
			this.g2tbNote.Name = "g2tbNote";
			this.g2tbNote.PasswordChar = '\0';
			this.g2tbNote.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.g2tbNote.PlaceholderText = "Ghi Chú";
			this.g2tbNote.SelectedText = "";
			this.g2tbNote.Size = new System.Drawing.Size(293, 44);
			this.g2tbNote.TabIndex = 8;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 10;
			// 
			// ItemFood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.g2tbNote);
			this.Controls.Add(this.g2tbQuantity);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.g2btnPlus);
			this.Controls.Add(this.idTable);
			this.Controls.Add(this.idFood);
			this.Controls.Add(this.btnPicFood);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(10);
			this.Name = "ItemFood";
			this.Size = new System.Drawing.Size(291, 318);
			this.Load += new System.EventHandler(this.ItemFood_Load);
			this.Click += new System.EventHandler(this.ItemFood_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPicFood;
		private System.Windows.Forms.Label idFood;
		private System.Windows.Forms.Label idTable;
		private Guna.UI2.WinForms.Guna2Button g2btnPlus;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2TextBox g2tbQuantity;
		private Guna.UI2.WinForms.Guna2TextBox g2tbNote;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
	}
}
