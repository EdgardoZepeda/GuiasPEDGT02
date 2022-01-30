using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Ejemplo1 : Form
    {

        double cant1;
        double cant2;
        double resultado;
        double memoria;
        string operador;
        public Ejemplo1()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void Ejemplo1_Load(object sender, EventArgs e)
        {

        }

        private void limpiar_pantalla_TextChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text = ".";
            btnpunto.Enabled = false;

        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            cant1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            cant1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            cant1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            cant1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();

            try
            {
                txtresultado.Text = string.Format("{0:f2}", cant1 / cant2);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No Se Permite Division Entre 0");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            cant2 = double.Parse(txtresultado.Text);
            switch (operador)
            {
                case "+":
                    resultado = cant1 + cant2;
                    txtresultado.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = cant1 - cant2;
                    txtresultado.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = cant1 * cant2;
                    txtresultado.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = cant1 / cant2;
                    txtresultado.Text = resultado.ToString();
                    break;



            }


        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Sqrt(cant1).ToString();
        }

        private void btncubo_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Pow(cant1,3).ToString();
        }

        private void btncuadrado_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Pow(cant1,2).ToString();
        }

        private void btnmenos1_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Pow(cant1,-1).ToString();
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Log(cant1).ToString();
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Sin(cant1).ToString();
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Cos(cant1).ToString();
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Tan(cant1).ToString();
        }

        private void btnsinh_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Sinh(cant1).ToString();
        }

        private void btncosh_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Cosh(cant1).ToString();
        }

        private void btntanh_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Tanh(cant1).ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {
        
            memoria = memoria - Convert.ToDouble(txtresultado.Text);
        }

        private void btnMmas_Click(object sender, EventArgs e)
        {
            memoria = memoria + Convert.ToDouble(txtresultado.Text);
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(txtresultado.Text);

        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(txtresultado.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
   
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
            cant2 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
            resultado = cant1 * cant2 / 100;
            txtresultado.Text = Convert.ToString((cant1 * cant2) / 100);
            txtresultado.Clear();
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Exp(cant1).ToString();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            cant1 = double.Parse(txtresultado.Text);
            resultado = cant1;
            txtresultado.Text = Math.Log10(cant1).ToString();
        }

        private void btnretroceso_Click(object sender, EventArgs e)
        {
            if (txtresultado.TextLength > 1)
            {
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1, 1);
            }

            if (txtresultado.Text.Length == 1)
            {
                txtresultado.Text = "0";
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

