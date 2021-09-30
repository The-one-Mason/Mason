using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.73580009";

            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0015971502";

            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.0015983323";

            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.1803243";
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                (Convert.ToDecimal(txtAmountAustralia.Text)) * (Convert.ToDecimal(txtRateAustralia.Text))
                ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                (Convert.ToDecimal(txtAmountBhutan.Text)) * (Convert.ToDecimal(txtRateBhutan.Text))
                ).ToString("0.00");
        }

        private void costaRicaTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
                (Convert.ToDecimal(txtAmountCostaRica.Text)) * (Convert.ToDecimal(txtRateCostaRica.Text))
                ).ToString("0.00");
        }

        private void EuroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                (Convert.ToDecimal(txtAmountEuro.Text)) * (Convert.ToDecimal(txtRateEuro.Text))
                ).ToString("0.00");
        }

        private void txtUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtUSD.Text = (
                (Convert.ToDecimal(txtUSDAustralia.Text)) 
                + (Convert.ToDecimal(txtUSDBhutan.Text)) 
                + (Convert.ToDecimal(txtUSDCostaRica.Text)) 
                + (Convert.ToDecimal(txtUSDEuro.Text))
                ).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
