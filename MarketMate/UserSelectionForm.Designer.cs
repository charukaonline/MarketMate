namespace MarketMate
{
    partial class UserSelectionForm
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
            this.CashierBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AdminBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CashierBtn
            // 
            this.CashierBtn.BorderRadius = 10;
            this.CashierBtn.CheckedState.Parent = this.CashierBtn;
            this.CashierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierBtn.CustomImages.Parent = this.CashierBtn;
            this.CashierBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CashierBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierBtn.ForeColor = System.Drawing.Color.White;
            this.CashierBtn.HoverState.Parent = this.CashierBtn;
            this.CashierBtn.Location = new System.Drawing.Point(226, 181);
            this.CashierBtn.Name = "CashierBtn";
            this.CashierBtn.ShadowDecoration.Parent = this.CashierBtn;
            this.CashierBtn.Size = new System.Drawing.Size(180, 45);
            this.CashierBtn.TabIndex = 12;
            this.CashierBtn.Text = "Cashier Login";
            this.CashierBtn.Click += new System.EventHandler(this.CashierBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.BorderRadius = 10;
            this.AdminBtn.CheckedState.Parent = this.AdminBtn;
            this.AdminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminBtn.CustomImages.Parent = this.AdminBtn;
            this.AdminBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AdminBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.ForeColor = System.Drawing.Color.White;
            this.AdminBtn.HoverState.Parent = this.AdminBtn;
            this.AdminBtn.Location = new System.Drawing.Point(226, 275);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.ShadowDecoration.Parent = this.AdminBtn;
            this.AdminBtn.Size = new System.Drawing.Size(180, 45);
            this.AdminBtn.TabIndex = 13;
            this.AdminBtn.Text = "Admin Login";
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(142, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome to Market Mate!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(154, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select the preferred login based on your role.";
            // 
            // UserSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.CashierBtn);
            this.Name = "UserSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button CashierBtn;
        private Guna.UI2.WinForms.Guna2Button AdminBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}