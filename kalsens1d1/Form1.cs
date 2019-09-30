using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalsens1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountCanada.Text = "0.00";
            txtAmountIceland.Text = "0.00";
            txtAmountJapan.Text = "0.00";
            txtAmountUK.Text = "0.00";
            txtRateCanada.Text = "0.757273";
            txtRateIceland.Text = "0.00800587";
            txtRateJapan.Text = "0.00925864";
            txtRateUK.Text = "1.23503";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
                  Convert.ToDecimal(txtAmountCanada.Text) * Convert.ToDecimal(txtRateCanada.Text)
                ).ToString("0.00");
        }

        private void icelandTextChanged(object sender, EventArgs e)
        {
            txtUSDIceland.Text = (
                Convert.ToDecimal(txtAmountIceland.Text) * Convert.ToDecimal(txtRateIceland.Text)
                ).ToString("0.00");
        }

        private void japanTextChanged(object sender, EventArgs e)
        {
            txtUSDJapan.Text = (
                Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateJapan.Text)
                ).ToString("0.00");
        }

        private void ukTextChanged(object sender, EventArgs e)
        {
            txtUSDUK.Text = (
                Convert.ToDecimal(txtAmountUK.Text) * Convert.ToDecimal(txtRateUK.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text =
                (Convert.ToDecimal(txtUSDCanada.Text)
                + Convert.ToDecimal(txtUSDIceland.Text)
                + Convert.ToDecimal(txtUSDJapan.Text)
                + Convert.ToDecimal(txtUSDUK.Text)
                ).ToString("0.00");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
