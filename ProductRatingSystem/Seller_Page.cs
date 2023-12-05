using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductRatingSystem;

namespace ProductRatingSystem
{
    public partial class Seller_Page : Form
    {
        public Seller_Page(DataTable dt)
        {
            InitializeComponent();
            Seller_PageLoad(dt);
        }
        
        private void p1_revOneDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void postProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Post_Product_Page product_Page = new Post_Product_Page();
            product_Page.ShowDialog();
            this.Show();

        }

        
        private void logoutButton_Load(object sender, EventArgs e)
        {
            
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout_Page logout_Page = new Logout_Page();
            logout_Page.ShowDialog();
            this.Show();
        }

        private void p2_revTwoAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Seller_Page_Load_1(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void welcomeMessage_Click(object sender, EventArgs e)
        {

        }
    }
}