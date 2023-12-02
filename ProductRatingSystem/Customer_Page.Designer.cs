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
            this.productOne = new System.Windows.Forms.TextBox();
            this.productTwo = new System.Windows.Forms.TextBox();
            this.productThree = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // postRevMessage
            // 
            this.postRevMessage.BackColor = System.Drawing.SystemColors.Window;
            this.postRevMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postRevMessage.Location = new System.Drawing.Point(307, 143);
            this.postRevMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postRevMessage.Name = "postRevMessage";
            this.postRevMessage.ReadOnly = true;
            this.postRevMessage.Size = new System.Drawing.Size(453, 36);
            this.postRevMessage.TabIndex = 0;
            this.postRevMessage.Text = "Post a Review for Your Purchases:";
            this.postRevMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.Location = new System.Drawing.Point(403, 85);
            this.welcomeMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(221, 31);
            this.welcomeMessage.TabIndex = 1;
            this.welcomeMessage.Text = "Welcome, User!";
            this.welcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productOne
            // 
            this.productOne.BackColor = System.Drawing.SystemColors.Window;
            this.productOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productOne.Location = new System.Drawing.Point(339, 223);
            this.productOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productOne.Name = "productOne";
            this.productOne.ReadOnly = true;
            this.productOne.Size = new System.Drawing.Size(365, 32);
            this.productOne.TabIndex = 2;
            this.productOne.Text = "\r\n";
            this.productOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productTwo
            // 
            this.productTwo.BackColor = System.Drawing.SystemColors.Window;
            this.productTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTwo.Location = new System.Drawing.Point(339, 284);
            this.productTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productTwo.Name = "productTwo";
            this.productTwo.ReadOnly = true;
            this.productTwo.Size = new System.Drawing.Size(365, 32);
            this.productTwo.TabIndex = 3;
            this.productTwo.Text = "\r\n";
            this.productTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productThree
            // 
            this.productThree.BackColor = System.Drawing.SystemColors.Window;
            this.productThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productThree.Location = new System.Drawing.Point(339, 345);
            this.productThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productThree.Name = "productThree";
            this.productThree.ReadOnly = true;
            this.productThree.Size = new System.Drawing.Size(365, 32);
            this.productThree.TabIndex = 4;
            this.productThree.Text = "\r\n";
            this.productThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1032, 85);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 95);
            this.vScrollBar1.TabIndex = 5;
            // 
            // Customer_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.productThree);
            this.Controls.Add(this.productTwo);
            this.Controls.Add(this.productOne);
            this.Controls.Add(this.welcomeMessage);
            this.Controls.Add(this.postRevMessage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customer_Page";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postRevMessage;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.TextBox productOne;
        private System.Windows.Forms.TextBox productTwo;
        private System.Windows.Forms.TextBox productThree;

        private void Customer_PageLoad()
        {
            welcomeMessage.Text = $"Welcome, userName!";
            productOne.Text = $"Product1";
            productTwo.Text = $"Product2";
            productThree.Text = $"Product3";
        }
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}
