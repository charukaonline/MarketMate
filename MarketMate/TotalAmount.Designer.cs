﻿namespace MarketMate
{
    partial class TotalAmount
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
            this.receivedMoneyTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.totAmountlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.discountlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.orderDetailsGrid = new System.Windows.Forms.DataGridView();
            this.balancelbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimelbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // receivedMoneyTxt
            // 
            this.receivedMoneyTxt.BackColor = System.Drawing.Color.Transparent;
            this.receivedMoneyTxt.BorderRadius = 10;
            this.receivedMoneyTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.receivedMoneyTxt.DefaultText = "";
            this.receivedMoneyTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.receivedMoneyTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.receivedMoneyTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.receivedMoneyTxt.DisabledState.Parent = this.receivedMoneyTxt;
            this.receivedMoneyTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.receivedMoneyTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.receivedMoneyTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.receivedMoneyTxt.FocusedState.Parent = this.receivedMoneyTxt;
            this.receivedMoneyTxt.ForeColor = System.Drawing.Color.White;
            this.receivedMoneyTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.receivedMoneyTxt.HoverState.Parent = this.receivedMoneyTxt;
            this.receivedMoneyTxt.Location = new System.Drawing.Point(117, 385);
            this.receivedMoneyTxt.Name = "receivedMoneyTxt";
            this.receivedMoneyTxt.PasswordChar = '\0';
            this.receivedMoneyTxt.PlaceholderText = "$ 0.00";
            this.receivedMoneyTxt.SelectedText = "";
            this.receivedMoneyTxt.ShadowDecoration.Parent = this.receivedMoneyTxt;
            this.receivedMoneyTxt.Size = new System.Drawing.Size(108, 25);
            this.receivedMoneyTxt.TabIndex = 9;
            this.receivedMoneyTxt.TextChanged += new System.EventHandler(this.ReceivedMoneyTxt_TextChanged);
            // 
            // totAmountlbl
            // 
            this.totAmountlbl.AutoSize = true;
            this.totAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totAmountlbl.Location = new System.Drawing.Point(114, 357);
            this.totAmountlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totAmountlbl.Name = "totAmountlbl";
            this.totAmountlbl.Size = new System.Drawing.Size(69, 18);
            this.totAmountlbl.TabIndex = 11;
            this.totAmountlbl.Text = "LKR 0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount Given: ";
            // 
            // discountlbl
            // 
            this.discountlbl.AutoSize = true;
            this.discountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountlbl.Location = new System.Drawing.Point(115, 422);
            this.discountlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(69, 18);
            this.discountlbl.TabIndex = 13;
            this.discountlbl.Text = "LKR 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Amount: ";
            // 
            // printBillBtn
            // 
            this.printBillBtn.BorderRadius = 10;
            this.printBillBtn.CheckedState.Parent = this.printBillBtn;
            this.printBillBtn.CustomImages.Parent = this.printBillBtn;
            this.printBillBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.printBillBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBillBtn.ForeColor = System.Drawing.Color.White;
            this.printBillBtn.HoverState.Parent = this.printBillBtn;
            this.printBillBtn.Location = new System.Drawing.Point(275, 443);
            this.printBillBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printBillBtn.Name = "printBillBtn";
            this.printBillBtn.ShadowDecoration.Parent = this.printBillBtn;
            this.printBillBtn.Size = new System.Drawing.Size(120, 29);
            this.printBillBtn.TabIndex = 15;
            this.printBillBtn.Text = "Done";
            this.printBillBtn.Click += new System.EventHandler(this.printBillBtn_Click);
            // 
            // orderDetailsGrid
            // 
            this.orderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsGrid.Location = new System.Drawing.Point(8, 155);
            this.orderDetailsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.orderDetailsGrid.Name = "orderDetailsGrid";
            this.orderDetailsGrid.RowHeadersWidth = 62;
            this.orderDetailsGrid.RowTemplate.Height = 28;
            this.orderDetailsGrid.Size = new System.Drawing.Size(387, 177);
            this.orderDetailsGrid.TabIndex = 16;
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelbl.Location = new System.Drawing.Point(77, 455);
            this.balancelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(69, 18);
            this.balancelbl.TabIndex = 10;
            this.balancelbl.Text = "LKR 0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 422);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Discount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 455);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "077 1234567 / 032 1234567 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Market Mate, Colombo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Market Mate";
            // 
            // dateTimelbl
            // 
            this.dateTimelbl.AutoSize = true;
            this.dateTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimelbl.Location = new System.Drawing.Point(133, 98);
            this.dateTimelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateTimelbl.Name = "dateTimelbl";
            this.dateTimelbl.Size = new System.Drawing.Size(104, 18);
            this.dateTimelbl.TabIndex = 21;
            this.dateTimelbl.Text = "Date and Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cash";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Payment Method: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Date and Time: ";
            // 
            // TotalAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 484);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimelbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.orderDetailsGrid);
            this.Controls.Add(this.printBillBtn);
            this.Controls.Add(this.receivedMoneyTxt);
            this.Controls.Add(this.balancelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totAmountlbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discountlbl);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TotalAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalAmount";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox receivedMoneyTxt;
        private System.Windows.Forms.Label totAmountlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label discountlbl;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button printBillBtn;
        private System.Windows.Forms.DataGridView orderDetailsGrid;
        private System.Windows.Forms.Label balancelbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateTimelbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}