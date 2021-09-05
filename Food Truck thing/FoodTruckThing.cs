using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Truck_thing
{
    public partial class FoodTruckThing : Form
    {
        public FoodTruckThing()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text =
               (Convert.ToDecimal(txtHotDogs.Text) * 4).ToString("0.00");
            txtHamburgersSubtotal.Text =
               (Convert.ToDecimal(txtHamburgers.Text) * 5).ToString("0.00");
            txtPretaxTotal.Text =
               (Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)).ToString("0.00");
            txtTax.Text =
               ((Convert.ToDecimal(txtPretaxTotal.Text) * .07m)).ToString("0.00");
            txtTotal.Text =
                (Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtPretaxTotal.Text)).ToString("0.00");
            btnClear.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtHotDogs.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
