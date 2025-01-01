namespace MarketMate.adminUserControls
{
    partial class ManageSuppliers
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
            this.showSuppliers = new System.Windows.Forms.DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.supplierIDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showSuppliers)).BeginInit();
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
            this.guna2Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(370, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Suppliers";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.showSuppliers);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 60);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1040, 271);
            this.guna2Panel2.TabIndex = 2;
            // 
            // showSuppliers
            // 
            this.showSuppliers.AllowUserToOrderColumns = true;
            this.showSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.showSuppliers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.showSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showSuppliers.Location = new System.Drawing.Point(0, 0);
            this.showSuppliers.Name = "showSuppliers";
            this.showSuppliers.Size = new System.Drawing.Size(1040, 271);
            this.showSuppliers.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.deleteBtn);
            this.guna2Panel3.Controls.Add(this.updateBtn);
            this.guna2Panel3.Controls.Add(this.nameTxt);
            this.guna2Panel3.Controls.Add(this.emailTxt);
            this.guna2Panel3.Controls.Add(this.phoneTxt);
            this.guna2Panel3.Controls.Add(this.supplierIDTxt);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 337);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1040, 168);
            this.guna2Panel3.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BorderRadius = 10;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Location = new System.Drawing.Point(758, 86);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(140, 36);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
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
            this.updateBtn.Location = new System.Drawing.Point(758, 42);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(140, 36);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "Update";
            // 
            // emailTxt
            // 
            this.emailTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.emailTxt.BorderRadius = 5;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.Parent = this.emailTxt;
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.FocusedState.Parent = this.emailTxt;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.White;
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.HoverState.Parent = this.emailTxt;
            this.emailTxt.Location = new System.Drawing.Point(347, 86);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(382, 36);
            this.emailTxt.TabIndex = 15;
            // 
            // phoneTxt
            // 
            this.phoneTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.phoneTxt.BorderRadius = 5;
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxt.DefaultText = "";
            this.phoneTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.DisabledState.Parent = this.phoneTxt;
            this.phoneTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.phoneTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.FocusedState.Parent = this.phoneTxt;
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.ForeColor = System.Drawing.Color.White;
            this.phoneTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.HoverState.Parent = this.phoneTxt;
            this.phoneTxt.Location = new System.Drawing.Point(67, 86);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.phoneTxt.PlaceholderText = "Contact Number";
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.ShadowDecoration.Parent = this.phoneTxt;
            this.phoneTxt.Size = new System.Drawing.Size(250, 36);
            this.phoneTxt.TabIndex = 17;
            // 
            // supplierIDTxt
            // 
            this.supplierIDTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.supplierIDTxt.BorderRadius = 5;
            this.supplierIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierIDTxt.DefaultText = "";
            this.supplierIDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierIDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierIDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierIDTxt.DisabledState.Parent = this.supplierIDTxt;
            this.supplierIDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierIDTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.supplierIDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierIDTxt.FocusedState.Parent = this.supplierIDTxt;
            this.supplierIDTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIDTxt.ForeColor = System.Drawing.Color.White;
            this.supplierIDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierIDTxt.HoverState.Parent = this.supplierIDTxt;
            this.supplierIDTxt.Location = new System.Drawing.Point(67, 42);
            this.supplierIDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierIDTxt.Name = "supplierIDTxt";
            this.supplierIDTxt.PasswordChar = '\0';
            this.supplierIDTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.supplierIDTxt.PlaceholderText = "Supplier ID";
            this.supplierIDTxt.SelectedText = "";
            this.supplierIDTxt.ShadowDecoration.Parent = this.supplierIDTxt;
            this.supplierIDTxt.Size = new System.Drawing.Size(250, 36);
            this.supplierIDTxt.TabIndex = 14;
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
            this.nameTxt.Location = new System.Drawing.Point(347, 42);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.nameTxt.PlaceholderText = "Supplier Name";
            this.nameTxt.SelectedText = "";
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(382, 36);
            this.nameTxt.TabIndex = 15;
            // 
            // ManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ManageSuppliers";
            this.Size = new System.Drawing.Size(1040, 505);
            this.Load += new System.EventHandler(this.ManageSuppliers_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showSuppliers)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView showSuppliers;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2TextBox phoneTxt;
        private Guna.UI2.WinForms.Guna2TextBox supplierIDTxt;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
    }
}
