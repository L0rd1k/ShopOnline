namespace OnlineStore
{
    partial class MainAppForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_Delivery = new System.Windows.Forms.Button();
            this.btn_Collection = new System.Windows.Forms.Button();
            this.btn_MyPurchase = new System.Windows.Forms.Button();
            this.btn_ShoppingChart = new System.Windows.Forms.Button();
            this.btn_MyProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btn_Delivery);
            this.panel1.Controls.Add(this.btn_Collection);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_MyPurchase);
            this.panel1.Controls.Add(this.btn_ShoppingChart);
            this.panel1.Controls.Add(this.btn_MyProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 411);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sidePanel.Location = new System.Drawing.Point(1, 134);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 44);
            this.sidePanel.TabIndex = 3;
            // 
            // btn_Delivery
            // 
            this.btn_Delivery.FlatAppearance.BorderSize = 0;
            this.btn_Delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delivery.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delivery.Location = new System.Drawing.Point(12, 334);
            this.btn_Delivery.Name = "btn_Delivery";
            this.btn_Delivery.Size = new System.Drawing.Size(141, 44);
            this.btn_Delivery.TabIndex = 5;
            this.btn_Delivery.Text = "Delivery";
            this.btn_Delivery.UseVisualStyleBackColor = true;
            this.btn_Delivery.Click += new System.EventHandler(this.btn_Delivery_Click);
            // 
            // btn_Collection
            // 
            this.btn_Collection.FlatAppearance.BorderSize = 0;
            this.btn_Collection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Collection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Collection.Location = new System.Drawing.Point(12, 284);
            this.btn_Collection.Name = "btn_Collection";
            this.btn_Collection.Size = new System.Drawing.Size(141, 44);
            this.btn_Collection.TabIndex = 4;
            this.btn_Collection.Text = "Collection";
            this.btn_Collection.UseVisualStyleBackColor = true;
            this.btn_Collection.Click += new System.EventHandler(this.btn_Collection_Click);
            // 
            // btn_MyPurchase
            // 
            this.btn_MyPurchase.FlatAppearance.BorderSize = 0;
            this.btn_MyPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MyPurchase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MyPurchase.Location = new System.Drawing.Point(12, 234);
            this.btn_MyPurchase.Name = "btn_MyPurchase";
            this.btn_MyPurchase.Size = new System.Drawing.Size(141, 44);
            this.btn_MyPurchase.TabIndex = 3;
            this.btn_MyPurchase.Text = "My Purchase";
            this.btn_MyPurchase.UseVisualStyleBackColor = true;
            this.btn_MyPurchase.Click += new System.EventHandler(this.btn_MyPurchase_Click);
            // 
            // btn_ShoppingChart
            // 
            this.btn_ShoppingChart.FlatAppearance.BorderSize = 0;
            this.btn_ShoppingChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShoppingChart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ShoppingChart.Location = new System.Drawing.Point(12, 184);
            this.btn_ShoppingChart.Name = "btn_ShoppingChart";
            this.btn_ShoppingChart.Size = new System.Drawing.Size(141, 44);
            this.btn_ShoppingChart.TabIndex = 2;
            this.btn_ShoppingChart.Text = "Shopping Cart";
            this.btn_ShoppingChart.UseVisualStyleBackColor = true;
            this.btn_ShoppingChart.Click += new System.EventHandler(this.btn_ShoppingChart_Click);
            // 
            // btn_MyProfile
            // 
            this.btn_MyProfile.FlatAppearance.BorderSize = 0;
            this.btn_MyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MyProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MyProfile.Location = new System.Drawing.Point(12, 134);
            this.btn_MyProfile.Name = "btn_MyProfile";
            this.btn_MyProfile.Size = new System.Drawing.Size(141, 44);
            this.btn_MyProfile.TabIndex = 1;
            this.btn_MyProfile.Text = "My Profile";
            this.btn_MyProfile.UseVisualStyleBackColor = true;
            this.btn_MyProfile.Click += new System.EventHandler(this.btn_MyProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(750, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(53, 62);
            this.panel3.TabIndex = 2;
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 411);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAppForm";
            this.Load += new System.EventHandler(this.MainAppForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btn_Delivery;
        private System.Windows.Forms.Button btn_Collection;
        private System.Windows.Forms.Button btn_MyPurchase;
        private System.Windows.Forms.Button btn_ShoppingChart;
        private System.Windows.Forms.Button btn_MyProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}