using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2B
{
    public partial class EX2B : Form
    {
        public EX2B()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = 10m;
            decimal rateAustralia = 0.73580009m;
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountBhutan = 100m;
            decimal rateBhutan = 0.0015971502m;
            decimal usdBhutan = amountBhutan * rateBhutan;

            decimal totalUSD = usdAustralia + usdBhutan;
        }
    }
}
