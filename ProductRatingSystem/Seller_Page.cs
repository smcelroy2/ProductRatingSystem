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
        public Seller_Page()
        {
            InitializeComponent();
            Seller_PageLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller_Page wc = new Seller_Page();
            this.Hide();
            wc.ShowDialog();
            wc.Close();
            this.Show();
        }

        private void p1_revOneDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}