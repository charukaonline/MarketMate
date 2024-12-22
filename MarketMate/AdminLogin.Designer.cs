namespace MarketMate
{
    partial class AdminLogin
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
            this.goBackBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLockoutTimer = new System.Windows.Forms.Label();
            this.pinValidationLbl = new System.Windows.Forms.Label();
            this.usernameValidationLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackBtn
            // 
            this.goBackBtn.AutoSize = true;
            this.goBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goBackBtn.Location = new System.Drawing.Point(275, 460);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(88, 24);
            this.goBackBtn.TabIndex = 29;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Welcome to Market Mate!";
            // 
            // labelLockoutTimer
            // 
            this.labelLockoutTimer.AutoSize = true;
            this.labelLockoutTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLockoutTimer.ForeColor = System.Drawing.Color.White;
            this.labelLockoutTimer.Location = new System.Drawing.Point(244, 69);
            this.labelLockoutTimer.Name = "labelLockoutTimer";
            this.labelLockoutTimer.Size = new System.Drawing.Size(0, 17);
            this.labelLockoutTimer.TabIndex = 27;
            // 
            // pinValidationLbl
            // 
            this.pinValidationLbl.AutoSize = true;
            this.pinValidationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinValidationLbl.ForeColor = System.Drawing.Color.Red;
            this.pinValidationLbl.Location = new System.Drawing.Point(118, 308);
            this.pinValidationLbl.Name = "pinValidationLbl";
            this.pinValidationLbl.Size = new System.Drawing.Size(145, 17);
            this.pinValidationLbl.TabIndex = 25;
            this.pinValidationLbl.Text = "*Enter valid Password";
            // 
            // usernameValidationLbl
            // 
            this.usernameValidationLbl.AutoSize = true;
            this.usernameValidationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValidationLbl.ForeColor = System.Drawing.Color.Red;
            this.usernameValidationLbl.Location = new System.Drawing.Point(118, 196);
            this.usernameValidationLbl.Name = "usernameValidationLbl";
            this.usernameValidationLbl.Size = new System.Drawing.Size(151, 17);
            this.usernameValidationLbl.TabIndex = 26;
            this.usernameValidationLbl.Text = "*Enter valid user name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(572, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "* This is the admin login, please go back to Cashier Login if you are not an admi" +
    "n";
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 10;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(225, 341);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(180, 45);
            this.loginBtn.TabIndex = 23;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.userNameTxt.BorderColor = System.Drawing.Color.Transparent;
            this.userNameTxt.BorderRadius = 10;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.DefaultText = "";
            this.userNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxt.DisabledState.Parent = this.userNameTxt;
            this.userNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxt.FillColor = System.Drawing.Color.DimGray;
            this.userNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxt.FocusedState.Parent = this.userNameTxt;
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.White;
            this.userNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxt.HoverState.Parent = this.userNameTxt;
            this.userNameTxt.Location = new System.Drawing.Point(121, 151);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.PasswordChar = '\0';
            this.userNameTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.userNameTxt.PlaceholderText = "";
            this.userNameTxt.SelectedText = "";
            this.userNameTxt.ShadowDecoration.Parent = this.userNameTxt;
            this.userNameTxt.Size = new System.Drawing.Size(390, 40);
            this.userNameTxt.TabIndex = 21;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.Color.White;
            this.passwordTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.passwordTxtBox.BorderRadius = 10;
            this.passwordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtBox.DefaultText = "";
            this.passwordTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtBox.DisabledState.Parent = this.passwordTxtBox;
            this.passwordTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxtBox.FillColor = System.Drawing.Color.DimGray;
            this.passwordTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.FocusedState.Parent = this.passwordTxtBox;
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.Color.White;
            this.passwordTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.HoverState.Parent = this.passwordTxtBox;
            this.passwordTxtBox.Location = new System.Drawing.Point(121, 261);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordTxtBox.PlaceholderText = "";
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.ShadowDecoration.Parent = this.passwordTxtBox;
            this.passwordTxtBox.Size = new System.Drawing.Size(390, 40);
            this.passwordTxtBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(117, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Admin Username";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLockoutTimer;
        private System.Windows.Forms.Label pinValidationLbl;
        private System.Windows.Forms.Label usernameValidationLbl;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2TextBox userNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}