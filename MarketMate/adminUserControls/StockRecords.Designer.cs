namespace MarketMate.adminUserControls
{
    partial class StockRecords
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.showStocks = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1040, 60);
            this.guna2Panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(297, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Previous Stock Additions";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.refreshBtn);
            this.guna2Panel1.Controls.Add(this.showStocks);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1040, 445);
            this.guna2Panel1.TabIndex = 5;
            // 
            // showStocks
            // 
            this.showStocks.AllowUserToOrderColumns = true;
            this.showStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showStocks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.showStocks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.showStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.showStocks.Location = new System.Drawing.Point(0, 0);
            this.showStocks.Name = "showStocks";
            this.showStocks.Size = new System.Drawing.Size(1040, 349);
            this.showStocks.TabIndex = 2;
            // 
            // refreshBtn
            // 
            this.refreshBtn.CheckedState.Parent = this.refreshBtn;
            this.refreshBtn.CustomImages.Parent = this.refreshBtn;
            this.refreshBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.HoverState.Parent = this.refreshBtn;
            this.refreshBtn.Location = new System.Drawing.Point(431, 375);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.ShadowDecoration.Parent = this.refreshBtn;
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 17;
            this.refreshBtn.Text = "Refresh Data";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // StockRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "StockRecords";
            this.Size = new System.Drawing.Size(1040, 505);
            this.Load += new System.EventHandler(this.StockRecords_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView showStocks;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
    }
}
