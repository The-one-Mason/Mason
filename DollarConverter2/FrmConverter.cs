using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarConverter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            BtnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtRate.Text = "0.73580009";
            txtUSD.Text = "0.00";
            txtFinalTotal.Text = "0.00";
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            BtnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtRate.Text = "0.73580009";
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            BtnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnBhutan.Text + ":";
            txtRate.Text = "0.0015971502";
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            BtnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnCostaRica.Text + ":";
            txtRate.Text = "0.0015983323";
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
        }

        private void BtnEuro_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            BtnEuro.BackgroundImage = picEuro.Image;
            lblCurrency.Text = BtnEuro.Text + ":";
            txtRate.Text = "1.1803243";

            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            BtnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtRate.Text = "0.73580009";
            txtUSD.Text = "0.00";
            txtFinalTotal.Text = "0.00";
            lblEquation.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;
            txtFinalTotal.Text = (Convert.ToDecimal(txtFinalTotal.Text) + Convert.ToDecimal(txtUSD.Text)).ToString("0.00");
            txtCurrency.Focus();
        }
    }
}
