using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRatingSystem
{
    public partial class Customer_Page : Form
    {
        private static string connectionString = @"Data Source =C:\Users\SalaM\sqlite\ProductRatingSystem.db;Version=3;";

        public Customer_Page(DataTable dt)
        {
            InitializeComponent();
            Customer_Page_Load(dt);
        }

        private void Customer_Page_Load(DataTable dt)
        {
            string name = dt.Rows[0]["name"].ToString();
            string username = dt.Rows[0]["username"].ToString();
            this.welcomeMessage.Text = $"Welcome, {name}";
            this.AutoScroll = true;

            using (var myconnection = new SQLiteConnection(connectionString))
            {
                string query = $"SELECT * FROM purchase_info WHERE purchaser = '{username}'";

                myconnection.Open();

                SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable prodTable = new DataTable();
                adapter.Fill(prodTable);

                int prodCount = prodTable.Rows.Count;
                object[] products = { this.product1, this.product2, this.product3, this.product4, this.product5 };

                if (prodCount > 0) this.product1.Text = prodTable.Rows[prodCount - 1]["product"].ToString();
                if (prodCount > 1) this.product2.Text = prodTable.Rows[prodCount - 2]["product"].ToString();
                if (prodCount > 2) this.product3.Text = prodTable.Rows[prodCount - 3]["product"].ToString();
                if (prodCount > 3) this.product4.Text = prodTable.Rows[prodCount - 4]["product"].ToString();
                if (prodCount > 4) this.product5.Text = prodTable.Rows[prodCount - 5]["product"].ToString();
            }
         }

        private void Customer_Page_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
            Logout_Page logout_Page = new Logout_Page();
            logout_Page.ShowDialog();
            this.Show();
        }

        private void logoutButton_Load(object sender, EventArgs e)
        {

        }
    }
}
