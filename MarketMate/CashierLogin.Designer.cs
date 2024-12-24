namespace MarketMate
{
    partial class CashierLogin
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
            this.labelLockoutTimer = new System.Windows.Forms.Label();
            this.pinValidationLbl = new System.Windows.Forms.Label();
            this.usernameValidationLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goBackBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLockoutTimer
            // 
            this.labelLockoutTimer.AutoSize = true;
            this.labelLockoutTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLockoutTimer.ForeColor = System.Drawing.Color.White;
            this.labelLockoutTimer.Location = new System.Drawing.Point(247, 73);
            this.labelLockoutTimer.Name = "labelLockoutTimer";
            this.labelLockoutTimer.Size = new System.Drawing.Size(0, 17);
            this.labelLockoutTimer.TabIndex = 16;
            // 
            // pinValidationLbl
            // 
            this.pinValidationLbl.AutoSize = true;
            this.pinValidationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinValidationLbl.ForeColor = System.Drawing.Color.Red;
            this.pinValidationLbl.Location = new System.Drawing.Point(122, 312);
            this.pinValidationLbl.Name = "pinValidationLbl";
            this.pinValidationLbl.Size = new System.Drawing.Size(106, 17);
            this.pinValidationLbl.TabIndex = 14;
            this.pinValidationLbl.Text = "*Enter valid PIN";
            // 
            // usernameValidationLbl
            // 
            this.usernameValidationLbl.AutoSize = true;
            this.usernameValidationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValidationLbl.ForeColor = System.Drawing.Color.Red;
            this.usernameValidationLbl.Location = new System.Drawing.Point(122, 200);
            this.usernameValidationLbl.Name = "usernameValidationLbl";
            this.usernameValidationLbl.Size = new System.Drawing.Size(151, 17);
            this.usernameValidationLbl.TabIndex = 15;
            this.usernameValidationLbl.Text = "*Enter valid user name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(154, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "If you don\'t have access, please contact admin";
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 10;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(228, 345);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(180, 45);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.BorderColor = System.Drawing.Color.Transparent;
            this.userNameTxt.BorderRadius = 10;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.DefaultText = "";
            this.userNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxt.DisabledState.Parent = this.userNameTxt;
            this.userNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.userNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxt.FocusedState.Parent = this.userNameTxt;
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.White;
            this.userNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxt.HoverState.Parent = this.userNameTxt;
            this.userNameTxt.Location = new System.Drawing.Point(124, 154);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.PasswordChar = '\0';
            this.userNameTxt.PlaceholderText = "";
            this.userNameTxt.SelectedText = "";
            this.userNameTxt.ShadowDecoration.Parent = this.userNameTxt;
            this.userNameTxt.Size = new System.Drawing.Size(390, 41);
            this.userNameTxt.TabIndex = 9;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.passwordTxtBox.BorderRadius = 10;
            this.passwordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtBox.DefaultText = "";
            this.passwordTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtBox.DisabledState.Parent = this.passwordTxtBox;
            this.passwordTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.passwordTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.FocusedState.Parent = this.passwordTxtBox;
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.Color.White;
            this.passwordTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.HoverState.Parent = this.passwordTxtBox;
            this.passwordTxtBox.Location = new System.Drawing.Point(124, 265);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.PlaceholderText = "";
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.ShadowDecoration.Parent = this.passwordTxtBox;
            this.passwordTxtBox.Size = new System.Drawing.Size(390, 41);
            this.passwordTxtBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(120, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(120, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cashier Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(142, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome to Market Mate!";
            // 
            // goBackBtn
            // 
            this.goBackBtn.AutoSize = true;
            this.goBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.goBackBtn.Location = new System.Drawing.Point(268, 459);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(88, 24);
            this.goBackBtn.TabIndex = 18;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click_1);
            // 
            // CashierLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 522);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLockoutTimer);
            this.Controls.Add(this.pinValidationLbl);
            this.Controls.Add(this.usernameValidationLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CashierLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLockoutTimer;
        private System.Windows.Forms.Label pinValidationLbl;
        private System.Windows.Forms.Label usernameValidationLbl;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2TextBox userNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label goBackBtn;
    }
}

