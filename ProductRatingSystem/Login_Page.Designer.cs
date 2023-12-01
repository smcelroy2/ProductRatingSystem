
namespace ProductRatingSystem
{
    partial class Login_Page
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
            this.textBoxControl2 = new ProductRatingSystem.TextBoxControl();
            this.textBoxControl1 = new ProductRatingSystem.TextBoxControl();
            this.buttonControl1 = new ProductRatingSystem.ButtonControl();
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
            // textBoxControl2
            // 
            this.textBoxControl2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxControl2.BorderColor = System.Drawing.Color.Black;
            this.textBoxControl2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxControl2.BorderRadius = 15;
            this.textBoxControl2.BorderSize = 2;
            this.textBoxControl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxControl2.Location = new System.Drawing.Point(232, 186);
            this.textBoxControl2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxControl2.Multiline = false;
            this.textBoxControl2.Name = "textBoxControl2";
            this.textBoxControl2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxControl2.PasswordChar = false;
            this.textBoxControl2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxControl2.PlaceholderText = "Password";
            this.textBoxControl2.Size = new System.Drawing.Size(269, 32);
            this.textBoxControl2.TabIndex = 5;
            this.textBoxControl2.Texts = "";
            this.textBoxControl2.UnderlinedStyle = false;
            // 
            // textBoxControl1
            // 
            this.textBoxControl1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxControl1.BorderColor = System.Drawing.Color.Black;
            this.textBoxControl1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxControl1.BorderRadius = 15;
            this.textBoxControl1.BorderSize = 2;
            this.textBoxControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxControl1.Location = new System.Drawing.Point(232, 122);
            this.textBoxControl1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxControl1.Multiline = false;
            this.textBoxControl1.Name = "textBoxControl1";
            this.textBoxControl1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxControl1.PasswordChar = false;
            this.textBoxControl1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxControl1.PlaceholderText = "Email";
            this.textBoxControl1.Size = new System.Drawing.Size(269, 32);
            this.textBoxControl1.TabIndex = 4;
            this.textBoxControl1.Texts = "";
            this.textBoxControl1.UnderlinedStyle = false;
            this.textBoxControl1.Load += new System.EventHandler(this.textBoxControl1_Load_1);
            // 
            // buttonControl1
            // 
            this.buttonControl1.BorderColor = System.Drawing.Color.Black;
            this.buttonControl1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.buttonControl1.BorderRadius = 15;
            this.buttonControl1.BorderSize = 2;
            this.buttonControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonControl1.Location = new System.Drawing.Point(242, 244);
            this.buttonControl1.Name = "buttonControl1";
            this.buttonControl1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.buttonControl1.Size = new System.Drawing.Size(250, 44);
            this.buttonControl1.TabIndex = 6;
            this.buttonControl1.Texts = "Login";
            this.buttonControl1.UnderlinedStyle = false;
            this.buttonControl1.Load += new System.EventHandler(this.buttonControl1_Load);
            // 
            // Login_Page
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(775, 453);
            this.Controls.Add(this.buttonControl1);
            this.Controls.Add(this.textBoxControl2);
            this.Controls.Add(this.textBoxControl1);
            this.Controls.Add(this.label1);
            this.Name = "Login_Page";
            this.Text = "Login Now:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private TextBoxControl textBoxControl1;
        private TextBoxControl textBoxControl2;
        private ButtonControl buttonControl1;
    }
}

