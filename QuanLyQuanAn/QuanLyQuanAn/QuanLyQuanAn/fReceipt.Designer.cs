namespace QuanLyQuanAn
{
	partial class fReceipt
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
			this.label1 = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.lbTotalPrice = new System.Windows.Forms.Label();
			this.lvReceipt = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbNameCustomer = new System.Windows.Forms.Label();
			this.lbDiscount = new System.Windows.Forms.Label();
			this.lbFinalTotalPrice = new System.Windows.Forms.Label();
			this.lbTable = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(325, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hóa Đơn";
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDate.Location = new System.Drawing.Point(40, 109);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(100, 25);
			this.lbDate.TabIndex = 1;
			this.lbDate.Text = "Ngày lập: ";
			// 
			// lbTotalPrice
			// 
			this.lbTotalPrice.AutoSize = true;
			this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPrice.Location = new System.Drawing.Point(40, 529);
			this.lbTotalPrice.Name = "lbTotalPrice";
			this.lbTotalPrice.Size = new System.Drawing.Size(100, 25);
			this.lbTotalPrice.TabIndex = 2;
			this.lbTotalPrice.Text = "Tổng tiền:";
			this.lbTotalPrice.Click += new System.EventHandler(this.lbTotalPrice_Click);
			// 
			// lvReceipt
			// 
			this.lvReceipt.AccessibleName = "lvBill";
			this.lvReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvReceipt.GridLines = true;
			this.lvReceipt.HideSelection = false;
			this.lvReceipt.Location = new System.Drawing.Point(45, 222);
			this.lvReceipt.Name = "lvReceipt";
			this.lvReceipt.Size = new System.Drawing.Size(709, 287);
			this.lvReceipt.TabIndex = 5;
			this.lvReceipt.Tag = "";
			this.lvReceipt.UseCompatibleStateImageBehavior = false;
			this.lvReceipt.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn giá";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thành tiền";
			this.columnHeader4.Width = 160;
			// 
			// lbNameCustomer
			// 
			this.lbNameCustomer.AutoSize = true;
			this.lbNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNameCustomer.Location = new System.Drawing.Point(40, 146);
			this.lbNameCustomer.Name = "lbNameCustomer";
			this.lbNameCustomer.Size = new System.Drawing.Size(124, 25);
			this.lbNameCustomer.TabIndex = 6;
			this.lbNameCustomer.Text = "Khách hàng:";
			// 
			// lbDiscount
			// 
			this.lbDiscount.AutoSize = true;
			this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiscount.Location = new System.Drawing.Point(40, 564);
			this.lbDiscount.Name = "lbDiscount";
			this.lbDiscount.Size = new System.Drawing.Size(95, 25);
			this.lbDiscount.TabIndex = 7;
			this.lbDiscount.Text = "Giảm giá:";
			// 
			// lbFinalTotalPrice
			// 
			this.lbFinalTotalPrice.AutoSize = true;
			this.lbFinalTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFinalTotalPrice.Location = new System.Drawing.Point(40, 602);
			this.lbFinalTotalPrice.Name = "lbFinalTotalPrice";
			this.lbFinalTotalPrice.Size = new System.Drawing.Size(111, 25);
			this.lbFinalTotalPrice.TabIndex = 8;
			this.lbFinalTotalPrice.Text = "Thành tiền:";
			// 
			// lbTable
			// 
			this.lbTable.AutoSize = true;
			this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTable.Location = new System.Drawing.Point(40, 183);
			this.lbTable.Name = "lbTable";
			this.lbTable.Size = new System.Drawing.Size(81, 25);
			this.lbTable.TabIndex = 9;
			this.lbTable.Text = "Số bàn:";
			// 
			// fReceipt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 658);
			this.Controls.Add(this.lbTable);
			this.Controls.Add(this.lbFinalTotalPrice);
			this.Controls.Add(this.lbDiscount);
			this.Controls.Add(this.lbNameCustomer);
			this.Controls.Add(this.lvReceipt);
			this.Controls.Add(this.lbTotalPrice);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "fReceipt";
			this.Text = "fReceipt";
			this.Load += new System.EventHandler(this.fReceipt_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label lbTotalPrice;
		private System.Windows.Forms.ListView lvReceipt;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label lbNameCustomer;
		private System.Windows.Forms.Label lbDiscount;
		private System.Windows.Forms.Label lbFinalTotalPrice;
		private System.Windows.Forms.Label lbTable;
	}
}