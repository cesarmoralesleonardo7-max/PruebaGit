using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) &&
                   double.TryParse(txtNumero2.Text, out double num2))
            {
                double resultado = num1 + num2;
                lblResultado.Text = "Resultado: " + resultado;
            }
            else
            {
                lblResultado.Text = "Ingresa números válidos";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) &&
                   double.TryParse(txtNumero2.Text, out double num2))
            {
                double resultado = num1 - num2;
                lblResultado.Text = "Resultado: " + resultado;
            }
            else
            {
                lblResultado.Text = "Ingresa números válidos";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) &&
       double.TryParse(txtNumero2.Text, out double num2))
            {
                if (num2 != 0)
                {
                    double resultado = num1 / num2;
                    lblResultado.Text = "Resultado: " + resultado;
                }
                else
                {
                    lblResultado.Text = "No se puede dividir entre 0";
                }
            }
            else
            {
                lblResultado.Text = "Ingresa números válidos";
            }
        }
    }
}
    


