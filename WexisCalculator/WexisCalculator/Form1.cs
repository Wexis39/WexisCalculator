using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WexisCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "3";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (KontrolEt(lblHesaplama.Text) && lblHesaplama.Text != "")
            {
                lblHesaplama.Text += "+";
            }
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(lblHesaplama.Text, "");
                result = Convert.ToDouble(result);
                lblHesaplama.Text = Convert.ToString(result);
                lblError.Text = "";
            }
            catch
            {
                lblError.Text = "ERROR";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblHesaplama.Text = "";
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            if (KontrolEt(lblHesaplama.Text) && lblHesaplama.Text != "")
            {
                lblHesaplama.Text += ".";
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (KontrolEt(lblHesaplama.Text))
            {
                lblHesaplama.Text += "-";
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (KontrolEt(lblHesaplama.Text) && lblHesaplama.Text != "")
            {
                lblHesaplama.Text += "*";
            }
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            if (KontrolEt(lblHesaplama.Text)&&lblHesaplama.Text!="")
            {
                lblHesaplama.Text += "/";
            }
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            if (lblHesaplama.Text.Length > 0)
            {
                lblHesaplama.Text = lblHesaplama.Text.Remove(lblHesaplama.Text.Length - 1);
            }
        }

        private void btnKareKok_Click(object sender, EventArgs e)
        {
            try
            {
                double kareKokIslemi = Convert.ToDouble(lblHesaplama.Text);
                kareKokIslemi = Math.Sqrt(kareKokIslemi);
                string kareKok = kareKokIslemi.ToString();
                lblHesaplama.Text = kareKok;
                lblError.Text = "";
            }
            catch
            {
                lblError.Text = "ERROR";
            }

        }

        private void btnKaresi_Click(object sender, EventArgs e)
        {
            try
            {
                double kareAlmaIslemi = Convert.ToDouble(lblHesaplama.Text);
                kareAlmaIslemi *= kareAlmaIslemi;
                string kareAlindi = kareAlmaIslemi.ToString();
                lblHesaplama.Text = kareAlindi;
                lblError.Text = "";
            }
            catch
            {
                lblError.Text = "ERROR";
            }
        }
        public static bool KontrolEt(string metin)
        {
            if (metin.EndsWith("-") || metin.EndsWith("+") || metin.EndsWith("/") || metin.EndsWith("*")|| metin.EndsWith("."))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
