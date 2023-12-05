
namespace ProductRatingSystem
{
    partial class Post_Product_Page
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
            this.ProductName = new ProductRatingSystem.TextBoxControl();
            this.ProductID = new ProductRatingSystem.TextBoxControl();
            this.ProductDescriptionBox = new System.Windows.Forms.TextBox();
            this.PostProductButton = new ProductRatingSystem.ButtonControl();
            this.PostProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sellerBox = new ProductRatingSystem.TextBoxControl();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductName.BackColor = System.Drawing.SystemColors.Window;
            this.ProductName.BorderColor = System.Drawing.Color.Black;
            this.ProductName.BorderFocusColor = System.Drawing.Color.Black;
            this.ProductName.BorderRadius = 15;
            this.ProductName.BorderSize = 2;
            this.ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductName.Location = new System.Drawing.Point(227, 115);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.ProductName.Multiline = false;
            this.ProductName.Name = "ProductName";
            this.ProductName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ProductName.PasswordChar = false;
            this.ProductName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ProductName.PlaceholderText = "Product Name";
            this.ProductName.Size = new System.Drawing.Size(350, 32);
            this.ProductName.TabIndex = 0;
            this.ProductName.Texts = "";
            this.ProductName.UnderlinedStyle = false;
            // 
            // ProductID
            // 
            this.ProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductID.BackColor = System.Drawing.SystemColors.Window;
            this.ProductID.BorderColor = System.Drawing.Color.Black;
            this.ProductID.BorderFocusColor = System.Drawing.Color.Black;
            this.ProductID.BorderRadius = 15;
            this.ProductID.BorderSize = 2;
            this.ProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductID.Location = new System.Drawing.Point(227, 155);
            this.ProductID.Margin = new System.Windows.Forms.Padding(4);
            this.ProductID.Multiline = false;
            this.ProductID.Name = "ProductID";
            this.ProductID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ProductID.PasswordChar = false;
            this.ProductID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ProductID.PlaceholderText = "a1b2c3d4";
            this.ProductID.Size = new System.Drawing.Size(350, 32);
            this.ProductID.TabIndex = 1;
            this.ProductID.Texts = "";
            this.ProductID.UnderlinedStyle = false;
            // 
            // ProductDescriptionBox
            // 
            this.ProductDescriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductDescriptionBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ProductDescriptionBox.Location = new System.Drawing.Point(98, 258);
            this.ProductDescriptionBox.Multiline = true;
            this.ProductDescriptionBox.Name = "ProductDescriptionBox";
            this.ProductDescriptionBox.Size = new System.Drawing.Size(600, 125);
            this.ProductDescriptionBox.TabIndex = 2;
            this.ProductDescriptionBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PostProductButton
            // 
            this.PostProductButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PostProductButton.BorderColor = System.Drawing.Color.Black;
            this.PostProductButton.BorderFocusColor = System.Drawing.Color.Black;
            this.PostProductButton.BorderRadius = 15;
            this.PostProductButton.BorderSize = 2;
            this.PostProductButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostProductButton.Location = new System.Drawing.Point(271, 389);
            this.PostProductButton.Name = "PostProductButton";
            this.PostProductButton.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PostProductButton.Size = new System.Drawing.Size(250, 49);
            this.PostProductButton.TabIndex = 3;
            this.PostProductButton.Texts = "Post Product";
            this.PostProductButton.UnderlinedStyle = false;
            this.PostProductButton.Click += new System.EventHandler(this.PostProductButton_Click);
            // 
            // PostProduct
            // 
            this.PostProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PostProduct.AutoSize = true;
            this.PostProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostProduct.Location = new System.Drawing.Point(300, 60);
            this.PostProduct.Name = "PostProduct";
            this.PostProduct.Size = new System.Drawing.Size(205, 34);
            this.PostProduct.TabIndex = 4;
            this.PostProduct.Text = "Post Product";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Description:";
            // 
            // sellerBox
            // 
            this.sellerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellerBox.BackColor = System.Drawing.SystemColors.Window;
            this.sellerBox.BorderColor = System.Drawing.Color.Black;
            this.sellerBox.BorderFocusColor = System.Drawing.Color.Black;
            this.sellerBox.BorderRadius = 15;
            this.sellerBox.BorderSize = 2;
            this.sellerBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellerBox.Location = new System.Drawing.Point(227, 196);
            this.sellerBox.Margin = new System.Windows.Forms.Padding(4);
            this.sellerBox.Multiline = false;
            this.sellerBox.Name = "sellerBox";
            this.sellerBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.sellerBox.PasswordChar = false;
            this.sellerBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.sellerBox.PlaceholderText = "Business Name";
            this.sellerBox.Size = new System.Drawing.Size(350, 32);
            this.sellerBox.TabIndex = 6;
            this.sellerBox.Texts = "";
            this.sellerBox.UnderlinedStyle = false;
            // 
            // Post_Product_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sellerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PostProduct);
            this.Controls.Add(this.PostProductButton);
            this.Controls.Add(this.ProductDescriptionBox);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.ProductName);
            this.Name = "Post_Product_Page";
            this.Text = "Post_Product_Page";
            this.Load += new System.EventHandler(this.Post_Product_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        new private TextBoxControl ProductName;
        private TextBoxControl ProductID;
        private System.Windows.Forms.TextBox ProductDescriptionBox;
        private ButtonControl PostProductButton;
        private System.Windows.Forms.Label PostProduct;
        private System.Windows.Forms.Label label2;
        private TextBoxControl sellerBox;
    }
}