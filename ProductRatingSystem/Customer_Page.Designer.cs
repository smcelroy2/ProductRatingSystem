using System;
using System.Runtime.CompilerServices;

namespace ProductRatingSystem
{
    partial class Customer_Page
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
            this.postRevMessage = new System.Windows.Forms.TextBox();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.product1 = new System.Windows.Forms.TextBox();
            this.product2 = new System.Windows.Forms.TextBox();
            this.product3 = new System.Windows.Forms.TextBox();
            this.logoutButton = new ProductRatingSystem.ButtonControl();
            this.product4 = new System.Windows.Forms.TextBox();
            this.product5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // postRevMessage
            // 
            this.postRevMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postRevMessage.BackColor = System.Drawing.SystemColors.Window;
            this.postRevMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postRevMessage.Location = new System.Drawing.Point(264, 135);
            this.postRevMessage.Margin = new System.Windows.Forms.Padding(4);
            this.postRevMessage.Multiline = true;
            this.postRevMessage.Name = "postRevMessage";
            this.postRevMessage.ReadOnly = true;
            this.postRevMessage.Size = new System.Drawing.Size(514, 45);
            this.postRevMessage.TabIndex = 0;
            this.postRevMessage.Text = "Post a Review for Your Purchases:";
            this.postRevMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.Location = new System.Drawing.Point(391, 81);
            this.welcomeMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(232, 32);
            this.welcomeMessage.TabIndex = 1;
            this.welcomeMessage.Text = "Welcome, User!";
            this.welcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // product1
            // 
            this.product1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product1.BackColor = System.Drawing.SystemColors.Window;
            this.product1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product1.Location = new System.Drawing.Point(339, 223);
            this.product1.Margin = new System.Windows.Forms.Padding(4);
            this.product1.Name = "product1";
            this.product1.ReadOnly = true;
            this.product1.Size = new System.Drawing.Size(365, 32);
            this.product1.TabIndex = 2;
            this.product1.Text = "\r\n";
            this.product1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // product2
            // 
            this.product2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product2.BackColor = System.Drawing.SystemColors.Window;
            this.product2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product2.Location = new System.Drawing.Point(339, 284);
            this.product2.Margin = new System.Windows.Forms.Padding(4);
            this.product2.Name = "product2";
            this.product2.ReadOnly = true;
            this.product2.Size = new System.Drawing.Size(365, 32);
            this.product2.TabIndex = 3;
            this.product2.Text = "\r\n";
            this.product2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // product3
            // 
            this.product3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product3.BackColor = System.Drawing.SystemColors.Window;
            this.product3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product3.Location = new System.Drawing.Point(339, 345);
            this.product3.Margin = new System.Windows.Forms.Padding(4);
            this.product3.Name = "product3";
            this.product3.ReadOnly = true;
            this.product3.Size = new System.Drawing.Size(365, 32);
            this.product3.TabIndex = 4;
            this.product3.Text = "\r\n";
            this.product3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutButton.BackColor = System.Drawing.Color.Black;
            this.logoutButton.BorderColor = System.Drawing.Color.Black;
            this.logoutButton.BorderFocusColor = System.Drawing.Color.Black;
            this.logoutButton.BorderRadius = 15;
            this.logoutButton.BorderSize = 2;
            this.logoutButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Transparent;
            this.logoutButton.Location = new System.Drawing.Point(836, 31);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.logoutButton.Size = new System.Drawing.Size(167, 45);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Texts = "Logout";
            this.logoutButton.UnderlinedStyle = false;
            this.logoutButton.Load += new System.EventHandler(this.logoutButton_Load);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // product4
            // 
            this.product4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product4.BackColor = System.Drawing.SystemColors.Window;
            this.product4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product4.Location = new System.Drawing.Point(339, 404);
            this.product4.Margin = new System.Windows.Forms.Padding(4);
            this.product4.Name = "product4";
            this.product4.ReadOnly = true;
            this.product4.Size = new System.Drawing.Size(365, 32);
            this.product4.TabIndex = 6;
            this.product4.Text = "\r\n";
            this.product4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // product5
            // 
            this.product5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product5.BackColor = System.Drawing.SystemColors.Window;
            this.product5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product5.Location = new System.Drawing.Point(339, 462);
            this.product5.Margin = new System.Windows.Forms.Padding(4);
            this.product5.Name = "product5";
            this.product5.ReadOnly = true;
            this.product5.Size = new System.Drawing.Size(365, 32);
            this.product5.TabIndex = 7;
            this.product5.Text = "\r\n";
            this.product5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Customer_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.product5);
            this.Controls.Add(this.product4);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.product3);
            this.Controls.Add(this.product2);
            this.Controls.Add(this.product1);
            this.Controls.Add(this.welcomeMessage);
            this.Controls.Add(this.postRevMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer_Page";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Customer_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postRevMessage;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.TextBox product1;
        private System.Windows.Forms.TextBox product2;
        private System.Windows.Forms.TextBox product3;

        private void Customer_PageLoad()
        {
            welcomeMessage.Text = $"Welcome, userName!";
            product1.Text = $"Product1";
            product2.Text = $"Product2";
            product3.Text = $"Product3";
        }

        private ButtonControl logoutButton;
        private System.Windows.Forms.TextBox product4;
        private System.Windows.Forms.TextBox product5;
    }
}
