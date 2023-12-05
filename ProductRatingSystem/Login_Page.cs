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
    public partial class Login_Page : Form
    {
        private static string connectionString = @"Data Source =C:\Users\SalaM\sqlite\ProductRatingSystem.db;Version=3;";


        public Login_Page()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (this.user.Texts.Trim() == "" && this.pass.Texts.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else 
            {

                    using(var myconnection = new SQLiteConnection(connectionString))
                    {

                        string query = "SELECT * FROM user_info WHERE username = @user AND password = @pass";

                        myconnection.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                        cmd.Parameters.AddWithValue("@user", user.Texts);
                        cmd.Parameters.AddWithValue("@pass", pass.Texts);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if(dataTable.Rows.Count>0)
                        {
                            //GO TO CORRESPONDING PAGE
                            MessageBox.Show("Login successful!");
                        
                        
                            if(dataTable.Rows[0]["type"].ToString() == "Seller") 
                            {
                                this.Hide();
                                Seller_Page seller_Page = new Seller_Page(dataTable);
                                seller_Page.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                this.Hide();
                                Customer_Page customer_Page = new Customer_Page(dataTable);
                                customer_Page.ShowDialog();
                                this.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Login unsuccessful. Please try again.");
                        }
                    }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxControl1_Load_1(object sender, EventArgs e)
        {

        }
        
        private void buttonControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxControl2_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Load(object sender, EventArgs e)
        {

        }
    }
}
