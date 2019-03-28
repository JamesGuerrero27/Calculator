using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        Clases.clsSuma obj = new Clases.clsSuma();
        Clases.clsResta obj2 = new Clases.clsResta();
        Clases.clsMultiplicacion obj3 = new Clases.clsMultiplicacion();
        Clases.clsDivision obj4 = new Clases.clsDivision();
        private void btnN1_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "2";

        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txbScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    txbScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    txbScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicacion((primero), (segundo));
                    txbScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Division((primero), (segundo));
                    txbScreen.Text = Div.ToString();
                    break;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txbScreen.Text.Length == 1)
                txbScreen.Text = "";
            else txbScreen.Text = txbScreen.Text.Substring(0, txbScreen.Text.Length - 1);


        }
    }
}
