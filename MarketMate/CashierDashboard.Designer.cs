namespace MarketMate
{
    partial class CashierDashboard
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.proceedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.addItemsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.quantityTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.productIdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.totAmountlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1426, 107);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "MarketMate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToOrderColumns = true;
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.quantity,
            this.discount,
            this.total_price});
            this.orderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGrid.Location = new System.Drawing.Point(0, 0);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.RowHeadersWidth = 62;
            this.orderGrid.RowTemplate.Height = 28;
            this.orderGrid.Size = new System.Drawing.Size(1426, 420);
            this.orderGrid.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 107);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1426, 55);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.orderGrid);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 162);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1426, 420);
            this.guna2Panel3.TabIndex = 6;
            // 
            // proceedBtn
            // 
            this.proceedBtn.BorderRadius = 10;
            this.proceedBtn.CheckedState.Parent = this.proceedBtn;
            this.proceedBtn.CustomImages.Parent = this.proceedBtn;
            this.proceedBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.proceedBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.ForeColor = System.Drawing.Color.White;
            this.proceedBtn.HoverState.Parent = this.proceedBtn;
            this.proceedBtn.Location = new System.Drawing.Point(224, 181);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.ShadowDecoration.Parent = this.proceedBtn;
            this.proceedBtn.Size = new System.Drawing.Size(180, 49);
            this.proceedBtn.TabIndex = 7;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2Panel6);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.Location = new System.Drawing.Point(1010, 582);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(416, 235);
            this.guna2Panel4.TabIndex = 8;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Honeydew;
            this.guna2Panel5.Controls.Add(this.addItemsBtn);
            this.guna2Panel5.Controls.Add(this.quantityTxt);
            this.guna2Panel5.Controls.Add(this.productIdTxt);
            this.guna2Panel5.Controls.Add(this.label3);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 582);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(1004, 235);
            this.guna2Panel5.TabIndex = 8;
            // 
            // addItemsBtn
            // 
            this.addItemsBtn.BorderRadius = 10;
            this.addItemsBtn.CheckedState.Parent = this.addItemsBtn;
            this.addItemsBtn.CustomImages.Parent = this.addItemsBtn;
            this.addItemsBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.addItemsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemsBtn.ForeColor = System.Drawing.Color.White;
            this.addItemsBtn.HoverState.Parent = this.addItemsBtn;
            this.addItemsBtn.Location = new System.Drawing.Point(762, 102);
            this.addItemsBtn.Name = "addItemsBtn";
            this.addItemsBtn.ShadowDecoration.Parent = this.addItemsBtn;
            this.addItemsBtn.Size = new System.Drawing.Size(180, 55);
            this.addItemsBtn.TabIndex = 13;
            this.addItemsBtn.Text = "Add Items";
            this.addItemsBtn.Click += new System.EventHandler(this.addItemsBtn_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.BorderRadius = 10;
            this.quantityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTxt.DefaultText = "";
            this.quantityTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityTxt.DisabledState.Parent = this.quantityTxt;
            this.quantityTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.quantityTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityTxt.FocusedState.Parent = this.quantityTxt;
            this.quantityTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.ForeColor = System.Drawing.Color.White;
            this.quantityTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityTxt.HoverState.Parent = this.quantityTxt;
            this.quantityTxt.Location = new System.Drawing.Point(398, 102);
            this.quantityTxt.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.PasswordChar = '\0';
            this.quantityTxt.PlaceholderText = "Quantity";
            this.quantityTxt.SelectedText = "";
            this.quantityTxt.ShadowDecoration.Parent = this.quantityTxt;
            this.quantityTxt.Size = new System.Drawing.Size(319, 55);
            this.quantityTxt.TabIndex = 10;
            // 
            // productIdTxt
            // 
            this.productIdTxt.BorderRadius = 10;
            this.productIdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productIdTxt.DefaultText = "";
            this.productIdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productIdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productIdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productIdTxt.DisabledState.Parent = this.productIdTxt;
            this.productIdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productIdTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.productIdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productIdTxt.FocusedState.Parent = this.productIdTxt;
            this.productIdTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTxt.ForeColor = System.Drawing.Color.White;
            this.productIdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productIdTxt.HoverState.Parent = this.productIdTxt;
            this.productIdTxt.Location = new System.Drawing.Point(54, 102);
            this.productIdTxt.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.productIdTxt.Name = "productIdTxt";
            this.productIdTxt.PasswordChar = '\0';
            this.productIdTxt.PlaceholderText = "Product ID";
            this.productIdTxt.SelectedText = "";
            this.productIdTxt.ShadowDecoration.Parent = this.productIdTxt;
            this.productIdTxt.Size = new System.Drawing.Size(308, 55);
            this.productIdTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Add Items";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.proceedBtn);
            this.guna2Panel6.Controls.Add(this.guna2TextBox1);
            this.guna2Panel6.Controls.Add(this.label7);
            this.guna2Panel6.Controls.Add(this.totAmountlbl);
            this.guna2Panel6.Controls.Add(this.label5);
            this.guna2Panel6.Controls.Add(this.label6);
            this.guna2Panel6.Controls.Add(this.label4);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(416, 235);
            this.guna2Panel6.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Amount: ";
            // 
            // totAmountlbl
            // 
            this.totAmountlbl.AutoSize = true;
            this.totAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totAmountlbl.Location = new System.Drawing.Point(219, 27);
            this.totAmountlbl.Name = "totAmountlbl";
            this.totAmountlbl.Size = new System.Drawing.Size(72, 26);
            this.totAmountlbl.TabIndex = 8;
            this.totAmountlbl.Text = "$ 0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount Given: ";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(224, 69);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "$ 0.00";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(162, 38);
            this.guna2TextBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Amount: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "$ 0.00";
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Product ID";
            this.product_id.MinimumWidth = 8;
            this.product_id.Name = "product_id";
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Product Name";
            this.product_name.MinimumWidth = 8;
            this.product_name.Name = "product_name";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.MinimumWidth = 8;
            this.discount.Name = "discount";
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total Price";
            this.total_price.MinimumWidth = 8;
            this.total_price.Name = "total_price";
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 817);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CashierDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDashboard";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderGrid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button proceedBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button addItemsBtn;
        private Guna.UI2.WinForms.Guna2TextBox quantityTxt;
        private Guna.UI2.WinForms.Guna2TextBox productIdTxt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label totAmountlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
    }
}