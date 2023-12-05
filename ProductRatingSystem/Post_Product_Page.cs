using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ProductRatingSystem
{
    public partial class Post_Product_Page : Form
    {
        public Post_Product_Page()
        {
            InitializeComponent();
        }

        private static string connectionString = @"Data Source =C:\Users\SalaM\sqlite\ProductRatingSystem.db;Version=3;";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostProductButton_Click(object sender, EventArgs e)
        {
            if (this.ProductName.Texts.Trim() == "" || this.ProductID.Texts.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else if (this.ProductID.Texts.Length < 8 || !this.ProductID.Texts.Any(char.IsDigit) || !this.ProductID.Texts.Any(char.IsLetter))
            {
                MessageBox.Show("Invalid Product ID");
            }
            else
            {

                using (var myconnection = new SQLiteConnection(connectionString))
                {
                    
                    myconnection.Open();
                    string query = "INSERT INTO product_info (`pid`, `name`, `description`, 'seller') VALUES (@ProductID, @ProductName, @ProductDescriptionBox, @sellerBox)";
                   
                    SQLiteCommand myCommand = new SQLiteCommand(query, myconnection);
                    myCommand.Parameters.AddWithValue("@ProductID", ProductID.Texts);
                    myCommand.Parameters.AddWithValue("@ProductName", ProductName.Texts);
                    myCommand.Parameters.AddWithValue("@ProductDescriptionBox", ProductDescriptionBox.Text);
                    myCommand.Parameters.AddWithValue("@sellerBox", sellerBox.Texts);
                    myCommand.ExecuteNonQuery();


                    MessageBox.Show("New product posted!");

                    this.Hide();
                    //Seller_Page back_to_seller_Page = new Seller_Page();
                    //back_to_seller_Page.ShowDialog();
                    //this.Show();
                }
            }
        }

        private void Post_Product_Page_Load(object sender, EventArgs e)
        {

        }
    }
}