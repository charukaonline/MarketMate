namespace MarketMate.adminUserControls
{
    partial class ViewProducts
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.showProducts = new System.Windows.Forms.DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.productIDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showProducts)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1040, 60);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(393, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Products";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.showProducts);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 60);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1040, 293);
            this.guna2Panel2.TabIndex = 3;
            // 
            // showProducts
            // 
            this.showProducts.AllowUserToOrderColumns = true;
            this.showProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.showProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.showProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showProducts.Location = new System.Drawing.Point(0, 0);
            this.showProducts.Name = "showProducts";
            this.showProducts.Size = new System.Drawing.Size(1040, 293);
            this.showProducts.TabIndex = 2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.updateBtn);
            this.guna2Panel3.Controls.Add(this.nameTxt);
            this.guna2Panel3.Controls.Add(this.productIDTxt);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 359);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1040, 146);
            this.guna2Panel3.TabIndex = 4;
            // 
            // updateBtn
            // 
            this.updateBtn.BorderRadius = 10;
            this.updateBtn.CheckedState.Parent = this.updateBtn;
            this.updateBtn.CustomImages.Parent = this.updateBtn;
            this.updateBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.HoverState.Parent = this.updateBtn;
            this.updateBtn.Location = new System.Drawing.Point(822, 50);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(140, 36);
            this.updateBtn.TabIndex = 25;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nameTxt.BorderRadius = 5;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.Parent = this.nameTxt;
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.FocusedState.Parent = this.nameTxt;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.White;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.HoverState.Parent = this.nameTxt;
            this.nameTxt.Location = new System.Drawing.Point(354, 50);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.nameTxt.PlaceholderText = "Product Name";
            this.nameTxt.SelectedText = "";
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(382, 36);
            this.nameTxt.TabIndex = 22;
            // 
            // productIDTxt
            // 
            this.productIDTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.productIDTxt.BorderRadius = 5;
            this.productIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productIDTxt.DefaultText = "";
            this.productIDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productIDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productIDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productIDTxt.DisabledState.Parent = this.productIDTxt;
            this.productIDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productIDTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.productIDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productIDTxt.FocusedState.Parent = this.productIDTxt;
            this.productIDTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTxt.ForeColor = System.Drawing.Color.White;
            this.productIDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productIDTxt.HoverState.Parent = this.productIDTxt;
            this.productIDTxt.Location = new System.Drawing.Point(74, 50);
            this.productIDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productIDTxt.Name = "productIDTxt";
            this.productIDTxt.PasswordChar = '\0';
            this.productIDTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.productIDTxt.PlaceholderText = "Product ID";
            this.productIDTxt.SelectedText = "";
            this.productIDTxt.ShadowDecoration.Parent = this.productIDTxt;
            this.productIDTxt.Size = new System.Drawing.Size(250, 36);
            this.productIDTxt.TabIndex = 21;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ViewProducts";
            this.Size = new System.Drawing.Size(1040, 505);
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showProducts)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView showProducts;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2TextBox productIDTxt;
    }
}
