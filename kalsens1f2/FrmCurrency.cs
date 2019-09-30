using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalsens1f2
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnIceland.BackgroundImage = picIcelandDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.7547";
            lblCCurrency.Text = btnCanada.Text + ": ";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnIceland.BackgroundImage = picIcelandDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            txtRate.Text = "0.757273";
            btnUK.BackgroundImage = picUKDim.Image;
        }

        private void BtnIceland_Click(object sender, EventArgs e)
        {
            btnIceland.BackgroundImage = picIceland.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.008104";
            lblCCurrency.Text = btnIceland.Text + ": ";

        }

        private void BtnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnIceland.BackgroundImage = picIcelandDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.009254";
            lblCCurrency.Text = btnJapan.Text + ": ";
        }

        private void BtnUK_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUK.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnIceland.BackgroundImage = picIcelandDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            txtRate.Text = "1.232";
            lblCCurrency.Text = btnUK.Text + ": ";

        }


        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text =
                (Convert.ToDecimal(txtRate.Text)
                * Convert.ToDecimal(txtCurrency.Text)).ToString("0.00");
            txtTotal.Text =
                (Convert.ToDecimal(txtCurrency.Text)
                + Convert.ToDecimal(txtUSD.Text)).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }
        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
            //txtTotal.Text =
               // (Convert.ToDecimal(txtCurrency.Text)
                //+ Convert.ToDecimal(txtUSD.Text)).ToString("0.00");
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtTotal.Text;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnIceland.BackgroundImage = picIcelandDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.7547";
            lblCCurrency.Text = btnCanada.Text + ": ";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
           
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUSD_TextChanged(object sender, EventArgs e)
        {
        
        }



        private void LblEquation_Click(object sender, EventArgs e)
        {

        }
    }
    }

