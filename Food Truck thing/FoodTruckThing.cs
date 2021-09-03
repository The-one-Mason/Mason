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
            //broken bit \/\/
            txtTax.Text =
               (7 / 100 * (Convert.ToDecimal(txtPretaxTotal.Text))).ToString("0.00");
            //broken bit /\/\
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
    }
}
