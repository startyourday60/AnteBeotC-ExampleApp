namespace AnteBeotWinClient
{
    partial class AntebeotLightClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntebeotLightClient));
            this.button1 = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UpdateSessionBut = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UpdateSessionBut
            // 
            resources.ApplyResources(this.UpdateSessionBut, "UpdateSessionBut");
            this.UpdateSessionBut.Name = "UpdateSessionBut";
            this.UpdateSessionBut.UseVisualStyleBackColor = true;
            this.UpdateSessionBut.Click += new System.EventHandler(this.UpdateSessionBut_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.reAuthButton_Click);
            // 
            // AntebeotLightClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UpdateSessionBut);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.button1);
            this.Name = "AntebeotLightClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button LoginButton;
        private Button UpdateSessionBut;
        private Button Exit;
    }
}