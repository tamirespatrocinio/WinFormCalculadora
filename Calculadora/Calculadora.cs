using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNumber0_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }


        private void btnNumber1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Infome um valor para efetuar a soma.");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRAÇÃO";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Infome um valor para efetuar a subtração.");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICAÇÃO";
                lblOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Infome um valor para efetuar a multiplicação.");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISÃO";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Infome um valor para efetuar a divisão.");
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {

                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                    lblOperacao.Text = "";

                }
                else if (operacao == "SUBTRAÇÃO")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                    lblOperacao.Text = "";

                }
                else if (operacao == "MULTIPLICAÇÃO")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                    lblOperacao.Text = "";

                }
                else if (operacao == "DIVISÃO")
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                    lblOperacao.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Erro! Infome um valor para realizar a operação");
            }
        }

    }
}
