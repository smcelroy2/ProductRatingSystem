
namespace ProductRatingSystem
{
    partial class Logout_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new ProductRatingSystem.TextBoxControl();
            this.user = new ProductRatingSystem.TextBoxControl();
            this.loginButton = new ProductRatingSystem.ButtonControl();
            this.logoutMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Now:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.Window;
            this.pass.BorderColor = System.Drawing.Color.Black;
            this.pass.BorderFocusColor = System.Drawing.Color.Black;
            this.pass.BorderRadius = 15;
            this.pass.BorderSize = 2;
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass.Location = new System.Drawing.Point(233, 187);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Multiline = false;
            this.pass.Name = "pass";
            this.pass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pass.PasswordChar = false;
            this.pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pass.PlaceholderText = "Password";
            this.pass.Size = new System.Drawing.Size(269, 32);
            this.pass.TabIndex = 5;
            this.pass.Texts = "";
            this.pass.UnderlinedStyle = false;
            this.pass.Load += new System.EventHandler(this.textBoxControl2_Load);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.Window;
            this.user.BorderColor = System.Drawing.Color.Black;
            this.user.BorderFocusColor = System.Drawing.Color.Black;
            this.user.BorderRadius = 15;
            this.user.BorderSize = 2;
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user.Location = new System.Drawing.Point(233, 123);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Multiline = false;
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.user.PasswordChar = false;
            this.user.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.user.PlaceholderText = "Email";
            this.user.Size = new System.Drawing.Size(269, 32);
            this.user.TabIndex = 4;
            this.user.Texts = "";
            this.user.UnderlinedStyle = false;
            this.user.Load += new System.EventHandler(this.textBoxControl1_Load_1);
            // 
            // loginButton
            // 
            this.loginButton.AllowDrop = true;
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.BorderFocusColor = System.Drawing.Color.Black;
            this.loginButton.BorderRadius = 15;
            this.loginButton.BorderSize = 2;
            this.loginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(243, 249);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.loginButton.Size = new System.Drawing.Size(250, 49);
            this.loginButton.TabIndex = 6;
            this.loginButton.Texts = "Login";
            this.loginButton.UnderlinedStyle = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutMessage
            // 
            this.logoutMessage.AutoSize = true;
            this.logoutMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutMessage.Location = new System.Drawing.Point(203, 340);
            this.logoutMessage.Name = "logoutMessage";
            this.logoutMessage.Size = new System.Drawing.Size(331, 20);
            this.logoutMessage.TabIndex = 7;
            this.logoutMessage.Text = "You have been successfully logged out.";
            this.logoutMessage.Click += new System.EventHandler(this.label2_Click);
            // 
            // Logout_Page
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(775, 453);
            this.Controls.Add(this.logoutMessage);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Name = "Logout_Page";
            this.Text = "Login Now:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private TextBoxControl user;
        private TextBoxControl pass;
        private ButtonControl loginButton;
        private System.Windows.Forms.Label logoutMessage;
    }
}