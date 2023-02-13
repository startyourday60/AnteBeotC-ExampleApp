namespace AnteBeotWinClient
{
    partial class LoginBox
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AuthBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._2faTextBox = new System.Windows.Forms.TextBox();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CaptchaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(79, 12);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(163, 23);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(79, 40);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(163, 23);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(13, 20);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(40, 15);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(13, 48);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // AuthBut
            // 
            this.AuthBut.Location = new System.Drawing.Point(117, 127);
            this.AuthBut.Name = "AuthBut";
            this.AuthBut.Size = new System.Drawing.Size(75, 23);
            this.AuthBut.TabIndex = 4;
            this.AuthBut.Text = "Auth";
            this.AuthBut.UseVisualStyleBackColor = true;
            this.AuthBut.Click += new System.EventHandler(this.AuthBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 102);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _2faTextBox
            // 
            this._2faTextBox.Location = new System.Drawing.Point(79, 69);
            this._2faTextBox.Name = "_2faTextBox";
            this._2faTextBox.Size = new System.Drawing.Size(163, 23);
            this._2faTextBox.TabIndex = 6;
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(79, 98);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(163, 23);
            this.captchaTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "2FA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CaptchaLabel
            // 
            this.CaptchaLabel.AutoSize = true;
            this.CaptchaLabel.Location = new System.Drawing.Point(22, 101);
            this.CaptchaLabel.Name = "CaptchaLabel";
            this.CaptchaLabel.Size = new System.Drawing.Size(51, 15);
            this.CaptchaLabel.TabIndex = 9;
            this.CaptchaLabel.Text = "Captcha";
            this.CaptchaLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 272);
            this.Controls.Add(this.CaptchaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this._2faTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AuthBut);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "LoginBox";
            this.Text = "Authentiphication";
            this.Load += new System.EventHandler(this.LoginBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button AuthBut;
        private PictureBox pictureBox1;
        private TextBox _2faTextBox;
        private TextBox captchaTextBox;
        private Label label1;
        private Label CaptchaLabel;
    }
}