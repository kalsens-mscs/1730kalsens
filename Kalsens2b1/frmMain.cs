using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalsens2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {

           decimal amountCanada = 10m;
            decimal rateCanada = 0.757273m;
            decimal usdCanada = amountCanada * rateCanada;

            decimal amountIceland = 1000m;
            decimal rateIceland = 0.00800587m;
            decimal usdIceland = amountIceland * rateIceland;

            decimal amountJapan = 10m;
            decimal rateJapan = 0.00925864m;
            decimal usdJapan = amountJapan * rateJapan;

            decimal amountUK = 10m;
            decimal rateUK = 1.23503m;
            decimal usdUK = amountUK * rateUK;

            decimal totalUSD = usdCanada + usdIceland + usdJapan + usdUK;




        }
    }


    }

