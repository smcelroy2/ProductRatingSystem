using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace ProductRatingSystem
{
    public partial class Logout_Page : Form
    {
        public Logout_Page()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxControl2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private static string connectionString = @"Data Source =C:\Users\SalaM\sqlite\ProductRatingSystem.db;Version=3;";
        private void loginButton_Click(object sender, EventArgs e)
        {

            if (this.user.Texts.Trim() == "" && this.pass.Texts.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {

                using (var myconnection = new SQLiteConnection(connectionString))
                {

                    string query = "SELECT * FROM user_info WHERE username = @user AND password = @pass";

                    myconnection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                    cmd.Parameters.AddWithValue("@user", user.Texts);
                    cmd.Parameters.AddWithValue("@pass", pass.Texts);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        //GO TO CORRESPONDING PAGE, BUT FOR NOW: 
                        MessageBox.Show("Login successful!");

                    }
                    else
                    {
                        MessageBox.Show("Login unsuccessful. Please try again.");
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
