namespace OnlineStore
{
    partial class SignUpUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpUserControl));
            this.pB_ShowPW = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_Login = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_ShowPW)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_ShowPW
            // 
            this.pB_ShowPW.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pB_ShowPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_ShowPW.Image = ((System.Drawing.Image)(resources.GetObject("pB_ShowPW.Image")));
            this.pB_ShowPW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pB_ShowPW.Location = new System.Drawing.Point(530, 113);
            this.pB_ShowPW.Name = "pB_ShowPW";
            this.pB_ShowPW.Size = new System.Drawing.Size(37, 23);
            this.pB_ShowPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_ShowPW.TabIndex = 13;
            this.pB_ShowPW.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(287, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(264, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.btn_SignIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SignIn.Location = new System.Drawing.Point(19, 151);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(562, 42);
            this.btn_SignIn.TabIndex = 9;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(291, 113);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(245, 20);
            this.txtBox_Password.TabIndex = 8;
            // 
            // txtBox_Login
            // 
            this.txtBox_Login.Location = new System.Drawing.Point(34, 113);
            this.txtBox_Login.Name = "txtBox_Login";
            this.txtBox_Login.Size = new System.Drawing.Size(251, 20);
            this.txtBox_Login.TabIndex = 7;
            // 
            // SignUpUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pB_ShowPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Login);
            this.Name = "SignUpUserControl";
            this.Size = new System.Drawing.Size(600, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pB_ShowPW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_ShowPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.TextBox txtBox_Login;
    }
}
