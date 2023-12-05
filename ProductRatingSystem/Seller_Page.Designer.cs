
using System;
using System.Runtime.CompilerServices;
using System.Data;
using System.Data.SQLite;


namespace ProductRatingSystem
{
    partial class Seller_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static string connectionString = @"Data Source =C:\Users\SalaM\sqlite\ProductRatingSystem.db;Version=3;";
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
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.prodOneName = new System.Windows.Forms.TextBox();
            this.prodOneRating = new System.Windows.Forms.TextBox();
            this.recentRevsBox = new System.Windows.Forms.TextBox();
            this.p1_revOneRating = new System.Windows.Forms.TextBox();
            this.p1_revOneTitle = new System.Windows.Forms.TextBox();
            this.p1_revOneAuthor = new System.Windows.Forms.TextBox();
            this.p1_revTwoDesc = new System.Windows.Forms.TextBox();
            this.p1_revTwoAuthor = new System.Windows.Forms.TextBox();
            this.p1_revTwoTitle = new System.Windows.Forms.TextBox();
            this.p1_revTwoRating = new System.Windows.Forms.TextBox();
            this.p1_revOneDesc = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.p2_revTwoTitle = new System.Windows.Forms.TextBox();
            this.p2_revTwoRating = new System.Windows.Forms.TextBox();
            this.p2_revOneDesc = new System.Windows.Forms.TextBox();
            this.p2_revOneAuthor = new System.Windows.Forms.TextBox();
            this.p2_revOneTitle = new System.Windows.Forms.TextBox();
            this.p2_revOneRating = new System.Windows.Forms.TextBox();
            this.p2_revTwoAuthor = new System.Windows.Forms.TextBox();
            this.prodTwoRating = new System.Windows.Forms.TextBox();
            this.prodTwoName = new System.Windows.Forms.TextBox();
            this.p3_revTwoDesc = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.p3_revTwoTitle = new System.Windows.Forms.TextBox();
            this.p3_revTwoRating = new System.Windows.Forms.TextBox();
            this.p3_revOneDesc = new System.Windows.Forms.TextBox();
            this.p3_revOneAuthor = new System.Windows.Forms.TextBox();
            this.p3_revOneTitle = new System.Windows.Forms.TextBox();
            this.p3_revOneRating = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.postProductButton = new ProductRatingSystem.ButtonControl();
            this.logoutButton = new ProductRatingSystem.ButtonControl();
            this.prodThreeName = new System.Windows.Forms.TextBox();
            this.prodThreeRating = new System.Windows.Forms.TextBox();
            this.p3_revTwoAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.Location = new System.Drawing.Point(364, -18);
            this.welcomeMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(248, 32);
            this.welcomeMessage.TabIndex = 1;
            this.welcomeMessage.Text = "Welcome, Seller!\r\n";
            this.welcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prodOneName
            // 
            this.prodOneName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodOneName.BackColor = System.Drawing.SystemColors.Window;
            this.prodOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodOneName.Location = new System.Drawing.Point(42, 143);
            this.prodOneName.Margin = new System.Windows.Forms.Padding(4);
            this.prodOneName.Name = "prodOneName";
            this.prodOneName.ReadOnly = true;
            this.prodOneName.Size = new System.Drawing.Size(444, 32);
            this.prodOneName.TabIndex = 2;
            this.prodOneName.Text = "\r\n";
            this.prodOneName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodOneRating
            // 
            this.prodOneRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodOneRating.BackColor = System.Drawing.SystemColors.Window;
            this.prodOneRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodOneRating.Location = new System.Drawing.Point(862, 143);
            this.prodOneRating.Margin = new System.Windows.Forms.Padding(4);
            this.prodOneRating.Name = "prodOneRating";
            this.prodOneRating.ReadOnly = true;
            this.prodOneRating.Size = new System.Drawing.Size(88, 32);
            this.prodOneRating.TabIndex = 6;
            this.prodOneRating.Text = "\r\n";
            this.prodOneRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recentRevsBox
            // 
            this.recentRevsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recentRevsBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentRevsBox.Location = new System.Drawing.Point(42, 183);
            this.recentRevsBox.Margin = new System.Windows.Forms.Padding(4);
            this.recentRevsBox.Multiline = true;
            this.recentRevsBox.Name = "recentRevsBox";
            this.recentRevsBox.Size = new System.Drawing.Size(908, 251);
            this.recentRevsBox.TabIndex = 7;
            this.recentRevsBox.Text = "Recent Reviews:";
            this.recentRevsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p1_revOneRating
            // 
            this.p1_revOneRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revOneRating.Location = new System.Drawing.Point(77, 214);
            this.p1_revOneRating.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revOneRating.Name = "p1_revOneRating";
            this.p1_revOneRating.Size = new System.Drawing.Size(159, 22);
            this.p1_revOneRating.TabIndex = 8;
            // 
            // p1_revOneTitle
            // 
            this.p1_revOneTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revOneTitle.Location = new System.Drawing.Point(77, 246);
            this.p1_revOneTitle.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revOneTitle.Multiline = true;
            this.p1_revOneTitle.Name = "p1_revOneTitle";
            this.p1_revOneTitle.Size = new System.Drawing.Size(159, 24);
            this.p1_revOneTitle.TabIndex = 9;
            // 
            // p1_revOneAuthor
            // 
            this.p1_revOneAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revOneAuthor.Location = new System.Drawing.Point(282, 246);
            this.p1_revOneAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revOneAuthor.Name = "p1_revOneAuthor";
            this.p1_revOneAuthor.Size = new System.Drawing.Size(159, 22);
            this.p1_revOneAuthor.TabIndex = 10;
            // 
            // p1_revTwoDesc
            // 
            this.p1_revTwoDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revTwoDesc.Location = new System.Drawing.Point(560, 588);
            this.p1_revTwoDesc.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revTwoDesc.Multiline = true;
            this.p1_revTwoDesc.Name = "p1_revTwoDesc";
            this.p1_revTwoDesc.Size = new System.Drawing.Size(364, 114);
            this.p1_revTwoDesc.TabIndex = 15;
            // 
            // p1_revTwoAuthor
            // 
            this.p1_revTwoAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revTwoAuthor.Location = new System.Drawing.Point(765, 246);
            this.p1_revTwoAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revTwoAuthor.Name = "p1_revTwoAuthor";
            this.p1_revTwoAuthor.Size = new System.Drawing.Size(159, 22);
            this.p1_revTwoAuthor.TabIndex = 14;
            // 
            // p1_revTwoTitle
            // 
            this.p1_revTwoTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revTwoTitle.Location = new System.Drawing.Point(560, 246);
            this.p1_revTwoTitle.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revTwoTitle.Multiline = true;
            this.p1_revTwoTitle.Name = "p1_revTwoTitle";
            this.p1_revTwoTitle.Size = new System.Drawing.Size(159, 24);
            this.p1_revTwoTitle.TabIndex = 13;
            // 
            // p1_revTwoRating
            // 
            this.p1_revTwoRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revTwoRating.Location = new System.Drawing.Point(560, 214);
            this.p1_revTwoRating.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revTwoRating.Name = "p1_revTwoRating";
            this.p1_revTwoRating.Size = new System.Drawing.Size(159, 22);
            this.p1_revTwoRating.TabIndex = 12;
            // 
            // p1_revOneDesc
            // 
            this.p1_revOneDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1_revOneDesc.Location = new System.Drawing.Point(77, 278);
            this.p1_revOneDesc.Margin = new System.Windows.Forms.Padding(4);
            this.p1_revOneDesc.Multiline = true;
            this.p1_revOneDesc.Name = "p1_revOneDesc";
            this.p1_revOneDesc.Size = new System.Drawing.Size(364, 114);
            this.p1_revOneDesc.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(765, 553);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 22);
            this.textBox4.TabIndex = 25;
            // 
            // p2_revTwoTitle
            // 
            this.p2_revTwoTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_revTwoTitle.Location = new System.Drawing.Point(560, 553);
            this.p2_revTwoTitle.Margin = new System.Windows.Forms.Padding(4);
            this.p2_revTwoTitle.Multiline = true;
            this.p2_revTwoTitle.Name = "p2_revTwoTitle";
            this.p2_revTwoTitle.Size = new System.Drawing.Size(159, 24);
            this.p2_revTwoTitle.TabIndex = 24;
            // 
            // p2_revTwoRating
            // 
            this.p2_revTwoRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_revTwoRating.Location = new System.Drawing.Point(560, 521);
            this.p2_revTwoRating.Margin = new System.Windows.Forms.Padding(4);
            this.p2_revTwoRating.Name = "p2_revTwoRating";
            this.p2_revTwoRating.Size = new System.Drawing.Size(159, 22);
            this.p2_revTwoRating.TabIndex = 23;
            // 
            // p2_revOneDesc
            // 
            this.p2_revOneDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_revOneDesc.Location = new System.Drawing.Point(77, 588);
            this.p2_revOneDesc.Margin = new System.Windows.Forms.Padding(4);
            this.p2_revOneDesc.Multiline = true;
            this.p2_revOneDesc.Name = "p2_revOneDesc";
            this.p2_revOneDesc.Size = new System.Drawing.Size(364, 114);
            this.p2_revOneDesc.TabIndex = 22;
            // 
            // p2_revOneAuthor
            // 
            this.p2_revOneAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_revOneAuthor.Location = new System.Drawing.Point(282, 555);
            this.p2_revOneAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.p2_revOneAuthor.Name = "p2_revOneAuthor";
            this.p2_revOneAuthor.Size = new System.Drawing.Size(159, 22);
            this.p2_revOneAuthor.TabIndex = 21;
            // 
            // p2_revOneTitle
            // 
            this.p2_revOneTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_revOneTitle.Location = new System.Drawing.Point(77, 555);
            this.p2_revOneTitle.Margin = new System.Windows.Forms.Padding(4);
            this.p2_revOneTitle.Multiline = true;
            this.p2_revOneTitle.Name = "p2_revOneTitle";
            this.p2_revOneTitle.Size = new System.Drawing.Size(159, 24);
            this.p2_revOneTitle.TabIndex = 20;
            // 
            // p2_revOneRating
            // 
            this.p2_revOneRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_revOneRating.Location = new System.Drawing.Point(77, 521);
            this.p2_revOneRating.Margin = new System.Windows.Forms.Padding(4);
            this.p2_revOneRating.Name = "p2_revOneRating";
            this.p2_revOneRating.Size = new System.Drawing.Size(159, 22);
            this.p2_revOneRating.TabIndex = 19;
            // 
            // p2_revTwoAuthor
            // 
            this.p2_revTwoAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_revTwoAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_revTwoAuthor.Location = new System.Drawing.Point(41, 497);
            this.p2_revTwoAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.p2_revTwoAuthor.Multiline = true;
            this.p2_revTwoAuthor.Name = "p2_revTwoAuthor";
            this.p2_revTwoAuthor.Size = new System.Drawing.Size(908, 251);
            this.p2_revTwoAuthor.TabIndex = 18;
            this.p2_revTwoAuthor.Text = "Recent Reviews:";
            this.p2_revTwoAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2_revTwoAuthor.TextChanged += new System.EventHandler(this.p2_revTwoAuthor_TextChanged);
            // 
            // prodTwoRating
            // 
            this.prodTwoRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodTwoRating.BackColor = System.Drawing.SystemColors.Window;
            this.prodTwoRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTwoRating.Location = new System.Drawing.Point(862, 457);
            this.prodTwoRating.Margin = new System.Windows.Forms.Padding(4);
            this.prodTwoRating.Name = "prodTwoRating";
            this.prodTwoRating.ReadOnly = true;
            this.prodTwoRating.Size = new System.Drawing.Size(88, 32);
            this.prodTwoRating.TabIndex = 17;
            this.prodTwoRating.Text = "\r\n";
            this.prodTwoRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodTwoName
            // 
            this.prodTwoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodTwoName.BackColor = System.Drawing.SystemColors.Window;
            this.prodTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTwoName.Location = new System.Drawing.Point(41, 457);
            this.prodTwoName.Margin = new System.Windows.Forms.Padding(4);
            this.prodTwoName.Name = "prodTwoName";
            this.prodTwoName.ReadOnly = true;
            this.prodTwoName.Size = new System.Drawing.Size(445, 32);
            this.prodTwoName.TabIndex = 16;
            this.prodTwoName.Text = "\r\n";
            this.prodTwoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p3_revTwoDesc
            // 
            this.p3_revTwoDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revTwoDesc.Location = new System.Drawing.Point(560, 932);
            this.p3_revTwoDesc.Margin = new System.Windows.Forms.Padding(4);
            this.p3_revTwoDesc.Multiline = true;
            this.p3_revTwoDesc.Name = "p3_revTwoDesc";
            this.p3_revTwoDesc.Size = new System.Drawing.Size(364, 114);
            this.p3_revTwoDesc.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(765, 902);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 22);
            this.textBox3.TabIndex = 36;
            // 
            // p3_revTwoTitle
            // 
            this.p3_revTwoTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revTwoTitle.Location = new System.Drawing.Point(560, 900);
            this.p3_revTwoTitle.Margin = new System.Windows.Forms.Padding(4);
            this.p3_revTwoTitle.Multiline = true;
            this.p3_revTwoTitle.Name = "p3_revTwoTitle";
            this.p3_revTwoTitle.Size = new System.Drawing.Size(159, 24);
            this.p3_revTwoTitle.TabIndex = 35;
            // 
            // p3_revTwoRating
            // 
            this.p3_revTwoRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revTwoRating.Location = new System.Drawing.Point(560, 870);
            this.p3_revTwoRating.Margin = new System.Windows.Forms.Padding(4);
            this.p3_revTwoRating.Name = "p3_revTwoRating";
            this.p3_revTwoRating.Size = new System.Drawing.Size(159, 22);
            this.p3_revTwoRating.TabIndex = 34;
            // 
            // p3_revOneDesc
            // 
            this.p3_revOneDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revOneDesc.Location = new System.Drawing.Point(77, 932);
            this.p3_revOneDesc.Margin = new System.Windows.Forms.Padding(4);
            this.p3_revOneDesc.Multiline = true;
            this.p3_revOneDesc.Name = "p3_revOneDesc";
            this.p3_revOneDesc.Size = new System.Drawing.Size(364, 114);
            this.p3_revOneDesc.TabIndex = 33;
            // 
            // p3_revOneAuthor
            // 
            this.p3_revOneAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revOneAuthor.Location = new System.Drawing.Point(282, 900);
            this.p3_revOneAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.p3_revOneAuthor.Name = "p3_revOneAuthor";
            this.p3_revOneAuthor.Size = new System.Drawing.Size(159, 22);
            this.p3_revOneAuthor.TabIndex = 32;
            // 
            // p3_revOneTitle
            // 
            this.p3_revOneTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revOneTitle.Location = new System.Drawing.Point(77, 898);
            this.p3_revOneTitle.Margin = new System.Windows.Forms.Padding(4);
            this.p3_revOneTitle.Multiline = true;
            this.p3_revOneTitle.Name = "p3_revOneTitle";
            this.p3_revOneTitle.Size = new System.Drawing.Size(159, 24);
            this.p3_revOneTitle.TabIndex = 31;
            // 
            // p3_revOneRating
            // 
            this.p3_revOneRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revOneRating.Location = new System.Drawing.Point(77, 868);
            this.p3_revOneRating.Margin = new System.Windows.Forms.Padding(4);
            this.p3_revOneRating.Name = "p3_revOneRating";
            this.p3_revOneRating.Size = new System.Drawing.Size(159, 22);
            this.p3_revOneRating.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(908, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Your Products:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(560, 278);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(364, 114);
            this.textBox5.TabIndex = 41;
            // 
            // postProductButton
            // 
            this.postProductButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postProductButton.BackColor = System.Drawing.Color.Black;
            this.postProductButton.BorderColor = System.Drawing.Color.Black;
            this.postProductButton.BorderFocusColor = System.Drawing.Color.Black;
            this.postProductButton.BorderRadius = 15;
            this.postProductButton.BorderSize = 2;
            this.postProductButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postProductButton.ForeColor = System.Drawing.Color.Transparent;
            this.postProductButton.Location = new System.Drawing.Point(267, 17);
            this.postProductButton.Name = "postProductButton";
            this.postProductButton.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.postProductButton.Size = new System.Drawing.Size(422, 44);
            this.postProductButton.TabIndex = 39;
            this.postProductButton.Texts = "Post A Product";
            this.postProductButton.UnderlinedStyle = false;
            this.postProductButton.Click += new System.EventHandler(this.postProductButton_Click);
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
            this.logoutButton.Location = new System.Drawing.Point(944, 17);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.logoutButton.Size = new System.Drawing.Size(167, 45);
            this.logoutButton.TabIndex = 38;
            this.logoutButton.Texts = "Logout";
            this.logoutButton.UnderlinedStyle = false;
            this.logoutButton.Load += new System.EventHandler(this.logoutButton_Load);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // prodThreeName
            // 
            this.prodThreeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodThreeName.BackColor = System.Drawing.SystemColors.Window;
            this.prodThreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodThreeName.Location = new System.Drawing.Point(42, 762);
            this.prodThreeName.Margin = new System.Windows.Forms.Padding(4);
            this.prodThreeName.Name = "prodThreeName";
            this.prodThreeName.ReadOnly = true;
            this.prodThreeName.Size = new System.Drawing.Size(445, 32);
            this.prodThreeName.TabIndex = 27;
            this.prodThreeName.Text = "\r\n";
            this.prodThreeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodThreeRating
            // 
            this.prodThreeRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodThreeRating.BackColor = System.Drawing.SystemColors.Window;
            this.prodThreeRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodThreeRating.Location = new System.Drawing.Point(862, 762);
            this.prodThreeRating.Margin = new System.Windows.Forms.Padding(4);
            this.prodThreeRating.Name = "prodThreeRating";
            this.prodThreeRating.ReadOnly = true;
            this.prodThreeRating.Size = new System.Drawing.Size(88, 32);
            this.prodThreeRating.TabIndex = 28;
            this.prodThreeRating.Text = "\r\n";
            this.prodThreeRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p3_revTwoAuthor
            // 
            this.p3_revTwoAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3_revTwoAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3_revTwoAuthor.Location = new System.Drawing.Point(41, 802);
            this.p3_revTwoAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.p3_revTwoAuthor.Multiline = true;
            this.p3_revTwoAuthor.Name = "p3_revTwoAuthor";
            this.p3_revTwoAuthor.Size = new System.Drawing.Size(908, 251);
            this.p3_revTwoAuthor.TabIndex = 29;
            this.p3_revTwoAuthor.Text = "Recent Reviews:";
            this.p3_revTwoAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Seller_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1138, 762);
            this.Controls.Add(this.p1_revTwoDesc);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.postProductButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.p3_revTwoDesc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.p3_revTwoTitle);
            this.Controls.Add(this.p3_revTwoRating);
            this.Controls.Add(this.p3_revOneDesc);
            this.Controls.Add(this.p3_revOneAuthor);
            this.Controls.Add(this.p3_revOneTitle);
            this.Controls.Add(this.p3_revOneRating);
            this.Controls.Add(this.p3_revTwoAuthor);
            this.Controls.Add(this.prodThreeRating);
            this.Controls.Add(this.prodThreeName);
            this.Controls.Add(this.p1_revOneDesc);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.p2_revTwoTitle);
            this.Controls.Add(this.p2_revTwoRating);
            this.Controls.Add(this.p2_revOneDesc);
            this.Controls.Add(this.p2_revOneAuthor);
            this.Controls.Add(this.p2_revOneTitle);
            this.Controls.Add(this.p2_revOneRating);
            this.Controls.Add(this.p2_revTwoAuthor);
            this.Controls.Add(this.prodTwoRating);
            this.Controls.Add(this.prodTwoName);
            this.Controls.Add(this.p1_revTwoAuthor);
            this.Controls.Add(this.p1_revTwoTitle);
            this.Controls.Add(this.p1_revTwoRating);
            this.Controls.Add(this.p1_revOneAuthor);
            this.Controls.Add(this.p1_revOneTitle);
            this.Controls.Add(this.p1_revOneRating);
            this.Controls.Add(this.recentRevsBox);
            this.Controls.Add(this.prodOneRating);
            this.Controls.Add(this.prodOneName);
            this.Controls.Add(this.welcomeMessage);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Seller_Page";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Seller_Page_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.TextBox prodOneName;

        private void Seller_PageLoad(DataTable dt)
        {
            this.AdjustFormScrollbars(true);
            this.AutoScroll = true;
            DataRow user = dt.Rows[0];
            string name = user["name"].ToString();
            this.AutoScroll = true;

            this.welcomeMessage.Text = $"Welcome, {name}!";

            // Connect to DB //
            using (var myconnection = new SQLiteConnection(connectionString))
            {


                string query = $"SELECT * FROM product_info WHERE seller = '{name}'";
                string reviewQuery;
                float avgRating;
                DataTable revTable;
                int revCount;

                myconnection.Open();

                SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable prodTable = new DataTable();
                adapter.Fill(prodTable);

                int prodCount = prodTable.Rows.Count;

                // Product One //
                if (prodCount - 1 >= 0)
                {
                    var productOne = prodTable.Rows[prodCount - 1];

                    reviewQuery = $"SELECT * FROM review_info WHERE pid = '{productOne["pid"]}'";
                    cmd = new SQLiteCommand(reviewQuery, myconnection);
                    adapter = new SQLiteDataAdapter(cmd);
                    revTable = new DataTable();
                    adapter.Fill(revTable);

                    
                    avgRating = 0;
                    for(int i = 0; i < revTable.Rows.Count; i++) 
                    { 
                        avgRating += float.Parse(revTable.Rows[i]["rating"].ToString()); 
                    }
                    avgRating /= float.Parse(revTable.Rows.Count.ToString());

                    this.prodOneName.Text = productOne["name"].ToString();
                    this.prodOneRating.Text = avgRating.ToString();

                    revCount = revTable.Rows.Count;
                    
                    // Product One Reviews //
                    if (revTable.Rows.Count > 0)
                    {
                        var prodOneRevOne = revTable.Rows[revCount - 1];

                        this.p1_revOneTitle.Text = prodOneRevOne["title"].ToString();
                        this.p1_revOneRating.Text = $"{prodOneRevOne["rating"]}/5";
                        this.p1_revOneAuthor.Text = prodOneRevOne["author"].ToString();
                        this.p1_revOneDesc.Text = prodOneRevOne["description"].ToString();
                    }
                    if (revTable.Rows.Count > 1) 
                    {
                            var prodOneRevTwo = revTable.Rows[revCount - 2];

                            this.p1_revTwoTitle.Text = prodOneRevTwo["title"].ToString();
                            this.p1_revTwoRating.Text = $"{prodOneRevTwo["rating"]}/5";
                            this.p1_revTwoAuthor.Text = prodOneRevTwo["author"].ToString();
                            this.textBox5.Text = prodOneRevTwo["description"].ToString();
                    }
                
                }
                // Product Two //
                if (prodCount -2 >= 0)
                { 
                var productTwo = prodTable.Rows[prodCount - 2];

                reviewQuery = $"SELECT * FROM review_info WHERE pid = '{productTwo["pid"]}'";
                cmd = new SQLiteCommand(reviewQuery, myconnection);
                adapter = new SQLiteDataAdapter(cmd);
                revTable = new DataTable();
                adapter.Fill(revTable);

                avgRating = 0;
                for (int i = 0; i < revTable.Rows.Count; i++)
                {
                    avgRating += float.Parse(revTable.Rows[i]["rating"].ToString());
                }
                avgRating /= float.Parse(revTable.Rows.Count.ToString());

                this.prodTwoName.Text = productTwo["name"].ToString();
                this.prodTwoRating.Text = avgRating.ToString();

                revCount = revTable.Rows.Count;
                    // Product Two Reviews //
                    if (revCount > 0)
                    {
                        var prodTwoRevOne = revTable.Rows[revCount - 1];

                        this.p2_revOneTitle.Text = prodTwoRevOne["title"].ToString();
                        this.p2_revOneRating.Text = $"{prodTwoRevOne["rating"]}/5";
                        this.p2_revOneAuthor.Text = prodTwoRevOne["author"].ToString();
                        this.p2_revOneDesc.Text = prodTwoRevOne["description"].ToString();
                    }
                    if (revCount > 1)
                    {


                        var prodTwoRevTwo = revTable.Rows[revCount - 2];

                        this.p2_revTwoTitle.Text = prodTwoRevTwo["title"].ToString();
                        this.p2_revTwoRating.Text = $"{prodTwoRevTwo["rating"]}/5";
                        this.textBox4.Text = prodTwoRevTwo["author"].ToString();
                        this.p1_revTwoDesc.Text = prodTwoRevTwo["description"].ToString();
                    }
                }

                // Product Three //
                if (prodCount - 3 >= 0)
                {
                    var productThree = prodTable.Rows[prodCount - 3];

                    reviewQuery = $"SELECT * FROM review_info WHERE pid = '{productThree["pid"]}'";
                    cmd = new SQLiteCommand(reviewQuery, myconnection);
                    adapter = new SQLiteDataAdapter(cmd);
                    revTable = new DataTable();
                    adapter.Fill(revTable);


                    avgRating = 0;
                    for (int i = 0; i < revTable.Rows.Count; i++)
                    {
                        avgRating += float.Parse(revTable.Rows[i]["rating"].ToString());
                    }
                    avgRating /= float.Parse(revTable.Rows.Count.ToString());

                    this.prodThreeName.Text = productThree["name"].ToString();
                    this.prodThreeRating.Text = avgRating.ToString();

                    revCount = revTable.Rows.Count;
                    // Product Three Reviews //
                    if (revCount > 0)
                    {
                        var prodThreeRevOne = revTable.Rows[revCount - 1];

                        this.p3_revOneTitle.Text = prodThreeRevOne["title"].ToString();
                        this.p3_revOneRating.Text = $"{prodThreeRevOne["rating"]}/5";
                        this.p3_revOneAuthor.Text = prodThreeRevOne["author"].ToString();
                        this.p3_revOneDesc.Text = prodThreeRevOne["description"].ToString();
                    }
                    if (revCount > 1)
                    {
                        var prodThreeRevTwo = revTable.Rows[revCount - 2];

                        this.p3_revTwoTitle.Text = prodThreeRevTwo["title"].ToString();
                        this.p3_revTwoRating.Text = $"{prodThreeRevTwo["rating"]}/5";
                        this.textBox3.Text = prodThreeRevTwo["author"].ToString();
                        this.p3_revTwoDesc.Text = prodThreeRevTwo["description"].ToString();
                    }
                }
            }
        }


        private System.Windows.Forms.TextBox prodOneRating;
        private System.Windows.Forms.TextBox recentRevsBox;
        private System.Windows.Forms.TextBox p1_revOneRating;
        private System.Windows.Forms.TextBox p1_revOneTitle;
        private System.Windows.Forms.TextBox p1_revOneAuthor;
        private System.Windows.Forms.TextBox p1_revTwoDesc;
        private System.Windows.Forms.TextBox p1_revTwoAuthor;
        private System.Windows.Forms.TextBox p1_revTwoTitle;
        private System.Windows.Forms.TextBox p1_revTwoRating;
        private System.Windows.Forms.TextBox p1_revOneDesc;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox p2_revTwoTitle;
        private System.Windows.Forms.TextBox p2_revTwoRating;
        private System.Windows.Forms.TextBox p2_revOneDesc;
        private System.Windows.Forms.TextBox p2_revOneAuthor;
        private System.Windows.Forms.TextBox p2_revOneTitle;
        private System.Windows.Forms.TextBox p2_revOneRating;
        private System.Windows.Forms.TextBox p2_revTwoAuthor;
        private System.Windows.Forms.TextBox prodTwoRating;
        private System.Windows.Forms.TextBox prodTwoName;
        private System.Windows.Forms.TextBox p3_revTwoDesc;

        private System.Windows.Forms.TextBox p3_revTwoTitle;
        private System.Windows.Forms.TextBox p3_revTwoRating;
        private System.Windows.Forms.TextBox p3_revOneDesc;
        private System.Windows.Forms.TextBox p3_revOneAuthor;
        private System.Windows.Forms.TextBox p3_revOneTitle;
        private System.Windows.Forms.TextBox p3_revOneRating;

        private System.Windows.Forms.TextBox textBox3;
        private ButtonControl logoutButton;
        private System.Windows.Forms.TextBox textBox1;
        private ButtonControl postProductButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox prodThreeName;
        private System.Windows.Forms.TextBox prodThreeRating;
        private System.Windows.Forms.TextBox p3_revTwoAuthor;
    }
}