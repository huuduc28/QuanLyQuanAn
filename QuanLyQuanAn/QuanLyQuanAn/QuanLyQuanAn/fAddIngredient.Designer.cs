namespace QuanLyQuanAn
{
    partial class fAddIngredient
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
			this.components = new System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.g2btnBill_Ingredient = new Guna.UI2.WinForms.Guna2Button();
			this.dgvIngredientList = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lvBill = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.g2tbNameSupplier = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.g2nudQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.g2tbIdSupplier = new Guna.UI2.WinForms.Guna2TextBox();
			this.g2tbIdIngredient = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnAddAcount = new Guna.UI2.WinForms.Guna2Button();
			this.label2 = new System.Windows.Forms.Label();
			this.g2tbNameIngredient = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbTotalPriceAll = new System.Windows.Forms.Label();
			this.g2tbAllTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvIngredientList)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.g2nudQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 20;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// g2btnBill_Ingredient
			// 
			this.g2btnBill_Ingredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.g2btnBill_Ingredient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.g2btnBill_Ingredient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.g2btnBill_Ingredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.g2btnBill_Ingredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.g2btnBill_Ingredient.FillColor = System.Drawing.Color.Firebrick;
			this.g2btnBill_Ingredient.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.g2btnBill_Ingredient.ForeColor = System.Drawing.Color.White;
			this.g2btnBill_Ingredient.Location = new System.Drawing.Point(306, 274);
			this.g2btnBill_Ingredient.Name = "g2btnBill_Ingredient";
			this.g2btnBill_Ingredient.Size = new System.Drawing.Size(160, 45);
			this.g2btnBill_Ingredient.TabIndex = 16;
			this.g2btnBill_Ingredient.Text = "Nhập";
			this.g2btnBill_Ingredient.Click += new System.EventHandler(this.g2btnBill_Ingredient_Click);
			// 
			// dgvIngredientList
			// 
			this.dgvIngredientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvIngredientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIngredientList.Location = new System.Drawing.Point(295, 55);
			this.dgvIngredientList.Name = "dgvIngredientList";
			this.dgvIngredientList.RowHeadersWidth = 51;
			this.dgvIngredientList.RowTemplate.Height = 24;
			this.dgvIngredientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvIngredientList.Size = new System.Drawing.Size(586, 349);
			this.dgvIngredientList.TabIndex = 17;
			this.dgvIngredientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientList_CellClick);
			this.dgvIngredientList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvIngredientList_MouseDoubleClick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.flowLayoutPanel1.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.loginb_1;
			this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(-9, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 856);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::QuanLyQuanAn.Properties.Resources._75305539_790011471429099_6391566559478808576_n;
			this.pictureBox1.Location = new System.Drawing.Point(3, 250);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(295, 177);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::QuanLyQuanAn.Properties.Resources.Logo;
			this.pictureBox2.Location = new System.Drawing.Point(20, 620);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(20, 190, 3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(94, 88);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// lvBill
			// 
			this.lvBill.AccessibleName = "";
			this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvBill.GridLines = true;
			this.lvBill.HideSelection = false;
			this.lvBill.Location = new System.Drawing.Point(915, 55);
			this.lvBill.Name = "lvBill";
			this.lvBill.Size = new System.Drawing.Size(617, 653);
			this.lvBill.TabIndex = 19;
			this.lvBill.Tag = "";
			this.lvBill.UseCompatibleStateImageBehavior = false;
			this.lvBill.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên Nguyên Liệu";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nhà Cung Cấp";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Số Lượng";
			this.columnHeader3.Width = 50;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Đơn Giá";
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Thành tiền";
			this.columnHeader5.Width = 140;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.guna2Panel1.Controls.Add(this.g2tbNameSupplier);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Controls.Add(this.g2nudQuantity);
			this.guna2Panel1.Controls.Add(this.g2tbIdSupplier);
			this.guna2Panel1.Controls.Add(this.g2tbIdIngredient);
			this.guna2Panel1.Controls.Add(this.btnAddAcount);
			this.guna2Panel1.Controls.Add(this.g2btnBill_Ingredient);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Controls.Add(this.g2tbNameIngredient);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Location = new System.Drawing.Point(295, 458);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(489, 333);
			this.guna2Panel1.TabIndex = 20;
			// 
			// g2tbNameSupplier
			// 
			this.g2tbNameSupplier.BorderColor = System.Drawing.Color.Black;
			this.g2tbNameSupplier.BorderRadius = 5;
			this.g2tbNameSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2tbNameSupplier.DefaultText = "";
			this.g2tbNameSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.g2tbNameSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.g2tbNameSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbNameSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbNameSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbNameSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.g2tbNameSupplier.ForeColor = System.Drawing.Color.Black;
			this.g2tbNameSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbNameSupplier.Location = new System.Drawing.Point(13, 131);
			this.g2tbNameSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.g2tbNameSupplier.Name = "g2tbNameSupplier";
			this.g2tbNameSupplier.PasswordChar = '\0';
			this.g2tbNameSupplier.PlaceholderText = "";
			this.g2tbNameSupplier.SelectedText = "";
			this.g2tbNameSupplier.Size = new System.Drawing.Size(274, 50);
			this.g2tbNameSupplier.TabIndex = 21;
			this.g2tbNameSupplier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.g2tbNameSupplier_MouseDoubleClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 25);
			this.label3.TabIndex = 20;
			this.label3.Text = "Nhà Cung Cấp";
			// 
			// g2nudQuantity
			// 
			this.g2nudQuantity.BackColor = System.Drawing.Color.Transparent;
			this.g2nudQuantity.BorderColor = System.Drawing.Color.Black;
			this.g2nudQuantity.BorderRadius = 10;
			this.g2nudQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2nudQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.g2nudQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.g2nudQuantity.Location = new System.Drawing.Point(13, 213);
			this.g2nudQuantity.Name = "g2nudQuantity";
			this.g2nudQuantity.Size = new System.Drawing.Size(122, 42);
			this.g2nudQuantity.TabIndex = 19;
			this.g2nudQuantity.UpDownButtonFillColor = System.Drawing.Color.Firebrick;
			// 
			// g2tbIdSupplier
			// 
			this.g2tbIdSupplier.BorderColor = System.Drawing.Color.Black;
			this.g2tbIdSupplier.BorderRadius = 5;
			this.g2tbIdSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2tbIdSupplier.DefaultText = "";
			this.g2tbIdSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.g2tbIdSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.g2tbIdSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbIdSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbIdSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbIdSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.g2tbIdSupplier.ForeColor = System.Drawing.Color.Black;
			this.g2tbIdSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbIdSupplier.Location = new System.Drawing.Point(456, 4);
			this.g2tbIdSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.g2tbIdSupplier.Name = "g2tbIdSupplier";
			this.g2tbIdSupplier.PasswordChar = '\0';
			this.g2tbIdSupplier.PlaceholderText = "";
			this.g2tbIdSupplier.SelectedText = "";
			this.g2tbIdSupplier.Size = new System.Drawing.Size(10, 27);
			this.g2tbIdSupplier.TabIndex = 18;
			this.g2tbIdSupplier.Visible = false;
			// 
			// g2tbIdIngredient
			// 
			this.g2tbIdIngredient.BorderColor = System.Drawing.Color.Black;
			this.g2tbIdIngredient.BorderRadius = 5;
			this.g2tbIdIngredient.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2tbIdIngredient.DefaultText = "";
			this.g2tbIdIngredient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.g2tbIdIngredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.g2tbIdIngredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbIdIngredient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbIdIngredient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbIdIngredient.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.g2tbIdIngredient.ForeColor = System.Drawing.Color.Black;
			this.g2tbIdIngredient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbIdIngredient.Location = new System.Drawing.Point(474, 4);
			this.g2tbIdIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.g2tbIdIngredient.Name = "g2tbIdIngredient";
			this.g2tbIdIngredient.PasswordChar = '\0';
			this.g2tbIdIngredient.PlaceholderText = "";
			this.g2tbIdIngredient.SelectedText = "";
			this.g2tbIdIngredient.Size = new System.Drawing.Size(10, 27);
			this.g2tbIdIngredient.TabIndex = 17;
			this.g2tbIdIngredient.Visible = false;
			// 
			// btnAddAcount
			// 
			this.btnAddAcount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddAcount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddAcount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddAcount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddAcount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddAcount.FillColor = System.Drawing.Color.Firebrick;
			this.btnAddAcount.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnAddAcount.ForeColor = System.Drawing.Color.White;
			this.btnAddAcount.Location = new System.Drawing.Point(13, 274);
			this.btnAddAcount.Name = "btnAddAcount";
			this.btnAddAcount.Size = new System.Drawing.Size(137, 45);
			this.btnAddAcount.TabIndex = 1;
			this.btnAddAcount.Text = "Thêm";
			this.btnAddAcount.Click += new System.EventHandler(this.btnAddAcount_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Số lượng";
			// 
			// g2tbNameIngredient
			// 
			this.g2tbNameIngredient.BorderColor = System.Drawing.Color.Black;
			this.g2tbNameIngredient.BorderRadius = 5;
			this.g2tbNameIngredient.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2tbNameIngredient.DefaultText = "";
			this.g2tbNameIngredient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.g2tbNameIngredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.g2tbNameIngredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbNameIngredient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbNameIngredient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbNameIngredient.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.g2tbNameIngredient.ForeColor = System.Drawing.Color.Black;
			this.g2tbNameIngredient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbNameIngredient.Location = new System.Drawing.Point(13, 35);
			this.g2tbNameIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.g2tbNameIngredient.Name = "g2tbNameIngredient";
			this.g2tbNameIngredient.PasswordChar = '\0';
			this.g2tbNameIngredient.PlaceholderText = "";
			this.g2tbNameIngredient.SelectedText = "";
			this.g2tbNameIngredient.Size = new System.Drawing.Size(274, 50);
			this.g2tbNameIngredient.TabIndex = 1;
			this.g2tbNameIngredient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.g2tbNameIngredient_MouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên Hàng";
			// 
			// lbTotalPriceAll
			// 
			this.lbTotalPriceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTotalPriceAll.AutoSize = true;
			this.lbTotalPriceAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPriceAll.Location = new System.Drawing.Point(908, 738);
			this.lbTotalPriceAll.Name = "lbTotalPriceAll";
			this.lbTotalPriceAll.Size = new System.Drawing.Size(168, 39);
			this.lbTotalPriceAll.TabIndex = 21;
			this.lbTotalPriceAll.Text = "Tổng tiền:";
			// 
			// g2tbAllTotalPrice
			// 
			this.g2tbAllTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.g2tbAllTotalPrice.BorderColor = System.Drawing.Color.Black;
			this.g2tbAllTotalPrice.BorderRadius = 10;
			this.g2tbAllTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.g2tbAllTotalPrice.DefaultText = "";
			this.g2tbAllTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.g2tbAllTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.g2tbAllTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbAllTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.g2tbAllTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbAllTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.g2tbAllTotalPrice.ForeColor = System.Drawing.Color.Red;
			this.g2tbAllTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.g2tbAllTotalPrice.Location = new System.Drawing.Point(1106, 738);
			this.g2tbAllTotalPrice.Margin = new System.Windows.Forms.Padding(4);
			this.g2tbAllTotalPrice.Name = "g2tbAllTotalPrice";
			this.g2tbAllTotalPrice.PasswordChar = '\0';
			this.g2tbAllTotalPrice.PlaceholderText = "";
			this.g2tbAllTotalPrice.SelectedText = "";
			this.g2tbAllTotalPrice.Size = new System.Drawing.Size(405, 39);
			this.g2tbAllTotalPrice.TabIndex = 22;
			// 
			// guna2CircleButton2
			// 
			this.guna2CircleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.guna2CircleButton2.BorderThickness = 2;
			this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
			this.guna2CircleButton2.Location = new System.Drawing.Point(1498, 12);
			this.guna2CircleButton2.Name = "guna2CircleButton2";
			this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton2.Size = new System.Drawing.Size(34, 30);
			this.guna2CircleButton2.TabIndex = 23;
			this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
			// 
			// fAddIngredient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1581, 803);
			this.ControlBox = false;
			this.Controls.Add(this.guna2CircleButton2);
			this.Controls.Add(this.g2tbAllTotalPrice);
			this.Controls.Add(this.lbTotalPriceAll);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.lvBill);
			this.Controls.Add(this.dgvIngredientList);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fAddIngredient";
			((System.ComponentModel.ISupportInitialize)(this.dgvIngredientList)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.g2nudQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button g2btnBill_Ingredient;
        private System.Windows.Forms.DataGridView dgvIngredientList;
		private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddAcount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox g2tbNameIngredient;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox g2tbIdSupplier;
        private Guna.UI2.WinForms.Guna2TextBox g2tbIdIngredient;
		private Guna.UI2.WinForms.Guna2NumericUpDown g2nudQuantity;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label lbTotalPriceAll;
		private Guna.UI2.WinForms.Guna2TextBox g2tbAllTotalPrice;
		private Guna.UI2.WinForms.Guna2TextBox g2tbNameSupplier;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
	}
}